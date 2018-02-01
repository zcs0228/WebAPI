using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZCSAPI.DAL.DBModels;

namespace ZCSAPI.BLL.ViewModels
{
    public class UserView : BaseView
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public static UserView ConvertFromUser(User user)
        {
            UserView userView = new UserView();
            userView.ID = user.ID.ToString();
            userView.Code = user.Code;
            userView.Name = user.Name;
            userView.Password = user.Password;
            userView.PasswordSalt = user.PasswordSalt;
            userView.Email = user.Email;
            userView.Phone = user.Phone;
            return userView;
        }
    }
}
