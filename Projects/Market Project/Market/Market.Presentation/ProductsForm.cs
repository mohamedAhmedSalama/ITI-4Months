using Market.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Presentation
{
    public partial class ProductsForm : Form
    {
        ProductsService productService;
        CategoriesService categoriesService;
        int selectedID = -1;
        string username;
        Form parentForm;
        public ProductsForm(string username, Form parent)
        {
            InitializeComponent();
            productService = new ProductsService();
            categoriesService = new CategoriesService();
            nud_productID.Enabled = false;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            this.username = username;
            lbl_name.Text = $"Welcome, Mr.{username}";
            btn_products.BackColor = Color.DodgerBlue;
            this.parentForm = parent;
        }


        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(username, parentForm);
            categoriesForm.StartPosition = FormStartPosition.Manual;
            categoriesForm.Location = this.Location;
            this.Hide();
            categoriesForm.ShowDialog();
            this.Close();
        }


        private void ProductsForm_Load(object sender, EventArgs e)
        {
            displayProducts();
        }

        private void displayProducts()
        {
            txt_productName.Clear();
            nud_price.Value = 0;
            nud_productID.Value = 0;

            dgv_products.DataSource = productService.getProducts();
            cb_category.DataSource = categoriesService.getCategories();
            cb_category.DisplayMember = "Category Name";
            cb_category.ValueMember = "Category Id";

            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_add.Visible = true;
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            //validation ...!
            if (txt_productName.Text != string.Empty || nud_price.Value != 0)
            {
                if (productService.addProduct(txt_productName.Text, nud_price.Value, (int)cb_category.SelectedValue) > 0)
                    MessageBox.Show("product is added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Missing Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayProducts();


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //validation...!

            if (MessageBox.Show("Are You Sure to Update This Product?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (productService.updateProduct((int)nud_productID.Value, txt_productName.Text, nud_price.Value, selectedID) > 0)
                {
                    MessageBox.Show("Product is Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No Products are Updated! Try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Update is canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            displayProducts();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //validation...!
            if (MessageBox.Show("Are You Sure to Delete This Product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (productService.deleteProduct((int)nud_productID.Value) > 0)
                {
                    
                    MessageBox.Show("Product is removed Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }
                else
                {
                    MessageBox.Show("No Products removed! Try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            displayProducts();
        }

        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            DataGridViewRow row = dgv_products.SelectedRows[0];
            txt_productName.Text = row.Cells["Product Name"].Value.ToString();
            nud_productID.Value = (int)row.Cells["Product Id"].Value;
            nud_price.Value = (decimal)row.Cells["Price"].Value;
            cb_category.SelectedValue = (int)row.Cells["Category Id"].Value;
            selectedID = (int)row.Cells["Category Id"].Value;
        }

        private void btn_getProducts_Click(object sender, EventArgs e)
        {
            displayProducts();
        }



        private void btn_getProducts_MouseMove(object sender, MouseEventArgs e)
        {
            btn_getProducts.BackColor = Color.Blue;
        }

        private void btn_getProducts_MouseLeave(object sender, EventArgs e)
        {
            btn_getProducts.BackColor = Color.DodgerBlue;
        }

        private void btn_add_MouseMove(object sender, MouseEventArgs e)
        {
            btn_add.BackColor = Color.DarkGreen;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.Green;
        }

        private void btn_update_MouseMove(object sender, MouseEventArgs e)
        {
            btn_update.BackColor = Color.Goldenrod;
        }

        private void btn_update_MouseLeave(object sender, EventArgs e)
        {
            btn_update.BackColor = Color.Gold;
        }

        private void btn_delete_MouseMove(object sender, MouseEventArgs e)
        {
            btn_delete.BackColor = Color.DarkRed;
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            btn_delete.BackColor = Color.Red;
        }

        private void btn_dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            btn_dashboard.BackColor = Color.DodgerBlue;
        }

        private void btn_dashboard_MouseLeave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.White;
        }

        private void btn_products_MouseMove(object sender, MouseEventArgs e)
        {
            btn_products.BackColor = Color.Blue;
        }

        private void btn_products_MouseLeave(object sender, EventArgs e)
        {
            btn_products.BackColor = Color.DodgerBlue;
        }

        private void btn_categories_MouseMove(object sender, MouseEventArgs e)
        {
            btn_categories.BackColor = Color.DodgerBlue;
        }

        private void btn_categories_MouseLeave(object sender, EventArgs e)
        {
            btn_categories.BackColor = Color.White;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            parentForm.Close();

            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_products.DataSource = productService.getProductBySearch(txt_search.Text);

        }
    }
}
