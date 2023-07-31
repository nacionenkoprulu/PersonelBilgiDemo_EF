using PersonelBilgiProject.Entities;
using System.ComponentModel;
using System;

namespace PersonelBilgiProject.DTO
{
    public class PersonelDTO
    {

        #region Entity'den Kopyalanan Özellikler
        [DisplayName("ID")]
        public int Id { get; set; }

        [Browsable(false)]
        public string Ad { get; set; } = null!;

        [Browsable(false)]
        public string Soyad { get; set; } = null!;

        [DisplayName("Kimlik No")]
        public string? KimlikNo
        {
            get;
            set;
        }
       
        [Browsable(false)]
        public DateTime DogumTarih { get; set; }

        #endregion
        
        #region DTO İhtiyaç Duyulan Özellikler

        [DisplayName("Adı Soyadı")]
        public string AdiSoyadiGosterim { get; set; }

        [DisplayName("Doğum Tarihi")]
        public string DogumTarihiGosterim => DogumTarih.ToString("dd.MM.yyyy");

        public List<Maas> MaasListesi { get; set; } = new List<Maas>();

        public string MaksimumMaas { get; set; }

        #endregion


    }
}
