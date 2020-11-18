using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2
{
    public partial class page5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookieCollection Cookies = Request.Cookies;
            Label1.Text = "The.ISBN# Book is:" + Cookies["MyCart"].Value;
        }
    }
}