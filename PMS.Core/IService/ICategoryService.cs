using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
    }
}
