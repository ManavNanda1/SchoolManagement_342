using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
    public interface ICountryRepo
    {
        void AddCountryInDb(CountryModel CountryData);

        List<Sp_Get_Country_Result> GetCountryTable();

        int DelCountryInDb(int CountryId);

        CountryModel EditCountryInDb(int CountryId);

        void UpdateData(int id,CountryModel Model);
    }
}
