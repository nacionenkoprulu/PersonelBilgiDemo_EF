using PersonelBilgiProject.Contexts;
using PersonelBilgiProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelBilgiProject
{
    public partial class UpdateForm : Form
    {
        int _updateId;
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();
        Personel _personel;

        public UpdateForm(int id)
        {
            InitializeComponent();
            _updateId = id;

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            Doldur(_updateId);
        }

        private void Doldur(int updateId)
        {
            _personel = _db.Personel.SingleOrDefault(p => p.Id == updateId);

            tbAd.Text = _personel.Ad;
            tbSoyad.Text = _personel.Soyad;
            tbKimlikNo.Text = _personel.KimlikNo;
            dtpDogumTarihi.Value = _personel.DogumTarih;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                PersonelGuncelle(_updateId);
                _db.Personel.Update(_personel);
                _db.SaveChanges();
                _personel = null;
                MessageBox.Show("Güncelleme başarılı!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Personel güncellenemedi!" + "(" + exc.Message + exc.InnerException?.Message + ")", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void PersonelGuncelle(int updateId)
        {

            string adi = tbAd.Text;
            if (string.IsNullOrWhiteSpace(adi))
            {
                MessageBox.Show("Lütfen bir personel ismi giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string soyad = tbSoyad.Text;
            if (string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Lütfen bir personel soyadı giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string? kimlikNo = string.IsNullOrWhiteSpace(tbKimlikNo.Text) ? null : tbKimlikNo.Text;
            if (kimlikNo is not null)
            {
                if (TCKontrol(kimlikNo) == false)
                {
                    MessageBox.Show("Hatalı TC kimlik no girdiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (dtpDogumTarihi.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _personel.Ad = adi;
            _personel.Soyad = soyad;
            _personel.KimlikNo = kimlikNo;
            _personel.DogumTarih = dtpDogumTarihi.Value;

        }

        bool TCKontrol(String tcNo)
        {

            int toplam = 0; int toplam2 = 0; int toplam3 = 0;
            if (tcNo.Length == 11)
            {
                if (Convert.ToInt32(tcNo[0].ToString()) != 0) //tc kimlik numaranın ilk hanesi 0 değilse
                {
                    for (int i = 0; i < 10; i++)
                    {
                        toplam = toplam + Convert.ToInt32(tcNo[i].ToString());
                        if (i % 2 == 0)
                        {
                            if (i != 10)
                            {
                                toplam2 = toplam2 + Convert.ToInt32(tcNo[i].ToString()); // 7 ile çarpılacak sayıları topluyoruz
                            }
                        }
                        else
                        {
                            if (i != 9)
                            {
                                toplam3 = toplam3 + Convert.ToInt32(tcNo[i].ToString());
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            if ((((toplam2 * 7) - toplam3) % 10 == Convert.ToInt32(tcNo[9].ToString()) && toplam % 10 == Convert.ToInt32(tcNo[10].ToString())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
