using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vision.Interfaces;
using Vision.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Vision.Data.Repository
{
    public class UserRepository : IUser
    {
        private readonly DbContext _context;
        public UserRepository(DbContext context)
        {
            _context = context;
        }
       public async Task creatUser(string Name, string Sexgender, int Age, string Phone, string Login, string Password)
        {
            var user = new User { Name = Name, Sexgender = Sexgender, Age = Age, Phone = Phone, Login= Login, Password= Password };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task deleteUser(Guid UserID)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == UserID);
            if(user != null)
            {
                _context.Users.Remove(user);
            }
            await _context.SaveChangesAsync();
        }

        public Task editUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<User>> getAll() => await _context.Users.ToListAsync();
    }
}
