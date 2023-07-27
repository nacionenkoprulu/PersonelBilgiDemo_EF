using PersonelBilgiProject.Entities;
using System.ComponentModel;

namespace PersonelBilgiProject.DTO
{
    class MaasDTO
    {
        //Entity'den gelenler
        public int Id { get; set; }

        [Browsable(false)]
        public int PersonelId { get; set; }

        [Browsable(false)]
        public decimal Ucret { get; set; }

        public string Yil { get; set; } = null!;


        //DTO için oluşturduklarımız
        [DisplayName("Ücret")]
        public string UcretGosterim { get; set; }

        [DisplayName ("Personel")]
        public string PersonelAdSoyadGosterim { get; set; }

        [Browsable(false)]
        public string PersonelKimlikNoGosterim { get; set; }

        [Browsable(false)]
        public string PersonelDogumTarihiGosterim { get; set; }


    }
}
