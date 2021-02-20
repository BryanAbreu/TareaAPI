using System.Threading.Tasks;
using TareasList.Core.Entities;

namespace TareasList.Core.Interfaces
{
    public interface ILoginService
    {
        Task<User> GetLoginByCredentials(UserLogin userLogin);
        Task RegisterUser(User user);
    }
}
