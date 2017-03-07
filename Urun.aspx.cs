using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Urun : BasePage
{
    private static Broker b;
    private int id;
    private static Phone p;
    private List<Cart> sepet;

    protected void Page_Load(object sender, EventArgs e)
    {
        sepet = (List<Cart>)Session["List"];
        Label1.Visible = false;
        b = new Broker();
        id = Convert.ToInt32(Request.QueryString["id"]);
        List<Phone> list = new List<Phone>();
        b.Select(list, " WHERE ID=" + id);
        if (list.Count != 0)
        {
            p = list[0];
            Image img = new Image();
            string path = "~/Images/Phones/" + p.Id + ".jpg";
            if (!System.IO.File.Exists(Server.MapPath(path)))
            {
                path = "~/Images/unavailable.png";
            }
            img.ImageUrl = path;
            img.Width = 400;
            img.Height = 400;
            img.CssClass = "filters";
            Table1.Rows[0].Cells[0].Controls.Add(img);
            Label header = new Label();
            header.Text = p.Brand + " " + p.Name;
            header.Font.Size = 36;
            header.CssClass = "text";
            Table1.Rows[0].Cells[1].Controls.Add(header);
            Label text = new Label();
            text.Text = "<br/>" + p.Price + "TL" + "<br/>" + "İşletim Sistemi: " + p.Os + "<br/>" + "Ekran büyüklüğü: " + p.Length + " inç" + "<br/>" + "Dahili Hafıza: " + p.Memory + "GB";
            text.CssClass = "text";
            Table1.Rows[0].Cells[1].Controls.Add(text);

        }
    }

    protected void satinAl_Click(object sender, EventArgs e)
    {
        if (p != null)
        {
            Cart c = new Cart
            {
                PhoneId = p.Id,
                Quantity = Convert.ToInt32(DropDownList1.SelectedValue),
                Price = p.Price * Convert.ToInt32(DropDownList1.SelectedValue)
            };
            bool flag = false;
            foreach (Cart cart in sepet)
            {
                if (cart.PhoneId == c.PhoneId)
                {
                    cart.Quantity += c.Quantity;
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                sepet.Add(c);
            }
            Label1.Visible = true;
            Label1.Text = p.Brand + " " + p.Name + " sepete eklendi.";

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}