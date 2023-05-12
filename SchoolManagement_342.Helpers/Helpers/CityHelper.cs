using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
    public class CityHelper
    {
        public City AddCityInDb(CityModel CityData)
        {
            City data = new City();
            data.CountryId = CityData.CountryId;
            data.StateId = CityData.StateId;
            data.CityName = CityData.CityName;
            return data;
        }
    }
}
