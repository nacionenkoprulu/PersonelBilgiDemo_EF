using PersonelBilgiProject.Contexts;
using PersonelBilgiProject.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace PersonelBilgiProject
{
    public partial class Form1 : Form
    {
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
            SetVisibleColums();


        }

        private void FillGrid()
        {
            _db = new PersonelBilgileriDbContext();

            dgvPersonel.DataSource = null;
            List<Personel> personels = _db.Personel.ToList();

            dgvPersonel.DataSource = personels;
            label1.Text = $"({personels.Count}) adet kayýt bulunmuþtur";
            dgvPersonel.ClearSelection();

        }

        private void SetVisibleColums()
        {

            dgvPersonel.Columns["Maas"].Visible = false;
            dgvPersonel.Columns["Iletisim"].Visible = false;

        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            
            FillGrid();
            SetVisibleColums();

        }

        private void GetPersonel(int id)
        {

            Personel personel = _db.Personel.SingleOrDefault(p => p.Id == id);

            MessageBox.Show($"ID: {personel.Id}\r\n" +
                $"AD SOYAD: {personel.Ad} {personel.Soyad}\r\n" +
                $"KÝMLÝK NO: {(personel.KimlikNo != null ? personel.KimlikNo.Remove(4) + "XXX" + personel.KimlikNo.Substring(7) : "")}\r\n" +
                $"Doðum Tarihi: {personel.DogumTarih.ToString("dd.MM.yyyy", new CultureInfo("tr-TR"))}\r\n", "PERSONEL BÝLGÝSÝ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tbId.Text.Trim(), out id))
                MessageBox.Show("Lütfen sayýsal bir deðer giriniz!");
            GetPersonel(id);
        }

        private void btnAraQuery_Click(object sender, EventArgs e)
        {

            string? adSoyad = null;
            DateTime? dogumTarihi1 = null;
            DateTime? dogumTarihi2 = null;

            if (!string.IsNullOrWhiteSpace(tbName.Text))
                adSoyad = tbName.Text;

            if (!string.IsNullOrWhiteSpace(tbDogumTarihi1.Text))
            {
                DateTime tarih1;
                if (!DateTime.TryParseExact(tbDogumTarihi1.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tarih1))
                {
                    MessageBox.Show("Geçersiz tarih formatý! ('dd.MM.yyyy' þeklinde giriniz)");
                }
                dogumTarihi1 = tarih1;

            }

            if (!string.IsNullOrWhiteSpace(tbDogumTarihi2.Text))
            {
                DateTime tarih2;
                if (!DateTime.TryParseExact(tbDogumTarihi2.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tarih2))
                {
                    MessageBox.Show("Geçersiz tarih formatý! ('dd.MM.yyyy' þeklinde giriniz)");
                }
                dogumTarihi2 = tarih2;
            }


            Ara(adSoyad, dogumTarihi1, dogumTarihi2);

        }

        private void Ara(string? adSoyad, DateTime? dogumTarihi1, DateTime? dogumTarihi2)
        {
            IQueryable<Personel> query = _db.Personel;

            if (!string.IsNullOrWhiteSpace(adSoyad))
                query = query.Where(p => p.Ad.ToLower().Contains(adSoyad.ToLower()) || p.Soyad.ToLower().Contains(adSoyad.ToLower()));
            if (dogumTarihi1 is not null)
                query = query.Where(p => p.DogumTarih >= dogumTarihi1);
            if (dogumTarihi2 is not null)
                query = query.Where(p => p.DogumTarih <= dogumTarihi2);

            query = query.OrderBy(p => p.Ad);

            List<Personel> personels = query.ToList();

            dgvPersonel.DataSource = personels;
            label1.Text = $"({personels.Count}) adet kayýt bulunmuþtur";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDelete.Text))
            {
                MessageBox.Show("Lütfen sayýsal bir deðer giriniz!");
                return;
            }
            int id;
            if (!int.TryParse(tbDelete.Text, out id))
            {
                MessageBox.Show("Lütfen sayýsal bir deðer giriniz!");
                return;
            }

            Delete(id);


        }

        private void Delete(int id)
        {
            Personel personel = _db.Personel.Include(personel => personel.Iletisim).Include(personel => personel.Maas).SingleOrDefault(p => p.Id == id);

            if (personel == null)
            {
                MessageBox.Show("Silinecek personel bulunumadý!");
                return;
            }

            try
            {
                _db.Iletisim.RemoveRange(personel.Iletisim);
                _db.Maas.RemoveRange(personel.Maas);
                _db.Personel.Remove(personel);

                _db.SaveChanges();
                MessageBox.Show("Personel baþarýyla silindi!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Personel silinemedi!" + exc.InnerException.Message);
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Form ekleForm = new PersonelEkleForm();
            ekleForm.Show();
        }

        private void personelGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen personel seçiniz!");
                return;
            }

            int id = Convert.ToInt32(dgvPersonel.SelectedRows[0].Cells[0].Value);

            UpdateForm _form = new UpdateForm(id);
            _form.Show();
        }

        private void maasIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maasForm = new MaasListele();
            maasForm.Show();
        }
    }
}