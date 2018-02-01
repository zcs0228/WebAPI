using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.BLL.ViewModels;

namespace ZCSAPI.BLL.Message
{
    public class UserResponse : APIResponse<UserView>
    {
        public UserResponse(UserView data) : base(data)
        {
        }
    }
}
