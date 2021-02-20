using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;
using TareasList.Infrastructure.Data;

namespace TareasList.Infrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly WorkListContext _workListContext;
        public LoginRepository(WorkListContext workListContext)
        {
            _workListContext = workListContext;
        }

        public async Task<User> GetLoginByCredentials(UserLogin userLogin)
        {
            return await _workListContext.Users.FirstOrDefaultAsync(x => x.UserName == userLogin.User);
        }
    }
}
