using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class ProductMenuForm : Form
    {
        public ProductMenuForm()
        {
            InitializeComponent();
        }

        private void picBackArrow_Click(object sender, EventArgs e)
        {


        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm _addProductForm = new AddProductForm();

            _addProductForm.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            UpdateProductForm _updateProductForm = new UpdateProductForm();

            _updateProductForm.Show();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProductForm _deleteProductForm = new DeleteProductForm();

            _deleteProductForm.ShowDialog();
        }
    }
}
