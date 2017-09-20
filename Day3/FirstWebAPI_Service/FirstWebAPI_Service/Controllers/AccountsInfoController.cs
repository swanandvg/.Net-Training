using FirstWebAPI_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI_Service.Controllers
{
    public class AccountsInfoController : ApiController
    {
        [ActionName("AllAccounts")]
        //[Route(Name ="AllAccounts")]
        public IEnumerable<Accounts> GetAllAccounts()
        {
            return (new Accounts().FetchAllFromDB());
        }

        //[ActionName("MaxBalAccount")]
        ////[Route(Name = "MaxBalAccount")]
        //public Accounts GetMaxBalAccount()
        //{
        //    return (new Accounts().FetchMaxBalAccount());
        //}

        [ActionName("SortedAccounts")]
        //[Route(Name = "SortedAccounts")]
        public IEnumerable<Accounts> GetSortedAllAccounts(string col)
        {
            return (new Accounts().SortAndFetchAllFromDB(col));
        }
    }
}