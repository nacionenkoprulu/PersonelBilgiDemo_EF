using Microsoft.EntityFrameworkCore;
using PersonelBilgiProject.Contexts;
using PersonelBilgiProject.DTO;
using PersonelBilgiProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelBilgiProject
{
    public partial class MaasDetayForm : Form
    {

        int id;
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();
        public MaasDetayForm(int detayId)
        {
            InitializeComponent();
            id = detayId;
        }

        private void MaasDetayForm_Load(object sender, EventArgs e)
        {
            DetayGetir(id);
        }

        private void DetayGetir(int id)
        {
            IQueryable<MaasDTO> maasDetaySorgu = _db.Maas.Include(m => m.Personel)
                .Select(maas => new MaasDTO()
                {
                    Id = maas.Id,
                    UcretGosterim = maas.Ucret.ToString("C2", new CultureInfo("tr-TR")),
                    Yil = maas.Yil,

                    PersonelId = maas.PersonelId,
                    PersonelAdSoyadGosterim = maas.Personel.Ad + " " + maas.Personel.Soyad,
                    PersonelKimlikNoGosterim = maas.Personel.KimlikNo != null ? maas.Personel.KimlikNo : "",
                    PersonelDogumTarihiGosterim = maas.Personel.DogumTarih.ToString("dd.MM.yyyy")

                });

            MaasDTO maas = maasDetaySorgu.SingleOrDefault(m => m.Id == id);

            if (maas is null)
            {
                MessageBox.Show("Maaş bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lid.Text = maas.PersonelId.ToString();
            lAdSoyad.Text = maas.PersonelAdSoyadGosterim;
            lKimlikNo.Text = maas.PersonelKimlikNoGosterim;
            lDogumTarihi.Text = maas.PersonelDogumTarihiGosterim;
            tbYil.Text = maas.Yil;
            tbMaas.Text = maas.UcretGosterim;



        }
    }
}
