using BloggProject.DataAccess.Abstract;
using BloggProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.DataAccess.Concrete
{
  public  class UserRepository : IUserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> CreateUser(User user)
        {
            using(var userDBContext = new BlogDBContext()) // using demek connection aç parantez bittiği an kapa demek
            {
                await userDBContext.AddAsync(user);
                await userDBContext.SaveChangesAsync();
                return user;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUser(int id)
        {
            using(var userDBContext = new BlogDBContext())
            {
                var deletedUser =await GetUserById(id);
                if (deletedUser == null)
                    return false;
                userDBContext.Users.Remove(deletedUser);
                await userDBContext.SaveChangesAsync();
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IList<User>> GetAllUsers()
        {
            using(var userDBContext=new BlogDBContext())
            {              
                return await userDBContext.Users.ToListAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetUserById(int id)
        {
            using (var userDBContext = new BlogDBContext())
            {
                return await userDBContext.Users.FindAsync(id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        public async Task<User> GetUserByName(string user_name)
        {
            using (var userDBContext = new BlogDBContext())
            {
                return await userDBContext.Users.Where(w => w.User_Name == user_name).FirstOrDefaultAsync();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> UpdateUser(User user)
        {
            using (var userDBContext = new BlogDBContext())
            {
                userDBContext.Users.Update(user);
                await userDBContext.SaveChangesAsync();
                return user;
            }
        }
    }
}
