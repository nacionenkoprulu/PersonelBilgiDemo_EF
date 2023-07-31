using Microsoft.EntityFrameworkCore;
using PersonelBilgiProject.Contexts;
using PersonelBilgiProject.DTO;
using PersonelBilgiProject.Entities;
using System.Globalization;

namespace PersonelBilgiProject
{
    public partial class MaasListele : Form
    {
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();


        public MaasListele()
        {
            InitializeComponent();
        }

        private void MaasListele_Load(object sender, EventArgs e)
        {
            FillMaasBilgileri();
            MaasSutunlariDuzenle();

        }

        private void FillMaasBilgileri()
        {
            IQueryable<MaasDTO> maasQuery = _db.Maas.Include(m => m.Personel)
                .OrderBy(m => m.Yil)
                .Select(maas => new MaasDTO()
                {
                    Id = maas.Id,
                    UcretGosterim = maas.Ucret.ToString("C2", new CultureInfo("tr-TR")),
                    Yil = maas.Yil,

                    PersonelAdSoyadGosterim = maas.Personel.Ad + " " + maas.Personel.Soyad
                });

            List<MaasDTO> maasListesi = maasQuery.ToList();
            dgvMaas.DataSource = maasListesi;

            label1.Text = $"({maasListesi.Count}) adet kayıt bulunmuştur";
            dgvMaas.ClearSelection();
        }

        void MaasSutunlariDuzenle()
        {
            dgvMaas.Columns["Id"].Width = 50;
            dgvMaas.Columns["Yil"].Width = 120;
            dgvMaas.Columns["PersonelAdSoyadGosterim"].Width = 240;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (dgvMaas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen maaş seçiniz!");
                return;
            }
            int id = Convert.ToInt32(dgvMaas.SelectedRows[0].Cells[0].Value);

            MaasDetayForm form = new MaasDetayForm(id);
            form.Show();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {



            if (dgvMaas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen maaş seçiniz!");
                return;
            }
            int id = Convert.ToInt32(dgvMaas.SelectedRows[0].Cells["id"].Value);

            MaasGuncellemeForm form = new MaasGuncellemeForm(id);
            form.Show();

        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            FillMaasBilgileri();
            MaasSutunlariDuzenle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form ekleForm = new MaasEkleForm();
            ekleForm.Show();
  
        }
    }
}
