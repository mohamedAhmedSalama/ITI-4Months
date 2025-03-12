namespace Market.Presentation
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            panel1 = new Panel();
            lbl_name = new Label();
            pictureBox1 = new PictureBox();
            btn_categories = new Button();
            btn_products = new Button();
            btn_dashboard = new Button();
            label1 = new Label();
            dgv_products = new DataGridView();
            nud_productID = new NumericUpDown();
            txt_productName = new TextBox();
            nud_price = new NumericUpDown();
            cb_category = new ComboBox();
            lbl_productId = new Label();
            lbl_productName = new Label();
            lbl_price = new Label();
            lbl_category = new Label();
            btn_getProducts = new Button();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_back = new Button();
            txt_search = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_productID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_price).BeginInit();
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
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 552);
            panel1.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(9, 192);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(292, 46);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 86);
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
            btn_categories.Location = new Point(25, 463);
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
            btn_products.Location = new Point(25, 364);
            btn_products.Margin = new Padding(4);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(246, 59);
            btn_products.TabIndex = 2;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.MouseLeave += btn_products_MouseLeave;
            btn_products.MouseMove += btn_products_MouseMove;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.White;
            btn_dashboard.ForeColor = SystemColors.ActiveCaptionText;
            btn_dashboard.Location = new Point(25, 270);
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
            label1.Size = new Size(325, 72);
            label1.TabIndex = 0;
            label1.Text = "My Market";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgv_products
            // 
            dgv_products.BackgroundColor = Color.Gainsboro;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(348, 293);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(592, 248);
            dgv_products.TabIndex = 4;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // nud_productID
            // 
            nud_productID.Location = new Point(446, 47);
            nud_productID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_productID.Name = "nud_productID";
            nud_productID.Size = new Size(165, 27);
            nud_productID.TabIndex = 5;
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(851, 47);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(165, 27);
            txt_productName.TabIndex = 6;
            // 
            // nud_price
            // 
            nud_price.Location = new Point(851, 105);
            nud_price.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_price.Name = "nud_price";
            nud_price.Size = new Size(165, 27);
            nud_price.TabIndex = 7;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(446, 104);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(165, 28);
            cb_category.TabIndex = 8;
            // 
            // lbl_productId
            // 
            lbl_productId.AutoSize = true;
            lbl_productId.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_productId.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_productId.Location = new Point(322, 50);
            lbl_productId.Name = "lbl_productId";
            lbl_productId.Size = new Size(111, 24);
            lbl_productId.TabIndex = 9;
            lbl_productId.Text = "Product ID";
            // 
            // lbl_productName
            // 
            lbl_productName.AutoSize = true;
            lbl_productName.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_productName.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_productName.Location = new Point(694, 50);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(141, 24);
            lbl_productName.TabIndex = 10;
            lbl_productName.Text = "Product Name";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_price.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_price.Location = new Point(694, 112);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(56, 24);
            lbl_price.TabIndex = 11;
            lbl_price.Text = "Price";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_category.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_category.Location = new Point(332, 104);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(92, 24);
            lbl_category.TabIndex = 12;
            lbl_category.Text = "Category";
            // 
            // btn_getProducts
            // 
            btn_getProducts.BackColor = Color.DodgerBlue;
            btn_getProducts.ForeColor = SystemColors.ButtonHighlight;
            btn_getProducts.Location = new Point(348, 175);
            btn_getProducts.Name = "btn_getProducts";
            btn_getProducts.Size = new Size(323, 46);
            btn_getProducts.TabIndex = 13;
            btn_getProducts.Text = "Get Products";
            btn_getProducts.UseVisualStyleBackColor = false;
            btn_getProducts.Click += btn_getProducts_Click;
            btn_getProducts.MouseLeave += btn_getProducts_MouseLeave;
            btn_getProducts.MouseMove += btn_getProducts_MouseMove;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.ForeColor = SystemColors.ButtonHighlight;
            btn_add.Location = new Point(723, 176);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 45);
            btn_add.TabIndex = 14;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            btn_add.MouseLeave += btn_add_MouseLeave;
            btn_add.MouseMove += btn_add_MouseMove;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Gold;
            btn_update.Location = new Point(869, 176);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 45);
            btn_update.TabIndex = 15;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            btn_update.MouseLeave += btn_update_MouseLeave;
            btn_update.MouseMove += btn_update_MouseMove;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Location = new Point(1015, 176);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 45);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            btn_delete.MouseLeave += btn_delete_MouseLeave;
            btn_delete.MouseMove += btn_delete_MouseMove;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DodgerBlue;
            btn_back.Location = new Point(1036, 11);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 45);
            btn_back.TabIndex = 25;
            btn_back.Text = "Log out";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(869, 260);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "search..";
            txt_search.Size = new Size(220, 27);
            txt_search.TabIndex = 26;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1132, 553);
            Controls.Add(txt_search);
            Controls.Add(btn_back);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_getProducts);
            Controls.Add(lbl_category);
            Controls.Add(lbl_price);
            Controls.Add(lbl_productName);
            Controls.Add(lbl_productId);
            Controls.Add(cb_category);
            Controls.Add(nud_price);
            Controls.Add(txt_productName);
            Controls.Add(nud_productID);
            Controls.Add(dgv_products);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_productID).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_categories;
        private Button btn_products;
        private Button btn_dashboard;
        private Label label1;
        private DataGridView dgv_products;
        private NumericUpDown nud_productID;
        private TextBox txt_productName;
        private NumericUpDown nud_price;
        private ComboBox cb_category;
        private Label lbl_productId;
        private Label lbl_productName;
        private Label lbl_price;
        private Label lbl_category;
        private Button btn_getProducts;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private PictureBox pictureBox1;
        private Label lbl_name;
        private Button btn_back;
        private TextBox txt_search;
    }
}