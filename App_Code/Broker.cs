using System;
using System.Collections.Generic;
using System.Data.SqlClient;

    public class Broker 
    {
        SqlConnection con;

        public void connect()
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True;User Instance=True");
        }
        public Broker()
        {
            connect();
        }
        
        public string Add(Phone p)
        {
            string status = "";
            try
            {
                string komutString = "INSERT INTO dbo.Telefonlar(Name,Price,Description,Brand,Memory,OS,Length) Values(@Name,@Price,@Description,@Brand,@Memory,@OS,@Length)";
                SqlCommand komut = new SqlCommand(komutString, con);
                con.Open();
                komut.Parameters.AddWithValue("@Name", p.Name);
                komut.Parameters.AddWithValue("@Price", p.Price);
                komut.Parameters.AddWithValue("@Description", p.Description);
                komut.Parameters.AddWithValue("@Brand", p.Brand);
                komut.Parameters.AddWithValue("@Memory", p.Memory);
                komut.Parameters.AddWithValue("@OS", p.Os);
                komut.Parameters.AddWithValue("@Length", p.Length);

                komut.ExecuteNonQuery();

                status = "Successfully added new item!";
            }
            catch (Exception e)
            {
                status = "Error occured. \n " + e.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return status;
        }
        public string Add(Cart c)
        {
            string status = "";
            try
            {
                string komutString = "INSERT INTO dbo.Cart(PhoneId,Quantity,Price) Values(@PhoneId,@Quantity,@Price)";
                SqlCommand komut = new SqlCommand(komutString, con);
                con.Open();
                komut.Parameters.AddWithValue("@PhoneId", c.PhoneId);
                komut.Parameters.AddWithValue("@Quantity", c.Quantity);
                komut.Parameters.AddWithValue("@Price", c.Price);

                komut.ExecuteNonQuery();

                status = "Successfully added new item!";
            }
            catch (Exception e)
            {
                status = "Error occured. \n " + e.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return status;
        }


        public string Select(List<Phone> list, string sqlKomut)
        {
            string status = "";
            try
            {
                string komutString = "SELECT * FROM dbo.Telefonlar " + sqlKomut;
                SqlCommand komut = new SqlCommand(komutString, con);
                con.Open();

                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Phone p = new Phone();
                    p.Id = Convert.ToInt32(reader["ID"].ToString());
                    p.Name = reader["Name"].ToString();
                    p.Price = Convert.ToDouble(reader["Price"].ToString());
                    p.Description = reader["Description"].ToString();
                    p.Brand = reader["Brand"].ToString();
                    p.Memory = Convert.ToInt32(reader["Memory"].ToString());
                    p.Os = reader["OS"].ToString();
                    p.Length = Convert.ToDouble(reader["Length"].ToString());

                    list.Add(p);
                }

                status = "Succesfully selected!";
            }
            catch (Exception e)
            {
                status = "error \n" + e.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return status;
        }

        public string Delete(int id)
        {
            string status = "";
            try
            {
                string komutString = "DELETE FROM dbo.Telefonlar WHERE ID=" + id;
                SqlCommand komut = new SqlCommand(komutString, con);
                con.Open();

                komut.ExecuteNonQuery();

                status = "Successfully removed the item!";
            }
            catch (Exception e)
            {
                status = "error \n" + e.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

            return status;
        }
    }
