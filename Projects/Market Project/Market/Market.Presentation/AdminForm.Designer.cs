namespace Market.Presentation
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panel1 = new Panel();
            lbl_name = new Label();
            pictureBox1 = new PictureBox();
            btn_categories = new Button();
            btn_products = new Button();
            btn_dashboard = new Button();
            label1 = new Label();
            lbl_users = new Label();
            lbl_products = new Label();
            lbl_categories = new Label();
            panel2 = new Panel();
            dgv_favProducts = new DataGridView();
            label5 = new Label();
            panel3 = new Panel();
            dgv_favCategories = new DataGridView();
            label2 = new Label();
            btn_back = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_favProducts).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_favCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 182);
            panel1.Controls.Add(lbl_name);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_categories);
            panel1.Controls.Add(btn_products);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 552);
            panel1.TabIndex = 0;
            // 
            // lbl_name
            // 
            lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(10, 179);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(291, 53);
            lbl_name.TabIndex = 9;
            lbl_name.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_categories
            // 
            btn_categories.BackColor = Color.White;
            btn_categories.ForeColor = SystemColors.ActiveCaptionText;
            btn_categories.Location = new Point(38, 445);
            btn_categories.Margin = new Padding(4);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(246, 59);
            btn_categories.TabIndex = 3;
            btn_categories.Text = "Categories";
            btn_categories.UseVisualStyleBackColor = false;
            btn_categories.Click += btn_categories_Click;
            btn_categories.MouseLeave += btn_categories_MouseLeave;
            btn_categories.MouseMove += btn_categories_MouseMove;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.White;
            btn_products.ForeColor = SystemColors.ActiveCaptionText;
            btn_products.Location = new Point(38, 345);
            btn_products.Margin = new Padding(4);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(246, 59);
            btn_products.TabIndex = 2;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            btn_products.MouseLeave += btn_products_MouseLeave;
            btn_products.MouseMove += btn_products_MouseMove;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.White;
            btn_dashboard.ForeColor = SystemColors.ActiveCaptionText;
            btn_dashboard.Location = new Point(38, 252);
            btn_dashboard.Margin = new Padding(4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(246, 59);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            btn_dashboard.MouseLeave += btn_dashboard_MouseLeave;
            btn_dashboard.MouseMove += btn_dashboard_MouseMove;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 119, 182);
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 57);
            label1.TabIndex = 0;
            label1.Text = "My Market";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_users
            // 
            lbl_users.BackColor = Color.Gainsboro;
            lbl_users.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_users.Location = new Point(353, 58);
            lbl_users.Margin = new Padding(4, 0, 4, 0);
            lbl_users.Name = "lbl_users";
            lbl_users.Size = new Size(737, 40);
            lbl_users.TabIndex = 1;
            lbl_users.Text = "Number of Users : ";
            // 
            // lbl_products
            // 
            lbl_products.BackColor = Color.Gainsboro;
            lbl_products.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_products.Location = new Point(353, 203);
            lbl_products.Margin = new Padding(4, 0, 4, 0);
            lbl_products.Name = "lbl_products";
            lbl_products.Size = new Size(737, 40);
            lbl_products.TabIndex = 2;
            lbl_products.Text = "Number of Products : ";
            // 
            // lbl_categories
            // 
            lbl_categories.BackColor = Color.Gainsboro;
            lbl_categories.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_categories.Location = new Point(353, 130);
            lbl_categories.Margin = new Padding(4, 0, 4, 0);
            lbl_categories.Name = "lbl_categories";
            lbl_categories.Size = new Size(737, 40);
            lbl_categories.TabIndex = 3;
            lbl_categories.Text = "Number of Categories : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(dgv_favProducts);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(342, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 256);
            panel2.TabIndex = 4;
            // 
            // dgv_favProducts
            // 
            dgv_favProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_favProducts.Location = new Point(13, 42);
            dgv_favProducts.Name = "dgv_favProducts";
            dgv_favProducts.RowHeadersWidth = 51;
            dgv_favProducts.Size = new Size(334, 206);
            dgv_favProducts.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 11);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 0;
            label5.Text = "Top 3 Favourite Products";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(dgv_favCategories);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(728, 289);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 256);
            panel3.TabIndex = 5;
            // 
            // dgv_favCategories
            // 
            dgv_favCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_favCategories.Location = new Point(13, 42);
            dgv_favCategories.Name = "dgv_favCategories";
            dgv_favCategories.RowHeadersWidth = 51;
            dgv_favCategories.Size = new Size(334, 206);
            dgv_favCategories.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 0;
            label2.Text = "Top 3 Favourite Categories";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DodgerBlue;
            btn_back.Location = new Point(1036, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 45);
            btn_back.TabIndex = 6;
            btn_back.Text = "Log out";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 553);
            Controls.Add(btn_back);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lbl_categories);
            Controls.Add(lbl_products);
            Controls.Add(lbl_users);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminForm";
            Text = "Form3";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_favProducts).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_favCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button btn_dashboard;
        private Button btn_categories;
        private Button btn_products;
        private Label lbl_users;
        private Label lbl_products;
        private Label lbl_categories;
        private Panel panel2;
        private Label label5;
        private DataGridView dgv_favProducts;
        private Panel panel3;
        private DataGridView dgv_favCategories;
        private Label label2;
        private Label lbl_name;
        private PictureBox pictureBox1;
        private Button btn_back;
    }
}