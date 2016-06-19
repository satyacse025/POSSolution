namespace POS
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet = new POS.POSDataSet();
            this.productTableAdapter = new POS.POSDataSetTableAdapters.productTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pOSDataSet1 = new POS.POSDataSet1();
            this.productdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_detailsTableAdapter = new POS.POSDataSet1TableAdapters.product_detailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodetailsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maincateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pOSDataSet2 = new POS.POSDataSet2();
            this.product_detailsTableAdapter1 = new POS.POSDataSet2TableAdapters.product_detailsTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 80);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(-2, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 45);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(-2, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 433);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(1121, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 433);
            this.panel4.TabIndex = 4;
            // 
            // pOSDataSet1
            // 
            this.pOSDataSet1.DataSetName = "POSDataSet1";
            this.pOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productdetailsBindingSource
            // 
            this.productdetailsBindingSource.DataMember = "product_details";
            this.productdetailsBindingSource.DataSource = this.pOSDataSet1;
            // 
            // product_detailsTableAdapter
            // 
            this.product_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodetailsidDataGridViewTextBoxColumn,
            this.maincateidDataGridViewTextBoxColumn,
            this.cateidDataGridViewTextBoxColumn,
            this.subcateidDataGridViewTextBoxColumn,
            this.proidDataGridViewTextBoxColumn,
            this.purchasepriceDataGridViewTextBoxColumn,
            this.salepriceDataGridViewTextBoxColumn,
            this.prodstockDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productdetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(69, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 432);
            this.dataGridView1.TabIndex = 5;
            // 
            // prodetailsidDataGridViewTextBoxColumn
            // 
            this.prodetailsidDataGridViewTextBoxColumn.DataPropertyName = "pro_details_id";
            this.prodetailsidDataGridViewTextBoxColumn.HeaderText = "pro_details_id";
            this.prodetailsidDataGridViewTextBoxColumn.Name = "prodetailsidDataGridViewTextBoxColumn";
            this.prodetailsidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maincateidDataGridViewTextBoxColumn
            // 
            this.maincateidDataGridViewTextBoxColumn.DataPropertyName = "maincate_id";
            this.maincateidDataGridViewTextBoxColumn.HeaderText = "maincate_id";
            this.maincateidDataGridViewTextBoxColumn.Name = "maincateidDataGridViewTextBoxColumn";
            this.maincateidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cateidDataGridViewTextBoxColumn
            // 
            this.cateidDataGridViewTextBoxColumn.DataPropertyName = "cate_id";
            this.cateidDataGridViewTextBoxColumn.HeaderText = "cate_id";
            this.cateidDataGridViewTextBoxColumn.Name = "cateidDataGridViewTextBoxColumn";
            this.cateidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subcateidDataGridViewTextBoxColumn
            // 
            this.subcateidDataGridViewTextBoxColumn.DataPropertyName = "subcate_id";
            this.subcateidDataGridViewTextBoxColumn.HeaderText = "subcate_id";
            this.subcateidDataGridViewTextBoxColumn.Name = "subcateidDataGridViewTextBoxColumn";
            this.subcateidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proidDataGridViewTextBoxColumn
            // 
            this.proidDataGridViewTextBoxColumn.DataPropertyName = "pro_id";
            this.proidDataGridViewTextBoxColumn.HeaderText = "pro_id";
            this.proidDataGridViewTextBoxColumn.Name = "proidDataGridViewTextBoxColumn";
            this.proidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasepriceDataGridViewTextBoxColumn
            // 
            this.purchasepriceDataGridViewTextBoxColumn.DataPropertyName = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.HeaderText = "purchase_price";
            this.purchasepriceDataGridViewTextBoxColumn.Name = "purchasepriceDataGridViewTextBoxColumn";
            this.purchasepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salepriceDataGridViewTextBoxColumn
            // 
            this.salepriceDataGridViewTextBoxColumn.DataPropertyName = "sale_price";
            this.salepriceDataGridViewTextBoxColumn.HeaderText = "sale_price";
            this.salepriceDataGridViewTextBoxColumn.Name = "salepriceDataGridViewTextBoxColumn";
            this.salepriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodstockDataGridViewTextBoxColumn
            // 
            this.prodstockDataGridViewTextBoxColumn.DataPropertyName = "prod_stock";
            this.prodstockDataGridViewTextBoxColumn.HeaderText = "prod_stock";
            this.prodstockDataGridViewTextBoxColumn.Name = "prodstockDataGridViewTextBoxColumn";
            this.prodstockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productdetailsBindingSource1
            // 
            this.productdetailsBindingSource1.DataMember = "product_details";
            this.productdetailsBindingSource1.DataSource = this.pOSDataSet2;
            // 
            // pOSDataSet2
            // 
            this.pOSDataSet2.DataSetName = "POSDataSet2";
            this.pOSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_detailsTableAdapter1
            // 
            this.product_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(277, -11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 79);
            this.panel5.TabIndex = 0;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 521);
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduct";
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private POSDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private POSDataSet1 pOSDataSet1;
        private System.Windows.Forms.BindingSource productdetailsBindingSource;
        private POSDataSet1TableAdapters.product_detailsTableAdapter product_detailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private POSDataSet2 pOSDataSet2;
        private System.Windows.Forms.BindingSource productdetailsBindingSource1;
        private POSDataSet2TableAdapters.product_detailsTableAdapter product_detailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodetailsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maincateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
    }
}