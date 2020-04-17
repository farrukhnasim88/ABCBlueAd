using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.Data;
using ABC.ENTITY;
namespace ABC.Logic
{
    public class ABCServices
    {
        //fields
        private ABCDateAccess dao;

        public ABCServices()
        {
            dao = new ABCDateAccess();
        }

        public StateEnum SaveClient(Clients clients)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.InsertClient(clients);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }



        public StateEnum UpdateClientDetails(Clients clients)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.UpdateClient(clients);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }

        public StateEnum DeleteClient(Clients clients)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.RemoveClient(clients);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }

        public List<Clients> FindAllClients()
        {

            //State<List<Clients>> result = new State<List<Clients>>();
            //try
           // {
                return dao.SelectAllClients();
                //result.StateResult = StateEnum.Success;
            //}
            //catch
            //{
              //  result.StateResult = StateEnum.Fail;
            //}
            //return result;


        }

        public Clients SearchClientByID(int id)
        {
            Clients found = null;
            try
            {
                found = dao.FindClientByID(id);
            }
            catch
            {

            }
            return found;
        }

        public List<Brands> SearchBrandByClientID(int id)
        {
            //Brands found = null;
            //try
            //{
            //    found = dao.FindBrandByClientID(id);
            //}
            //catch { }
            //return found;
            return dao.FindBrandByClientID(id);
            
        }

        public StateEnum SaveBrand(Brands brands)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.InsertBrand(brands);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }

        public List<Brands> FindAllBrands()
        {

            //State<List<Clients>> result = new State<List<Clients>>();
            //try
            // {
            return dao.SelectAllBrands();
            //result.StateResult = StateEnum.Success;
            //}
            //catch
            //{
            //  result.StateResult = StateEnum.Fail;
            //}
            //return result;


        }

        public Brands SearchBrandByID(int id)
        {
            Brands found = null;
            try
            {
                found = dao.FindBrandByID(id);
            }
            catch
            {

            }
            return found;
        }

        public StateEnum UpdateBrandDetails(Brands brands)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.UpdateBrand(brands);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }

        public StateEnum DeleteBrand(Brands brands)
        {
            StateEnum result = StateEnum.Success;
            try
            {
                dao.RemoveBrand(brands);
            }
            catch
            {
                result = StateEnum.Fail;
            }
            return result;
        }

        public List<Adverts> SearchAdvertByBrandID(int id)
        {
            //Brands found = null;
            //try
            //{
            //    found = dao.FindBrandByClientID(id);
            //}
            //catch { }
            //return found;
            return dao.FinAdvertByBrandID(id);

        }

    }
}
