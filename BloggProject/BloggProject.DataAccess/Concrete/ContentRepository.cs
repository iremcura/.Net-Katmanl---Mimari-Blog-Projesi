using BloggProject.DataAccess.Abstract;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggProject.DataAccess.Concrete
{
    public class ContentRepository : IContentRepository
    {
        public Content CreateContent(Content content)
        {
            using (var contentDBContext = new BlogDBContext())
            {
                contentDBContext.Add(content);
                contentDBContext.SaveChanges();
                return content;
            }
        }

        public void DeleteContent(int id)
        {
            using (var contentDBContext = new BlogDBContext())
            {
                var deleteContent = GetContentById(id);
                contentDBContext.Contents.Remove(deleteContent);
                contentDBContext.SaveChanges();
            }
        }

        public List<Content> GetAllContents()
        {
            using (var contentDBContext = new BlogDBContext())
            {
                return contentDBContext.Contents.ToList();
            }
        }

        public Content GetContentById(int id)
        {
            using (var contentDBContext = new BlogDBContext())
            {
                return contentDBContext.Contents.Find(id);
            }
        }

        public Content GetContentByTitle(string Content_Title)
        {
            using (var contentDBContext = new BlogDBContext())
            {
                return contentDBContext.Contents.Where(w => w.Content_Title == Content_Title).FirstOrDefault();
            }
        }

        public Content UpdateContent(Content content)
        {
            using (var contentDBContext = new BlogDBContext())
            {
                contentDBContext.Contents.Update(content);
                contentDBContext.SaveChanges();
                return content;
            }
        }
    }
}
