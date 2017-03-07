using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DBSil : BasePage
{
    Broker broker;
    protected void Page_Load(object sender, EventArgs e)
    {
        broker = new Broker();
        status.Visible = false;
    }

    protected void sil_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            status.Visible = true;
            int id = Convert.ToInt32(sil_id.Text);
            broker.Delete(id);
            status.Text = "Telefon silindi!";
        }

    }
}