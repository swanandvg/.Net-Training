using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BankAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        BankingDBEntities dbsource = new BankingDBEntities();

        var accounts = from a in dbsource.AccountDetails
                       select a;

        GridView1.DataSource = accounts.ToList();
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        BankingDBEntities db = new BankingDBEntities();
        var data = from a in db.AccountDetails
                   join br in db.BranchInfoes
                   on a.accBranch equals br.branchNo
                   select new
                   {
                       a.accNo,
                       a.accName,
                       a.accType,
                       a.accBalance,
                       a.accBranch,
                       br.branchCity,
                       br.branchName
                   };
        GridView1.DataSource = data.ToList();
        GridView1.DataBind();
    }
}