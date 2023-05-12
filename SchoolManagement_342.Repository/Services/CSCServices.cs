using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Services
{
    public class CSCServices : ICSCDropdown
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
        public List<City> CityDropDown(int Stateid)
        {
            try
            {
            List<City> GetCityList = context.Cities.Where(x => x.StateId == Stateid).ToList();
            return GetCityList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Country> CountryDropDown()
        {
            try
            {
            List<Country> GetCountryList = context.Countries.ToList();
            return GetCountryList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<State> StateDropDown(int CountryId)
        {
            try
            {
            List<State> getStateList = context.States.Where(x => x.CountryId == CountryId).ToList();
            return getStateList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
