using PMS.Core.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Common.ICache
{
    public interface ICacheManager
    {
        List<UserInfo> GetUserInfo();
    }
}
