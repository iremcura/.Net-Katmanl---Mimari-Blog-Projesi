using BloggProject.Business.Abstract;
using BloggProject.DataAccess.Abstract;
using BloggProject.DataAccess.Concrete;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.Business.Concrete
{
    public class ContentServices : IContentServices
    {
        private IContentRepository _contentRepository;
        public ContentServices()
        {
            _contentRepository = new ContentRepository();
        }
        public Content CreateContent(Content content)
        {
            return _contentRepository.CreateContent(content);
        }

        public void DeleteContent(int id)
        {
            _contentRepository.DeleteContent(id);
        }

        public List<Content> GetAllContents()
        {
            return _contentRepository.GetAllContents();
        }

        public Content GetContentById(int id)
        {
            return _contentRepository.GetContentById(id);

        }

        public Content GetContentByTitle(string Content_Title)
        {
            return _contentRepository.GetContentByTitle(Content_Title);
        }

        public Content UpdateContent(Content content)
        {
            return _contentRepository.UpdateContent(content);
        }
    }
}
