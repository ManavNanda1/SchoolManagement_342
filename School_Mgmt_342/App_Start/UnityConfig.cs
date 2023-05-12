using SchoolManagement_342.Repository.Repository;
using SchoolManagement_342.Repository.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace School_Mgmt_342
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IuserRepo, UserServices>();
            container.RegisterType<ICountryRepo,CountryServices >();
            container.RegisterType<IStateRepo, StateService>();
            container.RegisterType<IStudent, StudentService>();
            container.RegisterType<ITeacher, TeacherService>();
            container.RegisterType<ICity, CityServices>();
            container.RegisterType<ICSCDropdown, CSCServices>();
            container.RegisterType<ISubject, SubjectService>();
            container.RegisterType<ICountDashboard , CountServices>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));



        }
    }
}