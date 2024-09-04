namespace BankamatikSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskHesap = new System.Windows.Forms.MaskedTextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.btn_giriş = new System.Windows.Forms.Button();
            this.lnkKayıtOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // mskHesap
            // 
            this.mskHesap.Location = new System.Drawing.Point(136, 34);
            this.mskHesap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskHesap.Mask = "000000";
            this.mskHesap.Name = "mskHesap";
            this.mskHesap.Size = new System.Drawing.Size(148, 26);
            this.mskHesap.TabIndex = 1;
            this.mskHesap.ValidatingType = typeof(int);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(136, 85);
            this.txtŞifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(148, 26);
            this.txtŞifre.TabIndex = 2;
            // 
            // btn_giriş
            // 
            this.btn_giriş.Location = new System.Drawing.Point(158, 138);
            this.btn_giriş.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(112, 35);
            this.btn_giriş.TabIndex = 3;
            this.btn_giriş.Text = "Giriş Yap";
            this.btn_giriş.UseVisualStyleBackColor = true;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // lnkKayıtOl
            // 
            this.lnkKayıtOl.AutoSize = true;
            this.lnkKayıtOl.Location = new System.Drawing.Point(322, 85);
            this.lnkKayıtOl.Name = "lnkKayıtOl";
            this.lnkKayıtOl.Size = new System.Drawing.Size(62, 20);
            this.lnkKayıtOl.TabIndex = 4;
            this.lnkKayıtOl.TabStop = true;
            this.lnkKayıtOl.Text = "Kayıt Ol";
            this.lnkKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayıtOl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(424, 204);
            this.Controls.Add(this.lnkKayıtOl);
            this.Controls.Add(this.btn_giriş);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.mskHesap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskHesap;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.LinkLabel lnkKayıtOl;
    }
}

