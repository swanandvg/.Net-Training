using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Delete_Click(object sender, EventArgs e)
    {
        var db = new BankingDBEntities();
        //var acNo = Convert.ToInt32(txt_AccNo.Text);

        //Delete single
        //var acc = (from a in db.AccountDetails
        //           where a.accNo == acNo
        //           select a).Single();

        //db.AccountDetails.Remove(acc);
        //db.SaveChanges();

        //Delete Multiple
        var acc = from a in db.AccountDetails
                  where a.accType == txt_AccType.Text
                  select a;
        foreach (var item in acc)
            db.AccountDetails.Remove(item);

        db.SaveChanges();

        {

        }

        db.SaveChanges();
    }

    protected void btn_Insert_Click(object sender, EventArgs e)
    {
        var accObj = new AccountDetail()
        {
            accNo = Convert.ToInt32(txt_AccNo.Text),
            accName = txt_AccName.Text,
            accType = txt_AccType.Text,
            accBranch = Convert.ToInt32(txt_AccBr.Text),
            accBalance = Convert.ToInt32(txt_AccBal.Text)
        };

        var db = new BankingDBEntities();
        db.AccountDetails.Add(accObj);
        db.SaveChanges();

        Response.Write("Account added successfully");
    }

    protected void btn_Update_Click(object sender, EventArgs e)
    {
        var db = new BankingDBEntities();
        int accNo = Convert.ToInt32(txt_AccNo.Text);
        var acc = (from a in db.AccountDetails
                   where a.accNo == accNo
                   select a).Single();

        acc.accName = txt_AccName.Text;
        acc.accBalance = Convert.ToInt32(txt_AccBal.Text);
        acc.accBranch = Convert.ToInt32(txt_AccBr.Text);
        acc.accType = txt_AccType.Text;

        db.SaveChanges();

    }
    
    protected void SP1_Click(object sender, EventArgs e)
    {
        
        //var db = new BankingDBEntities();
        //int? newAccountNumber = 0;
        //int value = db.sp_newAccount( newAccountNumber,
        //                                 txt_AccName.Text,
        //                                 txt_AccType.Text,
        //                                 Convert.ToInt32(txt_AccBal.Text),
        //                                 Convert.ToInt32(txt_AccBr.Text)
        //                            );

        //Response.Write("account added, new account number " + newAccountNumber);
    }

    protected void SP2_Click(object sender, EventArgs e)
    {
        var db = new BankingDBEntities();
        db.updateBalance();
    }

    protected void SP3_Click(object sender, EventArgs e)
    {
        var db = new BankingDBEntities();
        db.sp_deleteAccount(Convert.ToInt32(txt_AccNo.Text));
    }
}