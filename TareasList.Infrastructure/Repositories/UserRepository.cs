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
    public class UserRepository : IUserRepository
    {
        private readonly WorkListContext _context;
        public UserRepository(WorkListContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var List = await _context.Users.AsNoTracking().ToListAsync();
            return List;
        }

        public async Task<User> GetUser(int id)
        {
            var Task = await _context.Users.FirstOrDefaultAsync(x => x.IdUser == id);
            return Task;
        }

        public async Task InsertUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> DeleteUser(int id)
        {
            var CurrenrtUser = await GetUser(id);
            _context.Users.Remove(CurrenrtUser);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;

        }
    }
}
