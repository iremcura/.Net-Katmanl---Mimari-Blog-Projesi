using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.DataAccess.Abstract
{
    public interface ICommentRepository
    {
        Comment CreateComment(Comment comment);

        Comment GetCommentByMessage(string comment_message);
        Comment GetCommentById(int id);

        Comment UpdateComment(Comment comment);

        void DeleteComment(int id);

        List<Comment> GetAllComments();
    }
}
