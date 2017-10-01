using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class LoginController : ApiController
    {
        // GET api/<controller>
        public String GetLogin(string UserName, string PassWord)
        {
            BankingDBEntities db = new BankingDBEntities();
            
            var currentUser = (from a in db.UserInfoes
                               where a.userName == UserName && a.password ==PassWord
                               select a).Count();

            
                if (currentUser==1)
                {
                return "Success";
            }
            return "Fail";
            
        }

        // POST api/<controller>
        public string Post(string UserName, string PassWord)
        {
            BankingDBEntities db = new BankingDBEntities();

            var currentUser = (from a in db.UserInfoes
                               where a.userName == UserName && a.password == PassWord
                               select a).Count();


            if (currentUser == 1)
            {
                return "Success";
            }
            return "Fail";
        }


        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}



        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}