namespace _194603017_yurtotomasyon
{
    partial class frmodemeler
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
            this.txtogr_ıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtodenen = new System.Windows.Forms.TextBox();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.btnodemeal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._194603017DataSet2 = new _194603017_yurtotomasyon._194603017DataSet2();
            this.odemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odemelerTableAdapter = new _194603017_yurtotomasyon._194603017DataSet2TableAdapters.odemelerTableAdapter();
            this.ogrencııdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencıadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencısoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencıborcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖGRENCI ID :";
            // 
            // txtogr_ıd
            // 
            this.txtogr_ıd.Location = new System.Drawing.Point(94, 12);
            this.txtogr_ıd.Name = "txtogr_ıd";
            this.txtogr_ıd.Size = new System.Drawing.Size(130, 20);
            this.txtogr_ıd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÖDENEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "KALAN :";
            // 
            // txtodenen
            // 
            this.txtodenen.Location = new System.Drawing.Point(94, 58);
            this.txtodenen.Name = "txtodenen";
            this.txtodenen.Size = new System.Drawing.Size(130, 20);
            this.txtodenen.TabIndex = 4;
            // 
            // txtkalan
            // 
            this.txtkalan.Location = new System.Drawing.Point(94, 104);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(130, 20);
            this.txtkalan.TabIndex = 5;
            // 
            // btnodemeal
            // 
            this.btnodemeal.Location = new System.Drawing.Point(249, 35);
            this.btnodemeal.Name = "btnodemeal";
            this.btnodemeal.Size = new System.Drawing.Size(120, 85);
            this.btnodemeal.TabIndex = 6;
            this.btnodemeal.Text = "ÖDEME AL";
            this.btnodemeal.UseVisualStyleBackColor = true;
            this.btnodemeal.Click += new System.EventHandler(this.btnodemeal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrencııdDataGridViewTextBoxColumn,
            this.ogrencıadıDataGridViewTextBoxColumn,
            this.ogrencısoyadıDataGridViewTextBoxColumn,
            this.ogrencıborcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 205);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // _194603017DataSet2
            // 
            this._194603017DataSet2.DataSetName = "_194603017DataSet2";
            this._194603017DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odemelerBindingSource
            // 
            this.odemelerBindingSource.DataMember = "odemeler";
            this.odemelerBindingSource.DataSource = this._194603017DataSet2;
            // 
            // odemelerTableAdapter
            // 
            this.odemelerTableAdapter.ClearBeforeFill = true;
            // 
            // ogrencııdDataGridViewTextBoxColumn
            // 
            this.ogrencııdDataGridViewTextBoxColumn.DataPropertyName = "ogrencı_ıd";
            this.ogrencııdDataGridViewTextBoxColumn.HeaderText = "ogrencı_ıd";
            this.ogrencııdDataGridViewTextBoxColumn.Name = "ogrencııdDataGridViewTextBoxColumn";
            // 
            // ogrencıadıDataGridViewTextBoxColumn
            // 
            this.ogrencıadıDataGridViewTextBoxColumn.DataPropertyName = "ogrencı_adı";
            this.ogrencıadıDataGridViewTextBoxColumn.HeaderText = "ogrencı_adı";
            this.ogrencıadıDataGridViewTextBoxColumn.Name = "ogrencıadıDataGridViewTextBoxColumn";
            // 
            // ogrencısoyadıDataGridViewTextBoxColumn
            // 
            this.ogrencısoyadıDataGridViewTextBoxColumn.DataPropertyName = "ogrencı_soyadı";
            this.ogrencısoyadıDataGridViewTextBoxColumn.HeaderText = "ogrencı_soyadı";
            this.ogrencısoyadıDataGridViewTextBoxColumn.Name = "ogrencısoyadıDataGridViewTextBoxColumn";
            // 
            // ogrencıborcDataGridViewTextBoxColumn
            // 
            this.ogrencıborcDataGridViewTextBoxColumn.DataPropertyName = "ogrencı_borc";
            this.ogrencıborcDataGridViewTextBoxColumn.HeaderText = "ogrencı_borc";
            this.ogrencıborcDataGridViewTextBoxColumn.Name = "ogrencıborcDataGridViewTextBoxColumn";
            // 
            // frmodemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(450, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnodemeal);
            this.Controls.Add(this.txtkalan);
            this.Controls.Add(this.txtodenen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtogr_ıd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmodemeler";
            this.Text = "frmodemeler";
            this.Load += new System.EventHandler(this.frmodemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtogr_ıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtodenen;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.Button btnodemeal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _194603017DataSet2 _194603017DataSet2;
        private System.Windows.Forms.BindingSource odemelerBindingSource;
        private _194603017DataSet2TableAdapters.odemelerTableAdapter odemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencııdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencıadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencısoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencıborcDataGridViewTextBoxColumn;
    }
}