namespace Market.Presentation
{
    partial class CategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            panel1 = new Panel();
            lbl_name = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_categories = new Button();
            btn_products = new Button();
            btn_dashboard = new Button();
            lbl_categoryId = new Label();
            nud_categoryID = new NumericUpDown();
            lbl_categoryName = new Label();
            txt_categoryName = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_getCategory = new Button();
            dgv_categories = new DataGridView();
            btn_back = new Button();
            txt_search = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_categoryID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 182);
            panel1.Controls.Add(lbl_name);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_categories);
            panel1.Controls.Add(btn_products);
            panel1.Controls.Add(btn_dashboard);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(3, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 552);
            panel1.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_name.Location = new Point(9, 177);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(292, 46);
            lbl_name.TabIndex = 13;
            lbl_name.Text = "label3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 119, 182);
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Bold);
            label1.Location = new Point(0, -7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(325, 72);
            label1.TabIndex = 11;
            label1.Text = "My Market";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_categories
            // 
            btn_categories.BackColor = Color.DodgerBlue;
            btn_categories.ForeColor = SystemColors.ActiveCaptionText;
            btn_categories.Location = new Point(31, 463);
            btn_categories.Margin = new Padding(4);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(246, 59);
            btn_categories.TabIndex = 3;
            btn_categories.Text = "Categories";
            btn_categories.UseVisualStyleBackColor = false;
            btn_categories.MouseLeave += btn_categories_MouseLeave;
            btn_categories.MouseMove += btn_categories_MouseMove;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.White;
            btn_products.ForeColor = SystemColors.ActiveCaptionText;
            btn_products.Location = new Point(31, 363);
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
            btn_dashboard.Location = new Point(31, 270);
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
            // lbl_categoryId
            // 
            lbl_categoryId.AutoSize = true;
            lbl_categoryId.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_categoryId.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_categoryId.Location = new Point(358, 71);
            lbl_categoryId.Name = "lbl_categoryId";
            lbl_categoryId.Size = new Size(122, 24);
            lbl_categoryId.TabIndex = 15;
            lbl_categoryId.Text = "Category ID";
            // 
            // nud_categoryID
            // 
            nud_categoryID.Location = new Point(495, 72);
            nud_categoryID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_categoryID.Name = "nud_categoryID";
            nud_categoryID.Size = new Size(150, 27);
            nud_categoryID.TabIndex = 13;
            // 
            // lbl_categoryName
            // 
            lbl_categoryName.AutoSize = true;
            lbl_categoryName.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_categoryName.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_categoryName.Location = new Point(733, 71);
            lbl_categoryName.Name = "lbl_categoryName";
            lbl_categoryName.Size = new Size(152, 24);
            lbl_categoryName.TabIndex = 18;
            lbl_categoryName.Text = "Category Name";
            // 
            // txt_categoryName
            // 
            txt_categoryName.Location = new Point(910, 71);
            txt_categoryName.Name = "txt_categoryName";
            txt_categoryName.Size = new Size(220, 27);
            txt_categoryName.TabIndex = 17;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Location = new Point(994, 389);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 45);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            btn_delete.MouseLeave += btn_delete_MouseLeave;
            btn_delete.MouseMove += btn_delete_MouseMove;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Gold;
            btn_update.Location = new Point(994, 319);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 45);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            btn_update.MouseLeave += btn_update_MouseLeave;
            btn_update.MouseMove += btn_update_MouseMove;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.Location = new Point(994, 249);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 45);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            btn_add.MouseLeave += btn_add_MouseLeave;
            btn_add.MouseMove += btn_add_MouseMove;
            // 
            // btn_getCategory
            // 
            btn_getCategory.BackColor = Color.DodgerBlue;
            btn_getCategory.ForeColor = SystemColors.ButtonHighlight;
            btn_getCategory.Location = new Point(527, 123);
            btn_getCategory.Name = "btn_getCategory";
            btn_getCategory.Size = new Size(323, 46);
            btn_getCategory.TabIndex = 19;
            btn_getCategory.Text = "Get Categories";
            btn_getCategory.UseVisualStyleBackColor = false;
            btn_getCategory.Click += btn_getCategory_Click;
            // 
            // dgv_categories
            // 
            dgv_categories.BackgroundColor = Color.Gainsboro;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.Location = new Point(341, 185);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(592, 321);
            dgv_categories.TabIndex = 23;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DodgerBlue;
            btn_back.Location = new Point(1036, 11);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 45);
            btn_back.TabIndex = 24;
            btn_back.Text = "Log out";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(910, 152);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "search..";
            txt_search.Size = new Size(220, 27);
            txt_search.TabIndex = 25;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1142, 553);
            Controls.Add(txt_search);
            Controls.Add(btn_back);
            Controls.Add(dgv_categories);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(btn_getCategory);
            Controls.Add(lbl_categoryName);
            Controls.Add(txt_categoryName);
            Controls.Add(lbl_categoryId);
            Controls.Add(nud_categoryID);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriesForm";
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_categoryID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_categories;
        private Button btn_products;
        private Button btn_dashboard;
        private Label lbl_categoryId;
        private NumericUpDown nud_categoryID;
        private Label lbl_categoryName;
        private TextBox txt_categoryName;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Button btn_getCategory;
        private DataGridView dgv_categories;
        private Label lbl_name;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_back;
        private TextBox txt_search;
    }
}