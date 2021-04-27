namespace Northwind.WebFormsUI
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
			this.dgwProducts = new System.Windows.Forms.DataGridView();
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.gbxSearch = new System.Windows.Forms.GroupBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.gbxAddNewProduct = new System.Windows.Forms.GroupBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblCategoryId = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblUnitsInStock = new System.Windows.Forms.Label();
			this.lblQuantityPerUnit = new System.Windows.Forms.Label();
			this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
			this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
			this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
			this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
			this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
			this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
			this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
			this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
			this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
			this.lblProductNameUpdate = new System.Windows.Forms.Label();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			this.lblDeleteProduct = new System.Windows.Forms.Label();
			this.gbxDeleteProduct = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
			this.gbxCategory.SuspendLayout();
			this.gbxSearch.SuspendLayout();
			this.gbxAddNewProduct.SuspendLayout();
			this.gbxUpdateProduct.SuspendLayout();
			this.gbxDeleteProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProducts
			// 
			this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProducts.Location = new System.Drawing.Point(12, 27);
			this.dgwProducts.Name = "dgwProducts";
			this.dgwProducts.Size = new System.Drawing.Size(816, 190);
			this.dgwProducts.TabIndex = 0;
			this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(596, 234);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(232, 57);
			this.gbxCategory.TabIndex = 4;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "List by Category";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(64, 24);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(153, 21);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(6, 27);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(52, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category:";
			// 
			// gbxSearch
			// 
			this.gbxSearch.Controls.Add(this.lblSearch);
			this.gbxSearch.Controls.Add(this.tbxSearch);
			this.gbxSearch.Location = new System.Drawing.Point(596, 297);
			this.gbxSearch.Name = "gbxSearch";
			this.gbxSearch.Size = new System.Drawing.Size(232, 57);
			this.gbxSearch.TabIndex = 5;
			this.gbxSearch.TabStop = false;
			this.gbxSearch.Text = "Search by Name";
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(6, 27);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(44, 13);
			this.lblSearch.TabIndex = 2;
			this.lblSearch.Text = "Search:";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Location = new System.Drawing.Point(64, 24);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(153, 20);
			this.tbxSearch.TabIndex = 1;
			this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
			// 
			// gbxAddNewProduct
			// 
			this.gbxAddNewProduct.Controls.Add(this.btnAddProduct);
			this.gbxAddNewProduct.Controls.Add(this.tbxQuantityPerUnitAdd);
			this.gbxAddNewProduct.Controls.Add(this.tbxUnitsInStockAdd);
			this.gbxAddNewProduct.Controls.Add(this.tbxUnitPriceAdd);
			this.gbxAddNewProduct.Controls.Add(this.tbxProductNameAdd);
			this.gbxAddNewProduct.Controls.Add(this.cbxCategoryAdd);
			this.gbxAddNewProduct.Controls.Add(this.lblQuantityPerUnit);
			this.gbxAddNewProduct.Controls.Add(this.lblUnitsInStock);
			this.gbxAddNewProduct.Controls.Add(this.lblUnitPrice);
			this.gbxAddNewProduct.Controls.Add(this.lblCategoryId);
			this.gbxAddNewProduct.Controls.Add(this.lblProductName);
			this.gbxAddNewProduct.Location = new System.Drawing.Point(12, 234);
			this.gbxAddNewProduct.Name = "gbxAddNewProduct";
			this.gbxAddNewProduct.Size = new System.Drawing.Size(280, 194);
			this.gbxAddNewProduct.TabIndex = 6;
			this.gbxAddNewProduct.TabStop = false;
			this.gbxAddNewProduct.Text = "Add New Product";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(7, 26);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(75, 13);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Product Name";
			// 
			// lblCategoryId
			// 
			this.lblCategoryId.AutoSize = true;
			this.lblCategoryId.Location = new System.Drawing.Point(7, 53);
			this.lblCategoryId.Name = "lblCategoryId";
			this.lblCategoryId.Size = new System.Drawing.Size(61, 13);
			this.lblCategoryId.TabIndex = 1;
			this.lblCategoryId.Text = "Category Id";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(7, 80);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
			this.lblUnitPrice.TabIndex = 2;
			this.lblUnitPrice.Text = "Unit Price";
			// 
			// lblUnitsInStock
			// 
			this.lblUnitsInStock.AutoSize = true;
			this.lblUnitsInStock.Location = new System.Drawing.Point(7, 107);
			this.lblUnitsInStock.Name = "lblUnitsInStock";
			this.lblUnitsInStock.Size = new System.Drawing.Size(73, 13);
			this.lblUnitsInStock.TabIndex = 3;
			this.lblUnitsInStock.Text = "Units in Stock";
			// 
			// lblQuantityPerUnit
			// 
			this.lblQuantityPerUnit.AutoSize = true;
			this.lblQuantityPerUnit.Location = new System.Drawing.Point(7, 134);
			this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
			this.lblQuantityPerUnit.Size = new System.Drawing.Size(86, 13);
			this.lblQuantityPerUnit.TabIndex = 4;
			this.lblQuantityPerUnit.Text = "Quantity per Unit";
			// 
			// cbxCategoryAdd
			// 
			this.cbxCategoryAdd.FormattingEnabled = true;
			this.cbxCategoryAdd.Location = new System.Drawing.Point(108, 52);
			this.cbxCategoryAdd.Name = "cbxCategoryAdd";
			this.cbxCategoryAdd.Size = new System.Drawing.Size(153, 21);
			this.cbxCategoryAdd.TabIndex = 2;
			// 
			// tbxProductNameAdd
			// 
			this.tbxProductNameAdd.Location = new System.Drawing.Point(108, 26);
			this.tbxProductNameAdd.Name = "tbxProductNameAdd";
			this.tbxProductNameAdd.Size = new System.Drawing.Size(153, 20);
			this.tbxProductNameAdd.TabIndex = 5;
			// 
			// tbxUnitPriceAdd
			// 
			this.tbxUnitPriceAdd.Location = new System.Drawing.Point(108, 79);
			this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
			this.tbxUnitPriceAdd.Size = new System.Drawing.Size(153, 20);
			this.tbxUnitPriceAdd.TabIndex = 6;
			// 
			// tbxUnitsInStockAdd
			// 
			this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(108, 105);
			this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
			this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(153, 20);
			this.tbxUnitsInStockAdd.TabIndex = 7;
			// 
			// tbxQuantityPerUnitAdd
			// 
			this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(108, 131);
			this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
			this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(153, 20);
			this.tbxQuantityPerUnitAdd.TabIndex = 8;
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(157, 157);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(55, 23);
			this.btnAddProduct.TabIndex = 9;
			this.btnAddProduct.Text = "Add";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// gbxUpdateProduct
			// 
			this.gbxUpdateProduct.Controls.Add(this.btnUpdateProduct);
			this.gbxUpdateProduct.Controls.Add(this.tbxQuantityPerUnitUpdate);
			this.gbxUpdateProduct.Controls.Add(this.tbxUnitsInStockUpdate);
			this.gbxUpdateProduct.Controls.Add(this.tbxUnitPriceUpdate);
			this.gbxUpdateProduct.Controls.Add(this.tbxProductNameUpdate);
			this.gbxUpdateProduct.Controls.Add(this.cbxCategoryUpdate);
			this.gbxUpdateProduct.Controls.Add(this.lblQuantityPerUnitUpdate);
			this.gbxUpdateProduct.Controls.Add(this.lblUnitsInStockUpdate);
			this.gbxUpdateProduct.Controls.Add(this.lblUnitPriceUpdate);
			this.gbxUpdateProduct.Controls.Add(this.lblCategoryIdUpdate);
			this.gbxUpdateProduct.Controls.Add(this.lblProductNameUpdate);
			this.gbxUpdateProduct.Location = new System.Drawing.Point(304, 234);
			this.gbxUpdateProduct.Name = "gbxUpdateProduct";
			this.gbxUpdateProduct.Size = new System.Drawing.Size(280, 194);
			this.gbxUpdateProduct.TabIndex = 10;
			this.gbxUpdateProduct.TabStop = false;
			this.gbxUpdateProduct.Text = "Update Product";
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.Location = new System.Drawing.Point(157, 157);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(55, 23);
			this.btnUpdateProduct.TabIndex = 9;
			this.btnUpdateProduct.Text = "Update";
			this.btnUpdateProduct.UseVisualStyleBackColor = true;
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			// 
			// tbxQuantityPerUnitUpdate
			// 
			this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(108, 131);
			this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
			this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(153, 20);
			this.tbxQuantityPerUnitUpdate.TabIndex = 8;
			// 
			// tbxUnitsInStockUpdate
			// 
			this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(108, 105);
			this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
			this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(153, 20);
			this.tbxUnitsInStockUpdate.TabIndex = 7;
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(108, 79);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(153, 20);
			this.tbxUnitPriceUpdate.TabIndex = 6;
			// 
			// tbxProductNameUpdate
			// 
			this.tbxProductNameUpdate.Location = new System.Drawing.Point(108, 26);
			this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
			this.tbxProductNameUpdate.Size = new System.Drawing.Size(153, 20);
			this.tbxProductNameUpdate.TabIndex = 5;
			// 
			// cbxCategoryUpdate
			// 
			this.cbxCategoryUpdate.FormattingEnabled = true;
			this.cbxCategoryUpdate.Location = new System.Drawing.Point(108, 52);
			this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
			this.cbxCategoryUpdate.Size = new System.Drawing.Size(153, 21);
			this.cbxCategoryUpdate.TabIndex = 2;
			// 
			// lblQuantityPerUnitUpdate
			// 
			this.lblQuantityPerUnitUpdate.AutoSize = true;
			this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(7, 134);
			this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
			this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(86, 13);
			this.lblQuantityPerUnitUpdate.TabIndex = 4;
			this.lblQuantityPerUnitUpdate.Text = "Quantity per Unit";
			// 
			// lblUnitsInStockUpdate
			// 
			this.lblUnitsInStockUpdate.AutoSize = true;
			this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(7, 107);
			this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
			this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(73, 13);
			this.lblUnitsInStockUpdate.TabIndex = 3;
			this.lblUnitsInStockUpdate.Text = "Units in Stock";
			// 
			// lblUnitPriceUpdate
			// 
			this.lblUnitPriceUpdate.AutoSize = true;
			this.lblUnitPriceUpdate.Location = new System.Drawing.Point(7, 80);
			this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
			this.lblUnitPriceUpdate.Size = new System.Drawing.Size(53, 13);
			this.lblUnitPriceUpdate.TabIndex = 2;
			this.lblUnitPriceUpdate.Text = "Unit Price";
			// 
			// lblCategoryIdUpdate
			// 
			this.lblCategoryIdUpdate.AutoSize = true;
			this.lblCategoryIdUpdate.Location = new System.Drawing.Point(7, 53);
			this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
			this.lblCategoryIdUpdate.Size = new System.Drawing.Size(61, 13);
			this.lblCategoryIdUpdate.TabIndex = 1;
			this.lblCategoryIdUpdate.Text = "Category Id";
			// 
			// lblProductNameUpdate
			// 
			this.lblProductNameUpdate.AutoSize = true;
			this.lblProductNameUpdate.Location = new System.Drawing.Point(7, 26);
			this.lblProductNameUpdate.Name = "lblProductNameUpdate";
			this.lblProductNameUpdate.Size = new System.Drawing.Size(75, 13);
			this.lblProductNameUpdate.TabIndex = 0;
			this.lblProductNameUpdate.Text = "Product Name";
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Location = new System.Drawing.Point(677, 393);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(74, 28);
			this.btnRemoveProduct.TabIndex = 10;
			this.btnRemoveProduct.Text = "Remove";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
			// 
			// lblDeleteProduct
			// 
			this.lblDeleteProduct.AutoSize = true;
			this.lblDeleteProduct.Location = new System.Drawing.Point(13, 12);
			this.lblDeleteProduct.Name = "lblDeleteProduct";
			this.lblDeleteProduct.Size = new System.Drawing.Size(204, 13);
			this.lblDeleteProduct.TabIndex = 11;
			this.lblDeleteProduct.Text = "Select the product from table to remove it.";
			// 
			// gbxDeleteProduct
			// 
			this.gbxDeleteProduct.Controls.Add(this.lblDeleteProduct);
			this.gbxDeleteProduct.Location = new System.Drawing.Point(596, 361);
			this.gbxDeleteProduct.Name = "gbxDeleteProduct";
			this.gbxDeleteProduct.Size = new System.Drawing.Size(232, 67);
			this.gbxDeleteProduct.TabIndex = 12;
			this.gbxDeleteProduct.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(851, 460);
			this.Controls.Add(this.btnRemoveProduct);
			this.Controls.Add(this.gbxUpdateProduct);
			this.Controls.Add(this.gbxAddNewProduct);
			this.Controls.Add(this.gbxSearch);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.dgwProducts);
			this.Controls.Add(this.gbxDeleteProduct);
			this.Name = "Form1";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxSearch.ResumeLayout(false);
			this.gbxSearch.PerformLayout();
			this.gbxAddNewProduct.ResumeLayout(false);
			this.gbxAddNewProduct.PerformLayout();
			this.gbxUpdateProduct.ResumeLayout(false);
			this.gbxUpdateProduct.PerformLayout();
			this.gbxDeleteProduct.ResumeLayout(false);
			this.gbxDeleteProduct.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgwProducts;
		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.GroupBox gbxSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.GroupBox gbxAddNewProduct;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblQuantityPerUnit;
		private System.Windows.Forms.Label lblUnitsInStock;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblCategoryId;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
		private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
		private System.Windows.Forms.TextBox tbxUnitPriceAdd;
		private System.Windows.Forms.TextBox tbxProductNameAdd;
		private System.Windows.Forms.ComboBox cbxCategoryAdd;
		private System.Windows.Forms.GroupBox gbxUpdateProduct;
		private System.Windows.Forms.Button btnUpdateProduct;
		private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
		private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
		private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
		private System.Windows.Forms.TextBox tbxProductNameUpdate;
		private System.Windows.Forms.ComboBox cbxCategoryUpdate;
		private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
		private System.Windows.Forms.Label lblUnitsInStockUpdate;
		private System.Windows.Forms.Label lblUnitPriceUpdate;
		private System.Windows.Forms.Label lblCategoryIdUpdate;
		private System.Windows.Forms.Label lblProductNameUpdate;
		private System.Windows.Forms.Button btnRemoveProduct;
		private System.Windows.Forms.Label lblDeleteProduct;
		private System.Windows.Forms.GroupBox gbxDeleteProduct;
	}
}

