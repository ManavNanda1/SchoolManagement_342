using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement_342.Helpers.Helpers;

namespace SchoolManagement_342.Repository.Services
{

    public class UserServices : IuserRepo
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
        
         int IuserRepo.LoginDataCheck(LoginModel uCheck)
        {
            try
            {
            UserHelper userdata = new UserHelper();
            User user = userdata.GetData(uCheck);
            if (context.Users.Any(x => x.UserEmail == user.UserEmail && x.UserPassword == user.UserPassword))
            {
                return 1;
            }
            else {
                return 0;
            }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

          void IuserRepo.AddUserInData(RegisterModel AddUser)
        {
            try
            {
                UserHelper userdata = new UserHelper();
                User user = userdata.AddData(AddUser);
                context.Sp_Add_User_SM(user.UserEmail, user.UserPassword, user.UserFirstName, user.UserLastName);
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
