namespace P5_3_714240062
{
    partial class Form1
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
            this.MerkHP = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMerkHP = new System.Windows.Forms.TextBox();
            this.rb_android = new System.Windows.Forms.RadioButton();
            this.rb_ios = new System.Windows.Forms.RadioButton();
            this.cb_Ya = new System.Windows.Forms.CheckBox();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MerkHP
            // 
            this.MerkHP.AutoSize = true;
            this.MerkHP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MerkHP.Location = new System.Drawing.Point(31, 41);
            this.MerkHP.Name = "MerkHP";
            this.MerkHP.Size = new System.Drawing.Size(59, 18);
            this.MerkHP.TabIndex = 0;
            this.MerkHP.Text = "Merk HP";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OS.Location = new System.Drawing.Point(31, 105);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(24, 18);
            this.OS.TabIndex = 1;
            this.OS.Text = "OS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sudah Diperbaiki?";
            // 
            // txtMerkHP
            // 
            this.txtMerkHP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkHP.Location = new System.Drawing.Point(188, 41);
            this.txtMerkHP.Name = "txtMerkHP";
            this.txtMerkHP.Size = new System.Drawing.Size(224, 23);
            this.txtMerkHP.TabIndex = 3;
            // 
            // rb_android
            // 
            this.rb_android.AutoSize = true;
            this.rb_android.Location = new System.Drawing.Point(188, 106);
            this.rb_android.Name = "rb_android";
            this.rb_android.Size = new System.Drawing.Size(61, 17);
            this.rb_android.TabIndex = 4;
            this.rb_android.TabStop = true;
            this.rb_android.Text = "Android";
            this.rb_android.UseVisualStyleBackColor = true;
            // 
            // rb_ios
            // 
            this.rb_ios.AutoSize = true;
            this.rb_ios.Location = new System.Drawing.Point(284, 106);
            this.rb_ios.Name = "rb_ios";
            this.rb_ios.Size = new System.Drawing.Size(43, 17);
            this.rb_ios.TabIndex = 5;
            this.rb_ios.TabStop = true;
            this.rb_ios.Text = "IOS";
            this.rb_ios.UseVisualStyleBackColor = true;
            // 
            // cb_Ya
            // 
            this.cb_Ya.AutoSize = true;
            this.cb_Ya.Location = new System.Drawing.Point(188, 156);
            this.cb_Ya.Name = "cb_Ya";
            this.cb_Ya.Size = new System.Drawing.Size(39, 17);
            this.cb_Ya.TabIndex = 6;
            this.cb_Ya.Text = "Ya";
            this.cb_Ya.UseVisualStyleBackColor = true;
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(75, 223);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 7;
            this.btnTampilkan.Text = "T&ampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(284, 223);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 8;
            this.btnKeluar.Text = "K&eluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(450, 276);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.cb_Ya);
            this.Controls.Add(this.rb_ios);
            this.Controls.Add(this.rb_android);
            this.Controls.Add(this.txtMerkHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.MerkHP);
            this.Name = "Form1";
            this.Text = "Service HP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MerkHP;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMerkHP;
        private System.Windows.Forms.RadioButton rb_android;
        private System.Windows.Forms.RadioButton rb_ios;
        private System.Windows.Forms.CheckBox cb_Ya;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKeluar;
    }
}

