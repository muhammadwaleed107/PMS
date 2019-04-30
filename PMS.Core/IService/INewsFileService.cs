using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IService
{
    public interface INewsFileService
    {
        Task<List<NewsFile>> GetNewsFileByFilter(int categoryId, List<int> filters, int pageOffset, int pageSize,string searchText);
        Task<List<string>> SearchKeyword(string searchtext, int count);
    }
}
