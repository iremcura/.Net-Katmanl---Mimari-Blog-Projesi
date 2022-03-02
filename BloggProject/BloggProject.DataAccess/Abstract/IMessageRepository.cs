using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.DataAccess.Abstract
{
    public interface IMessageRepository
    {
        Message CreateMessage(Message message);
        Message GetMessageByName(string name);
        Message GetMessageById(int id);
        Message UpdateMessage(Message message);
        void DeleteMessage(int id);
        List<Message> GetAllMessages();
    }
}
