using BloggProject.Business.Abstract;
using BloggProject.DataAccess.Abstract;
using BloggProject.DataAccess.Concrete;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.Business.Concrete
{
    public class CommentServices : ICommentServices
    {
        private ICommentRepository _commentRepository;

        public CommentServices()
        {
            _commentRepository = new CommentRepository();
        }
        public Comment CreateComment(Comment comment)
        {
            return _commentRepository.CreateComment(comment);
        }

        public void DeleteComment(int id)
        {
            _commentRepository.DeleteComment(id);
        }

        public List<Comment> GetAllComments()
        {
            return _commentRepository.GetAllComments();
        }

        public Comment GetCommentById(int id)
        {
            return _commentRepository.GetCommentById(id);
        }

        public Comment GetCommentByMessage(string comment_message)
        {
            return _commentRepository.GetCommentByMessage(comment_message);
        }

        public Comment UpdateComment(Comment comment)
        {
            return _commentRepository.UpdateComment(comment);
        }
    }
}
