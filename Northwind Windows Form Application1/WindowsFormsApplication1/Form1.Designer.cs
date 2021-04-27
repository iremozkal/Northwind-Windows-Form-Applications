namespace WindowsFormsApplication1
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
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.gbxSearch = new System.Windows.Forms.GroupBox();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.gbxCategory.SuspendLayout();
			this.gbxSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(30, 28);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(637, 79);
			this.gbxCategory.TabIndex = 0;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "List by Category";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(140, 38);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(202, 21);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(31, 41);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(52, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Category:";
			// 
			// gbxSearch
			// 
			this.gbxSearch.Controls.Add(this.tbxSearch);
			this.gbxSearch.Location = new System.Drawing.Point(30, 122);
			this.gbxSearch.Name = "gbxSearch";
			this.gbxSearch.Size = new System.Drawing.Size(637, 79);
			this.gbxSearch.TabIndex = 2;
			this.gbxSearch.TabStop = false;
			this.gbxSearch.Text = "Search by Name";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Location = new System.Drawing.Point(140, 33);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(202, 20);
			this.tbxSearch.TabIndex = 1;
			this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(61, 158);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(44, 13);
			this.lblSearch.TabIndex = 0;
			this.lblSearch.Text = "Search:";
			// 
			// dgwProduct
			// 
			this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(30, 216);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.Size = new System.Drawing.Size(637, 201);
			this.dgwProduct.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 444);
			this.Controls.Add(this.dgwProduct);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.gbxSearch);
			this.Name = "Form1";
			this.Text = "Products";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxSearch.ResumeLayout(false);
			this.gbxSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxCategory;
		private System.Windows.Forms.ComboBox cbxCategory;
		private System.Windows.Forms.Label lblCategory;
		private System.Windows.Forms.GroupBox gbxSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.DataGridView dgwProduct;
	}
}

