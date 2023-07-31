using Microsoft.EntityFrameworkCore;
using PersonelBilgiProject.Contexts;
using PersonelBilgiProject.DTO;
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
                if(ddlPersonel.SelectedIndex == 0)
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


            if(personel is null)
            {
                MessageBox.Show("Personel Bulunamadı");
                return;
            }    


            lAdSoyad.Text = personel.AdiSoyadiGosterim;
            lKimlikNo.Text = personel.KimlikNo == null ? "" : personel.KimlikNo;
            lDogumTarihi.Text = personel.DogumTarihiGosterim;


        }
    }
}
