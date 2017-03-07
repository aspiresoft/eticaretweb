using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DBEkle : BasePage
{
    Broker b;
    protected void Page_Load(object sender, EventArgs e)
    {
        b = new Broker();
        status.Visible = false;
    }

    protected void ekle_telefon_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            status.Visible = true;

            Phone p = new Phone();

            p.Brand = ekle_firma.SelectedValue.ToString();
            p.Description = ekle_desc.Text;
            p.Length = Convert.ToDouble(ekle_length.Text);
            p.Memory = Convert.ToInt32(ekle_boyut.SelectedValue.ToString().Remove(ekle_boyut.SelectedValue.ToString().Length - 2));
            p.Name = ekle_isim.Text;
            p.Os = ekle_os.SelectedValue.ToString();
            p.Price = Convert.ToDouble(ekle_fiyat.Text);

            b.Add(p);

            status.Visible = true;
            status.Text = p.Brand + " " + p.Name + " basariyla eklendi!";
        }
    }
}