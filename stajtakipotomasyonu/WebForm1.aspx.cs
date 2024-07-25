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
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

           

        }
        
        /*List<Ogrenci> ogrList = new List<Ogrenci>();
        OgrenciIslemleri oi = new OgrenciIslemleri();
        ProgramIslemleri pi = new ProgramIslemleri();*/
        

        protected void Button2_Click(object sender, EventArgs e)
        {
            
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
    }
}