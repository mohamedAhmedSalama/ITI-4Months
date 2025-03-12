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
    public partial class UserForm : Form
    {
        ProductsService productsService;
        FavouritesService favouritesService;
        CategoriesService categoriesService;
        int userId;
        bool inFav = false;
        int selectedID = -1;
        public UserForm(int id)
        {
            InitializeComponent();
            productsService = new ProductsService();
            favouritesService = new FavouritesService();
            categoriesService = new CategoriesService();
            this.userId = id;

            txt_productName.Enabled = false;
            nud_productId.Enabled = false;
            nud_productPrice.Enabled = false;
            cb_category.Enabled = false;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_getProuducts_Click(object sender, EventArgs e)
        {
            inFav = false;
            btn_addFavourite.Enabled = true;
            DataTable dt = new DataTable();
            dt = productsService.getProducts();
            dgv_products.DataSource = dt;
            dt = categoriesService.getCategories();
            cb_category.DataSource = dt;
            cb_category.DisplayMember = "Category Name";
            cb_category.ValueMember = "Category Id";

            btn_deleteFav.Visible = false;

            btn_addFavourite.Visible = false;

        }

        private void btn_favourites_Click(object sender, EventArgs e)
        {
            inFav = true;
            DataTable dt = new DataTable();
            dt = favouritesService.getFavouritesById(this.userId);
            dgv_products.DataSource = dt;
            btn_addFavourite.Enabled = false;
            btn_deleteFav.Enabled = false;


        }

        private void btn_addFavourite_Click(object sender, EventArgs e)
        {
            int productid = (int)nud_productId.Value;
            if (favouritesService.getFavourite(userId, productid) == true)
            {
                MessageBox.Show("Product is added successfully","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                favouritesService.addFavourites(userId, productid);
            }
            else
                MessageBox.Show("Product is already added before", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

           

        }

        private void dgv_products_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = dgv_products.SelectedRows[0];

            if (inFav == true)
            {
                lbl_productId.Visible = false;
                nud_productId.Visible = false;
                btn_deleteFav.Enabled = true;
                btn_deleteFav.Visible = true;
                btn_addFavourite.Visible = false;
                cb_category.DataSource = categoriesService.getCategories();
                //cb_category.SelectedValue = categoriesService.getCategoryId(row.Cells["CategoryName"].Value.ToString());
                //selectedID = categoriesService.getCategoryId(row.Cells["Category Name"].Value.ToString());
            }
            else
            {
                lbl_productId.Visible = true;
                nud_productId.Visible = true;
                nud_productId.Value = (int)row.Cells["Product Id"].Value;


                btn_deleteFav.Visible = false;

                btn_addFavourite.Visible = true;
            }
            txt_productName.Text = row.Cells["Product Name"].Value.ToString();
            nud_productPrice.Value = (decimal)row.Cells["Price"].Value;
            cb_category.SelectedValue = (int)row.Cells["Category Id"].Value;
            selectedID = (int)row.Cells["Category Id"].Value;




        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete This Product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (favouritesService.deleteFavouriteByProductName(userId, txt_productName.Text, selectedID) > 0)
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
            dgv_products.DataSource = favouritesService.getFavouritesById(this.userId);
        }

        private void btn_getProuducts_MouseLeave(object sender, EventArgs e)
        {
            btn_getProuducts.BackColor = Color.DodgerBlue;
        }

        private void btn_getProuducts_MouseMove(object sender, MouseEventArgs e)
        {
            btn_getProuducts.BackColor = Color.Blue;
        }

        private void btn_favourites_MouseLeave(object sender, EventArgs e)
        {
            btn_favourites.BackColor = Color.DodgerBlue;
        }

        private void btn_favourites_MouseMove(object sender, MouseEventArgs e)
        {
            btn_favourites.BackColor = Color.Blue;
        }

        private void btn_addFavourite_MouseMove(object sender, MouseEventArgs e)
        {
            btn_addFavourite.BackColor = Color.DarkGreen;
        }

        private void btn_addFavourite_MouseLeave(object sender, EventArgs e)
        {
            btn_addFavourite.BackColor = Color.Green;
        }

        private void btn_deleteFav_MouseMove(object sender, MouseEventArgs e)
        {
            btn_deleteFav.BackColor = Color.DarkRed;
        }

        private void btn_deleteFav_MouseLeave(object sender, EventArgs e)
        {
            btn_deleteFav.BackColor = Color.Red;
        }

        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.BackColor = Color.Blue;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.DodgerBlue;
        }
    }
}
