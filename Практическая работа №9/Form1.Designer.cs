namespace WindowsFormsApplication3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.g284_l09_Khvashchevskii_PushkarevDataSet = new WindowsFormsApplication3.g284_l09_Khvashchevskii_PushkarevDataSet();
            this.pLANETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANETTableAdapter = new WindowsFormsApplication3.g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.PLANETTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.TableAdapterManager();
            this.pLANETBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pLANETBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pLANETDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.g284_l09_Khvashchevskii_PushkarevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETBindingNavigator)).BeginInit();
            this.pLANETBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PLANETTableAdapter = this.pLANETTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLANETBindingNavigator
            // 
            this.pLANETBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pLANETBindingNavigator.BindingSource = this.pLANETBindingSource;
            this.pLANETBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pLANETBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pLANETBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pLANETBindingNavigatorSaveItem});
            this.pLANETBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pLANETBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pLANETBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pLANETBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pLANETBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pLANETBindingNavigator.Name = "pLANETBindingNavigator";
            this.pLANETBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pLANETBindingNavigator.Size = new System.Drawing.Size(739, 25);
            this.pLANETBindingNavigator.TabIndex = 0;
            this.pLANETBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pLANETBindingNavigatorSaveItem
            // 
            this.pLANETBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pLANETBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pLANETBindingNavigatorSaveItem.Image")));
            this.pLANETBindingNavigatorSaveItem.Name = "pLANETBindingNavigatorSaveItem";
            this.pLANETBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pLANETBindingNavigatorSaveItem.Text = "Save Data";
            this.pLANETBindingNavigatorSaveItem.Click += new System.EventHandler(this.pLANETBindingNavigatorSaveItem_Click);
            // 
            // pLANETDataGridView
            // 
            this.pLANETDataGridView.AutoGenerateColumns = false;
            this.pLANETDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pLANETDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pLANETDataGridView.DataSource = this.pLANETBindingSource;
            this.pLANETDataGridView.Location = new System.Drawing.Point(29, 47);
            this.pLANETDataGridView.Name = "pLANETDataGridView";
            this.pLANETDataGridView.Size = new System.Drawing.Size(344, 140);
            this.pLANETDataGridView.TabIndex = 1;
            this.pLANETDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pLANETDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlanetName";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlanetName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DistanceFromSun";
            this.dataGridViewTextBoxColumn2.HeaderText = "DistanceFromSun";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Inhabitants";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inhabitants";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pLANETDataGridView);
            this.Controls.Add(this.pLANETBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g284_l09_Khvashchevskii_PushkarevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETBindingNavigator)).EndInit();
            this.pLANETBindingNavigator.ResumeLayout(false);
            this.pLANETBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLANETDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private g284_l09_Khvashchevskii_PushkarevDataSet g284_l09_Khvashchevskii_PushkarevDataSet;
        private System.Windows.Forms.BindingSource pLANETBindingSource;
        private g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.PLANETTableAdapter pLANETTableAdapter;
        private g284_l09_Khvashchevskii_PushkarevDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pLANETBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pLANETBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pLANETDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}

