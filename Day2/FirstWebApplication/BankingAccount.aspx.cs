using System;

using System.Data.SqlClient;
using System.Security;

public partial class BankingAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_AddAccount_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        //new SecureString();
        //SqlConnection con = new SqlConnection("server=CORP\\gajens2;database=BankingDB", new SqlCredential("sa", new System.Security.SecureString("MYPASSWORD",10)));
        SqlCommand cmd = new SqlCommand("insert into accountsinfo values (@acNo,@acName,@acType,@acBalance,@acBranch)", con);

        cmd.Parameters.AddWithValue("@acNo", txt_AccountNumber.Text);
        cmd.Parameters.AddWithValue("@acName", txt_AccountName.Text);
        cmd.Parameters.AddWithValue("@acType", txt_AccountType.Text);
        cmd.Parameters.AddWithValue("@acBalance", txt_AccountBalance.Text);
        cmd.Parameters.AddWithValue("@acBranch", txt_BranchNumber.Text);

        con.Open();

        cmd.ExecuteNonQuery();

        con.Close();

        Response.Write("Account added Successfully");

    }

    protected void btn_DeleteAccount_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        //new SecureString();
        //SqlConnection con = new SqlConnection("server=CORP\\gajens2;database=BankingDB", new SqlCredential("sa", new System.Security.SecureString("MYPASSWORD",10)));
        SqlCommand cmd = new SqlCommand("delete from accountsinfo where AccNumber=@acNo", con);
        cmd.Parameters.AddWithValue("@acNo", txt_AccountNumber.Text);

        con.Open();

        int rowsAffected = cmd.ExecuteNonQuery();

        con.Close();

        if(rowsAffected>0)
            Response.Write("Account deleted Successfully");
        else
            Response.Write("No such account");
    }

    protected void btn_EditAccount_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        //new SecureString();
        //SqlConnection con = new SqlConnection("server=CORP\\gajens2;database=BankingDB", new SqlCredential("sa", new System.Security.SecureString("MYPASSWORD",10)));
        SqlCommand cmd = new SqlCommand("update accountsinfo set accName=@acName,accType=@acType,accBalance=@acBalance,accBranchNo=@acBranch where AccNumber=@acNo", con);

        cmd.Parameters.AddWithValue("@acNo", txt_AccountNumber.Text);
        cmd.Parameters.AddWithValue("@acName", txt_AccountName.Text);
        cmd.Parameters.AddWithValue("@acType", txt_AccountType.Text);
        cmd.Parameters.AddWithValue("@acBalance", txt_AccountBalance.Text);
        cmd.Parameters.AddWithValue("@acBranch", txt_BranchNumber.Text);

        con.Open();

        cmd.ExecuteNonQuery();

        con.Close();

        Response.Write("Account updated Successfully");
    }

    #region Copied from net for future execution
    private SecureString ConvertToSecureString(string password)
    {
        if (password == null)
            throw new ArgumentNullException("password");

        var securePassword = new SecureString();

        foreach (char c in password)
            securePassword.AppendChar(c);

        securePassword.MakeReadOnly();
        return securePassword;
    }
    #endregion

    protected void btn_Summary_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        //new SecureString();
        //SqlConnection con = new SqlConnection("server=CORP\\gajens2;database=BankingDB", new SqlCredential("sa", new System.Security.SecureString("MYPASSWORD",10)));
        SqlCommand cmd_sum = new SqlCommand("select sum(AccBalance) from accountsinfo", con);
        SqlCommand cmd_count = new SqlCommand("select count(AccBalance) from accountsinfo", con);
        SqlCommand cmd_min = new SqlCommand("select min(AccBalance) from accountsinfo", con);
        SqlCommand cmd_max = new SqlCommand("select max(AccBalance) from accountsinfo", con);
        SqlCommand cmd_avg = new SqlCommand("select avg(AccBalance) from accountsinfo", con);

        double sum, avg;
        double min, max, count;

        con.Open();
        sum = Convert.ToDouble(cmd_sum.ExecuteScalar().ToString());
        min = Convert.ToDouble(cmd_min.ExecuteScalar().ToString());
        max = Convert.ToDouble(cmd_max.ExecuteScalar().ToString());
        count = Convert.ToDouble(cmd_count.ExecuteScalar().ToString());
        avg = Convert.ToDouble(cmd_avg.ExecuteScalar().ToString());
        con.Close();

        Label1.Text = "Total Sum of Balnce: " + sum;
        Label2.Text = "Minimum Balnce: " + min;
        Label3.Text = "Maxmimum Balnce: " + max;
        Label4.Text = "Total Accounts : " + count;
        Label5.Text = "Average Balnce: " + avg;
    }

    protected void btn_GetDetails_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        //new SecureString();
        //SqlConnection con = new SqlConnection("server=CORP\\gajens2;database=BankingDB", new SqlCredential("sa", new System.Security.SecureString("MYPASSWORD",10)));
        SqlCommand cmd_getDetails = new SqlCommand("select * from accountsinfo where accnumber=@acNo", con);
        cmd_getDetails.Parameters.AddWithValue("@acNo", txt_AccountNumber.Text);

        con.Open();
        SqlDataReader rd = cmd_getDetails.ExecuteReader();
        

        if(rd.Read())
        {
            txt_AccountName.Text = rd["AccName"].ToString();
            txt_AccountType.Text = rd["AccType"].ToString();
            txt_AccountBalance.Text = rd["AccBalance"].ToString();
            txt_BranchNumber.Text = rd["AccBranchNo"].ToString();
        }
        else
        {
            Response.Write("Account Number not found");
            txt_AccountName.Text = "";
            txt_AccountType.Text = "";
            txt_AccountBalance.Text = "";
            txt_BranchNumber.Text = "";
        }
        rd.Close();
        con.Close();
    }
}