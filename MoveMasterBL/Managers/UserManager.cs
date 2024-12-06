using MoveMasterBL.Interfaces;
using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.Managers
{
    public class UserManager
    {
        private readonly IUserRepo _userRepo;

        public UserManager(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public User GetUserById(int id) => _userRepo.GetById(id);

        public List<User> GetAllClients() => _userRepo.GetAllClients();

        public List<User> GetAllTrainers() => _userRepo.GetAllTrainers();

        public void CreateUser(User user)
        {
            // Eventuele validatie kan hier worden toegevoegd
            _userRepo.Create(user);
        }
    }

}
