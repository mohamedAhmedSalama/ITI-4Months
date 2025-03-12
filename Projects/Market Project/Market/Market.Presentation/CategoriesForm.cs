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
    public partial class CategoriesForm : Form
    {
        CategoriesService categoriesService;
        string username;
        Form parentForm;
        public CategoriesForm(string username, Form parent)
        {
            InitializeComponent();
            categoriesService = new CategoriesService();
            nud_categoryID.Enabled = false;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            this.username = username;
            lbl_name.Text = $"Welcome, Mr.{username}";
            btn_categories.BackColor = Color.DodgerBlue;
            this.parentForm = parent;
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(username, parentForm);
            productsForm.StartPosition = FormStartPosition.Manual;
            productsForm.Location = this.Location;
            this.Hide();
            productsForm.ShowDialog();
            this.Close();
        }

        private void displayCategories()
        {
            txt_categoryName.Text = string.Empty;
            nud_categoryID.Value = 0;

            dgv_categories.DataSource = categoriesService.getCategoriesWithCounts();


            btn_delete.Visible = false;
            btn_update.Visible = false;
            btn_add.Visible = true;
        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            displayCategories();
        }
        private void btn_getCategory_Click(object sender, EventArgs e)
        {
            displayCategories();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //validation...
            if (txt_categoryName.Text != string.Empty)
            {
                if (categoriesService.addCategory(txt_categoryName.Text) > 0)
                    MessageBox.Show("Category is added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Category is not added!, Try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Missing Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            displayCategories();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete This Category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (categoriesService.deleteCategory((int)nud_categoryID.Value) > 0)
                    MessageBox.Show("Category is removed Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Category removed! Try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            displayCategories();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //validation...
            if (txt_categoryName.Text != string.Empty)
            {
                if (MessageBox.Show("Are You Sure to Update This Category?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (categoriesService.updateCategory((int)nud_categoryID.Value, txt_categoryName.Text) > 0)
                        MessageBox.Show("Category is Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No Categories are Updated! Try again", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Category is canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("Missing Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            displayCategories();
        }

        private void dgv_categories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_add.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            DataGridViewRow row = dgv_categories.SelectedRows[0];
            nud_categoryID.Value = (int)row.Cells["Category Id"].Value;
            txt_categoryName.Text = row.Cells["Category Name"].Value.ToString();

        }

        private void btn_categories_MouseMove(object sender, MouseEventArgs e)
        {
            btn_categories.BackColor = Color.Blue;
        }
        private void btn_categories_MouseLeave(object sender, EventArgs e)
        {
            btn_categories.BackColor = Color.DodgerBlue;
        }

        private void btn_products_MouseMove(object sender, MouseEventArgs e)
        {
            btn_products.BackColor = Color.DodgerBlue;
        }

        private void btn_products_MouseLeave(object sender, EventArgs e)
        {
            btn_products.BackColor = Color.White;
        }

        private void btn_dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            btn_dashboard.BackColor = Color.DodgerBlue;
        }

        private void btn_dashboard_MouseLeave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.White;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            parentForm.Close();
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgv_categories.DataSource = categoriesService.getCategoryBySearch(txt_search.Text);
            
        }
    }
}
