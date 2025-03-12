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
    public partial class AdminForm : Form
    {
        UsersService usersService;
        CategoriesService categoriesService;
        ProductsService productsService;
        string username;
        
        public AdminForm(string username)
        {
            InitializeComponent();
            usersService = new UsersService();
            categoriesService = new CategoriesService();
            productsService = new ProductsService();
            this.username = username;
            lbl_name.Text = $"Welcome, Mr.{username}";
            btn_dashboard.BackColor = Color.DodgerBlue;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            showDashBoard();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
                showDashBoard();
        }

        private void showDashBoard()
        {
            lbl_users.Text = $"Number of Users: \t\t {usersService.getNumberOfUsers()}";
            lbl_categories.Text = $"Number of Categories: \t\t {categoriesService.getNumberOfCategories()}";
            lbl_products.Text = $"Number of Products: \t\t {productsService.getNumberOfProducts()}";
            dgv_favProducts.DataSource = productsService.getFavouriteProducts();
            dgv_favCategories.DataSource = categoriesService.getFavCategories();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm(username,this);
            productsForm.StartPosition = FormStartPosition.Manual;
            productsForm.Location = this.Location;
            this.Hide();
            productsForm.ShowDialog();
            showDashBoard();
            this.Show();
  
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm(username,this);
            categoriesForm.StartPosition = FormStartPosition.Manual;
            categoriesForm.Location = this.Location;
            this.Hide();
            categoriesForm.ShowDialog();
            showDashBoard();
            this.Show();
            
        }

        private void btn_dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            btn_dashboard.BackColor = Color.Blue;
        }

        private void btn_dashboard_MouseLeave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.DodgerBlue;
        }

        private void btn_products_MouseMove(object sender, MouseEventArgs e)
        {
            btn_products.BackColor = Color.DodgerBlue;
        }

        private void btn_products_MouseLeave(object sender, EventArgs e)
        {
            btn_products.BackColor = Color.White;
        }

        private void btn_categories_MouseLeave(object sender, EventArgs e)
        {
            btn_categories.BackColor = Color.White;
        }

        private void btn_categories_MouseMove(object sender, MouseEventArgs e)
        {
            btn_categories.BackColor = Color.DodgerBlue;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        
    }
}
