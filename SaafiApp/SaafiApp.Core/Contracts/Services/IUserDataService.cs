using SaafiApp.Core.Model;
using System.Threading.Tasks;

namespace SaafiApp.Core.Contracts.Services
{
    public interface IUserDataService
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);

        User GetActiveUser();
    }
}
