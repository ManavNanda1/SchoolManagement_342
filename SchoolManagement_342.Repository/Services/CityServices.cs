using SchoolManagement_342.Helpers.Helpers;
using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Services
{
    public class CityServices : ICity
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();

        public void AddCity(CityModel CityDatas)
        {
            CityHelper CityData = new CityHelper();
            City s = CityData.AddCityInDb(CityDatas);
            context.Cities.Add(s);
            context.SaveChanges();
        }

        public List<Country> CountryDropDown()
        {
            try
            {
                List<Country> getCountryLisyt = context.Countries.ToList();
                return getCountryLisyt;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public int DelCityInDb(int CityID)
        {
            try
            {
                var CityStatus = context.Cities.Any(x => x.Id == CityID);
                if (CityStatus)
                {
                    var GetCity = context.Cities.Find(CityID);
                    context.Cities.Remove(GetCity);
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

        public List<Sp_Get_City_Result> GetCity()
        {
            try
            {
                List<Sp_Get_City_Result> CityList = context.Sp_Get_City().ToList();
                return CityList;
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
                List<State> GetStateList = context.States.Where(x => x.CountryId == CountryId).ToList();
                return GetStateList;
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        public CityModel EditCityInDb(int CityId)
        {
            try
            {
                var City = context.Cities.Where(x => x.Id == CityId).FirstOrDefault();
                return new CityModel
                {
                    id = (int)City.Id,
                    StateId = (int)City.StateId,
                    CountryId = (int)City.CountryId,
                    CityName = City.CityName
                };
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public void UpdateData(int id, CityModel Model)
        {
            try
            {
                var City = context.Cities.Where(x => x.Id == id).FirstOrDefault();
                City.CountryId = Model.CountryId;
                City.StateId = Model.StateId;
                City.CityName = Model.CityName;
                context.SaveChanges();
            }
            catch (Exception E)
            {
                throw E;
            }
        }

    }
}
