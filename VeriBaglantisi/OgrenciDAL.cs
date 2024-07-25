using InterFaceler;
using islemler;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriBaglantisi
{
    public class OgrenciDAL : VtIslemleriI<OgrenciIslemler>
    {
        public void Ekle(OgrenciIslemler kayit)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                var eklenecekKayit = vt.Entry(kayit);
                eklenecekKayit.State = EntityState.Added;
                vt.SaveChanges();
            }
        }

        public void Guncelle(OgrenciIslemler kayit)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                var guncellenecekKayit = vt.Entry(kayit);
                guncellenecekKayit.State = EntityState.Modified;
                vt.SaveChanges();
            }
        }

        public void Sil(OgrenciIslemler kayit)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                var silinecekKayit = vt.Entry(kayit);
                silinecekKayit.State = EntityState.Deleted;
                vt.SaveChanges();
            }
        }

        public List<OgrenciIslemler> sorgula(Func<OgrenciIslemler, bool> filtre)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                return filtre == null ? vt.Set<OgrenciIslemler>().ToList() : vt.Set<OgrenciIslemler>().Where(filtre).ToList();
            }

        }

        public List<OgrenciIslemler> tamaminiGetir()
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                return vt.Set<OgrenciIslemler>().ToList();
            }
        }

        public OgrenciIslemler tekilGetir(Func<OgrenciIslemler, bool> filtre = null)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                return vt.Set<OgrenciIslemler>().SingleOrDefault(filtre);
            }
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
