namespace _194603017_yurtotomasyon
{
    partial class frmgıderlistesi
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
            this._194603017DataSet4 = new _194603017_yurtotomasyon._194603017DataSet4();
            this.gıderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gıderlerTableAdapter = new _194603017_yurtotomasyon._194603017DataSet4TableAdapters.gıderlerTableAdapter();
            this.odemeıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektırıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogalgazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutfakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temızlıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadılatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dıgerodemelerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıderlerBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // _194603017DataSet4
            // 
            this._194603017DataSet4.DataSetName = "_194603017DataSet4";
            this._194603017DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gıderlerBindingSource
            // 
            this.gıderlerBindingSource.DataMember = "gıderler";
            this.gıderlerBindingSource.DataSource = this._194603017DataSet4;
            // 
            // gıderlerTableAdapter
            // 
            this.gıderlerTableAdapter.ClearBeforeFill = true;
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
            // frmgıderlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 231);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgıderlistesi";
            this.Text = "frmgıderlistesi";
            this.Load += new System.EventHandler(this.frmgıderlistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._194603017DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıderlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _194603017DataSet4 _194603017DataSet4;
        private System.Windows.Forms.BindingSource gıderlerBindingSource;
        private _194603017DataSet4TableAdapters.gıderlerTableAdapter gıderlerTableAdapter;
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