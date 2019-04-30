using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IRepository
{
   public interface IFilterRepository
    {
        Task<List<Filter>> GetAllFilters();
        Task<List<Filter>> GetAllCategories();
    }
}
