using BloggProject.Business.Abstract;
using BloggProject.DataAccess.Abstract;
using BloggProject.DataAccess.Concrete;
using BloggProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggProject.Business.Concrete
{
    public class CategoryServices : ICategoryServices

    {
        private ICategoryRepository _categoryRepository;
        public CategoryServices()
        {
            _categoryRepository = new CategoryRepository();
        }

        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }

        public Category GetCategoryByName(string category_name)
        {
            return _categoryRepository.GetCategoryByName(category_name);
        }

        public Category UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
