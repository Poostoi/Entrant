using Enrollee.Domain.Models;

namespace Enrollee.Application.Services.User;

public interface ITokenProvider
{
    Token CreateToken(Account account);

}