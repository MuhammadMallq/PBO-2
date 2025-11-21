namespace P6_4_714240062
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupIdentitas = new System.Windows.Forms.GroupBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupTiket = new System.Windows.Forms.GroupBox();
            this.numKursi = new System.Windows.Forms.NumericUpDown();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKonfirmasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.groupIdentitas.SuspendLayout();
            this.groupTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKursi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupIdentitas
            // 
            this.groupIdentitas.Controls.Add(this.txtUmur);
            this.groupIdentitas.Controls.Add(this.label3);
            this.groupIdentitas.Controls.Add(this.txtEmail);
            this.groupIdentitas.Controls.Add(this.label2);
            this.groupIdentitas.Controls.Add(this.txtNama);
            this.groupIdentitas.Controls.Add(this.label1);
            this.groupIdentitas.Location = new System.Drawing.Point(26, 26);
            this.groupIdentitas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupIdentitas.Name = "groupIdentitas";
            this.groupIdentitas.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupIdentitas.Size = new System.Drawing.Size(551, 102);
            this.groupIdentitas.TabIndex = 0;
            this.groupIdentitas.TabStop = false;
            this.groupIdentitas.Text = "Identitas Pemesan";
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(236, 34);
            this.txtUmur.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(70, 25);
            this.txtUmur.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Umur:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 71);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(29, 31);
            this.txtNama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(176, 25);
            this.txtNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama:";
            // 
            // groupTiket
            // 
            this.groupTiket.Controls.Add(this.numKursi);
            this.groupTiket.Controls.Add(this.txtCatatan);
            this.groupTiket.Controls.Add(this.label7);
            this.groupTiket.Controls.Add(this.label6);
            this.groupTiket.Controls.Add(this.txtKonfirmasi);
            this.groupTiket.Controls.Add(this.label5);
            this.groupTiket.Controls.Add(this.txtKode);
            this.groupTiket.Controls.Add(this.label4);
            this.groupTiket.Controls.Add(this.dtTanggal);
            this.groupTiket.Controls.Add(this.label8);
            this.groupTiket.Location = new System.Drawing.Point(26, 144);
            this.groupTiket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupTiket.Name = "groupTiket";
            this.groupTiket.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupTiket.Size = new System.Drawing.Size(551, 153);
            this.groupTiket.TabIndex = 1;
            this.groupTiket.TabStop = false;
            this.groupTiket.Text = "Informasi Tiket";
            // 
            // numKursi
            // 
            this.numKursi.Location = new System.Drawing.Point(239, 34);
            this.numKursi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKursi.Name = "numKursi";
            this.numKursi.Size = new System.Drawing.Size(44, 25);
            this.numKursi.TabIndex = 4;
            this.numKursi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCatatan
            // 
            this.txtCatatan.Location = new System.Drawing.Point(236, 75);
            this.txtCatatan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCatatan.Multiline = true;
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatatan.Size = new System.Drawing.Size(219, 51);
            this.txtCatatan.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Catatan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kursi:";
            // 
            // txtKonfirmasi
            // 
            this.txtKonfirmasi.Location = new System.Drawing.Point(26, 120);
            this.txtKonfirmasi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKonfirmasi.Name = "txtKonfirmasi";
            this.txtKonfirmasi.Size = new System.Drawing.Size(132, 25);
            this.txtKonfirmasi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Konfirmasi Kode:";
            // 
            // txtKode
            // 
            this.txtKode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKode.Location = new System.Drawing.Point(26, 75);
            this.txtKode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(132, 25);
            this.txtKode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kode Tiket:";
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(26, 34);
            this.dtTanggal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(176, 25);
            this.dtTanggal.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tanggal Pemesanan";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(376, 314);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(490, 314);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(88, 30);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(612, 382);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupTiket);
            this.Controls.Add(this.groupIdentitas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pemesanan Tiket";
            this.groupIdentitas.ResumeLayout(false);
            this.groupIdentitas.PerformLayout();
            this.groupTiket.ResumeLayout(false);
            this.groupTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKursi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupIdentitas;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupTiket;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKonfirmasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.NumericUpDown numKursi;
    }
}
