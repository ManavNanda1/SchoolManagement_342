using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
   public interface IStateRepo
    {
        void AddStateInDb(StateModel StateData);

        List<Sp_Get_State_Result> GetStateTable();

        List<Country> CountryDropDown();

        int DelStateInDb(int Stateid);

        StateModel EditStateInDb(int StateId);

        void UpdateData(int id, StateModel Model);
    }
}
