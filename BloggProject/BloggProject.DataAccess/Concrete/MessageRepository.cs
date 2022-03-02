using BloggProject.DataAccess.Abstract;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggProject.DataAccess.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        public Message CreateMessage(Message message)
        {
            using (var messageDBContext = new BlogDBContext())
            {
                messageDBContext.Add(message);
                messageDBContext.SaveChanges();
                return message;
            }
        }

        public void DeleteMessage(int id)
        {
            using (var messageDBContext = new BlogDBContext())
            {
                var deleteMessage = GetMessageById(id);
                messageDBContext.Messages.Remove(deleteMessage);
                messageDBContext.SaveChanges();
            }
        }

        public List<Message> GetAllMessages()
        {
            using(var messageDBContext = new BlogDBContext())
            {
                return messageDBContext.Messages.ToList();
            }
        }

        public Message GetMessageById(int id)
        {
            using (var messageDBContext = new BlogDBContext())
            {
                return messageDBContext.Messages.Find(id);
            }
        }

        public Message GetMessageByName(string name)
        {
            using (var messageDBContext = new BlogDBContext())
            {
                return messageDBContext.Messages.Where(w => w.Name == name).FirstOrDefault();
            }
        }

        public Message UpdateMessage(Message message)
        {
            using (var messageDBContext = new BlogDBContext())
            {
                messageDBContext.Messages.Update(message);
                messageDBContext.SaveChanges();
                return message;
            }
        }
    }
}
