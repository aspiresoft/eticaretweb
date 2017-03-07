using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string theme = Page.Theme;
            HttpCookie cookie = Request.Cookies.Get("theme");
            if (cookie != null)
            {
                theme = cookie.Value;
            }
            if (!String.IsNullOrEmpty(theme) || themes.Items.FindByValue(theme) != null)
            {
                themes.Items.FindByValue(theme).Selected = true;
            }

        }
    }

    protected void themes_SelectedIndexChanged(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("theme");
        cookie.Expires = DateTime.Now.AddDays(5);
        cookie.Value = themes.SelectedValue;
        Response.Cookies.Add(cookie);
        Response.Redirect(Request.Url.ToString());
    }
    protected void Image1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
