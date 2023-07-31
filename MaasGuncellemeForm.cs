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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelBilgiProject
{
    public partial class MaasGuncellemeForm : Form
    {
        int id;
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();
        Maas maas;
        public MaasGuncellemeForm(int guncellenecekId)
        {
            InitializeComponent();
            id = guncellenecekId;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                Maas maas = MaasOlustur();

                if (maas != null)
                {
                    Guncelle(maas);
                    MessageBox.Show("Maaş başarıyla güncellendi");
                }

            }
            catch (Exception exc)
            {

                MessageBox.Show("Maas güncellenemedi!" + "(" + exc.Message + exc.InnerException?.Message + ")", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Guncelle(Maas maas)
        {
            _db.Maas.Update(maas);
            _db.SaveChanges();

        }


        Maas MaasOlustur()
        {

            Maas mevcutMaas = _db.Maas.Include(p => p.Personel).SingleOrDefault(m => m.Id == id);

            string yil = tbYil.Text.Trim();
            if (string.IsNullOrWhiteSpace(tbYil.Text))
            {
                MessageBox.Show("Yıl bilgisi boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Decimal ucret = 0;
            if (!string.IsNullOrWhiteSpace(tbMaas.Text))
            {
                if (!Decimal.TryParse(tbMaas.Text, out ucret))
                {
                    MessageBox.Show("Maaş sayısal olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }


            mevcutMaas.Ucret = ucret;
            mevcutMaas.Yil = yil;

            return mevcutMaas;
        }

        private void MaasGuncellemeForm_Load(object sender, EventArgs e)
        {
            GetMaas(id);
        }

        private void GetMaas(int id)
        {
            IQueryable<MaasDTO> maasDetaySorgu = _db.Maas.Include(m => m.Personel)
                .Select(maas => new MaasDTO()
                {
                    Id = maas.Id,
                    UcretGosterim = maas.Ucret.ToString("N2", new CultureInfo("tr-TR")),
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
