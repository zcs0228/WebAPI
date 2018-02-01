using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.BLL.Message;
using ZCSAPI.BLL.ViewModels;
using ZCSAPI.DAL.DBModels;
using ZCSAPI.Repository;

namespace ZCSAPI.BLL
{
    public class LoginUser
    {
        private static UserRepository userRep = new UserRepository();
        public static UserResponse GetUserByCode(UserRequest request)
        {
            try
            {
                User result = userRep.GetUserByCode(request.Data.Code);
                UserView userView = UserView.ConvertFromUser(result);
                UserResponse response = new UserResponse(userView);
                return response;
            }
            catch(Exception ex)
            {
                UserResponse response = new UserResponse(null);
                response.Msg = ex.Message;
                return response;
            }
        }
    }
}
