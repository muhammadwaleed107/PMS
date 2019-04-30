using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IRepository
{
   public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategories();
    }
}
