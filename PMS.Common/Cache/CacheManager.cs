using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PMS.Common.ICache;
using PMS.Core.DataTransfer;
using PMS.Common;

namespace PMS.Core.Cache
{
    public class CacheManager : ICacheManager
    { 

        private const int expiry = 120;

        public Store<List<UserInfo>> UserInfoStore;

        public CacheManager(
            )
        {
            LoadInitialDataInMemory();

        }

        private void LoadInitialDataInMemory()
        {
            DateTime oldDate = DateTime.UtcNow.AddYears(-1000);

            UserInfoStore = new Store<List<UserInfo>>(expiry);
            UserInfoStore.OnUpdateDate += UserInfoStore_OnUpdateDate;
            UserInfoStore.MaxLastUpdateDate = oldDate;
            UserInfoStore.updateData();
        }

        private List<UserInfo> UserInfoStore_OnUpdateDate()
        {
            return HelperUtility.GetUserInfo().Result;
        }

        public List<UserInfo> GetUserInfo()
        {
            var userInfo = UserInfoes.ToList();
            return userInfo;
        }

        private List<UserInfo> UserInfoes { get { return UserInfoStore.Data; } }
    }
}
