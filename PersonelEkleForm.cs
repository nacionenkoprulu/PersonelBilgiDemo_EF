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
    public partial class PersonelEkleForm : Form
    {
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();
        public PersonelEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();

        }

        Personel CreatePersonel()
        {

            string adi = tbAd.Text;
            if (string.IsNullOrWhiteSpace(adi)) 
            {
                MessageBox.Show("Lütfen bir personel ismi giriniz!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
            string soyad = tbSoyad.Text;
            if (string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Lütfen bir personel soyadı giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            string? kimlikNo = string.IsNullOrWhiteSpace(tbKimlikNo.Text) ? null : tbKimlikNo.Text;
            if (TCKontrol(kimlikNo) == false)
            {
                MessageBox.Show("Hatalı TC kimlik no girdiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
           
            if (dtpDogumTarihi.Value == DateTime.Now)
            {
                MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return new Personel
            {
                Ad = adi,
                Soyad = soyad,
                KimlikNo = kimlikNo,
                DogumTarih = dtpDogumTarihi.Value
            };

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

        private void Ekle()
        {
            

            try
            {
                Personel? personel = CreatePersonel();
                _db.Personel.Add(personel);
                _db.SaveChanges();
                MessageBox.Show("Personel kaydı eklendi!");
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Personel eklenemedi!"+ "("+ exc.Message +exc.InnerException?.Message+")", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


    }
}
