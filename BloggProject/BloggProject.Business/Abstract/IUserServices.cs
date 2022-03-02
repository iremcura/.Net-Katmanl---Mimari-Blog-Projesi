using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.Business.Abstract
{
   public interface IUserServices
    {
        Task<User> CreateUser(User user);
        Task<User> GetUserByName(string user_name);
        Task<User> GetUserById(int id);
        Task<User> UpdateUser(User user);
        Task<bool> DeleteUser(int id);
        Task<IList<User>> GetAllUsers();
    }
}
