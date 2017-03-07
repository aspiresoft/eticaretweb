using System;
using System.Collections.Generic;
using System.Web;

public partial class BasePage : System.Web.UI.Page
{
	public BasePage()
	{
        this.PreRender += new EventHandler(Page_PreRender);
        this.PreInit += new EventHandler(Page_PreInit);
	}

    private void Page_PreInit(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies.Get("theme");
        if(cookie != null)
        {
            Page.Theme = cookie.Value;
        }
    }

    private void Page_PreRender(object sender, EventArgs e)
    {
        if(this.Title == "Untitled Page" || String.IsNullOrEmpty(this.Title))
        {
            throw new Exception("Page title cannot be empty or untitled!");
        }
    }
}