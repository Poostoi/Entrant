using Enrollee.Domain.Models.User;

namespace Enrollee.Application.Services.User;

public interface ITokenProvider
{
    Token CreateToken(Account account);

}