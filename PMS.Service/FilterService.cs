using PMS.Core.IRepository;
using PMS.Core.IService;
using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Service
{
    public class FilterService: IFilterService
    {
        private IFilterRepository _filterRepository;
        public FilterService(IFilterRepository filterRepository)
        {
            this._filterRepository = filterRepository;
        }
        public async Task<List<Filter>> GetAllFilters()
        {
            var filters = await _filterRepository.GetAllFilters();
            return filters;
        }

        public async Task<List<Filter>> GetAllCategories()
        {
            var filters = await _filterRepository.GetAllCategories();
            return filters;
        }
    }
}
