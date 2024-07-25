using islem;
using islemler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StajTakipOtomasyonu
{
    public partial class Öğrenciİşlemleri : System.Web.UI.Page
    {
        private ogrenciIslemler oi;
        private List<Ogrenci> al;

        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (al == null) al = new List<Ogrenci>();
            if (oi == null) oi = new OgrenciIslemler();
        }
        List<Ogrenci> ogrList = new List<Ogrenci>();
        Öğrenciİşlemleri oi = new Öğrenciİşlemleri();

        private void yukle()
        {
            al= oi.tamaminiGetir().OrderBy(p=> p.ID).ToList();
            GridView.Data
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (toluSec.HasFile)
            {
                if (Path.GetExtension(toluSec.FileName) == ".xlsx")
                {
                    dt.Clear();
                    toluSec.SaveAs(Request.PhysicalApplicationPath + "Temp//" + toluSec.FileName);
                    OleDbConnectionStringBuilder excelAyar = new OleDbConnectionStringBuilder();
                    excelAyar.DataSource = Server.MapPath("Temp//" + toluSec.FileName);
                    excelAyar.Provider = "Microsoft.ACE.OLEDB.12.0";
                    excelAyar["Extended Properties"] = "Excel 12.0 Xml; HDR = YES";
                    string excelSayfaAdi = "Sayfa1";
                    OleDbConnection excelBag = new OleDbConnection(excelAyar.ConnectionString);
                    try
                    {
                        excelBag.Open();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('" + ex.Message + "')</script>");
                        return;
                    }
                    OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM [" + excelSayfaAdi + "$]", excelBag);
                    adap.Fill(dt);
                    excelBag.Close();
                    topluGW.DataSource = dt;
                    topluGW.DataBind();
                    /*
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Ogrenci o = new Ogrenci();
                        o.Ad = dt.Rows[i][0].ToString().ToUpper();
                        o.SoyAd = dt.Rows[i][1].ToString().ToUpper();
                        Programlar p = pi.TekilGetir(x => x.ID == Convert.ToInt32(topluBolum.SelectedValue));
                        o.BolumID = p.BolumID;
                        o.OgrenciNO = dt.Rows[i][2].ToString();
                        string dogumTarihi = dt.Rows[i][4].ToString();
                        string mezunTarihi = dt.Rows[i][3].ToString();
                        o.MezunTarihi = Convert.ToDateTime(mezunTarihi);
                        o.DogumTarihi = Convert.ToDateTime(dogumTarihi);
                        o.Cinsiyet = dt.Rows[i][5].ToString();
                        o.KimlikSeriNO = dt.Rows[i][6].ToString().ToUpper();
                        o.TCNo = dt.Rows[i][7].ToString();
                        ogrList.Add(o);
                    }
                    oi.TopluEkle(ogrList);
                    */
                }
                else
                {
                    Response.Write("<script>alert('Sadece excel dosyaları (.xlsx) kabul edilmektedir.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Dosya Seçilmedi')</script>");
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox30_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}