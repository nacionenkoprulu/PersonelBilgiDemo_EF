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
    public partial class MaasEkleForm : Form
    {

        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();

        public MaasEkleForm()
        {
            InitializeComponent();
        }

        private void MaasEkleForm_Load(object sender, EventArgs e)
        {
            _db = new PersonelBilgileriDbContext();

            PersonelleriDoldur();
        }

        private void PersonelleriDoldur()
        {

            List<PersonelDTO> personelList = _db.Personel.Include("Maas").OrderBy(p => p.Ad).Select(personel => new PersonelDTO
            {
                Id = personel.Id,

                AdiSoyadiGosterim = personel.Ad + " " + personel.Soyad,

            }).ToList();


            personelList.Insert(0, new PersonelDTO()
            {
                Id = -1,
                AdiSoyadiGosterim = "--Personel Seçiniz--"
            });

            ddlPersonel.DataSource = personelList;
            ddlPersonel.ValueMember = "Id";
            ddlPersonel.DisplayMember = "AdiSoyadiGosterim";

        }

        private void ddlPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (ddlPersonel.SelectedIndex == 0)
                {
                    MessageBox.Show("Personel seçilmeeedi!");
                    return;
                }
                BilgileriDoldur(Convert.ToInt32(ddlPersonel.SelectedValue));
            }
            catch (Exception exc)
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi! (" + exc.Message + " | " + exc.InnerException?.Message + ")", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void BilgileriDoldur(int id)
        {
            PersonelDTO personel = _db.Personel.Include(p => p.Maas).Select(personel => new PersonelDTO()
            {
                Id = personel.Id,
                AdiSoyadiGosterim = personel.Ad + " " + personel.Soyad,
                KimlikNo = personel.KimlikNo,
                DogumTarih = personel.DogumTarih,

            }).SingleOrDefault(personel => personel.Id == id);


            if (personel is null)
            {
                MessageBox.Show("Personel Bulunamadı");
                return;
            }

            lAdSoyad.Text = personel.AdiSoyadiGosterim;
            lKimlikNo.Text = personel.KimlikNo == null ? "" : personel.KimlikNo;
            lDogumTarihi.Text = personel.DogumTarihiGosterim;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                int personelId = Convert.ToInt32(ddlPersonel.SelectedValue);

                if (personelId == -1)
                {
                    MessageBox.Show("Lütfen personel seçiniz!");
                    return;
                }
                MaasDTO yeniMaas = MaasOlustur(personelId);

                if (yeniMaas is not null)
                {
                    MaasEkle(yeniMaas);
                    MessageBox.Show("Allah bereket versin :)");
                }
                
            }
            catch (Exception exc)
            {

                MessageBox.Show("İşlem sırasında hata meydana geldi! (" + exc.Message + " | " + exc.InnerException?.Message + ")", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void MaasEkle(MaasDTO yeniMaas)
        {
            Maas maasEntity = new Maas()
            {
                PersonelId = yeniMaas.PersonelId,
                Yil = yeniMaas.Yil,
                Ucret = yeniMaas.Ucret
            };

            _db.Maas.Add(maasEntity);

            _db.SaveChanges();


        }

        MaasDTO MaasOlustur(int personelId)
        {


            MaasDTO yeniMaas = new MaasDTO()
            {
                PersonelId = personelId,
                
            };

            

            if (string.IsNullOrWhiteSpace(tbYil.Text))
            {
                MessageBox.Show("Yıl bilgisi zorunludur!");
                return null;
            }

            yeniMaas.Yil = tbYil.Text;

            Decimal? ucret = null;

            if (!string.IsNullOrWhiteSpace(tbMaas.Text)) 
            {
                Decimal yeniUcret;
                if(!decimal.TryParse(tbMaas.Text, out yeniUcret))
                {
                    MessageBox.Show("Ücret Sayısal bir değer olmalıdır!");
                    return null;
                }
                ucret = yeniUcret;
            }

            yeniMaas.Ucret = (decimal)ucret;

            return yeniMaas;

        }



    }
}
