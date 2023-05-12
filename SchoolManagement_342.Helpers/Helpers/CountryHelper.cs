using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
   public  class CountryHelper
    {
        public Country AddCountryData(CountryModel CountryData)
        {
            Country data = new Country();
            data.CountryName = CountryData.CountryName;
            return data;
        }
    }
}
