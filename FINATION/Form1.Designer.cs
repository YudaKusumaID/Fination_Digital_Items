namespace FINATION
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbproduk = new System.Windows.Forms.ComboBox();
            this.cmblist = new System.Windows.Forms.ComboBox();
            this.produk = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.Label();
            this.textJumlah = new System.Windows.Forms.TextBox();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbitems = new System.Windows.Forms.ComboBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.Credits = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbproduk
            // 
            this.cmbproduk.FormattingEnabled = true;
            this.cmbproduk.Items.AddRange(new object[] {
            "Top Up",
            "Voucher"});
            this.cmbproduk.Location = new System.Drawing.Point(182, 42);
            this.cmbproduk.Name = "cmbproduk";
            this.cmbproduk.Size = new System.Drawing.Size(182, 33);
            this.cmbproduk.TabIndex = 0;
            this.cmbproduk.SelectedIndexChanged += new System.EventHandler(this.cmbjenisitems_SelectedIndexChanged);
            // 
            // cmblist
            // 
            this.cmblist.FormattingEnabled = true;
            this.cmblist.Location = new System.Drawing.Point(182, 106);
            this.cmblist.Name = "cmblist";
            this.cmblist.Size = new System.Drawing.Size(182, 33);
            this.cmblist.TabIndex = 1;
            this.cmblist.SelectedIndexChanged += new System.EventHandler(this.cmblist_SelectedIndexChanged);
            // 
            // produk
            // 
            this.produk.AutoSize = true;
            this.produk.Location = new System.Drawing.Point(54, 45);
            this.produk.Name = "produk";
            this.produk.Size = new System.Drawing.Size(82, 25);
            this.produk.TabIndex = 2;
            this.produk.Text = "PRODUK";
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(54, 109);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(44, 25);
            this.list.TabIndex = 3;
            this.list.Text = "LIST";
            // 
            // textJumlah
            // 
            this.textJumlah.Location = new System.Drawing.Point(182, 280);
            this.textJumlah.Name = "textJumlah";
            this.textJumlah.Size = new System.Drawing.Size(150, 31);
            this.textJumlah.TabIndex = 4;
            // 
            // textHarga
            // 
            this.textHarga.Location = new System.Drawing.Point(182, 226);
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(150, 31);
            this.textHarga.TabIndex = 5;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(595, 221);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(150, 31);
            this.textTotal.TabIndex = 6;
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(54, 229);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(72, 25);
            this.harga.TabIndex = 7;
            this.harga.Text = "HARGA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "JUMLAH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "TOTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FINATION.Properties.Resources.Logo_Fination_2;
            this.pictureBox1.Location = new System.Drawing.Point(518, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "ITEMS";
            // 
            // cmbitems
            // 
            this.cmbitems.FormattingEnabled = true;
            this.cmbitems.Location = new System.Drawing.Point(182, 168);
            this.cmbitems.Name = "cmbitems";
            this.cmbitems.Size = new System.Drawing.Size(182, 33);
            this.cmbitems.TabIndex = 12;
            this.cmbitems.SelectedIndexChanged += new System.EventHandler(this.cmbitems_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(182, 331);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(112, 34);
            this.btnHitung.TabIndex = 13;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Credits.Location = new System.Drawing.Point(618, 367);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(152, 25);
            this.Credits.TabIndex = 14;
            this.Credits.Text = "Created By Yuda";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(641, 396);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 25);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Visit Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.cmbitems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textHarga);
            this.Controls.Add(this.textJumlah);
            this.Controls.Add(this.list);
            this.Controls.Add(this.produk);
            this.Controls.Add(this.cmblist);
            this.Controls.Add(this.cmbproduk);
            this.Name = "Form1";
            this.Text = "FINATION - DIGITAL ITEMS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbproduk;
        private ComboBox cmblist;
        private Label produk;
        private Label list;
        private TextBox textJumlah;
        private TextBox textHarga;
        private TextBox textTotal;
        private Label harga;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox cmbitems;
        private Button btnHitung;
        private Label Credits;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}