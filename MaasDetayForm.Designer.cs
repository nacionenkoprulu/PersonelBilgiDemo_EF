namespace PersonelBilgiProject
{
    partial class MaasDetayForm
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
            label1 = new Label();
            lid = new Label();
            lDogum = new Label();
            lDogumTarihi = new Label();
            label2 = new Label();
            lKimlikNo = new Label();
            label5 = new Label();
            lAdSoyad = new Label();
            groupBox1 = new GroupBox();
            tbYil = new TextBox();
            groupBox2 = new GroupBox();
            tbMaas = new TextBox();
            label7 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // lid
            // 
            lid.AutoSize = true;
            lid.Location = new Point(53, 36);
            lid.Name = "lid";
            lid.Size = new Size(26, 20);
            lid.TabIndex = 0;
            lid.Text = "lid";
            // 
            // lDogum
            // 
            lDogum.AutoSize = true;
            lDogum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lDogum.Location = new Point(544, 36);
            lDogum.Name = "lDogum";
            lDogum.Size = new Size(108, 20);
            lDogum.TabIndex = 0;
            lDogum.Text = "Doğum Tarihi:";
            // 
            // lDogumTarihi
            // 
            lDogumTarihi.AutoSize = true;
            lDogumTarihi.Location = new Point(650, 36);
            lDogumTarihi.Name = "lDogumTarihi";
            lDogumTarihi.Size = new Size(98, 20);
            lDogumTarihi.TabIndex = 0;
            lDogumTarihi.Text = "lDogumTarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(335, 36);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Kimlik No:";
            // 
            // lKimlikNo
            // 
            lKimlikNo.AutoSize = true;
            lKimlikNo.Location = new Point(414, 36);
            lKimlikNo.Name = "lKimlikNo";
            lKimlikNo.Size = new Size(74, 20);
            lKimlikNo.TabIndex = 0;
            lKimlikNo.Text = "lKimlikNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(105, 36);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 0;
            label5.Text = "Ad Soyad:";
            // 
            // lAdSoyad
            // 
            lAdSoyad.AutoSize = true;
            lAdSoyad.Location = new Point(188, 36);
            lAdSoyad.Name = "lAdSoyad";
            lAdSoyad.Size = new Size(73, 20);
            lAdSoyad.TabIndex = 0;
            lAdSoyad.Text = "lAdSoyad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lDogumTarihi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lKimlikNo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lDogum);
            groupBox1.Controls.Add(lid);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // tbYil
            // 
            tbYil.Enabled = false;
            tbYil.Location = new Point(89, 44);
            tbYil.Name = "tbYil";
            tbYil.Size = new Size(100, 27);
            tbYil.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbMaas);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbYil);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 93);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Maaş Bilgileri";
            // 
            // tbMaas
            // 
            tbMaas.Enabled = false;
            tbMaas.Location = new Point(284, 44);
            tbMaas.Name = "tbMaas";
            tbMaas.Size = new Size(251, 27);
            tbMaas.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(232, 47);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "Maaş";
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
            // MaasDetayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 218);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MaasDetayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaasDetayForm";
            Load += MaasDetayForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lid;
        private Label lDogum;
        private Label lDogumTarihi;
        private Label label2;
        private Label lKimlikNo;
        private Label label5;
        private Label lAdSoyad;
        private GroupBox groupBox1;
        private TextBox tbYil;
        private GroupBox groupBox2;
        private TextBox tbMaas;
        private Label label7;
        private Label label3;
    }
}