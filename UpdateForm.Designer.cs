namespace PersonelBilgiProject
{
    partial class UpdateForm
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
            btnGuncelle = new Button();
            dtpDogumTarihi = new DateTimePicker();
            tbKimlikNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tbSoyad = new TextBox();
            label1 = new Label();
            tbAd = new TextBox();
            Ad = new Label();
            SuspendLayout();
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(49, 235);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(315, 29);
            btnGuncelle.TabIndex = 17;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(162, 175);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(202, 27);
            dtpDogumTarihi.TabIndex = 16;
            // 
            // tbKimlikNo
            // 
            tbKimlikNo.Location = new Point(162, 132);
            tbKimlikNo.Margin = new Padding(3, 4, 3, 4);
            tbKimlikNo.Name = "tbKimlikNo";
            tbKimlikNo.Size = new Size(202, 27);
            tbKimlikNo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 180);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 9;
            label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 135);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 10;
            label2.Text = "KİMLİK NO:";
            // 
            // tbSoyad
            // 
            tbSoyad.Location = new Point(162, 84);
            tbSoyad.Margin = new Padding(3, 4, 3, 4);
            tbSoyad.Name = "tbSoyad";
            tbSoyad.Size = new Size(202, 27);
            tbSoyad.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 87);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 11;
            label1.Text = "SOYADI:";
            // 
            // tbAd
            // 
            tbAd.Location = new Point(162, 39);
            tbAd.Margin = new Padding(3, 4, 3, 4);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(202, 27);
            tbAd.TabIndex = 15;
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.Location = new Point(49, 42);
            Ad.Name = "Ad";
            Ad.Size = new Size(37, 20);
            Ad.TabIndex = 12;
            Ad.Text = "ADI:";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 317);
            Controls.Add(btnGuncelle);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(tbKimlikNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSoyad);
            Controls.Add(label1);
            Controls.Add(tbAd);
            Controls.Add(Ad);
            Name = "UpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuncelle;
        private DateTimePicker dtpDogumTarihi;
        private TextBox tbKimlikNo;
        private Label label3;
        private Label label2;
        private TextBox tbSoyad;
        private Label label1;
        private TextBox tbAd;
        private Label Ad;
    }
}