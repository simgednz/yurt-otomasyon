namespace _194603017_yurtotomasyon
{
    partial class frmgıderler
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtelektırık = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttemizlik = new System.Windows.Forms.TextBox();
            this.txttadılat = new System.Windows.Forms.TextBox();
            this.txtmutfak = new System.Windows.Forms.TextBox();
            this.txtsu = new System.Windows.Forms.TextBox();
            this.txtgaz = new System.Windows.Forms.TextBox();
            this.txtpersonel = new System.Windows.Forms.TextBox();
            this.txtd_odeme = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odemeıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektırıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutfakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temızlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadılatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dıgerodemelerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gıderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._194603017DataSet5 = new _194603017_yurtotomasyon._194603017DataSet5();
            this.gıderlerTableAdapter = new _194603017_yurtotomasyon._194603017DataSet5TableAdapters.gıderlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıderlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELEKTİRİK :";
            // 
            // txtelektırık
            // 
            this.txtelektırık.Location = new System.Drawing.Point(181, 23);
            this.txtelektırık.Name = "txtelektırık";
            this.txtelektırık.Size = new System.Drawing.Size(191, 20);
            this.txtelektırık.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOGALGAZ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "SU :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "MUTFAK :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "TEMİZLİK :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "PERSONEL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "TADİLAT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "DİĞER ÖDEMELER :";
            // 
            // txttemizlik
            // 
            this.txttemizlik.Location = new System.Drawing.Point(181, 159);
            this.txttemizlik.Name = "txttemizlik";
            this.txttemizlik.Size = new System.Drawing.Size(191, 20);
            this.txttemizlik.TabIndex = 9;
            // 
            // txttadılat
            // 
            this.txttadılat.Location = new System.Drawing.Point(181, 236);
            this.txttadılat.Name = "txttadılat";
            this.txttadılat.Size = new System.Drawing.Size(191, 20);
            this.txttadılat.TabIndex = 10;
            // 
            // txtmutfak
            // 
            this.txtmutfak.Location = new System.Drawing.Point(181, 128);
            this.txtmutfak.Name = "txtmutfak";
            this.txtmutfak.Size = new System.Drawing.Size(191, 20);
            this.txtmutfak.TabIndex = 11;
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(181, 91);
            this.txtsu.Name = "txtsu";
            this.txtsu.Size = new System.Drawing.Size(191, 20);
            this.txtsu.TabIndex = 12;
            // 
            // txtgaz
            // 
            this.txtgaz.Location = new System.Drawing.Point(181, 56);
            this.txtgaz.Name = "txtgaz";
            this.txtgaz.Size = new System.Drawing.Size(191, 20);
            this.txtgaz.TabIndex = 13;
            // 
            // txtpersonel
            // 
            this.txtpersonel.Location = new System.Drawing.Point(181, 197);
            this.txtpersonel.Name = "txtpersonel";
            this.txtpersonel.Size = new System.Drawing.Size(191, 20);
            this.txtpersonel.TabIndex = 14;
            // 
            // txtd_odeme
            // 
            this.txtd_odeme.Location = new System.Drawing.Point(181, 271);
            this.txtd_odeme.Name = "txtd_odeme";
            this.txtd_odeme.Size = new System.Drawing.Size(191, 20);
            this.txtd_odeme.TabIndex = 15;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(167, 301);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(99, 23);
            this.btnkaydet.TabIndex = 16;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(283, 301);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(99, 23);
            this.btnguncelle.TabIndex = 17;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeıdDataGridViewTextBoxColumn,
            this.elektırıkDataGridViewTextBoxColumn,
            this.dogalgazDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.mutfakDataGridViewTextBoxColumn,
            this.temızlıkDataGridViewTextBoxColumn,
            this.personelDataGridViewTextBoxColumn,
            this.tadılatDataGridViewTextBoxColumn,
            this.dıgerodemelerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gıderlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(423, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 271);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // odemeıdDataGridViewTextBoxColumn
            // 
            this.odemeıdDataGridViewTextBoxColumn.DataPropertyName = "odeme_ıd";
            this.odemeıdDataGridViewTextBoxColumn.HeaderText = "odeme_ıd";
            this.odemeıdDataGridViewTextBoxColumn.Name = "odemeıdDataGridViewTextBoxColumn";
            this.odemeıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektırıkDataGridViewTextBoxColumn
            // 
            this.elektırıkDataGridViewTextBoxColumn.DataPropertyName = "elektırık";
            this.elektırıkDataGridViewTextBoxColumn.HeaderText = "elektırık";
            this.elektırıkDataGridViewTextBoxColumn.Name = "elektırıkDataGridViewTextBoxColumn";
            // 
            // dogalgazDataGridViewTextBoxColumn
            // 
            this.dogalgazDataGridViewTextBoxColumn.DataPropertyName = "dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.HeaderText = "dogalgaz";
            this.dogalgazDataGridViewTextBoxColumn.Name = "dogalgazDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "su";
            this.suDataGridViewTextBoxColumn.HeaderText = "su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // mutfakDataGridViewTextBoxColumn
            // 
            this.mutfakDataGridViewTextBoxColumn.DataPropertyName = "mutfak";
            this.mutfakDataGridViewTextBoxColumn.HeaderText = "mutfak";
            this.mutfakDataGridViewTextBoxColumn.Name = "mutfakDataGridViewTextBoxColumn";
            // 
            // temızlıkDataGridViewTextBoxColumn
            // 
            this.temızlıkDataGridViewTextBoxColumn.DataPropertyName = "temızlık";
            this.temızlıkDataGridViewTextBoxColumn.HeaderText = "temızlık";
            this.temızlıkDataGridViewTextBoxColumn.Name = "temızlıkDataGridViewTextBoxColumn";
            // 
            // personelDataGridViewTextBoxColumn
            // 
            this.personelDataGridViewTextBoxColumn.DataPropertyName = "personel";
            this.personelDataGridViewTextBoxColumn.HeaderText = "personel";
            this.personelDataGridViewTextBoxColumn.Name = "personelDataGridViewTextBoxColumn";
            // 
            // tadılatDataGridViewTextBoxColumn
            // 
            this.tadılatDataGridViewTextBoxColumn.DataPropertyName = "tadılat";
            this.tadılatDataGridViewTextBoxColumn.HeaderText = "tadılat";
            this.tadılatDataGridViewTextBoxColumn.Name = "tadılatDataGridViewTextBoxColumn";
            // 
            // dıgerodemelerDataGridViewTextBoxColumn
            // 
            this.dıgerodemelerDataGridViewTextBoxColumn.DataPropertyName = "dıger_odemeler";
            this.dıgerodemelerDataGridViewTextBoxColumn.HeaderText = "dıger_odemeler";
            this.dıgerodemelerDataGridViewTextBoxColumn.Name = "dıgerodemelerDataGridViewTextBoxColumn";
            // 
            // gıderlerBindingSource
            // 
            this.gıderlerBindingSource.DataMember = "gıderler";
            this.gıderlerBindingSource.DataSource = this._194603017DataSet5;
            // 
            // _194603017DataSet5
            // 
            this._194603017DataSet5.DataSetName = "_194603017DataSet5";
            this._194603017DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gıderlerTableAdapter
            // 
            this.gıderlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmgıderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(880, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtd_odeme);
            this.Controls.Add(this.txtpersonel);
            this.Controls.Add(this.txtgaz);
            this.Controls.Add(this.txtsu);
            this.Controls.Add(this.txtmutfak);
            this.Controls.Add(this.txttadılat);
            this.Controls.Add(this.txttemizlik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtelektırık);
            this.Controls.Add(this.label1);
            this.Name = "frmgıderler";
            this.Text = "frmgıderler";
            this.Load += new System.EventHandler(this.frmgıderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıderlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtelektırık;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttemizlik;
        private System.Windows.Forms.TextBox txttadılat;
        private System.Windows.Forms.TextBox txtmutfak;
        private System.Windows.Forms.TextBox txtsu;
        private System.Windows.Forms.TextBox txtgaz;
        private System.Windows.Forms.TextBox txtpersonel;
        private System.Windows.Forms.TextBox txtd_odeme;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _194603017DataSet5 _194603017DataSet5;
        private System.Windows.Forms.BindingSource gıderlerBindingSource;
        private _194603017DataSet5TableAdapters.gıderlerTableAdapter gıderlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektırıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogalgazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutfakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temızlıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadılatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dıgerodemelerDataGridViewTextBoxColumn;
    }
}