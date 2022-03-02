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
    public class ProfileController : ControllerBase
    {
        private IProfileServices _profileServices;

        public ProfileController()
        {
            _profileServices = new ProfileServices();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var profiles = await _profileServices.GetAllProfiles();
            return Ok(profiles.ToList());
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Profile profile)
        {
            var createProfile = await _profileServices.CreateProfile(profile);
            return Ok(createProfile);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _profileServices.DeleteProfile(id);
            if (isDeleted)
                return Ok("Deleted Profile");
            else
                return Ok("Not deleted Profile");
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Profile profile)
        {
            var usr = await _profileServices.GetProfileById(profile.User_Id);
            if (usr != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(await _profileServices.UpdateProfile(profile));
            }
            return NotFound();
        }
        [HttpGet("get-by-city")]
        public async Task<IActionResult> GetProfileByCity([FromQuery] string city)
        {
            var response = await _profileServices.GetProfileByCity(city);

            return Ok(response);
        }
    }
}
