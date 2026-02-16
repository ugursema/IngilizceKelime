
namespace IngilizceKelime
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.btnGrisYap = new System.Windows.Forms.Button();
            this.btnUyeForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtKullaniciAd);
            this.groupBox1.Controls.Add(this.btnGrisYap);
            this.groupBox1.Controls.Add(this.btnUyeForm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giris Ekranı";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(120, 81);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(253, 22);
            this.txtPass.TabIndex = 2;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(120, 34);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(253, 22);
            this.txtKullaniciAd.TabIndex = 1;
            // 
            // btnGrisYap
            // 
            this.btnGrisYap.Location = new System.Drawing.Point(255, 135);
            this.btnGrisYap.Name = "btnGrisYap";
            this.btnGrisYap.Size = new System.Drawing.Size(118, 39);
            this.btnGrisYap.TabIndex = 3;
            this.btnGrisYap.Text = "Giriş Yap";
            this.btnGrisYap.UseVisualStyleBackColor = true;
            this.btnGrisYap.Click += new System.EventHandler(this.btnGrisYap_Click);
            // 
            // btnUyeForm
            // 
            this.btnUyeForm.Location = new System.Drawing.Point(120, 135);
            this.btnUyeForm.Name = "btnUyeForm";
            this.btnUyeForm.Size = new System.Drawing.Size(129, 39);
            this.btnUyeForm.TabIndex = 4;
            this.btnUyeForm.Text = "Üye Ol";
            this.btnUyeForm.UseVisualStyleBackColor = true;
            this.btnUyeForm.Click += new System.EventHandler(this.btnUyeForm_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 242);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Button btnGrisYap;
        private System.Windows.Forms.Button btnUyeForm;
    }
}