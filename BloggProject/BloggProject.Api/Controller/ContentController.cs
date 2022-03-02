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
    public class ContentController : ControllerBase
    {
        private IContentServices _contentServices;
        public ContentController()
        {
            _contentServices = new ContentServices();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var contents = _contentServices.GetAllContents();
            return Ok(contents);
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Content content)
        {
            var createContent = _contentServices.CreateContent(content);
            return Ok(createContent);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_contentServices.GetContentById(id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                _contentServices.DeleteContent(id);
                return Ok("Deleted Content");
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Content content)
        {
            if (_contentServices.GetContentById(content.Content_Id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(_contentServices.UpdateContent(content));
            }
            return NotFound();
        }
    }
}
