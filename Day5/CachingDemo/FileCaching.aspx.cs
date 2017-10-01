using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FileCaching : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Page generated on " + DateTime.Now.ToLongTimeString());
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.AddFileDependency(Server.MapPath("Books.xml"));
        

        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("./Books.xml"));
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}