using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islemler
{
    [Table("Ogrenciler")]
    public class OgrenciIslemler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(20)]
        public string ogrenciNo { get; set; }
        [MaxLength(11)]
        public string tcKimlikNo { get; set; }
        [MaxLength(50)]
        public string adi { get; set; }
        [MaxLength(50)]
        public string soyAdi { get; set; }
        [MaxLength(10)]
        public string cinsiyet { get; set; }
        [MaxLength(50)]
        public string dogumYeri { get; set; }
        public DateTime dogumTarihi { get; set; }
        public int programID { get; set; }
        public string sinif { get; set; }
        [MaxLength(20)]
        public string telefon { get; set; }
        [MaxLength(150)]
        public string ikametAdresi { get; set; }
        [MaxLength(30)]
        public string ikametAdresIl { get; set; }
        [MaxLength(30)]
        public string ikametAdresIlce { get; set; }
        [MaxLength(50)]
        public string eposta { get; set; }
        [MaxLength(30)]
        public string stajDurumu { get; set; }
        [MaxLength(30)]
        public string stajSonuc { get; set; }
        [MaxLength(50)]
        public string kimlikID { get; set; }
        [MaxLength(30)]
        public string anneAdi { get; set; }
        [MaxLength(30)]
        public string babaAdi { get; set; }
        [MaxLength(30)]
        public string uyrugu { get; set; }
        public DateTime kayitTarihi { get; set; }
        [MaxLength(50)]
        public string kayitNedeni { get; set; }
        public string cezaSayisi { get; set; }
        public string aktifDonemDersKayitSayisi { get; set; }
        [MaxLength(10)]
        public string medenihali { get; set; }
        [MaxLength(50)]
        public string mahalleKoy { get; set; }
        public int ciltNo { get; set; }
        public int aileSira { get; set; }
        public int siraNo { get; set; }
        [MaxLength(30)]
        public string nufKayIl { get; set; }
        [MaxLength(30)]
        public string nufKayIlce { get; set; }

        public OgrenciIslemler()
        {

        }

        public OgrenciIslemler(int ID, string ogrenciNo, string tcKimlikNo, string adi, string soyAdi, string cinsiyet, string dogumYeri, DateTime dogumTarihi, int programID, string sinif, string telefon, string ikametAdresi, string ikametAdresIl, string ikametAdresIlce, string eposta, string stajDurumu, string stajSonuc, string kimlikID, string anneAdi, string babaAdi, string uyrugu, DateTime kayitTarihi, string kayitNedeni, string cezaSayisi, string aktifDonemDersKayitSayisi, string medenihali, string mahalleKoy, int ciltNo, int aileSira, int siraNo, string nufKayIl, string nufKayIlce)
        {
            this.ID = ID;
            this.ogrenciNo = ogrenciNo;
            this.tcKimlikNo = tcKimlikNo;
            this.adi = adi;
            this.soyAdi = soyAdi;
            this.cinsiyet = cinsiyet;
            this.dogumYeri = dogumYeri;
            this.dogumTarihi = dogumTarihi;
            this.programID = programID;
            this.sinif = sinif;
            this.telefon = telefon;
            this.ikametAdresi = ikametAdresi;
            this.ikametAdresIl = ikametAdresIl;
            this.ikametAdresIlce = ikametAdresIlce;
            this.eposta = eposta;
            this.stajDurumu = stajDurumu;
            this.stajSonuc = stajSonuc;
            this.kimlikID = kimlikID;
            this.anneAdi = anneAdi;
            this.babaAdi = babaAdi;
            this.uyrugu = uyrugu;
            this.kayitTarihi = kayitTarihi;
            this.kayitNedeni = kayitNedeni;
            this.cezaSayisi = cezaSayisi;
            this.aktifDonemDersKayitSayisi = aktifDonemDersKayitSayisi;
            this.medenihali = medenihali;
            this.mahalleKoy = mahalleKoy;
            this.ciltNo = ciltNo;
            this.aileSira = aileSira;
            this.siraNo = siraNo;
            this.nufKayIl = nufKayIl;
            this.nufKayIlce = nufKayIlce;
        }


    }
}
