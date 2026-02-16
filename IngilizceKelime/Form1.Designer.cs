
namespace IngilizceKelime
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIng = new System.Windows.Forms.TextBox();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPas = new System.Windows.Forms.Label();
            this.LabelPas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // txtIng
            // 
            this.txtIng.Enabled = false;
            this.txtIng.Location = new System.Drawing.Point(105, 36);
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(281, 22);
            this.txtIng.TabIndex = 2;
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(105, 93);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(281, 22);
            this.txtTurkce.TabIndex = 1;
            this.txtTurkce.TextChanged += new System.EventHandler(this.txtTurkce_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelPas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblKelime);
            this.groupBox1.Controls.Add(this.lblSure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTurkce);
            this.groupBox1.Controls.Add(this.txtIng);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 176);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(436, 205);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(46, 17);
            this.lblCevap.TabIndex = 4;
            this.lblCevap.Text = "label4";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(538, 75);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(24, 25);
            this.lblKelime.TabIndex = 3;
            this.lblKelime.Text = "0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(514, 43);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(48, 25);
            this.lblSure.TabIndex = 3;
            this.lblSure.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(419, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kelime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(419, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Süre:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Yeni Oyun";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(261, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Skor Tablosu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Location = new System.Drawing.Point(436, 231);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(31, 17);
            this.lblPas.TabIndex = 5;
            this.lblPas.Text = "pas";
            // 
            // LabelPas
            // 
            this.LabelPas.AutoSize = true;
            this.LabelPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelPas.Location = new System.Drawing.Point(538, 112);
            this.LabelPas.Name = "LabelPas";
            this.LabelPas.Size = new System.Drawing.Size(24, 25);
            this.LabelPas.TabIndex = 4;
            this.LabelPas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(419, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 291);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIng;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPas;
        private System.Windows.Forms.Label LabelPas;
        private System.Windows.Forms.Label label6;
    }
}

