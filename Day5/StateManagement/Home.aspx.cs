using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{   
    //Memory leak happens with static variable on websites
    //static int PageHits = 0;
    //int PageHits = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label1.Text = "Page Hits" + ++PageHits;
        if (IsPostBack)
        {
            ViewState["PageHits"] = Convert.ToInt32(ViewState["PageHits"]) + 1; //APplicable to Page only
            Label1.Text = "View State Hits" + ViewState["PageHits"];

            Session["SessionHits"] = Convert.ToInt32(Session["SessionHits"]) + 1; //applicable to browser session
            Label2.Text = "Session Hits" + Session["SessionHits"].ToString();

            //Application["AppHits"] initialized in Global.asax
            Application["AppHits"] = Convert.ToInt32(Application["AppHits"]) + 1; //applicable to whole application
            Label3.Text = "Application Hits" + Application["AppHits"].ToString();
        }
            

    }
}