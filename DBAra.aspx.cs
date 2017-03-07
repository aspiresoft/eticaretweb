using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DBAra : BasePage
{
    Broker broker;
    protected void Page_Load(object sender, EventArgs e)
    {
        broker = new Broker();
        status.Visible = false;

    }
    protected void sorgula_sorgula_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            status.Visible = true;
            string sorgu = sorgula_sorgu.Text;

            List<Phone> list = new List<Phone>();
            broker.Select(list, sorgu);
            if (list.Count != 0)
            {
                sorgula_telefonlistesi.Visible = true;
                sorgula_telefonlistesi.Items.Clear();
                foreach (Phone p in list)
                {
                    sorgula_telefonlistesi.Items.Add(new ListItem("[" + p.Id + "] " + p.Brand + " " + p.Name + " | " + p.Price + " TL | "));
                }
                status.Text = list.Count + " telefon bulundu!";
            }
            else
            {
                sorgula_telefonlistesi.Visible = false;
                status.Text = "Hicbir telefon bulunamadi!";
            }
            status.Visible = true;
        }
    }
}