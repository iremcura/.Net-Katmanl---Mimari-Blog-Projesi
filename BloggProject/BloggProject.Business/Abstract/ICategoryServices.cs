using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.Business.Abstract
{
   public interface ICategoryServices
    {
        Category CreateCategory(Category category);
        Category GetCategoryByName(string category_name);
        Category GetCategoryById(int id);
        Category UpdateCategory(Category category);
        void DeleteCategory(int id);
        List<Category> GetAllCategories();
    }
}
