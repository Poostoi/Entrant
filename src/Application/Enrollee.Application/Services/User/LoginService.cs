using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;
using Microsoft.IdentityModel.Tokens;
using  Enrollee.Domain.Models;

namespace Enrollee.Application.Services.User;

internal sealed class LoginService : ILoginService
{
    private readonly IUserProvider _userProvider;

    public LoginService(IUserProvider userProvider)
    {
        ArgumentNullException.ThrowIfNull(userProvider);

        _userProvider = userProvider;
    }

    public async Task<Tokens> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);
            
        if (await _userProvider.FindAsync(command.Login, command.Password, cancellationToken).ConfigureAwait(false) is not null)
        {
            throw new ArgumentException("Введён неправильно логин/пароль");
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(AuthOptions.KEY);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, command.Login)                    
            }),
            Expires = DateTime.UtcNow.AddMinutes(10),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return new Tokens { Token = tokenHandler.WriteToken(token) };
    }
}
