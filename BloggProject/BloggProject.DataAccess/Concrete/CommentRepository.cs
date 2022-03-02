using BloggProject.DataAccess.Abstract;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggProject.DataAccess.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        public Comment CreateComment(Comment comment)
        {
            using(var commentDBContext = new BlogDBContext())
            {
                commentDBContext.Add(comment);
                commentDBContext.SaveChanges();
                return comment;
            }
        }

        public void DeleteComment(int id)
        {
            using (var commentDBContext = new BlogDBContext())
            {
                var deleteComment = GetCommentById(id);
                commentDBContext.Comments.Remove(deleteComment);
                commentDBContext.SaveChanges();
            }
        }

        public List<Comment> GetAllComments()
        {
            using (var commentDBContext = new BlogDBContext())
            {
                return commentDBContext.Comments.ToList();
            }
        }

        public Comment GetCommentByMessage(string comment_message)
        {
            using (var commentDBContext = new BlogDBContext())
            {
                return commentDBContext.Comments.Where(w => w.Comment_Message == comment_message).FirstOrDefault();
            }
        }

        public Comment GetCommentById(int id)
        {
            using (var commentDBContext = new BlogDBContext())
            {
                return commentDBContext.Comments.Find(id);
            }
        }

        public Comment UpdateComment(Comment comment)
        {
            using (var commentDBContext = new BlogDBContext())
            {
                commentDBContext.Comments.Update(comment);
                commentDBContext.SaveChanges();
                return comment;
            }
        }
    }
}
