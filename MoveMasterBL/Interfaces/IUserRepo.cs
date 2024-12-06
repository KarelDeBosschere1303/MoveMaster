using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.Interfaces
{
    public interface IUserRepo
    {
        User GetById(int id);
        List<User> GetAllClients();
        List<User> GetAllTrainers();
        void Create(User user);
    }
}
