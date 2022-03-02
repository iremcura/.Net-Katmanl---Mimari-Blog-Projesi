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
    public class MessageController : ControllerBase
    {
        private IMessageServices _messageServices;
        public MessageController()
        {
            _messageServices = new MessageServices();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var messages = _messageServices.GetAllMessages();
            return Ok(messages);
        }
        /// <summary>
        /// Create Company Method
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Message message)
        {
            var createMessage = _messageServices.CreateMessage(message);
            return Ok(createMessage);
        }
        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_messageServices.GetMessageById(id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                _messageServices.DeleteMessage(id);
                return Ok("Deleted Message");
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult Put([FromBody] Message message)
        {
            if (_messageServices.GetMessageById(message.Message_Id) != null) //Parantez içine ModelState.IsValid yazılırsa da aynı amaç için kullanılır.
            {
                return Ok(_messageServices.UpdateMessage(message));
            }
            return NotFound();
        }

    }
}
