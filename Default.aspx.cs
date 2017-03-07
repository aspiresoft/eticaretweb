using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : BasePage
{
    private static List<Cart> Sepet = new List<Cart>();
    private static bool searchedOnce = false;
    private static Broker b;
    private static List<Phone> list;
    private static int currentIndex;


    protected void Page_Load(object sender, EventArgs e)
    {
        Session["List"] = Sepet;
        if (!IsPostBack)
        {
            b = new Broker();
            list = new List<Phone>();
            b.Select(list, "");
            Session["Ccount"] = list.Count;
            list.Clear();
            currentIndex = 1;
            clearDisplayTable();
            indexer.Visible = false;
            aramaYap();
            Label1.Visible = false;

        }
    }
    protected void aramaButonu_Click(object obj, EventArgs args)
    {
        aramaYap();
    }
    private void aramaYap()
    {
        if (list == null)
        {
            b = new Broker();
            list = new List<Phone>();
        }
        Label1.Visible = true;
        list.Clear();
        currentIndex = 1;
        clearDisplayTable();
        b.Select(list, createSQLQuery());
        handleDisplayTable();
        handleIndexes();
    }
    private void handleIndexes()
    {
        indexer.Items.Clear();
        if (list.Count > 9)
        {
            for (int k = 1; k <= (int)Math.Ceiling(list.Count / 9d); k++)
            {
                indexer.Items.Add(k + "");
            }
            indexer.Visible = true;
        }
        else
        {
            currentIndex = 1;
            indexer.Visible = false;
        }
    }
    protected void indexChanger(object o, EventArgs args)
    {
        if (indexer.Visible)
        {
            currentIndex = Convert.ToInt32(indexer.SelectedValue);
        }
        handleDisplayTable();
    }
    private void handleDisplayTable()
    {
        if (!searchedOnce)
        {
            Label1.Visible = true;
            searchedOnce = true;
        }
        if (list.Count == 0)
        {
            Label1.Text = "Hiçbir telefon bulunamadı!";
        }
        else
        {
            Label1.Text = list.Count + " telefon bulundu!";
        }
        if (list.Count > 0)
        {
            clearDisplayTable();
            int max = 9 * (currentIndex);
            if (max < 0)
            {
                max = 0;
            }
            for (int i = 9 * (currentIndex - 1); i < max; i++)
            {
                if (i < list.Count)
                {
                    Label l = new Label();
                    Phone p = list.ElementAt(i);
                    HyperLink hyp = new HyperLink();
                    hyp.Font.Size = 14;
                    hyp.Text = p.Brand + " " + p.Name + " (" + p.Price + "TL)";
                    hyp.NavigateUrl = "Urun.aspx?id=" + p.Id;
                    Image img = new Image();
                    string path = "~/Images/Phones/" + p.Id + ".jpg";
                    if (!System.IO.File.Exists(Server.MapPath(path)))
                    {
                        path = "~/Images/unavailable.png";
                    }
                    img.ImageUrl = path;
                    img.Width = 240;
                    img.Height = 240;
                    Table2.Rows[(i % 9) / 3].Cells[(i % 9) % 3].BackColor = System.Drawing.Color.Beige;
                    Table2.Rows[(i % 9) / 3].Cells[(i % 9) % 3].Controls.Add(img);
                    Table2.Rows[(i % 9) / 3].Cells[(i % 9) % 3].Controls.Add(hyp);
                }
                else
                {
                    Image img = new Image();
                    img.ImageUrl = "~/Images/back.jpg";
                    img.Width = 240;
                    img.Height = 340;
                    Table2.Rows[(i % 9) / 3].Cells[(i % 9) % 3].Controls.Add(img);
                }
            }
        }
        else
        {
            for (int i = 0; i < 9; i++)
            {
                Image img = new Image();
                img.ImageUrl = "~/Images/back.jpg";
                img.Width = 240;
                img.Height = 340;
                Table2.Rows[(i % 9) / 3].Cells[(i % 9) % 3].Controls.Add(img);
            }
        }
    }
    private void clearDisplayTable()
    {
        Table2.Rows.Clear();
        for (int i = 1; i <= 3; i++)
        {
            TableRow tRow = new TableRow();
            tRow.HorizontalAlign = HorizontalAlign.Center;
            tRow.VerticalAlign = VerticalAlign.Top;
            Table2.Rows.Add(tRow);
            for (int j = 1; j <= 3; j++)
            {
                TableCell tCell = new TableCell();
                tCell.CssClass = "filters";
                tCell.BorderStyle = BorderStyle.Double;
                tCell.BorderColor = System.Drawing.Color.DarkGray;
                tCell.Width = 240;
                tCell.Height = 340;
                tRow.Cells.Add(tCell);
            }

        }
    }
    private string createSQLQuery()
    {
        string komut = " WHERE 1=1 ";
        // MARKALAR
        string marka = "";
        if (CheckBoxList1.SelectedItem != null)
        {
            marka = " AND(";
            foreach (ListItem listItem in CheckBoxList1.Items)
            {
                if (listItem.Selected)
                {
                    marka += " Brand='" + listItem.Text + "' OR";
                }
            }
            marka = marka.Remove(marka.Length - 2);
            marka += ")";
        }
        komut += marka;
        // FIYATLAR
        string fiyat = "";
        if (CheckBoxList2.SelectedItem != null)
        {
            fiyat = " AND(";
            for (int i = 0; i < CheckBoxList2.Items.Count; i++)
            {
                ListItem item = CheckBoxList2.Items[i];
                if (item.Selected)
                {
                    int min = i * 1000;
                    int max = (i + 1) * 1000 - 1;
                    if (i == CheckBoxList2.Items.Count - 1)
                    {
                        max = 99999;
                    }
                    fiyat += " (Price >='" + min + "' AND Price <='" + max + "' ) OR";
                }
            }
            fiyat = fiyat.Remove(fiyat.Length - 2);
            fiyat += ")";
        }
        komut += fiyat;
        // OS
        string os = "";
        if (CheckBoxList3.SelectedItem != null)
        {
            os = " AND(";
            foreach (ListItem listItem in CheckBoxList3.Items)
            {
                if (listItem.Selected)
                {
                    os += " OS='" + listItem.Text + "' OR";
                }
            }

            os = os.Remove(os.Length - 2);
            os += ")";
        }
        komut += os;
        // hafiza
        string hafiza = "";
        if (CheckBoxList4.SelectedItem != null)
        {
            hafiza = " AND(";
            foreach (ListItem listItem in CheckBoxList4.Items)
            {
                if (listItem.Selected)
                {
                    hafiza += " Memory='" + listItem.Text.Remove(listItem.Text.Length - 2) + "' OR";
                }
            }

            hafiza = hafiza.Remove(hafiza.Length - 2);
            hafiza += ")";
        }
        komut += hafiza;
        // UZUNLUK
        string uzunluk = "";
        if (CheckBoxList5.SelectedItem != null)
        {
            uzunluk = " AND(";
            for (int i = 0; i < CheckBoxList5.Items.Count; i++)
            {
                ListItem item = CheckBoxList5.Items[i];
                if (item.Selected)
                {
                    double min = 4 + i * 0.5;
                    double max = 4 + (i + 1) * 0.5;
                    string strMin = (min.ToString()).Replace(',', '.');
                    string strMax = (max.ToString()).Replace(',', '.');
                    uzunluk += " (Length >='" + strMin + "' AND Length <='" + strMax + "' ) OR";
                }
            }
            uzunluk = uzunluk.Remove(uzunluk.Length - 2);
            uzunluk += ")";
        }
        komut += uzunluk;
        string order = "";
        switch (DropDownList2.SelectedIndex)
        {
            case 0: order = " DESC"; break;
            case 1: order = " ASC"; break;
        }
        // SIRAMALAMA ÖLÇÜTÜ
        switch (DropDownList1.SelectedIndex)
        {
            case 0: komut += " ORDER BY Price " + order; break;
            case 1: komut += " ORDER BY Brand " + order + " ,Name " + order; break;
            case 2: komut += " ORDER BY Length " + order; break;
            case 3: komut += " ORDER BY Memory " + order; break;
        }
        return komut;
    }
}
