using InterFaceler;
using islemler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriBaglantisi;

namespace islem
{
    public class ogrenciIslemleri : VtIslemleriI<OgrenciIslemler>
    {
        private OgrenciDAL ogrenciDAL;
        public ogrenciIslemleri()
        {
            if (ogrenciDAL == null)
            {
                ogrenciDAL = new OgrenciDAL();
            }
        }
        public void Ekle(OgrenciIslemler kayit)
        {
            ogrenciDAL.Ekle(kayit);
        }

        public void Guncelle(OgrenciIslemler kayit)
        {
            ogrenciDAL.Guncelle(kayit);
        }

        public void Sil(OgrenciIslemler kayit)
        {
            ogrenciDAL.Sil(kayit);
        }

        public List<OgrenciIslemler> sorgula(Func<OgrenciIslemler, bool> filtre)
        {
            return ogrenciDAL.sorgula(filtre);
        }

        public List<OgrenciIslemler> tamaminiGetir()
        {
            return ogrenciDAL.tamaminiGetir();
        }

        public OgrenciIslemler tekilGetir(Func<OgrenciIslemler, bool> filtre = null)
        {
            return ogrenciDAL.tekilGetir(filtre);
        }

        public OgrenciIslemler tekilGetir(int ID)
        {
            throw new NotImplementedException();
        }

        public void TopluEkle(List<OgrenciIslemler> eklenecekListe)
        {
            throw new NotImplementedException();
        }

        public void TopluSil(List<OgrenciIslemler> silinecekListe)
        {
            throw new NotImplementedException();
        }
    }
}
