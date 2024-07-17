using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;


namespace Infraestructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
    
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public User? Get(string name)
        {
            return _context.Users.FirstOrDefault(u => u.Name == name);  
        }

        public List<User> GetAll()
        {

            return _context.Users.ToList();
        }
    }
}
