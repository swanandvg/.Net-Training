using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstWebAPI_Service.Models
{
    public class Accounts
    {
        public string AccName { get; set; }
        public int AccNumber { get; set; }
        public string AccType { get; set; }
        public double AccBalance { get; set; }
        public int BranchNo { get; set; }

        public int AddAccount(Accounts acc)
        {

            SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
            SqlCommand cmd_max = new SqlCommand("select max(AccNumber) from accountsinfo", con);
            con.Open();
            acc.AccNumber = Convert.ToInt32(cmd_max.ExecuteScalar().ToString()) + 1;          
            SqlCommand cmd = new SqlCommand("insert into accountsinfo values (@acNo,@acName,@acType,@acBalance,@acBranch)", con);

            cmd.Parameters.AddWithValue("@acNo", acc.AccNumber);
            cmd.Parameters.AddWithValue("@acName", acc.AccName);
            cmd.Parameters.AddWithValue("@acType", acc.AccType);
            cmd.Parameters.AddWithValue("@acBalance", acc.AccBalance);
            cmd.Parameters.AddWithValue("@acBranch", 10);

            

            int row = cmd.ExecuteNonQuery();

            con.Close();

            if (row == 1)
                return acc.AccNumber;
            else
                return -99;
        }

        public List<Accounts> AllAccounts()
        {
            List<Accounts> accList = new List<Accounts>();
            Accounts acc1 = new Accounts() { AccName = "Swanand", AccNumber = 101, AccBalance = 10000, AccType = "Savings" };
            Accounts acc2 = new Accounts() { AccName = "Nand", AccNumber = 102, AccBalance = 10000, AccType = "Savings" };
            Accounts acc3 = new Accounts() { AccName = "Swan", AccNumber = 103, AccBalance = 10000, AccType = "Savings" };
            Accounts acc4 = new Accounts() { AccName = "Swany", AccNumber = 104, AccBalance = 10000, AccType = "Savings" };

            accList.Add(acc1);
            accList.Add(acc2);
            accList.Add(acc3);
            accList.Add(acc4);

            return accList;
        }

        public Accounts SearchAccounts(int accNo)
        {
            List<Accounts> accList = new List<Accounts>();
            Accounts acc1 = new Accounts() { AccName = "Swanand", AccNumber = 101, AccBalance = 10000, AccType = "Savings" };
            Accounts acc2 = new Accounts() { AccName = "Nand", AccNumber = 102, AccBalance = 10000, AccType = "Savings" };
            Accounts acc3 = new Accounts() { AccName = "Swan", AccNumber = 103, AccBalance = 10000, AccType = "Savings" };
            Accounts acc4 = new Accounts() { AccName = "Swany", AccNumber = 104, AccBalance = 10000, AccType = "Savings" };

            accList.Add(acc1);
            accList.Add(acc2);
            accList.Add(acc3);
            accList.Add(acc4);

            try
            {
                var acc = (from ac in accList
                           where ac.AccNumber == accNo
                           select ac).Single();
                return acc;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
            
        }

        public IEnumerable<Accounts> FetchAllFromDB()
        {
            List<Accounts> accList = new List<Accounts>();
            SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
            SqlCommand cmd_getDetails = new SqlCommand("select * from accountsinfo ", con);

            con.Open();
            SqlDataReader rd = cmd_getDetails.ExecuteReader();
            while(rd.Read())
                accList.Add(new Accounts() { AccNumber = (int)rd["AccNumber"], AccBalance = Convert.ToDouble(rd["AccBalance"]), AccName = rd["AccName"].ToString(), AccType = rd["AccType"].ToString() });

            rd.Close();
            con.Close();
            return accList;
        }

        public Accounts FetchMaxBalAccount()
        {
            SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
            SqlCommand cmd_getDetails = new SqlCommand("select * from accountsinfo where AccBalance= (select max(AccBalance) from AccountsInfo)", con);

            con.Open();
            SqlDataReader rd = cmd_getDetails.ExecuteReader();
            Accounts acc = new Accounts();
            if (rd.Read())
            {
                acc.AccNumber = (int)rd["AccNumber"];
                acc.AccBalance = Convert.ToDouble(rd["AccBalance"]);
                acc.AccName = rd["AccName"].ToString();
                acc.AccType = rd["AccType"].ToString() ;
            }
            rd.Close();
            con.Close();
            return acc;
        }

        public IEnumerable<Accounts> SortAndFetchAllFromDB(string column)
        {
            List<Accounts> accList = new List<Accounts>();
            SqlConnection con = new SqlConnection("server=localhost; database=BankingDB; user id=sa; password=Rsa@2bsafe");
            SqlCommand cmd_getDetails = new SqlCommand("select * from accountsinfo order by "+column, con);

            con.Open();
            SqlDataReader rd = cmd_getDetails.ExecuteReader();
            while (rd.Read())
                accList.Add(new Accounts() { AccNumber = (int)rd["AccNumber"], AccBalance = Convert.ToDouble(rd["AccBalance"]), AccName = rd["AccName"].ToString(), AccType = rd["AccType"].ToString() });

            rd.Close();
            con.Close();
            return accList;
        }
    }
}