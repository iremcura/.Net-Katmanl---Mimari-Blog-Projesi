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
    public class CategoryController : ControllerBase
    {
        private ICategoryServices _categoryServices;

        public CategoryController()
        {
            _categoryServices = new CategoryServices();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryServices.GetAllCategories();
            return Ok(categories);
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            var createCategory = _categoryServices.CreateCategory(category);
            return Ok(createCategory);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_categoryServices.GetCategoryById(id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                _categoryServices.DeleteCategory(id);
                return Ok("Deleted Category");
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Category category)
        {
            if (_categoryServices.GetCategoryById(category.Category_Id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(_categoryServices.UpdateCategory(category));
            }
            return NotFound();
        }

    }
}
