using FirstWebAPI_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebAPI_Service.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Accounts> GetAllAccounts()
        {
            return (new Accounts().AllAccounts());
        }

        public Accounts GetSearchAccounts(int AccNo)
        {
            return (new Accounts().SearchAccounts(AccNo));
        }

        [HttpPost]
        public int PostAddAccount(Accounts acc)
        {
            return(new Accounts().AddAccount(acc));
        }

        //[Route(Name = "GreetUser")]
        //public string GetGreetUser()
        //{
        //    return "Welcome to Web API";
        //}

        //[Route(Name ="GetProducts")]
        //public IEnumerable<string> GetListOfProducts()
        //{
        //    return new string[] {"Laptop", "Mobile Phone", "Watch" };
        //}

        ////[Route(Name ="GetBonus")]
        //public int GetBonus(int Salary)
        //{
        //    return (int)(Salary * 0.2);
        //}

        #region dummy code
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        #endregion

    }
}