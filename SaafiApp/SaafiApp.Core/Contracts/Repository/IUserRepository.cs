using System.Threading.Tasks;
using SaafiApp.Core.Model;

namespace SaafiApp.Core.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);
    }
}
