using System.Threading.Tasks;
using DatingApp.A.Models;

namespace DatingApp.A.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string password);
         
         Task<User> Login(string username,string password);
         
         Task<bool> UserExists(string username);

    }
}