using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.DataAccess.Abstract
{
    public interface IContentRepository
    {
        //crud işlemleri

        //Create
        Content CreateContent(Content content);

        //Read
        Content GetContentByTitle(string Content_Title);
        Content GetContentById(int id);

        //Update
        Content UpdateContent(Content content);

        //Delete
        void DeleteContent(int id);

        //List
        List<Content> GetAllContents();
    }
}
