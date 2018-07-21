namespace FinalliziedProject
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
            this.txtMetin = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grupBox = new System.Windows.Forms.GroupBox();
            this.ckRenklendir = new System.Windows.Forms.CheckBox();
            this.cbNoktalamaKaldır = new System.Windows.Forms.CheckBox();
            this.cbCumle = new System.Windows.Forms.CheckBox();
            this.cbHarflereAyır = new System.Windows.Forms.CheckBox();
            this.cbHecelereAyır = new System.Windows.Forms.CheckBox();
            this.cbKelimelereAyır = new System.Windows.Forms.CheckBox();
            this.txtAranacakKelime = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIndır = new System.Windows.Forms.Button();
            this.btnUygula = new System.Windows.Forms.Button();
            this.grpRenk = new System.Windows.Forms.GroupBox();
            this.rdRengarenk = new System.Windows.Forms.RadioButton();
            this.rdSiyah = new System.Windows.Forms.RadioButton();
            this.rdYesil = new System.Windows.Forms.RadioButton();
            this.rdSarı = new System.Windows.Forms.RadioButton();
            this.rdMavi = new System.Windows.Forms.RadioButton();
            this.rdKırmızı = new System.Windows.Forms.RadioButton();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grupBox.SuspendLayout();
            this.grpRenk.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.HideSelection = false;
            this.txtMetin.Location = new System.Drawing.Point(15, 108);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(388, 300);
            this.txtMetin.TabIndex = 0;
            this.txtMetin.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(342, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grupBox
            // 
            this.grupBox.BackColor = System.Drawing.Color.Lavender;
            this.grupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grupBox.Controls.Add(this.ckRenklendir);
            this.grupBox.Controls.Add(this.cbNoktalamaKaldır);
            this.grupBox.Controls.Add(this.cbCumle);
            this.grupBox.Controls.Add(this.cbHarflereAyır);
            this.grupBox.Controls.Add(this.cbHecelereAyır);
            this.grupBox.Controls.Add(this.cbKelimelereAyır);
            this.grupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.grupBox.Location = new System.Drawing.Point(457, 62);
            this.grupBox.Name = "grupBox";
            this.grupBox.Size = new System.Drawing.Size(209, 216);
            this.grupBox.TabIndex = 2;
            this.grupBox.TabStop = false;
            this.grupBox.Text = "İşlemler";
            // 
            // ckRenklendir
            // 
            this.ckRenklendir.AutoSize = true;
            this.ckRenklendir.BackColor = System.Drawing.Color.Lavender;
            this.ckRenklendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.ckRenklendir.Location = new System.Drawing.Point(6, 158);
            this.ckRenklendir.Name = "ckRenklendir";
            this.ckRenklendir.Size = new System.Drawing.Size(86, 19);
            this.ckRenklendir.TabIndex = 5;
            this.ckRenklendir.Text = "Renklendir";
            this.ckRenklendir.UseVisualStyleBackColor = false;
            this.ckRenklendir.CheckedChanged += new System.EventHandler(this.ckRenklendir_CheckedChanged);
            // 
            // cbNoktalamaKaldır
            // 
            this.cbNoktalamaKaldır.AutoSize = true;
            this.cbNoktalamaKaldır.BackColor = System.Drawing.Color.Lavender;
            this.cbNoktalamaKaldır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.cbNoktalamaKaldır.Location = new System.Drawing.Point(6, 108);
            this.cbNoktalamaKaldır.Name = "cbNoktalamaKaldır";
            this.cbNoktalamaKaldır.Size = new System.Drawing.Size(126, 19);
            this.cbNoktalamaKaldır.TabIndex = 4;
            this.cbNoktalamaKaldır.Text = "Noklamaları kaldır";
            this.cbNoktalamaKaldır.UseVisualStyleBackColor = false;
            // 
            // cbCumle
            // 
            this.cbCumle.AutoSize = true;
            this.cbCumle.BackColor = System.Drawing.Color.Lavender;
            this.cbCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.cbCumle.Location = new System.Drawing.Point(6, 58);
            this.cbCumle.Name = "cbCumle";
            this.cbCumle.Size = new System.Drawing.Size(123, 19);
            this.cbCumle.TabIndex = 3;
            this.cbCumle.Text = "Cümlelere Ayır      ";
            this.cbCumle.UseVisualStyleBackColor = false;
            // 
            // cbHarflereAyır
            // 
            this.cbHarflereAyır.AutoSize = true;
            this.cbHarflereAyır.BackColor = System.Drawing.Color.Lavender;
            this.cbHarflereAyır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.cbHarflereAyır.Location = new System.Drawing.Point(6, 133);
            this.cbHarflereAyır.Name = "cbHarflereAyır";
            this.cbHarflereAyır.Size = new System.Drawing.Size(92, 19);
            this.cbHarflereAyır.TabIndex = 2;
            this.cbHarflereAyır.Text = "Harflere ayır";
            this.cbHarflereAyır.UseVisualStyleBackColor = false;
            // 
            // cbHecelereAyır
            // 
            this.cbHecelereAyır.AutoSize = true;
            this.cbHecelereAyır.BackColor = System.Drawing.Color.Lavender;
            this.cbHecelereAyır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.cbHecelereAyır.Location = new System.Drawing.Point(6, 83);
            this.cbHecelereAyır.Name = "cbHecelereAyır";
            this.cbHecelereAyır.Size = new System.Drawing.Size(128, 19);
            this.cbHecelereAyır.TabIndex = 1;
            this.cbHecelereAyır.Text = "Hecelere Ayır          ";
            this.cbHecelereAyır.UseVisualStyleBackColor = false;
            // 
            // cbKelimelereAyır
            // 
            this.cbKelimelereAyır.AutoSize = true;
            this.cbKelimelereAyır.BackColor = System.Drawing.Color.Lavender;
            this.cbKelimelereAyır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.cbKelimelereAyır.Location = new System.Drawing.Point(6, 33);
            this.cbKelimelereAyır.Name = "cbKelimelereAyır";
            this.cbKelimelereAyır.Size = new System.Drawing.Size(120, 19);
            this.cbKelimelereAyır.TabIndex = 0;
            this.cbKelimelereAyır.Text = "Kelimelere Ayır    ";
            this.cbKelimelereAyır.UseVisualStyleBackColor = false;
            // 
            // txtAranacakKelime
            // 
            this.txtAranacakKelime.Location = new System.Drawing.Point(105, 31);
            this.txtAranacakKelime.Name = "txtAranacakKelime";
            this.txtAranacakKelime.Size = new System.Drawing.Size(222, 20);
            this.txtAranacakKelime.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(610, 297);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 38);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kütüphaneye Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIndır
            // 
            this.btnIndır.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIndır.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndır.Location = new System.Drawing.Point(764, 297);
            this.btnIndır.Name = "btnIndır";
            this.btnIndır.Size = new System.Drawing.Size(129, 38);
            this.btnIndır.TabIndex = 6;
            this.btnIndır.Text = "Indir";
            this.btnIndır.UseVisualStyleBackColor = false;
            this.btnIndır.Click += new System.EventHandler(this.btnIndır_Click);
            // 
            // btnUygula
            // 
            this.btnUygula.AutoEllipsis = true;
            this.btnUygula.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUygula.Location = new System.Drawing.Point(457, 297);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(128, 38);
            this.btnUygula.TabIndex = 7;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = false;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // grpRenk
            // 
            this.grpRenk.BackColor = System.Drawing.Color.Lavender;
            this.grpRenk.Controls.Add(this.rdRengarenk);
            this.grpRenk.Controls.Add(this.rdSiyah);
            this.grpRenk.Controls.Add(this.rdYesil);
            this.grpRenk.Controls.Add(this.rdSarı);
            this.grpRenk.Controls.Add(this.rdMavi);
            this.grpRenk.Controls.Add(this.rdKırmızı);
            this.grpRenk.Location = new System.Drawing.Point(703, 66);
            this.grpRenk.Name = "grpRenk";
            this.grpRenk.Size = new System.Drawing.Size(162, 172);
            this.grpRenk.TabIndex = 11;
            this.grpRenk.TabStop = false;
            this.grpRenk.Text = "Renklendirme";
            // 
            // rdRengarenk
            // 
            this.rdRengarenk.AutoSize = true;
            this.rdRengarenk.Location = new System.Drawing.Point(6, 144);
            this.rdRengarenk.Name = "rdRengarenk";
            this.rdRengarenk.Size = new System.Drawing.Size(78, 17);
            this.rdRengarenk.TabIndex = 5;
            this.rdRengarenk.TabStop = true;
            this.rdRengarenk.Text = "Rengarenk";
            this.rdRengarenk.UseVisualStyleBackColor = true;
            this.rdRengarenk.CheckedChanged += new System.EventHandler(this.rdRengarenk_CheckedChanged);
            // 
            // rdSiyah
            // 
            this.rdSiyah.AutoSize = true;
            this.rdSiyah.Location = new System.Drawing.Point(6, 121);
            this.rdSiyah.Name = "rdSiyah";
            this.rdSiyah.Size = new System.Drawing.Size(51, 17);
            this.rdSiyah.TabIndex = 4;
            this.rdSiyah.TabStop = true;
            this.rdSiyah.Text = "Siyah";
            this.rdSiyah.UseVisualStyleBackColor = true;
            // 
            // rdYesil
            // 
            this.rdYesil.AutoSize = true;
            this.rdYesil.Location = new System.Drawing.Point(6, 98);
            this.rdYesil.Name = "rdYesil";
            this.rdYesil.Size = new System.Drawing.Size(47, 17);
            this.rdYesil.TabIndex = 3;
            this.rdYesil.TabStop = true;
            this.rdYesil.Text = "Yeşil";
            this.rdYesil.UseVisualStyleBackColor = true;
            // 
            // rdSarı
            // 
            this.rdSarı.AutoSize = true;
            this.rdSarı.Location = new System.Drawing.Point(6, 75);
            this.rdSarı.Name = "rdSarı";
            this.rdSarı.Size = new System.Drawing.Size(43, 17);
            this.rdSarı.TabIndex = 2;
            this.rdSarı.TabStop = true;
            this.rdSarı.Text = "Sarı";
            this.rdSarı.UseVisualStyleBackColor = true;
            // 
            // rdMavi
            // 
            this.rdMavi.AutoSize = true;
            this.rdMavi.Location = new System.Drawing.Point(6, 52);
            this.rdMavi.Name = "rdMavi";
            this.rdMavi.Size = new System.Drawing.Size(48, 17);
            this.rdMavi.TabIndex = 1;
            this.rdMavi.TabStop = true;
            this.rdMavi.Text = "Mavi";
            this.rdMavi.UseVisualStyleBackColor = true;
            // 
            // rdKırmızı
            // 
            this.rdKırmızı.AutoSize = true;
            this.rdKırmızı.Location = new System.Drawing.Point(6, 29);
            this.rdKırmızı.Name = "rdKırmızı";
            this.rdKırmızı.Size = new System.Drawing.Size(54, 17);
            this.rdKırmızı.TabIndex = 0;
            this.rdKırmızı.TabStop = true;
            this.rdKırmızı.Text = "Kırmızı";
            this.rdKırmızı.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.OrangeRed;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(457, 345);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(128, 39);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGeriAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriAl.Location = new System.Drawing.Point(610, 345);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(128, 38);
            this.btnGeriAl.TabIndex = 13;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = false;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.OrangeRed;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(764, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 39);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(732, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(105, 63);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(298, 20);
            this.txtBaslik.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Uygulama Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(637, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kütüphanede Bul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Metin Ara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(905, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.grpRenk);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.btnIndır);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAranacakKelime);
            this.Controls.Add(this.grupBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMetin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Eğlen Öğren";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupBox.ResumeLayout(false);
            this.grupBox.PerformLayout();
            this.grpRenk.ResumeLayout(false);
            this.grpRenk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMetin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grupBox;
        private System.Windows.Forms.CheckBox cbNoktalamaKaldır;
        private System.Windows.Forms.CheckBox cbCumle;
        private System.Windows.Forms.CheckBox cbHarflereAyır;
        private System.Windows.Forms.CheckBox cbHecelereAyır;
        private System.Windows.Forms.CheckBox cbKelimelereAyır;
        private System.Windows.Forms.TextBox txtAranacakKelime;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIndır;
        private System.Windows.Forms.GroupBox grpRenk;
        private System.Windows.Forms.RadioButton rdSiyah;
        private System.Windows.Forms.RadioButton rdYesil;
        private System.Windows.Forms.RadioButton rdSarı;
        private System.Windows.Forms.RadioButton rdMavi;
        private System.Windows.Forms.RadioButton rdKırmızı;
        private System.Windows.Forms.CheckBox ckRenklendir;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdRengarenk;
    }
}

