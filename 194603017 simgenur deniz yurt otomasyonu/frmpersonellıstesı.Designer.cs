namespace _194603017_yurtotomasyon
{
    partial class frmpersonellıstesı
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._194603017DataSet11 = new _194603017_yurtotomasyon._194603017DataSet11();
            this.personellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personellTableAdapter = new _194603017_yurtotomasyon._194603017DataSet11TableAdapters.personellTableAdapter();
            this.personelıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeldepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelıdDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelsoyadıDataGridViewTextBoxColumn,
            this.personeltelDataGridViewTextBoxColumn,
            this.personeldepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personellBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // _194603017DataSet11
            // 
            this._194603017DataSet11.DataSetName = "_194603017DataSet11";
            this._194603017DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personellBindingSource
            // 
            this.personellBindingSource.DataMember = "personell";
            this.personellBindingSource.DataSource = this._194603017DataSet11;
            // 
            // personellTableAdapter
            // 
            this.personellTableAdapter.ClearBeforeFill = true;
            // 
            // personelıdDataGridViewTextBoxColumn
            // 
            this.personelıdDataGridViewTextBoxColumn.DataPropertyName = "personel_ıd";
            this.personelıdDataGridViewTextBoxColumn.HeaderText = "personel_ıd";
            this.personelıdDataGridViewTextBoxColumn.Name = "personelıdDataGridViewTextBoxColumn";
            this.personelıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "personel_Ad";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "personel_Ad";
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelsoyadıDataGridViewTextBoxColumn
            // 
            this.personelsoyadıDataGridViewTextBoxColumn.DataPropertyName = "personel_soyadı";
            this.personelsoyadıDataGridViewTextBoxColumn.HeaderText = "personel_soyadı";
            this.personelsoyadıDataGridViewTextBoxColumn.Name = "personelsoyadıDataGridViewTextBoxColumn";
            // 
            // personeltelDataGridViewTextBoxColumn
            // 
            this.personeltelDataGridViewTextBoxColumn.DataPropertyName = "personel_tel";
            this.personeltelDataGridViewTextBoxColumn.HeaderText = "personel_tel";
            this.personeltelDataGridViewTextBoxColumn.Name = "personeltelDataGridViewTextBoxColumn";
            // 
            // personeldepartmanDataGridViewTextBoxColumn
            // 
            this.personeldepartmanDataGridViewTextBoxColumn.DataPropertyName = "personel_departman";
            this.personeldepartmanDataGridViewTextBoxColumn.HeaderText = "personel_departman";
            this.personeldepartmanDataGridViewTextBoxColumn.Name = "personeldepartmanDataGridViewTextBoxColumn";
            // 
            // frmpersonellıstesı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 311);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmpersonellıstesı";
            this.Text = "frmpersonellıstesı";
            this.Load += new System.EventHandler(this.frmpersonellıstesı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _194603017DataSet11 _194603017DataSet11;
        private System.Windows.Forms.BindingSource personellBindingSource;
        private _194603017DataSet11TableAdapters.personellTableAdapter personellTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeltelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeldepartmanDataGridViewTextBoxColumn;
    }
}