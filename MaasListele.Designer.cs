namespace PersonelBilgiProject
{
    partial class MaasListele
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
            dgvMaas = new DataGridView();
            label1 = new Label();
            btnReflesh = new Button();
            button1 = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaas).BeginInit();
            SuspendLayout();
            // 
            // dgvMaas
            // 
            dgvMaas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaas.Location = new Point(12, 58);
            dgvMaas.MultiSelect = false;
            dgvMaas.Name = "dgvMaas";
            dgvMaas.RowHeadersWidth = 51;
            dgvMaas.RowTemplate.Height = 29;
            dgvMaas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaas.Size = new Size(611, 191);
            dgvMaas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // btnReflesh
            // 
            btnReflesh.Location = new Point(528, 18);
            btnReflesh.Name = "btnReflesh";
            btnReflesh.Size = new Size(95, 29);
            btnReflesh.TabIndex = 3;
            btnReflesh.Text = "Reflesh";
            btnReflesh.UseVisualStyleBackColor = true;
            btnReflesh.Click += btnReflesh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Detay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(112, 266);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Orange;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = SystemColors.InfoText;
            btnEkle.Location = new Point(436, 266);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(188, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Yeni Maaş Bilgisi Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // MaasListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 311);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnReflesh);
            Controls.Add(dgvMaas);
            Name = "MaasListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MaasListele";
            Load += MaasListele_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMaas;
        private Label label1;
        private Button btnReflesh;
        private Button button1;
        private Button btnGuncelle;
        private Button btnEkle;
    }
}