using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.BLL.ViewModels;

namespace ZCSAPI.BLL.Message
{
    public class UserRequest : APIRequest<UserView>
    {
        public UserRequest(UserView data) : base(data)
        {
        }
    }
}
