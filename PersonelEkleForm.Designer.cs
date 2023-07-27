namespace PersonelBilgiProject
{
    partial class PersonelEkleForm
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
            tbAd = new TextBox();
            Ad = new Label();
            label1 = new Label();
            tbSoyad = new TextBox();
            label2 = new Label();
            tbKimlikNo = new TextBox();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dtpDogumTarihi = new DateTimePicker();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // tbAd
            // 
            tbAd.Location = new Point(162, 33);
            tbAd.Margin = new Padding(3, 4, 3, 4);
            tbAd.Name = "tbAd";
            tbAd.Size = new Size(202, 27);
            tbAd.TabIndex = 6;
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.Location = new Point(49, 36);
            Ad.Name = "Ad";
            Ad.Size = new Size(37, 20);
            Ad.TabIndex = 5;
            Ad.Text = "ADI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 81);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "SOYADI:";
            // 
            // tbSoyad
            // 
            tbSoyad.Location = new Point(162, 78);
            tbSoyad.Margin = new Padding(3, 4, 3, 4);
            tbSoyad.Name = "tbSoyad";
            tbSoyad.Size = new Size(202, 27);
            tbSoyad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 129);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "KİMLİK NO:";
            // 
            // tbKimlikNo
            // 
            tbKimlikNo.Location = new Point(162, 126);
            tbKimlikNo.Margin = new Padding(3, 4, 3, 4);
            tbKimlikNo.Name = "tbKimlikNo";
            tbKimlikNo.Size = new Size(202, 27);
            tbKimlikNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 174);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Doğum Tarihi";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.CalendarFont = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(162, 169);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(202, 27);
            dtpDogumTarihi.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(49, 229);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(315, 29);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // PersonelEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 317);
            Controls.Add(btnEkle);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(tbKimlikNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSoyad);
            Controls.Add(label1);
            Controls.Add(tbAd);
            Controls.Add(Ad);
            Name = "PersonelEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Ekle";
            Load += PersonelEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAd;
        private Label Ad;
        private Label label1;
        private TextBox tbSoyad;
        private Label label2;
        private TextBox tbKimlikNo;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dtpDogumTarihi;
        private Button btnEkle;
    }
}