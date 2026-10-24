using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Author.moduls.models;

namespace Author.moduls.repositoty
{
    public interface userrepo
    {
        Task<IEnumerable<user>> GetUsers();
        Task<user> CreateUser(user user);
        Task<user> GetUserbyid(int id);
        Task<user> DeleteUser(int id);
    }
}