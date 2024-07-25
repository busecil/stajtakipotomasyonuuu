using islemler;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriBaglantisi
{
    public class STAJOTOMASYONU:DbContext
    {
        DbSet<OgrenciIslemler> Orenciler { get; set; }
        DbSet<GenelAyarIslemleri> GenelAyar { get; set; }
    }
}
