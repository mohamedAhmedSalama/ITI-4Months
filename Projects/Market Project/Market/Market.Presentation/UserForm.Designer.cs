namespace Market.Presentation
{
    partial class UserForm
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
            btn_getProuducts = new Button();
            btn_addFavourite = new Button();
            btn_favourites = new Button();
            btn_back = new Button();
            dgv_products = new DataGridView();
            txt_productName = new TextBox();
            cb_category = new ComboBox();
            nud_productId = new NumericUpDown();
            nud_productPrice = new NumericUpDown();
            label1 = new Label();
            lbl_productId = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_deleteFav = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_productId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_productPrice).BeginInit();
            SuspendLayout();
            // 
            // btn_getProuducts
            // 
            btn_getProuducts.BackColor = Color.DodgerBlue;
            btn_getProuducts.Location = new Point(649, 12);
            btn_getProuducts.Name = "btn_getProuducts";
            btn_getProuducts.Size = new Size(340, 56);
            btn_getProuducts.TabIndex = 0;
            btn_getProuducts.Text = "Get Products";
            btn_getProuducts.UseVisualStyleBackColor = false;
            btn_getProuducts.Click += btn_getProuducts_Click;
            btn_getProuducts.MouseLeave += btn_getProuducts_MouseLeave;
            btn_getProuducts.MouseMove += btn_getProuducts_MouseMove;
            // 
            // btn_addFavourite
            // 
            btn_addFavourite.BackColor = Color.Green;
            btn_addFavourite.Location = new Point(630, 392);
            btn_addFavourite.Name = "btn_addFavourite";
            btn_addFavourite.Size = new Size(138, 53);
            btn_addFavourite.TabIndex = 1;
            btn_addFavourite.Text = "Add to Favourite";
            btn_addFavourite.UseVisualStyleBackColor = false;
            btn_addFavourite.Click += btn_addFavourite_Click;
            btn_addFavourite.MouseLeave += btn_addFavourite_MouseLeave;
            btn_addFavourite.MouseMove += btn_addFavourite_MouseMove;
            // 
            // btn_favourites
            // 
            btn_favourites.BackColor = Color.DodgerBlue;
            btn_favourites.Location = new Point(744, 319);
            btn_favourites.Name = "btn_favourites";
            btn_favourites.Size = new Size(138, 53);
            btn_favourites.TabIndex = 2;
            btn_favourites.Text = "My Favourites";
            btn_favourites.UseVisualStyleBackColor = false;
            btn_favourites.Click += btn_favourites_Click;
            btn_favourites.MouseLeave += btn_favourites_MouseLeave;
            btn_favourites.MouseMove += btn_favourites_MouseMove;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.DodgerBlue;
            btn_back.Location = new Point(941, 452);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(94, 39);
            btn_back.TabIndex = 3;
            btn_back.Text = "Log out";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            btn_back.MouseLeave += btn_back_MouseLeave;
            btn_back.MouseMove += btn_back_MouseMove;
            // 
            // dgv_products
            // 
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(0, 0);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(585, 491);
            dgv_products.TabIndex = 4;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(818, 89);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(171, 27);
            txt_productName.TabIndex = 5;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(818, 273);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(171, 28);
            cb_category.TabIndex = 9;
            // 
            // nud_productId
            // 
            nud_productId.Location = new Point(818, 151);
            nud_productId.Name = "nud_productId";
            nud_productId.Size = new Size(171, 27);
            nud_productId.TabIndex = 10;
            // 
            // nud_productPrice
            // 
            nud_productPrice.Location = new Point(818, 214);
            nud_productPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_productPrice.Name = "nud_productPrice";
            nud_productPrice.Size = new Size(171, 27);
            nud_productPrice.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(649, 92);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 12;
            label1.Text = "Product Name";
            // 
            // lbl_productId
            // 
            lbl_productId.AutoSize = true;
            lbl_productId.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lbl_productId.ForeColor = Color.FromArgb(0, 119, 182);
            lbl_productId.Location = new Point(649, 158);
            lbl_productId.Name = "lbl_productId";
            lbl_productId.Size = new Size(111, 24);
            lbl_productId.TabIndex = 13;
            lbl_productId.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 119, 182);
            label3.Location = new Point(649, 221);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 14;
            label3.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 119, 182);
            label4.Location = new Point(649, 281);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 15;
            label4.Text = "Category";
            // 
            // btn_deleteFav
            // 
            btn_deleteFav.BackColor = Color.Red;
            btn_deleteFav.Location = new Point(851, 392);
            btn_deleteFav.Name = "btn_deleteFav";
            btn_deleteFav.Size = new Size(138, 53);
            btn_deleteFav.TabIndex = 18;
            btn_deleteFav.Text = "Delete Favourite";
            btn_deleteFav.UseVisualStyleBackColor = false;
            btn_deleteFav.Click += btn_delete_Click;
            btn_deleteFav.MouseLeave += btn_deleteFav_MouseLeave;
            btn_deleteFav.MouseMove += btn_deleteFav_MouseMove;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1047, 503);
            Controls.Add(btn_deleteFav);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_productId);
            Controls.Add(label1);
            Controls.Add(nud_productPrice);
            Controls.Add(nud_productId);
            Controls.Add(cb_category);
            Controls.Add(txt_productName);
            Controls.Add(dgv_products);
            Controls.Add(btn_back);
            Controls.Add(btn_favourites);
            Controls.Add(btn_addFavourite);
            Controls.Add(btn_getProuducts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_productId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_productPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_getProuducts;
        private Button btn_addFavourite;
        private Button btn_favourites;
        private Button btn_back;
        private DataGridView dgv_products;
        private TextBox txt_productName;
        private ComboBox cb_category;
        private NumericUpDown nud_productId;
        private NumericUpDown nud_productPrice;
        private Label label1;
        private Label lbl_productId;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_update;
        private Button btn_deleteFav;
    }
}