using System.Threading.Tasks;
using Enrollee.Domain.Models;
using Enrollee.Application;

namespace Enrollee.Application.Services.User;

public interface ITokenProvider
{
    Token CreateToken(Account account);

}