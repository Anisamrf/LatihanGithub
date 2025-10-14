namespace LatihanGithub
{
    partial class FormSiswa
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
            this.labelnama = new System.Windows.Forms.Label();
            this.labeljeniskelamin = new System.Windows.Forms.Label();
            this.labelnotelepon = new System.Windows.Forms.Label();
            this.labelalamat = new System.Windows.Forms.Label();
            this.labelkelas = new System.Windows.Forms.Label();
            this.txtidanggota = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.lblperempuan = new System.Windows.Forms.RadioButton();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dgvTampilData = new System.Windows.Forms.DataGridView();
            this.cmbkelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(23, 46);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(38, 13);
            this.labelnama.TabIndex = 0;
            this.labelnama.Text = "Nama:";
            // 
            // labeljeniskelamin
            // 
            this.labeljeniskelamin.AutoSize = true;
            this.labeljeniskelamin.Location = new System.Drawing.Point(23, 177);
            this.labeljeniskelamin.Name = "labeljeniskelamin";
            this.labeljeniskelamin.Size = new System.Drawing.Size(74, 13);
            this.labeljeniskelamin.TabIndex = 1;
            this.labeljeniskelamin.Text = "Jenis Kelamin:";
            // 
            // labelnotelepon
            // 
            this.labelnotelepon.AutoSize = true;
            this.labelnotelepon.Location = new System.Drawing.Point(23, 143);
            this.labelnotelepon.Name = "labelnotelepon";
            this.labelnotelepon.Size = new System.Drawing.Size(66, 13);
            this.labelnotelepon.TabIndex = 2;
            this.labelnotelepon.Text = "No.Telepon:";
            // 
            // labelalamat
            // 
            this.labelalamat.AutoSize = true;
            this.labelalamat.Location = new System.Drawing.Point(23, 111);
            this.labelalamat.Name = "labelalamat";
            this.labelalamat.Size = new System.Drawing.Size(42, 13);
            this.labelalamat.TabIndex = 3;
            this.labelalamat.Text = "Alamat:";
            // 
            // labelkelas
            // 
            this.labelkelas.AutoSize = true;
            this.labelkelas.Location = new System.Drawing.Point(23, 79);
            this.labelkelas.Name = "labelkelas";
            this.labelkelas.Size = new System.Drawing.Size(36, 13);
            this.labelkelas.TabIndex = 4;
            this.labelkelas.Text = "Kelas:";
            // 
            // txtidanggota
            // 
            this.txtidanggota.Location = new System.Drawing.Point(130, 46);
            this.txtidanggota.Name = "txtidanggota";
            this.txtidanggota.Size = new System.Drawing.Size(119, 20);
            this.txtidanggota.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 21;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(130, 175);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(64, 17);
            this.rbLaki.TabIndex = 23;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // lblperempuan
            // 
            this.lblperempuan.AutoSize = true;
            this.lblperempuan.Location = new System.Drawing.Point(130, 202);
            this.lblperempuan.Name = "lblperempuan";
            this.lblperempuan.Size = new System.Drawing.Size(79, 17);
            this.lblperempuan.TabIndex = 24;
            this.lblperempuan.TabStop = true;
            this.lblperempuan.Text = "Perempuan";
            this.lblperempuan.UseVisualStyleBackColor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.Location = new System.Drawing.Point(130, 243);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(75, 23);
            this.btnsimpan.TabIndex = 25;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = true;
            // 
            // btnhapus
            // 
            this.btnhapus.Location = new System.Drawing.Point(349, 243);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(75, 23);
            this.btnhapus.TabIndex = 26;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(582, 243);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 27;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // dgvTampilData
            // 
            this.dgvTampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilData.Location = new System.Drawing.Point(35, 272);
            this.dgvTampilData.Name = "dgvTampilData";
            this.dgvTampilData.Size = new System.Drawing.Size(753, 150);
            this.dgvTampilData.TabIndex = 28;
            // 
            // cmbkelas
            // 
            this.cmbkelas.FormattingEnabled = true;
            this.cmbkelas.Location = new System.Drawing.Point(130, 84);
            this.cmbkelas.Name = "cmbkelas";
            this.cmbkelas.Size = new System.Drawing.Size(121, 21);
            this.cmbkelas.TabIndex = 30;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbkelas);
            this.Controls.Add(this.dgvTampilData);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.lblperempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtidanggota);
            this.Controls.Add(this.labelkelas);
            this.Controls.Add(this.labelalamat);
            this.Controls.Add(this.labelnotelepon);
            this.Controls.Add(this.labeljeniskelamin);
            this.Controls.Add(this.labelnama);
            this.Name = "FormSiswa";
            this.Text = "FormSiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labeljeniskelamin;
        private System.Windows.Forms.Label labelnotelepon;
        private System.Windows.Forms.Label labelalamat;
        private System.Windows.Forms.Label labelkelas;
        private System.Windows.Forms.TextBox txtidanggota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton lblperempuan;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridView dgvTampilData;
        private System.Windows.Forms.ComboBox cmbkelas;
    }
}