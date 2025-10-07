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
            this.lblnama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTampilData = new System.Windows.Forms.DataGridView();
            this.lbljeniskelamin = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.lblperempuan = new System.Windows.Forms.RadioButton();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.texttelepon = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnama
            // 
            this.lblnama.AutoSize = true;
            this.lblnama.Location = new System.Drawing.Point(29, 44);
            this.lblnama.Name = "lblnama";
            this.lblnama.Size = new System.Drawing.Size(38, 13);
            this.lblnama.TabIndex = 2;
            this.lblnama.Text = "Nama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelas:";
            // 
            // dgvTampilData
            // 
            this.dgvTampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilData.Location = new System.Drawing.Point(32, 260);
            this.dgvTampilData.Name = "dgvTampilData";
            this.dgvTampilData.Size = new System.Drawing.Size(728, 155);
            this.dgvTampilData.TabIndex = 27;
            // 
            // lbljeniskelamin
            // 
            this.lbljeniskelamin.AutoSize = true;
            this.lbljeniskelamin.Location = new System.Drawing.Point(29, 168);
            this.lbljeniskelamin.Name = "lbljeniskelamin";
            this.lbljeniskelamin.Size = new System.Drawing.Size(73, 13);
            this.lbljeniskelamin.TabIndex = 28;
            this.lbljeniskelamin.Text = "Jenis kelamin:";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(114, 164);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(64, 17);
            this.rbLaki.TabIndex = 29;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // lblperempuan
            // 
            this.lblperempuan.AutoSize = true;
            this.lblperempuan.Location = new System.Drawing.Point(114, 187);
            this.lblperempuan.Name = "lblperempuan";
            this.lblperempuan.Size = new System.Drawing.Size(79, 17);
            this.lblperempuan.TabIndex = 30;
            this.lblperempuan.TabStop = true;
            this.lblperempuan.Text = "Perempuan";
            this.lblperempuan.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(114, 231);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 31;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(323, 231);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 32;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(553, 231);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(29, 102);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(42, 13);
            this.lblAlamat.TabIndex = 34;
            this.lblAlamat.Text = "Alamat:";
            this.lblAlamat.Click += new System.EventHandler(this.lblAlamat_Click);
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Location = new System.Drawing.Point(29, 135);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(69, 13);
            this.lblTelepon.TabIndex = 35;
            this.lblTelepon.Text = " No.Telepon:";
            this.lblTelepon.Click += new System.EventHandler(this.lblTelepon_Click);
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(114, 41);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(119, 20);
            this.textnama.TabIndex = 36;
            // 
            // texttelepon
            // 
            this.texttelepon.Location = new System.Drawing.Point(114, 135);
            this.texttelepon.Name = "texttelepon";
            this.texttelepon.Size = new System.Drawing.Size(119, 20);
            this.texttelepon.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 40;
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.texttelepon);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblperempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.lbljeniskelamin);
            this.Controls.Add(this.dgvTampilData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnama);
            this.Name = "FormSiswa";
            this.Text = "FormSiswa";
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTampilData;
        private System.Windows.Forms.Label lbljeniskelamin;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton lblperempuan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.TextBox texttelepon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}