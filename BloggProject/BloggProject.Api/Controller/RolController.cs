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
    public class RolController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private IRolServices _rolServices;
        public RolController()
        {
            _rolServices = new RolServices();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var rols = await _rolServices.GetAllRols();
            return Ok(rols.ToList());
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Rol rol)
        {
            var createRol = await _rolServices.CreateRol(rol);
            return Ok(createRol);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _rolServices.DeleteRol(id);
            if (isDeleted)
                return Ok("Deleted Rol");
            else
                return Ok("Not deleted Rol");
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Rol rol)
        {
            var usr = await _rolServices.GetRolById(rol.Rol_Id);
            if (usr != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(await _rolServices.UpdateRol(rol));
            }
            return NotFound();
        }

        [HttpGet("get-by-rolname")]
        public async Task<IActionResult> GetByRolName([FromQuery] string rol_name)
        {
            var response = await _rolServices.GetRolByName(rol_name);

            return Ok(response);
        }
    }
}
