using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
   public class UserHelper
    {

        public User GetData(LoginModel logdata) {
                 User data = new User(); 
                data.UserEmail = logdata.UserEmail;
                data.UserPassword = logdata.UserPassword;
                return data; 

        }

        public User AddData(RegisterModel Registerdata)
        {
            User data = new User();
            data.UserFirstName = Registerdata.UserFirstName;
            data.UserLastName = Registerdata.UserLastName;
            data.UserEmail = Registerdata.UserEmail;
            data.UserPassword = Registerdata.UserPassword;
            return data;
        }
    }
}
