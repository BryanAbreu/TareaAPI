using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;

namespace TareasList.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoginRepository _loginRepository;

        public LoginService(IUserRepository userRepository, ILoginRepository loginRepository)
        {
            _userRepository = userRepository;
            _loginRepository = loginRepository;
        }

        public async Task<User> GetLoginByCredentials(UserLogin userLogin)
        {
            return await _loginRepository.GetLoginByCredentials(userLogin);
        }

        public async Task RegisterUser(User user)
        {
            user.IdUser = 0;
            await _userRepository.InsertUser(user);
        }
    }
}
