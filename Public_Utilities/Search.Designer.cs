namespace Public_Utilities
{
    partial class Search
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
            this.full = new Public_Utilities.Full();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.readingS1TableAdapter1 = new Public_Utilities.FullTableAdapters.READINGS1TableAdapter();
            this.full1 = new Public_Utilities.Full();
            this.rEADINGS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLICUTILITIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pUBLIC_UTILITIESTableAdapter = new Public_Utilities.FullTableAdapters.PUBLIC_UTILITIESTableAdapter();
            this.rEADIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEADMETERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.METER_PU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rEADVALUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEADDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.full1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADINGS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICUTILITIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEADIDDataGridViewTextBoxColumn,
            this.rEADMETERDataGridViewTextBoxColumn,
            this.METER_PU,
            this.rEADVALUEDataGridViewTextBoxColumn,
            this.rEADDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEADINGS1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // full
            // 
            this.full.DataSetName = "Full";
            this.full.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(28, 23);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(159, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(193, 21);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(75, 23);
            this.Find.TabIndex = 2;
            this.Find.Text = "Искать";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // readingS1TableAdapter1
            // 
            this.readingS1TableAdapter1.ClearBeforeFill = true;
            // 
            // full1
            // 
            this.full1.DataSetName = "Full";
            this.full1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEADINGS1BindingSource
            // 
            this.rEADINGS1BindingSource.DataMember = "READINGS1";
            this.rEADINGS1BindingSource.DataSource = this.full1;
            // 
            // pUBLICUTILITIESBindingSource
            // 
            this.pUBLICUTILITIESBindingSource.DataMember = "PUBLIC_UTILITIES";
            this.pUBLICUTILITIESBindingSource.DataSource = this.full1;
            // 
            // pUBLIC_UTILITIESTableAdapter
            // 
            this.pUBLIC_UTILITIESTableAdapter.ClearBeforeFill = true;
            // 
            // rEADIDDataGridViewTextBoxColumn
            // 
            this.rEADIDDataGridViewTextBoxColumn.DataPropertyName = "READ_ID";
            this.rEADIDDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.rEADIDDataGridViewTextBoxColumn.Name = "rEADIDDataGridViewTextBoxColumn";
            // 
            // rEADMETERDataGridViewTextBoxColumn
            // 
            this.rEADMETERDataGridViewTextBoxColumn.DataPropertyName = "READ_METER";
            this.rEADMETERDataGridViewTextBoxColumn.HeaderText = "Счетчик";
            this.rEADMETERDataGridViewTextBoxColumn.Name = "rEADMETERDataGridViewTextBoxColumn";
            // 
            // METER_PU
            // 
            this.METER_PU.DataPropertyName = "METER_PU";
            this.METER_PU.DataSource = this.pUBLICUTILITIESBindingSource;
            this.METER_PU.DisplayMember = "PU_NAME";
            this.METER_PU.HeaderText = "Услуга";
            this.METER_PU.Name = "METER_PU";
            this.METER_PU.ValueMember = "PU_ID";
            // 
            // rEADVALUEDataGridViewTextBoxColumn
            // 
            this.rEADVALUEDataGridViewTextBoxColumn.DataPropertyName = "READ_VALUE";
            this.rEADVALUEDataGridViewTextBoxColumn.HeaderText = "Показание";
            this.rEADVALUEDataGridViewTextBoxColumn.Name = "rEADVALUEDataGridViewTextBoxColumn";
            // 
            // rEADDATEDataGridViewTextBoxColumn
            // 
            this.rEADDATEDataGridViewTextBoxColumn.DataPropertyName = "READ_DATE";
            this.rEADDATEDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.rEADDATEDataGridViewTextBoxColumn.Name = "rEADDATEDataGridViewTextBoxColumn";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 296);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search";
            this.Text = "Показания по квартире";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.full1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADINGS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUBLICUTILITIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Full full;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.BindingSource rEADINGS1BindingSource;
        private Full full1;
        private FullTableAdapters.READINGS1TableAdapter readingS1TableAdapter1;
        private System.Windows.Forms.BindingSource pUBLICUTILITIESBindingSource;
        private FullTableAdapters.PUBLIC_UTILITIESTableAdapter pUBLIC_UTILITIESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEADIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEADMETERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn METER_PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEADVALUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEADDATEDataGridViewTextBoxColumn;
    }
}