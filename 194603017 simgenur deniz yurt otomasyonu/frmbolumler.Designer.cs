namespace _194603017_yurtotomasyon
{
    partial class frmbolumler
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
            this.txtbolumıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbolumadı = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._194603017DataSet = new _194603017_yurtotomasyon._194603017DataSet();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsıl = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.bolumlerTableAdapter = new _194603017_yurtotomasyon._194603017DataSetTableAdapters.bolumlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÖLÜM ID:";
            // 
            // txtbolumıd
            // 
            this.txtbolumıd.Location = new System.Drawing.Point(136, 37);
            this.txtbolumıd.Name = "txtbolumıd";
            this.txtbolumıd.Size = new System.Drawing.Size(162, 20);
            this.txtbolumıd.TabIndex = 1;
            this.txtbolumıd.TextChanged += new System.EventHandler(this.txtbolumıd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BÖLÜM ADI :";
            // 
            // txtbolumadı
            // 
            this.txtbolumadı.Location = new System.Drawing.Point(136, 63);
            this.txtbolumadı.Name = "txtbolumadı";
            this.txtbolumadı.Size = new System.Drawing.Size(162, 20);
            this.txtbolumadı.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumıdDataGridViewTextBoxColumn,
            this.bolumadıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 186);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumıdDataGridViewTextBoxColumn
            // 
            this.bolumıdDataGridViewTextBoxColumn.DataPropertyName = "bolum_ıd";
            this.bolumıdDataGridViewTextBoxColumn.HeaderText = "bolum_ıd";
            this.bolumıdDataGridViewTextBoxColumn.Name = "bolumıdDataGridViewTextBoxColumn";
            this.bolumıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumadıDataGridViewTextBoxColumn
            // 
            this.bolumadıDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumadıDataGridViewTextBoxColumn.DataPropertyName = "bolum_adı";
            this.bolumadıDataGridViewTextBoxColumn.HeaderText = "bolum_adı";
            this.bolumadıDataGridViewTextBoxColumn.Name = "bolumadıDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "bolumler";
            this.bolumlerBindingSource.DataSource = this._194603017DataSet;
            // 
            // _194603017DataSet
            // 
            this._194603017DataSet.DataSetName = "_194603017DataSet";
            this._194603017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 110);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(118, 47);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsıl
            // 
            this.btnsıl.Location = new System.Drawing.Point(160, 110);
            this.btnsıl.Name = "btnsıl";
            this.btnsıl.Size = new System.Drawing.Size(118, 47);
            this.btnsıl.TabIndex = 6;
            this.btnsıl.Text = "SİL";
            this.btnsıl.UseVisualStyleBackColor = true;
            this.btnsıl.Click += new System.EventHandler(this.btnsıl_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(301, 110);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(118, 47);
            this.btnguncelle.TabIndex = 7;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmbolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(431, 361);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsıl);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbolumadı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbolumıd);
            this.Controls.Add(this.label1);
            this.Name = "frmbolumler";
            this.Text = "frmbolumler";
            this.Load += new System.EventHandler(this.frmbolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbolumıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbolumadı;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsıl;
        private System.Windows.Forms.Button btnguncelle;
        private _194603017DataSet _194603017DataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private _194603017DataSetTableAdapters.bolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadıDataGridViewTextBoxColumn;
    }
}