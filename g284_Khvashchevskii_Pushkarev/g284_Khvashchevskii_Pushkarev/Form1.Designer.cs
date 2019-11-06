namespace g284_Khvashchevskii_Pushkarev
{
    partial class Form1
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
            this.g284_l009_Khvashchevskii_PushkarevDataSet = new g284_Khvashchevskii_Pushkarev.g284_l009_Khvashchevskii_PushkarevDataSet();
            this.planetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planetTableAdapter = new g284_Khvashchevskii_Pushkarev.g284_l009_Khvashchevskii_PushkarevDataSetTableAdapters.PlanetTableAdapter();
            this.planetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceFromSunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhabitantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g284_l009_Khvashchevskii_PushkarevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planetNameDataGridViewTextBoxColumn,
            this.distanceFromSunDataGridViewTextBoxColumn,
            this.inhabitantsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.planetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // g284_l009_Khvashchevskii_PushkarevDataSet
            // 
            this.g284_l009_Khvashchevskii_PushkarevDataSet.DataSetName = "g284_l009_Khvashchevskii_PushkarevDataSet";
            this.g284_l009_Khvashchevskii_PushkarevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planetBindingSource
            // 
            this.planetBindingSource.DataMember = "Planet";
            this.planetBindingSource.DataSource = this.g284_l009_Khvashchevskii_PushkarevDataSet;
            // 
            // planetTableAdapter
            // 
            this.planetTableAdapter.ClearBeforeFill = true;
            // 
            // planetNameDataGridViewTextBoxColumn
            // 
            this.planetNameDataGridViewTextBoxColumn.DataPropertyName = "PlanetName";
            this.planetNameDataGridViewTextBoxColumn.HeaderText = "PlanetName";
            this.planetNameDataGridViewTextBoxColumn.Name = "planetNameDataGridViewTextBoxColumn";
            // 
            // distanceFromSunDataGridViewTextBoxColumn
            // 
            this.distanceFromSunDataGridViewTextBoxColumn.DataPropertyName = "DistanceFromSun";
            this.distanceFromSunDataGridViewTextBoxColumn.HeaderText = "DistanceFromSun";
            this.distanceFromSunDataGridViewTextBoxColumn.Name = "distanceFromSunDataGridViewTextBoxColumn";
            // 
            // inhabitantsDataGridViewTextBoxColumn
            // 
            this.inhabitantsDataGridViewTextBoxColumn.DataPropertyName = "Inhabitants";
            this.inhabitantsDataGridViewTextBoxColumn.HeaderText = "Inhabitants";
            this.inhabitantsDataGridViewTextBoxColumn.Name = "inhabitantsDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(-4, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g284_l009_Khvashchevskii_PushkarevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private g284_l009_Khvashchevskii_PushkarevDataSet g284_l009_Khvashchevskii_PushkarevDataSet;
        private System.Windows.Forms.BindingSource planetBindingSource;
        private g284_l009_Khvashchevskii_PushkarevDataSetTableAdapters.PlanetTableAdapter planetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceFromSunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhabitantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

