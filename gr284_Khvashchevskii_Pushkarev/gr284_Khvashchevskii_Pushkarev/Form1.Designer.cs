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
            this.g284_l09_Khvashchevskii_PushkarevDataSet = new gr284_Khvashchevskii_Pushkarev.g284_l09_Khvashchevskii_PushkarevDataSet();
            this.pLANETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANETTableAdapter = new gr284_Khvashchevskii_Pushkarev.g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.PLANETTableAdapter();
            this.planetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceFromSunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhabitantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g284_l09_Khvashchevskii_PushkarevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planetNameDataGridViewTextBoxColumn,
            this.distanceFromSunDataGridViewTextBoxColumn,
            this.inhabitantsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pLANETBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Indigo;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // g284_l09_Khvashchevskii_PushkarevDataSet
            // 
            this.g284_l09_Khvashchevskii_PushkarevDataSet.DataSetName = "g284_l09_Khvashchevskii_PushkarevDataSet";
            this.g284_l09_Khvashchevskii_PushkarevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLANETBindingSource
            // 
            this.pLANETBindingSource.DataMember = "PLANET";
            this.pLANETBindingSource.DataSource = this.g284_l09_Khvashchevskii_PushkarevDataSet;
            // 
            // pLANETTableAdapter
            // 
            this.pLANETTableAdapter.ClearBeforeFill = true;
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
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.SkyBlue;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Indigo;
            this.Start.Location = new System.Drawing.Point(274, 287);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(81, 34);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(365, 333);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g284_l09_Khvashchevskii_PushkarevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private g284_l09_Khvashchevskii_PushkarevDataSet g284_l09_Khvashchevskii_PushkarevDataSet;
        private System.Windows.Forms.BindingSource pLANETBindingSource;
        private g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.PLANETTableAdapter pLANETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceFromSunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhabitantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Start;
    }
}

