﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement_342.Models.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Manav_SchoolMgmt_42Entities : DbContext
    {
        public Manav_SchoolMgmt_42Entities()
            : base("name=Manav_SchoolMgmt_42Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StudentTeacherDetail> StudentTeacherDetails { get; set; }
        public virtual DbSet<SubjectDetail> SubjectDetails { get; set; }
        public virtual DbSet<TeacherDetail> TeacherDetails { get; set; }
        public virtual DbSet<TeacherSubjectDetail> TeacherSubjectDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<StudentDetail> StudentDetails { get; set; }
    
        public virtual int Sp_Add_User_SM(string userEmail, string userPassword, string userFirstName, string userLastName)
        {
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("UserEmail", userEmail) :
                new ObjectParameter("UserEmail", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("UserPassword", userPassword) :
                new ObjectParameter("UserPassword", typeof(string));
    
            var userFirstNameParameter = userFirstName != null ?
                new ObjectParameter("UserFirstName", userFirstName) :
                new ObjectParameter("UserFirstName", typeof(string));
    
            var userLastNameParameter = userLastName != null ?
                new ObjectParameter("UserLastName", userLastName) :
                new ObjectParameter("UserLastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Add_User_SM", userEmailParameter, userPasswordParameter, userFirstNameParameter, userLastNameParameter);
        }
    
        public virtual int Sp_Add_Country(string countryname)
        {
            var countrynameParameter = countryname != null ?
                new ObjectParameter("Countryname", countryname) :
                new ObjectParameter("Countryname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Add_Country", countrynameParameter);
        }
    
        public virtual ObjectResult<Sp_Get_City_Result> Sp_Get_City()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_City_Result>("Sp_Get_City");
        }
    
        public virtual ObjectResult<Sp_Get_Country_Result> Sp_Get_Country()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_Country_Result>("Sp_Get_Country");
        }
    
        public virtual ObjectResult<Sp_Get_State_Result> Sp_Get_State()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_State_Result>("Sp_Get_State");
        }
    
        public virtual int Sp_Add_Student(string fname, string lname, string address, string phone, string email, string gender, Nullable<long> country, Nullable<long> state, Nullable<long> city, string teacherid)
        {
            var fnameParameter = fname != null ?
                new ObjectParameter("Fname", fname) :
                new ObjectParameter("Fname", typeof(string));
    
            var lnameParameter = lname != null ?
                new ObjectParameter("Lname", lname) :
                new ObjectParameter("Lname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var countryParameter = country.HasValue ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(long));
    
            var stateParameter = state.HasValue ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(long));
    
            var cityParameter = city.HasValue ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(long));
    
            var teacheridParameter = teacherid != null ?
                new ObjectParameter("teacherid", teacherid) :
                new ObjectParameter("teacherid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Add_Student", fnameParameter, lnameParameter, addressParameter, phoneParameter, emailParameter, genderParameter, countryParameter, stateParameter, cityParameter, teacheridParameter);
        }
    
        public virtual ObjectResult<Sp_Get_Students_Result> Sp_Get_Students()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_Students_Result>("Sp_Get_Students");
        }
    
        public virtual ObjectResult<Sp_Get_Subject_Result> Sp_Get_Subject()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_Subject_Result>("Sp_Get_Subject");
        }
    
        public virtual ObjectResult<Sp_Get_Teachers_Result> Sp_Get_Teachers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_Get_Teachers_Result>("Sp_Get_Teachers");
        }
    }
}