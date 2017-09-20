using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Procedures : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        SqlCommand cmd = new SqlCommand("updateAccount", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("Procedure One Executed");
    }

    protected void SP_2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        SqlCommand cmd = new SqlCommand("deleteAccount", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@accNo", 15);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("Procedure One Executed");
    }

    protected void SP_3_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        SqlCommand cmd = new SqlCommand("InsertAccount", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@acNo", 21);
        cmd.Parameters.AddWithValue("@acName", "Iron Man");
        cmd.Parameters.AddWithValue("@acType","PF" );
        cmd.Parameters.AddWithValue("@acBal", 50000);
        cmd.Parameters.AddWithValue("@acBranch", 09);


        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("Procedure Three Executed");
    }

    protected void SP_4_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
        SqlCommand cmd = new SqlCommand("InsertAccount_2", con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add("@acNo", SqlDbType.Int,4);
        cmd.Parameters["@acNo"].Direction = ParameterDirection.Output;


        cmd.Parameters.AddWithValue("@acName", "Iron Man");
        cmd.Parameters.AddWithValue("@acType", "PF");
        cmd.Parameters.AddWithValue("@acBal", 50000);
        cmd.Parameters.AddWithValue("@acBranch", 09);


        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("Procedure fout Executed, new account number is "+cmd.Parameters["@acNo"].Value);
    }
}