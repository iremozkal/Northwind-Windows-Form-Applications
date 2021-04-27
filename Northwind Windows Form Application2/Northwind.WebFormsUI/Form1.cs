using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public Form1()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
            _productService = new ProductManager(new EfProductDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListAllProducts();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { ListProductsByCategoryId(); }
            catch {	/* It works for the first load,too. but we dont want that.*/ }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;

            if (String.IsNullOrEmpty(key)) ListAllProducts();
            else ListProductsByProductName(key);
        }

        private void ListCategories()
        {
            FillCategoryCbx(cbxCategory);
            FillCategoryCbx(cbxCategoryAdd);
            FillCategoryCbx(cbxCategoryUpdate);
        }

        private void ListAllProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void ListProductsByCategoryId()
        {
            dgwProducts.DataSource = _productService.GetProductsByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
        }

        private void ListProductsByProductName(string key)
        {
            dgwProducts.DataSource = _productService.GetProductsByProductName(key);
        }

        private void FillCategoryCbx(ComboBox cbxCategory)
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgwProducts.CurrentRow;
            cbxCategoryUpdate.SelectedValue = currentRow.Cells[1].Value;
            tbxProductNameUpdate.Text = currentRow.Cells[2].Value.ToString();
            tbxUnitPriceUpdate.Text = currentRow.Cells[3].Value.ToString();
            tbxUnitsInStockUpdate.Text = currentRow.Cells[4].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = currentRow.Cells[5].Value.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                ProductName = tbxProductNameAdd.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockAdd.Text),
                QuantityPerUnit = tbxQuantityPerUnitAdd.Text
            });
            MessageBox.Show("Product added!");
            ListAllProducts();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                ProductName = tbxProductNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text.Replace(".", ",")),
                UnitsInStock = Convert.ToInt16(tbxUnitsInStockUpdate.Text),
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text
            });
            MessageBox.Show("Product updated!");
            ListAllProducts();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgwProducts.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Product deleted!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.InnerException.InnerException.Message);
                }
            }
            else
            {
                MessageBox.Show("You didn't select a row to remove!");
            }

            ListAllProducts();
        }
    }
}
