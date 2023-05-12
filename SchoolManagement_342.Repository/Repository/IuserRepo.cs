using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;

namespace SchoolManagement_342.Repository.Repository
{
   public  interface IuserRepo
    {
        int LoginDataCheck(LoginModel uCheck);

        void AddUserInData(RegisterModel AddUser);
    }
}
