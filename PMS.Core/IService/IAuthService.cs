using PMS.Core.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Core.IService
{
    public interface IAuthService
    {
        Task<UserLoginDTO> Login(SigninDTO signinDTO);
        Task<UserLoginDTO> SubscribeDeviceToken(string token);
        
    }
}
