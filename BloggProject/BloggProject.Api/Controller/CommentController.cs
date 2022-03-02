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
    public class CommentController : ControllerBase
    {
        private ICommentServices _commentServices;

        public CommentController()
        {
            _commentServices = new CommentServices();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var comments = _commentServices.GetAllComments();
            return Ok(comments);
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Comment comment)
        {
            var createComment = _commentServices.CreateComment(comment);
            return Ok(createComment);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_commentServices.GetCommentById(id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                _commentServices.DeleteComment(id);
                return Ok("Deleted Comment");
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Comment comment)
        {
            if (_commentServices.GetCommentById(comment.Comment_Id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(_commentServices.UpdateComment(comment));
            }
            return NotFound();
        }
    }
}
