﻿using PMS.Core.DataTransfer;
using PMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IRepository
{
    public interface INewsFileRepository
    {
        Task<List<NewsFile>> GetNewsFileWithFilterFromTo(int categoryId, List<int> filters, int PageOffset, int PageSize,string searchText);
        Task<List<NewsFileResource>> GetResources(List<int> newsFileIds);
        Task<List<string>> Search(string search, int count);
        Task<bool> InsertDeviceInNMS(string deviceToken, string device, string loggedInBy);
    }
}
