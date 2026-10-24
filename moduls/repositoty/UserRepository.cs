using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Author.moduls.models;

namespace Author.moduls.repositoty
{
    public class UserRepository : userrepo
    {
        public Task<user> CreateUser(user user)
        {
            throw new NotImplementedException();
        }

        public Task<user> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<user> GetUserbyid(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<user>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}