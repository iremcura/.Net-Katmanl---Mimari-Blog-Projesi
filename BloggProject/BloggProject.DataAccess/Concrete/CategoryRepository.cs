using BloggProject.DataAccess.Abstract;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggProject.DataAccess.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category CreateCategory(Category category)
        {
            using (var categoryDBContext = new BlogDBContext())
            {
                categoryDBContext.Add(category);
                categoryDBContext.SaveChanges();
                return category;
            }
        }

        public void DeleteCategory(int id)
        {
            using (var categoryDBContext = new BlogDBContext())
            {
                var deleteCategory = GetCategoryById(id);
                categoryDBContext.Categories.Remove(deleteCategory);
                categoryDBContext.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            using (var categoryDBContext = new BlogDBContext())
            {
                return categoryDBContext.Categories.ToList();
            }
        }

        public Category GetCategoryById(int id)
        {
            using (var categoryDBContext = new BlogDBContext())
            {
                return categoryDBContext.Categories.Find(id);
            }
        }

        public Category GetCategoryByName(string category_name)
        {
            using (var categoryDBContext = new BlogDBContext())
            {
                return categoryDBContext.Categories.Where(w => w.Category_Name == category_name).FirstOrDefault();
            }
        }

        public Category UpdateCategory(Category category)
        {
            using (var categoryDBContext = new BlogDBContext())
            {
                categoryDBContext.Categories.Update(category);
                categoryDBContext.SaveChanges();
                return category;
            }
        }
    }
}
