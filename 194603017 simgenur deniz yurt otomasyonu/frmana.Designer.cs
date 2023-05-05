namespace _194603017_yurtotomasyon
{
    partial class frmana
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öĞRENCİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öGRENCİEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÖLÜMLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öDEMELERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİDERLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrencıBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._194603017DataSet1 = new _194603017_yurtotomasyon._194603017DataSet1();
            this.ogrencıTableAdapter = new _194603017_yurtotomasyon._194603017DataSet1TableAdapters.ogrencıTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencıBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öĞRENCİLERToolStripMenuItem,
            this.bÖLÜMLERToolStripMenuItem,
            this.öDEMELERToolStripMenuItem,
            this.gİDERLERToolStripMenuItem,
            this.pERSONELLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öĞRENCİLERToolStripMenuItem
            // 
            this.öĞRENCİLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öGRENCİEKLEToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem});
            this.öĞRENCİLERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öĞRENCİLERToolStripMenuItem.Name = "öĞRENCİLERToolStripMenuItem";
            this.öĞRENCİLERToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.öĞRENCİLERToolStripMenuItem.Text = "ÖĞRENCİLER";
            // 
            // öGRENCİEKLEToolStripMenuItem
            // 
            this.öGRENCİEKLEToolStripMenuItem.Name = "öGRENCİEKLEToolStripMenuItem";
            this.öGRENCİEKLEToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.öGRENCİEKLEToolStripMenuItem.Text = "öğrenci ekle";
            this.öGRENCİEKLEToolStripMenuItem.Click += new System.EventHandler(this.öGRENCİEKLEToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.öğrenciListesiToolStripMenuItem.Text = "öğrenci listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // bÖLÜMLERToolStripMenuItem
            // 
            this.bÖLÜMLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümDüzenleToolStripMenuItem});
            this.bÖLÜMLERToolStripMenuItem.Name = "bÖLÜMLERToolStripMenuItem";
            this.bÖLÜMLERToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.bÖLÜMLERToolStripMenuItem.Text = "BÖLÜMLER";
            this.bÖLÜMLERToolStripMenuItem.Click += new System.EventHandler(this.bÖLÜMLERToolStripMenuItem_Click);
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.bölümDüzenleToolStripMenuItem.Text = "bölüm düzenle";
            this.bölümDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bölümDüzenleToolStripMenuItem_Click);
            // 
            // öDEMELERToolStripMenuItem
            // 
            this.öDEMELERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeİşlemiToolStripMenuItem});
            this.öDEMELERToolStripMenuItem.Name = "öDEMELERToolStripMenuItem";
            this.öDEMELERToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.öDEMELERToolStripMenuItem.Text = "ÖDEMELER";
            // 
            // ödemeİşlemiToolStripMenuItem
            // 
            this.ödemeİşlemiToolStripMenuItem.Name = "ödemeİşlemiToolStripMenuItem";
            this.ödemeİşlemiToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.ödemeİşlemiToolStripMenuItem.Text = "ödeme işlemi ";
            this.ödemeİşlemiToolStripMenuItem.Click += new System.EventHandler(this.ödemeİşlemiToolStripMenuItem_Click);
            // 
            // gİDERLERToolStripMenuItem
            // 
            this.gİDERLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderListesiToolStripMenuItem});
            this.gİDERLERToolStripMenuItem.Name = "gİDERLERToolStripMenuItem";
            this.gİDERLERToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.gİDERLERToolStripMenuItem.Text = "GİDERLER";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.giderEkleToolStripMenuItem.Text = "gider ekle";
            this.giderEkleToolStripMenuItem.Click += new System.EventHandler(this.giderEkleToolStripMenuItem_Click);
            // 
            // giderListesiToolStripMenuItem
            // 
            this.giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            this.giderListesiToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.giderListesiToolStripMenuItem.Text = "gider listesi";
            this.giderListesiToolStripMenuItem.Click += new System.EventHandler(this.giderListesiToolStripMenuItem_Click);
            // 
            // pERSONELLERToolStripMenuItem
            // 
            this.pERSONELLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDüzenleToolStripMenuItem,
            this.personelListelemeToolStripMenuItem});
            this.pERSONELLERToolStripMenuItem.Name = "pERSONELLERToolStripMenuItem";
            this.pERSONELLERToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.pERSONELLERToolStripMenuItem.Text = "PERSONELLER";
            // 
            // personelDüzenleToolStripMenuItem
            // 
            this.personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            this.personelDüzenleToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.personelDüzenleToolStripMenuItem.Text = "personel düzenle ";
            this.personelDüzenleToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenleToolStripMenuItem_Click);
            // 
            // personelListelemeToolStripMenuItem
            // 
            this.personelListelemeToolStripMenuItem.Name = "personelListelemeToolStripMenuItem";
            this.personelListelemeToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.personelListelemeToolStripMenuItem.Text = "personel listeleme";
            this.personelListelemeToolStripMenuItem.Click += new System.EventHandler(this.personelListelemeToolStripMenuItem_Click);
            // 
            // ogrencıBindingSource
            // 
            this.ogrencıBindingSource.DataMember = "ogrencı";
            this.ogrencıBindingSource.DataSource = this._194603017DataSet1;
            // 
            // _194603017DataSet1
            // 
            this._194603017DataSet1.DataSetName = "_194603017DataSet1";
            this._194603017DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencıTableAdapter
            // 
            this.ogrencıTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "YURT OTOMASYONU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SİMGENUR DENİZ";
            // 
            // frmana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(556, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmana";
            this.Text = "frmana";
            this.Load += new System.EventHandler(this.frmana_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencıBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öĞRENCİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öGRENCİEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÖLÜMLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öDEMELERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİDERLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListelemeToolStripMenuItem;
        private _194603017DataSet1 _194603017DataSet1;
        private System.Windows.Forms.BindingSource ogrencıBindingSource;
        private _194603017DataSet1TableAdapters.ogrencıTableAdapter ogrencıTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}