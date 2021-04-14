using System.Threading.Tasks;
using TareasList.Core.Entities;

namespace TareasList.Core.Interfaces
{
    public interface ILoginRepository
    {
        Task<User> GetLoginByCredentials(UserLogin userLogin);
    }
}
