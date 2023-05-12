using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
    public interface ICity
    {
         void AddCity(CityModel CityData);

        List<Sp_Get_City_Result> GetCity();
        List<State> StateDropDown(int CountryId);

        List<Country> CountryDropDown();

        int DelCityInDb(int CityID);

        CityModel EditCityInDb(int CityId);

        void UpdateData(int id, CityModel Model);

    }
}
