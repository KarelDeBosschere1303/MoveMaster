using MoveMasterBL.Interfaces;
using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoveMasterDL;

namespace MoveMasterDL.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly MoveMasterContext _context;

        public UserRepo(MoveMasterContext context)
        {
            _context = context;
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetAllClients()
        {
            return _context.Users.Where(u => u.Role == Role.Client).ToList();
        }

        public List<User> GetAllTrainers()
        {
            return _context.Users.Where(u => u.Role == Role.Trainer).ToList();
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
