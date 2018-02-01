using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZCSAPI.DAL.DBModels
{
    public class User : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
