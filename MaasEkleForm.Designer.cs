namespace PersonelBilgiProject
{
    partial class MaasEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            tbMaas = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbYil = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGuncelle = new Button();
            groupBox1 = new GroupBox();
            ddlPersonel = new ComboBox();
            lDogumTarihi = new Label();
            label1 = new Label();
            lAdSoyad = new Label();
            label2 = new Label();
            lKimlikNo = new Label();
            label5 = new Label();
            lDogum = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbMaas);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbYil);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(10, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 93);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Maaş Bilgileri";
            // 
            // tbMaas
            // 
            tbMaas.Location = new Point(257, 45);
            tbMaas.Name = "tbMaas";
            tbMaas.Size = new Size(147, 27);
            tbMaas.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(205, 48);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Maaş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(643, 48);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 0;
            label6.Text = "lAdSoyad";
            // 
            // tbYil
            // 
            tbYil.Location = new Point(89, 44);
            tbYil.Name = "tbYil";
            tbYil.Size = new Size(100, 27);
            tbYil.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 47);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "Yıl Bilgisi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(418, 47);
            label4.Name = "label4";
            label4.Size = new Size(219, 20);
            label4.TabIndex = 0;
            label4.Text = "Kişinin Aldığı En Yüksek Maaş:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(298, 263);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(153, 29);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddlPersonel);
            groupBox1.Controls.Add(lDogumTarihi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lKimlikNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lDogum);
            groupBox1.Location = new Point(10, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 132);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Seçiniz";
            // 
            // ddlPersonel
            // 
            ddlPersonel.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlPersonel.FormattingEnabled = true;
            ddlPersonel.Location = new Point(85, 40);
            ddlPersonel.Name = "ddlPersonel";
            ddlPersonel.Size = new Size(338, 28);
            ddlPersonel.TabIndex = 1;
            ddlPersonel.SelectedIndexChanged += ddlPersonel_SelectedIndexChanged;
            // 
            // lDogumTarihi
            // 
            lDogumTarihi.AutoSize = true;
            lDogumTarihi.Location = new Point(531, 93);
            lDogumTarihi.Name = "lDogumTarihi";
            lDogumTarihi.Size = new Size(98, 20);
            lDogumTarihi.TabIndex = 0;
            lDogumTarihi.Text = "lDogumTarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel:";
            // 
            // lAdSoyad
            // 
            lAdSoyad.AutoSize = true;
            lAdSoyad.Location = new Point(532, 28);
            lAdSoyad.Name = "lAdSoyad";
            lAdSoyad.Size = new Size(73, 20);
            lAdSoyad.TabIndex = 0;
            lAdSoyad.Text = "lAdSoyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(451, 58);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Kimlik No:";
            // 
            // lKimlikNo
            // 
            lKimlikNo.AutoSize = true;
            lKimlikNo.Location = new Point(531, 58);
            lKimlikNo.Name = "lKimlikNo";
            lKimlikNo.Size = new Size(74, 20);
            lKimlikNo.TabIndex = 0;
            lKimlikNo.Text = "lKimlikNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(454, 28);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "Ad Soyad:";
            // 
            // lDogum
            // 
            lDogum.AutoSize = true;
            lDogum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lDogum.Location = new Point(425, 93);
            lDogum.Name = "lDogum";
            lDogum.Size = new Size(108, 20);
            lDogum.TabIndex = 0;
            lDogum.Text = "Doğum Tarihi:";
            // 
            // MaasEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 317);
            Controls.Add(btnGuncelle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MaasEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Maaş Bilgisi Ekle";
            Load += MaasEkleForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnGuncelle;
        private TextBox tbMaas;
        private Label label7;
        private TextBox tbYil;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox ddlPersonel;
        private Label lDogumTarihi;
        private Label label1;
        private Label lAdSoyad;
        private Label label2;
        private Label lKimlikNo;
        private Label label5;
        private Label lDogum;
        private Label label6;
        private Label label4;
    }
}