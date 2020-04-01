namespace BoyKiloIndeksi
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
            this.labelBoy = new System.Windows.Forms.Label();
            this.textBoxBoy = new System.Windows.Forms.TextBox();
            this.textBoxKilo = new System.Windows.Forms.TextBox();
            this.labelKilo = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.labelDeger = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBoy
            // 
            this.labelBoy.AutoSize = true;
            this.labelBoy.Location = new System.Drawing.Point(13, 13);
            this.labelBoy.Name = "labelBoy";
            this.labelBoy.Size = new System.Drawing.Size(85, 13);
            this.labelBoy.TabIndex = 0;
            this.labelBoy.Text = "Boyunuzu Giriniz";
            // 
            // textBoxBoy
            // 
            this.textBoxBoy.Location = new System.Drawing.Point(150, 13);
            this.textBoxBoy.Name = "textBoxBoy";
            this.textBoxBoy.Size = new System.Drawing.Size(100, 20);
            this.textBoxBoy.TabIndex = 1;
            // 
            // textBoxKilo
            // 
            this.textBoxKilo.Location = new System.Drawing.Point(150, 50);
            this.textBoxKilo.Name = "textBoxKilo";
            this.textBoxKilo.Size = new System.Drawing.Size(100, 20);
            this.textBoxKilo.TabIndex = 2;
            // 
            // labelKilo
            // 
            this.labelKilo.AutoSize = true;
            this.labelKilo.Location = new System.Drawing.Point(16, 50);
            this.labelKilo.Name = "labelKilo";
            this.labelKilo.Size = new System.Drawing.Size(78, 13);
            this.labelKilo.TabIndex = 3;
            this.labelKilo.Text = "Kilonuzu Giriniz";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(19, 99);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(75, 23);
            this.buttonHesapla.TabIndex = 4;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // labelDeger
            // 
            this.labelDeger.AutoSize = true;
            this.labelDeger.Location = new System.Drawing.Point(16, 159);
            this.labelDeger.Name = "labelDeger";
            this.labelDeger.Size = new System.Drawing.Size(67, 13);
            this.labelDeger.TabIndex = 5;
            this.labelDeger.Text = "Değer Aralığı";
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(150, 99);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(35, 13);
            this.labelSonuc.TabIndex = 6;
            this.labelSonuc.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 333);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.labelDeger);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.labelKilo);
            this.Controls.Add(this.textBoxKilo);
            this.Controls.Add(this.textBoxBoy);
            this.Controls.Add(this.labelBoy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBoy;
        private System.Windows.Forms.TextBox textBoxBoy;
        private System.Windows.Forms.TextBox textBoxKilo;
        private System.Windows.Forms.Label labelKilo;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.Label labelDeger;
        private System.Windows.Forms.Label labelSonuc;
    }
}

