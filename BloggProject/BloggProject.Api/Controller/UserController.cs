using BloggProject.Business.Abstract;
using BloggProject.Business.Concrete;
using BloggProject.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggProject.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private IUserServices _userServices;
        public UserController()
        {
            _userServices = new UserServices();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userServices.GetAllUsers();
            return Ok(users.ToList());
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            var createUser = await _userServices.CreateUser(user);
            return Ok(createUser);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {          
            var isDeleted = await _userServices.DeleteUser(id);
            if (isDeleted)
                return Ok("Deleted User");
            else
                return Ok("Not deleted User");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] User user)
        {
            var usr = await _userServices.GetUserById(user.User_Id);
            if (usr != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(await _userServices.UpdateUser(user));
            }
            return NotFound();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpGet("get-by-username")]
        public async Task<IActionResult> GetByUserName([FromQuery]string username)
        {
            var response = await _userServices.GetUserByName(username);

            return Ok(response);
        }
    }
}
