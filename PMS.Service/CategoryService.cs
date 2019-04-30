using PMS.Core.IRepository;
using PMS.Core.IService;
using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Service
{
    public class CategoryService: ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<List<Category>> GetAllCategories()
        {
            var categories = await _categoryRepository.GetAllCategories();
            return categories;
        }
    }
}
