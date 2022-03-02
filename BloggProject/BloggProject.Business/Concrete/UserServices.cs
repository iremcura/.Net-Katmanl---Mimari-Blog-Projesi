using BloggProject.Business.Abstract;
using BloggProject.DataAccess.Abstract;
using BloggProject.DataAccess.Concrete;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BloggProject.Business.Concrete
{
    public class UserServices : IUserServices
    {
        private IUserRepository _userRepository;
        /// <summary>
        /// 
        /// </summary>
        public UserServices()
        {
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> CreateUser(User user)
        {
            return await _userRepository.CreateUser(user);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IList<User>> GetAllUsers()
        {
            var response = await _userRepository.GetAllUsers();
            return response;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns></returns>
        public async Task<User> GetUserByName(string user_name)
        {
            return await _userRepository.GetUserByName(user_name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<User> UpdateUser(User user)
        {
            return await _userRepository.UpdateUser(user);
        }
    }
}
