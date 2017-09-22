using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LinqExcercise : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var db = new BankingDBEntities();
        var data = from a in db.AccountDetails
                   group a by a.accType into res
                   select new
                   {
                       Type = res.Key,
                       TotalBalance = res.Sum(x => x.accBalance)
                   };

        GridView1.DataSource = data.ToList();
        GridView1.DataBind();
    }
}