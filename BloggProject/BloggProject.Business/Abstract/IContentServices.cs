using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.Business.Abstract
{
   public interface IContentServices
    {
       
        Content CreateContent(Content content);
        Content GetContentByTitle(string Content_Title);
        Content GetContentById(int id);
        Content UpdateContent(Content content);
        void DeleteContent(int id);
        List<Content> GetAllContents();
    }
}
