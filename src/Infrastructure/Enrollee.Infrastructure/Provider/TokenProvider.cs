using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Enrollee.Application.Services.User;
using Enrollee.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using Enrollee.Application;
using Enrollee.Infrastructure.Setting;
using System;


namespace Enrollee.Infrastructure.Provider;

public class TokenProvider : ITokenProvider
{
    private readonly IAuthOptions _authOptions;

    public TokenProvider(IAuthOptions authOptions)
    {
        _authOptions = authOptions;
    }

    public TokenValidationParameters CreateTokenValidationParameters()
    {
        return new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidIssuer = _authOptions.Issuer,
            ValidateAudience = true,
            ValidAudience = _authOptions.Audience,
            ValidateLifetime = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authOptions.Key)),
            ValidateIssuerSigningKey = true,
        };
    }

    public Token CreateToken(Account account)
    {
        ArgumentNullException.ThrowIfNull(account);
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(_authOptions.Key);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Sid, Convert.ToString(account.Id))
            }),
            Expires = null,
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return new Token {Value = tokenHandler.WriteToken(token)};
    }
}