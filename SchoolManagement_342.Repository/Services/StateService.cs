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
    public class StateService:IStateRepo
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();
        public List<Sp_Get_State_Result> GetStateTable()
        {
            try
            {
                List<Sp_Get_State_Result> StateList = context.Sp_Get_State().ToList();
                return StateList;
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

        void IStateRepo.AddStateInDb(StateModel StateData)
        {
            try
            {
                StateHelper statedata = new StateHelper();
                State s = statedata.AddstateData(StateData);
                context.States.Add(s);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
          
        }

        public int DelStateInDb(int Stateid)
        {
            try
            {
                var DelState = context.States.Any(x => x.Id == Stateid);
                if (DelState)
                {
                  State GetState = context.States.Find(Stateid);
                    context.States.Remove(GetState);
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

        public StateModel EditStateInDb(int StateId)
        {
            try
            {
                var State = context.States.Where(x => x.Id == StateId).FirstOrDefault();
                return new StateModel
                {
                    Id = (int)State.Id,
                    CountryId = (int)State.CountryId,
                    StateName = State.StateName
                };
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public void UpdateData(int id, StateModel Model)
        {
            try
            {
                var State = context.States.Where(x => x.Id == id).FirstOrDefault();
                State.CountryId = Model.CountryId;
                State.StateName = Model.StateName;             
                context.SaveChanges();
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
