using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islemler
{
    [Table("GenelAyar")]
    public class GenelAyarIslemleri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(100)]
        public string okulAdi { get; set; }
        [MaxLength(50)]
        public string ogretimYili { get; set; }
        [MaxLength(10)]
        public string yariYili { get; set; }
        public string stajSure { get; set; }
        public DateTime baslamaTarihi { get; set; }
        public DateTime bitisTarihi { get; set; }
        public GenelAyarIslemleri()
        {

        }

        public GenelAyarIslemleri(int ıD, string okulAdi, string ogretimYili, string yariYili, string stajSure, DateTime baslamaTarihi, DateTime bitisTarihi)
        {
            ID = ıD;
            this.okulAdi = okulAdi;
            this.ogretimYili = ogretimYili;
            this.yariYili = yariYili;
            this.stajSure = stajSure;
            this.baslamaTarihi = baslamaTarihi;
            this.bitisTarihi = bitisTarihi;
        }
    }
}
