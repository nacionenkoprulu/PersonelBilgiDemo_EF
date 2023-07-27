namespace PersonelBilgiProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersonel = new DataGridView();
            btnReflesh = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnPersonelAra = new Button();
            tbId = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnAraQuery = new Button();
            tbDogumTarihi2 = new TextBox();
            tbDogumTarihi1 = new TextBox();
            tbName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnDelete = new Button();
            tbDelete = new TextBox();
            label9 = new Label();
            btnPersonelEkle = new Button();
            menuStrip1 = new MenuStrip();
            personelGuncelleToolStripMenuItem = new ToolStripMenuItem();
            maasIslemleriToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonel
            // 
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPersonel.Location = new Point(12, 76);
            dgvPersonel.MultiSelect = false;
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.RowHeadersWidth = 51;
            dgvPersonel.RowTemplate.Height = 29;
            dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonel.Size = new Size(776, 201);
            dgvPersonel.TabIndex = 0;
            // 
            // btnReflesh
            // 
            btnReflesh.Location = new Point(693, 41);
            btnReflesh.Name = "btnReflesh";
            btnReflesh.Size = new Size(95, 29);
            btnReflesh.TabIndex = 1;
            btnReflesh.Text = "Reflesh";
            btnReflesh.UseVisualStyleBackColor = true;
            btnReflesh.Click += btnReflesh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPersonelAra);
            groupBox1.Controls.Add(tbId);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 295);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(359, 96);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Getir";
            // 
            // btnPersonelAra
            // 
            btnPersonelAra.Location = new Point(197, 39);
            btnPersonelAra.Margin = new Padding(3, 4, 3, 4);
            btnPersonelAra.Name = "btnPersonelAra";
            btnPersonelAra.Size = new Size(147, 31);
            btnPersonelAra.TabIndex = 5;
            btnPersonelAra.Text = "Get Details (SoD)";
            btnPersonelAra.UseVisualStyleBackColor = true;
            btnPersonelAra.Click += btnPersonelAra_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(36, 41);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.Size = new Size(145, 27);
            tbId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAraQuery);
            groupBox2.Controls.Add(tbDogumTarihi2);
            groupBox2.Controls.Add(tbDogumTarihi1);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(389, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 96);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Ara";
            // 
            // btnAraQuery
            // 
            btnAraQuery.Location = new Point(324, 24);
            btnAraQuery.Margin = new Padding(3, 4, 3, 4);
            btnAraQuery.Name = "btnAraQuery";
            btnAraQuery.Size = new Size(69, 62);
            btnAraQuery.TabIndex = 13;
            btnAraQuery.Text = "ARA";
            btnAraQuery.UseVisualStyleBackColor = true;
            btnAraQuery.Click += btnAraQuery_Click;
            // 
            // tbDogumTarihi2
            // 
            tbDogumTarihi2.Location = new Point(226, 59);
            tbDogumTarihi2.Margin = new Padding(3, 4, 3, 4);
            tbDogumTarihi2.Name = "tbDogumTarihi2";
            tbDogumTarihi2.Size = new Size(92, 27);
            tbDogumTarihi2.TabIndex = 11;
            // 
            // tbDogumTarihi1
            // 
            tbDogumTarihi1.Location = new Point(107, 59);
            tbDogumTarihi1.Margin = new Padding(3, 4, 3, 4);
            tbDogumTarihi1.Name = "tbDogumTarihi1";
            tbDogumTarihi1.Size = new Size(92, 27);
            tbDogumTarihi1.TabIndex = 11;
            // 
            // tbName
            // 
            tbName.Location = new Point(107, 24);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(211, 27);
            tbName.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 63);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 4;
            label5.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 64);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 6;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "İsim";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(209, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 25);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Personel Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbDelete
            // 
            tbDelete.Location = new Point(48, 413);
            tbDelete.Margin = new Padding(3, 4, 3, 4);
            tbDelete.Name = "tbDelete";
            tbDelete.Size = new Size(145, 27);
            tbDelete.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 417);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 8;
            label9.Text = "ID";
            // 
            // btnPersonelEkle
            // 
            btnPersonelEkle.Location = new Point(389, 413);
            btnPersonelEkle.Name = "btnPersonelEkle";
            btnPersonelEkle.Size = new Size(399, 25);
            btnPersonelEkle.TabIndex = 11;
            btnPersonelEkle.Text = "Personel Ekle";
            btnPersonelEkle.UseVisualStyleBackColor = true;
            btnPersonelEkle.Click += btnPersonelEkle_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { personelGuncelleToolStripMenuItem, maasIslemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // personelGuncelleToolStripMenuItem
            // 
            personelGuncelleToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            personelGuncelleToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            personelGuncelleToolStripMenuItem.Name = "personelGuncelleToolStripMenuItem";
            personelGuncelleToolStripMenuItem.Size = new Size(176, 24);
            personelGuncelleToolStripMenuItem.Text = "PERSONEL GÜNCELLE";
            personelGuncelleToolStripMenuItem.Click += personelGuncelleToolStripMenuItem_Click;
            // 
            // maasIslemleriToolStripMenuItem
            // 
            maasIslemleriToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            maasIslemleriToolStripMenuItem.Name = "maasIslemleriToolStripMenuItem";
            maasIslemleriToolStripMenuItem.Size = new Size(145, 24);
            maasIslemleriToolStripMenuItem.Text = "MAAŞ İŞLEMLERİ";
            maasIslemleriToolStripMenuItem.Click += maasIslemleriToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(btnPersonelEkle);
            Controls.Add(btnDelete);
            Controls.Add(tbDelete);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnReflesh);
            Controls.Add(dgvPersonel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Bilgi Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonel;
        private Button btnReflesh;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnPersonelAra;
        private TextBox tbId;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnAraQuery;
        private TextBox tbUnitInStock2;
        private TextBox tbUnitPrice2;
        private TextBox tbUnitInStock1;
        private TextBox tbDogumTarihi1;
        private TextBox tbName;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox tbDogumTarihi2;
        private Button btnDelete;
        private TextBox tbDelete;
        private Label label9;
        private Button btnPersonelEkle;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem personelGuncelleToolStripMenuItem;
        private ToolStripMenuItem maasIslemleriToolStripMenuItem;
    }
}