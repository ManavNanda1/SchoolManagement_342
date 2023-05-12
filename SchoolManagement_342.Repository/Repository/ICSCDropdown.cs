using SchoolManagement_342.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
    public interface ICSCDropdown
    {
        List<Country> CountryDropDown();
        List<State> StateDropDown(int CountryId);
        List<City> CityDropDown(int StateId);
    }
}
