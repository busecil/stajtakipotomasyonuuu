using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StajTakipOtomasyonu
{
    public partial class giris : System.Web.UI.MasterPage
    {
     
        SqlConnection  baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\veritabani.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Öğrenciler where email=@email and şifre =@şifre", baglanti);
            komut.Parameters.AddWithValue("@email",txtemail.Text.ToString());
            komut.Parameters.AddWithValue("@şifre", txtpassword.Text.ToString());
            SqlDataReader oku= komut.ExecuteReader();
            if (oku.Read())
            {
                Session["Eposta"] = oku["Email"].ToString();
                Response.Redirect("~/anasayfa/anasayfa.aspx");
            }
            else
            {
                Label1.Text = "Eposta veya Şifre Hatalı !";
            }
            oku.Close();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}