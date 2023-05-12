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
    public  class CountryServices : ICountryRepo
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
        public void AddCountryInDb(CountryModel CountryData)
        {
            try
            {
                CountryHelper userdata = new CountryHelper();
                Country Cont = userdata.AddCountryData(CountryData);
                context.Sp_Add_Country(Cont.CountryName);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public int DelCountryInDb(int CountryId)
        {
            try
            {
                var delcountry = context.Countries.Any(x => (x.Id == CountryId));
                if(context.States.Any(x=> x.CountryId == CountryId))
                {
                    return -1;
                }
                if (delcountry)
                {
                    Country selectedC = context.Countries.Find(CountryId);
                    context.Countries.Remove(selectedC);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }

     
        public List<Sp_Get_Country_Result> GetCountryTable()
        {
            try
            {
            List<Sp_Get_Country_Result> CountryList = context.Sp_Get_Country().ToList();
            return CountryList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public CountryModel EditCountryInDb(int CountryId)
        {
            try
            {
                var country = context.Countries.Where(x => x.Id == CountryId).FirstOrDefault();
                return new CountryModel
                {
                    Id = (int)country.Id,
                    CountryName = country.CountryName
                };
            }
            catch(Exception E)
            {
                throw E;
            }
           
        }

        public void UpdateData(int id,CountryModel Model)
        {
            try
            {
                var country = context.Countries.Where(x => x.Id == id).FirstOrDefault();
                country.CountryName = Model.CountryName;
                context.SaveChanges();
            }
            catch(Exception E)
            {
                throw E;
            }
           
        }
    }
}
