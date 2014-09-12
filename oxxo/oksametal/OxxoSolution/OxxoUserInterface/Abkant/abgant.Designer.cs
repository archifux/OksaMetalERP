namespace OxxoUserInterface.Abkant
{
    partial class abgant
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
            this.vardiyaCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.makineCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.abgantLW = new System.Windows.Forms.ListView();
            this.stokKodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bukumSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bukulenParcaSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilkParcaOnay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processKontrol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teknikResimeUygunluk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operatorFunction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ayarZamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.islemeBaslama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.islemiBitirme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.aciklamaTB = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.durusCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.degerTB = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abgant İş Takip Formu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vardiya:";
            // 
            // vardiyaCB
            // 
            this.vardiyaCB.FormattingEnabled = true;
            this.vardiyaCB.Location = new System.Drawing.Point(90, 51);
            this.vardiyaCB.Name = "vardiyaCB";
            this.vardiyaCB.Size = new System.Drawing.Size(121, 21);
            this.vardiyaCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(226, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Makine:";
            // 
            // makineCB
            // 
            this.makineCB.FormattingEnabled = true;
            this.makineCB.Location = new System.Drawing.Point(311, 52);
            this.makineCB.Name = "makineCB";
            this.makineCB.Size = new System.Drawing.Size(121, 21);
            this.makineCB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(453, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // abgantLW
            // 
            this.abgantLW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stokKodu,
            this.bukumSayisi,
            this.bukulenParcaSayisi,
            this.ilkParcaOnay,
            this.processKontrol,
            this.teknikResimeUygunluk,
            this.operatorFunction,
            this.imza,
            this.saat,
            this.ayarZamani,
            this.islemeBaslama,
            this.islemiBitirme});
            this.abgantLW.GridLines = true;
            this.abgantLW.Location = new System.Drawing.Point(16, 88);
            this.abgantLW.Name = "abgantLW";
            this.abgantLW.Size = new System.Drawing.Size(910, 165);
            this.abgantLW.TabIndex = 7;
            this.abgantLW.UseCompatibleStateImageBehavior = false;
            this.abgantLW.View = System.Windows.Forms.View.Details;
            // 
            // stokKodu
            // 
            this.stokKodu.Text = "Stok Kodu";
            this.stokKodu.Width = 81;
            // 
            // bukumSayisi
            // 
            this.bukumSayisi.Text = "Büküm Sayısı";
            this.bukumSayisi.Width = 75;
            // 
            // bukulenParcaSayisi
            // 
            this.bukulenParcaSayisi.Text = "Bük. Parça Say";
            this.bukulenParcaSayisi.Width = 87;
            // 
            // ilkParcaOnay
            // 
            this.ilkParcaOnay.Text = "İlk parça onay";
            this.ilkParcaOnay.Width = 79;
            // 
            // processKontrol
            // 
            this.processKontrol.Text = "Proses Kontrol";
            this.processKontrol.Width = 88;
            // 
            // teknikResimeUygunluk
            // 
            this.teknikResimeUygunluk.Text = "Tek Res Uyg";
            this.teknikResimeUygunluk.Width = 78;
            // 
            // operatorFunction
            // 
            this.operatorFunction.Text = "Operator";
            // 
            // imza
            // 
            this.imza.Text = "İmza";
            this.imza.Width = 42;
            // 
            // saat
            // 
            this.saat.Text = "Saat";
            this.saat.Width = 42;
            // 
            // ayarZamani
            // 
            this.ayarZamani.Text = "Ayar Zamanı";
            this.ayarZamani.Width = 71;
            // 
            // islemeBaslama
            // 
            this.islemeBaslama.Text = "İşleme Başlama";
            this.islemeBaslama.Width = 87;
            // 
            // islemiBitirme
            // 
            this.islemiBitirme.Text = "İşlemi Bitirme";
            this.islemiBitirme.Width = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama:";
            // 
            // aciklamaTB
            // 
            this.aciklamaTB.Location = new System.Drawing.Point(145, 269);
            this.aciklamaTB.Name = "aciklamaTB";
            this.aciklamaTB.Size = new System.Drawing.Size(225, 59);
            this.aciklamaTB.TabIndex = 9;
            this.aciklamaTB.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(404, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Duruşlar:";
            // 
            // durusCB
            // 
            this.durusCB.FormattingEnabled = true;
            this.durusCB.Items.AddRange(new object[] {
            "Makina Arızası",
            "Takım problemleri",
            "Elektrik Sorunları",
            "Operator Sorunları",
            "Hat Dengeleme",
            "Diğer Sorunlar"});
            this.durusCB.Location = new System.Drawing.Point(491, 267);
            this.durusCB.Name = "durusCB";
            this.durusCB.Size = new System.Drawing.Size(162, 21);
            this.durusCB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Değerlendirme:";
            // 
            // degerTB
            // 
            this.degerTB.Location = new System.Drawing.Point(145, 358);
            this.degerTB.Name = "degerTB";
            this.degerTB.Size = new System.Drawing.Size(225, 59);
            this.degerTB.TabIndex = 9;
            this.degerTB.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vardiya Amiri:";
            // 
            // abgant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 428);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.durusCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.degerTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aciklamaTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.abgantLW);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.makineCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vardiyaCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "abgant";
            this.Text = "abgant";
            this.Load += new System.EventHandler(this.abgant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vardiyaCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox makineCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView abgantLW;
        private System.Windows.Forms.ColumnHeader stokKodu;
        private System.Windows.Forms.ColumnHeader bukumSayisi;
        private System.Windows.Forms.ColumnHeader bukulenParcaSayisi;
        private System.Windows.Forms.ColumnHeader ilkParcaOnay;
        private System.Windows.Forms.ColumnHeader processKontrol;
        private System.Windows.Forms.ColumnHeader teknikResimeUygunluk;
        private System.Windows.Forms.ColumnHeader operatorFunction;
        private System.Windows.Forms.ColumnHeader imza;
        private System.Windows.Forms.ColumnHeader saat;
        private System.Windows.Forms.ColumnHeader ayarZamani;
        private System.Windows.Forms.ColumnHeader islemeBaslama;
        private System.Windows.Forms.ColumnHeader islemiBitirme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox aciklamaTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox durusCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox degerTB;
        private System.Windows.Forms.Label label8;
    }
}