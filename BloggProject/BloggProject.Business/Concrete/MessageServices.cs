using BloggProject.Business.Abstract;
using BloggProject.DataAccess.Abstract;
using BloggProject.DataAccess.Concrete;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.Business.Concrete
{
    public class MessageServices : IMessageServices
    {
        private IMessageRepository _messageRepository;
        public MessageServices()
        {
            _messageRepository = new MessageRepository();
        }
        public Message CreateMessage(Message message)
        {
            return _messageRepository.CreateMessage(message);
        }

        public void DeleteMessage(int id)
        {
            _messageRepository.DeleteMessage(id);
        }

        public List<Message> GetAllMessages()
        {
            return _messageRepository.GetAllMessages();
        }

        public Message GetMessageById(int id)
        {
            return _messageRepository.GetMessageById(id);

        }

        public Message GetMessageByName(string name)
        {
            return _messageRepository.GetMessageByName(name);
        }

        public Message UpdateMessage(Message message)
        {
            return _messageRepository.UpdateMessage(message);
        }
    }
}
