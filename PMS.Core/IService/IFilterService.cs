using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IService
{
    public interface IFilterService
    {
        Task<List<Filter>> GetAllFilters();
        Task<List<Filter>> GetAllCategories();
    }
}
