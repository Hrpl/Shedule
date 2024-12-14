
using Shedule.Domain.Models;

namespace Shedule.Infrastructure.Services.Interfaces;

public interface IUserRepository
{
    public Task CreateUserAsync(UserModel model);
}
