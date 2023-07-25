using PersonelBilgiProject.Contexts;
using PersonelBilgiProject.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System;
using Microsoft.EntityFrameworkCore;

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
            List<Personel> personels = _db.Personel.ToList();

            dgvPersonel.DataSource = personels;
            label1.Text = $"({personels.Count}) adet kay�t bulunmu�tur";

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
                $"K�ML�K NO: {(personel.KimlikNo != null ? personel.KimlikNo.Remove(4) + "XXX" + personel.KimlikNo.Substring(7) : "")}\r\n" +
                $"Do�um Tarihi: {personel.DogumTarih.ToString("dd.MM.yyyy", new CultureInfo("tr-TR"))}\r\n", "PERSONEL B�LG�S�", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tbId.Text.Trim(), out id))
                MessageBox.Show("L�tfen say�sal bir de�er giriniz!");
            GetPersonel(id);
        }

        private void btnAraQuery_Click(object sender, EventArgs e)
        {

            string? adSoyad = null;
            DateTime? dogumTarihi1 = null;
            DateTime dogumTarihi2 = DateTime.Now;

            if (!string.IsNullOrWhiteSpace(tbName.Text))
                adSoyad = tbName.Text;
            if (!string.IsNullOrWhiteSpace(tbDogumTarihi1.Text))
            {
                dogumTarihi1 = DateTime.Parse(tbDogumTarihi1.Text);
            }
            //if (!string.IsNullOrWhiteSpace(tbDogumTarihi2.Text))
            //{
            //    //if (!DateTime.TryParseExact(tbDogumTarihi2.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dogumTarihi2))
            //    //dogumTarihi2 = DateTime.Parse(tbDogumTarihi2.Text);
            //}

            if (!string.IsNullOrWhiteSpace(tbDogumTarihi2.Text))
            {
                if (!DateTime.TryParseExact(tbDogumTarihi2.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dogumTarihi2))
                    MessageBox.Show("Ge�ersiz tarih format�! ('dd.MM.yyyy' �eklinde giriniz)");
            }


            Ara(adSoyad, dogumTarihi1, dogumTarihi2);

        }

        private void Ara(string? adSoyad, DateTime? dogumTarihi1, DateTime dogumTarihi2)
        {
            IQueryable<Personel> query = _db.Personel;

            if (!string.IsNullOrWhiteSpace(adSoyad))
                query = query.Where(p => p.Ad.ToLower().Contains(adSoyad.ToLower()) || p.Soyad.ToLower().Contains(adSoyad.ToLower()));
            if (dogumTarihi1 is not null)
                query = query.Where(p => p.DogumTarih >= dogumTarihi1);
            //if (dogumTarihi2)
            //    query = query.Where(p => p.DogumTarih <= dogumTarihi2);

            query = query.OrderBy(p => p.Ad);

            List<Personel> personels = query.ToList();

            dgvPersonel.DataSource = personels;
            label1.Text = $"({personels.Count}) adet kay�t bulunmu�tur";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDelete.Text))
            {
                MessageBox.Show("L�tfen say�sal bir de�er giriniz!");
                return;
            }
            int id;
            if (!int.TryParse(tbDelete.Text, out id))
            {
                MessageBox.Show("L�tfen say�sal bir de�er giriniz!");
                return;
            }

            Delete(id);


        }

        private void Delete(int id)
        {
            Personel personel = _db.Personel.Include(personel => personel.Iletisim).Include(personel => personel.Maas).SingleOrDefault(p => p.Id == id);

            if (personel == null)
            {
                MessageBox.Show("Silinecek personel bulunumad�!");
                return;
            }

            try
            {
                _db.Iletisim.RemoveRange(personel.Iletisim);
                _db.Maas.RemoveRange(personel.Maas);
                _db.Personel.Remove(personel);

                _db.SaveChanges();
                MessageBox.Show("Personel ba�ar�yla silindi!");
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
    }
}