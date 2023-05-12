using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
    public class StateHelper
    {
        public State AddstateData(StateModel StateData)
        {
            State data = new State();
            data.CountryId = StateData.CountryId;
            data.StateName = StateData.StateName;
            return data;
        }
    }
}
