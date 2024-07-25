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
    internal class GenelAyarDAL : VtIslemleriI<GenelAyarIslemleri>
    {
        public void Ekle(GenelAyarIslemleri kayit)
        {

            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                var eklenecekKayit = vt.Entry(kayit);
                eklenecekKayit.State = EntityState.Added;
                vt.SaveChanges();
            }
        }

        public void Guncelle(GenelAyarIslemleri kayit)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                var guncellenecekKayit = vt.Entry(kayit);
                guncellenecekKayit.State = EntityState.Modified;
                vt.SaveChanges();
            }
        }

        public void Sil(GenelAyarIslemleri kayit)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                var silinecekKayit = vt.Entry(kayit);
                silinecekKayit.State = EntityState.Deleted;
                vt.SaveChanges();
            }
        }

        public List<GenelAyarIslemleri> sorgula(Func<GenelAyarIslemleri, bool> filtre)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                return filtre == null ? vt.Set<GenelAyarIslemleri>().ToList() : vt.Set<GenelAyarIslemleri>().Where(filtre).ToList();
            }
        }

        public List<GenelAyarIslemleri> tamaminiGetir()
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                return vt.Set<GenelAyarIslemleri>().ToList();
            }
        }

        public GenelAyarIslemleri tekilGetir(Func<GenelAyarIslemleri, bool> filtre = null)
        {
            using (STAJOTOMASYONU vt = new STAJOTOMASYONU())
            {
                return vt.Set<GenelAyarIslemleri>().SingleOrDefault(filtre);
            }
        }

        public GenelAyarIslemleri tekilGetir(int ID)
        {
            throw new NotImplementedException();
        }

        public void TopluEkle(List<GenelAyarIslemleri> eklenecekListe)
        {
            throw new NotImplementedException();
        }

        public void TopluSil(List<GenelAyarIslemleri> silinecekListe)
        {
            throw new NotImplementedException();
        }
    }
}
