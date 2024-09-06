namespace kursovoymips
{
    partial class FormRep2
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
            this.database1DataSet = new kursovoymips.Database1DataSet();
            this.zAKRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zAKRTableAdapter = new kursovoymips.Database1DataSetTableAdapters.ZAKRTableAdapter();
            this.tableAdapterManager = new kursovoymips.Database1DataSetTableAdapters.TableAdapterManager();
            this.oTVTableAdapter = new kursovoymips.Database1DataSetTableAdapters.OTVTableAdapter();
            this.sRSVTableAdapter = new kursovoymips.Database1DataSetTableAdapters.SRSVTableAdapter();
            this.oTVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_SRSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAZV_SRSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VID_SRSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_OTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAKRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zAKRBindingSource
            // 
            this.zAKRBindingSource.DataMember = "ZAKR";
            this.zAKRBindingSource.DataSource = this.database1DataSet;
            // 
            // zAKRTableAdapter
            // 
            this.zAKRTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NALTableAdapter = null;
            this.tableAdapterManager.OTVTableAdapter = this.oTVTableAdapter;
            this.tableAdapterManager.PEREDTableAdapter = null;
            this.tableAdapterManager.PODRTableAdapter = null;
            this.tableAdapterManager.POSTTableAdapter = null;
            this.tableAdapterManager.REMTableAdapter = null;
            this.tableAdapterManager.SRSVTableAdapter = this.sRSVTableAdapter;
            this.tableAdapterManager.UpdateOrder = kursovoymips.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZAKRTableAdapter = this.zAKRTableAdapter;
            // 
            // oTVTableAdapter
            // 
            this.oTVTableAdapter.ClearBeforeFill = true;
            // 
            // sRSVTableAdapter
            // 
            this.sRSVTableAdapter.ClearBeforeFill = true;
            // 
            // oTVBindingSource
            // 
            this.oTVBindingSource.DataMember = "OTV";
            this.oTVBindingSource.DataSource = this.database1DataSet;
            // 
            // sRSVBindingSource
            // 
            this.sRSVBindingSource.DataMember = "SRSV";
            this.sRSVBindingSource.DataSource = this.database1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SRSV,
            this.NAZV_SRSV,
            this.VID_SRSV,
            this.ID_OTV,
            this.FIO});
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(519, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_SRSV
            // 
            this.ID_SRSV.HeaderText = "Номер средства связи";
            this.ID_SRSV.Name = "ID_SRSV";
            // 
            // NAZV_SRSV
            // 
            this.NAZV_SRSV.HeaderText = "Название средства связи";
            this.NAZV_SRSV.Name = "NAZV_SRSV";
            // 
            // VID_SRSV
            // 
            this.VID_SRSV.HeaderText = "Вид средства связи";
            this.VID_SRSV.Name = "VID_SRSV";
            // 
            // ID_OTV
            // 
            this.ID_OTV.HeaderText = "Номер ответственного лица";
            this.ID_OTV.Name = "ID_OTV";
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // FormRep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 327);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRep2";
            this.Text = "Отчет о видах средств связи и закреплении средств связи за ответственными лицами";
            this.Load += new System.EventHandler(this.FormRep2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAKRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oTVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource zAKRBindingSource;
        private Database1DataSetTableAdapters.ZAKRTableAdapter zAKRTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.OTVTableAdapter oTVTableAdapter;
        private System.Windows.Forms.BindingSource oTVBindingSource;
        private Database1DataSetTableAdapters.SRSVTableAdapter sRSVTableAdapter;
        private System.Windows.Forms.BindingSource sRSVBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SRSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAZV_SRSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn VID_SRSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
    }
}