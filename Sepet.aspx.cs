using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sepet : BasePage
{
    private Broker b;
    private double toplam;
    private List<Cart> sepet;
    protected void Page_Load(object sender, EventArgs e)
    {
        sepet = (List<Cart>)Session["List"];
        b = new Broker();
        handleTable();

        if (sepet.Count == 0)
        {
            Table1.Visible = false;
            Label1.Visible = false;
        }
        else
        {
            Table1.Visible = true;
            Label1.Visible = true;
        }
    }
    private void clearTable()
    {
        Table1.Rows.Clear();
        for (int i = 1; i <= sepet.Count; i++)
        {
            TableRow tRow = new TableRow();
            tRow.HorizontalAlign = HorizontalAlign.Center;
            tRow.VerticalAlign = VerticalAlign.Middle;
            Table1.Rows.Add(tRow);
            TableCell tCell = new TableCell();
            tCell.Width = 200;
            tCell.Height = 200;
            tRow.Cells.Add(tCell);
            tCell = new TableCell();
            tCell.Width = 600;
            tCell.Height = 200;
            tRow.Cells.Add(tCell);
        }
    }
    private void handleTable()
    {
        toplam = 0;
        clearTable();

        for (int i = 0; i < sepet.Count; i++)
        {
            Cart c = sepet[i];
            Phone p = new Phone();
            List<Phone> tempList = new List<Phone>();
            this.b.Select(tempList, " WHERE ID =" + c.PhoneId);
            if (tempList.Count != 0)
            {
                p = tempList[0];
            }
            toplam += c.Price;

            Image img = new Image
            {
                Width = 200,
                Height = 200,
                CssClass = "filters"
            };
            string path = "~/Images/Phones/" + p.Id + ".jpg";
            if (!System.IO.File.Exists(Server.MapPath(path)))
            {
                path = "~/Images/unavailable.png";
            }
            img.ImageUrl = path;
            Table1.Rows[i].Cells[0].Controls.Add(img);
            Label l = new Label
            {
                Text = p.Brand + " " + p.Name + " (" + p.Price + "TL)" + "<br/>" + c.Price + "TL<br/>(" + c.Quantity + " tane)<br/>"
            };
            Table1.Rows[i].Cells[1].Controls.Add(l);
            Button b = new Button
            {
                Text = "Kaldır",
                ID = i.ToString()
            };
            b.Click += new EventHandler(button_Click);
            Table1.Rows[i].Cells[1].Controls.Add(b);
            Label1.Text = "TOTAL=" + toplam + "TL";
        }
    }

    private void button_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        sepet.RemoveAt(Convert.ToInt32(button.ID));
        handleTable();
        if (sepet.Count == 0)
        {
            Label1.Visible = false;
            Table1.Visible = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (sepet.Count != 0)
        {
            foreach (Cart c in sepet)
            {
                b.Add(c);
            }
            sepet.Clear();
            handleTable();
            Table1.Visible = false;
            Label1.Text = "Bizimle alışveriş yaptığınız için teşekkür ederiz!";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Sepette ürün bulunmamaktadır.";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}