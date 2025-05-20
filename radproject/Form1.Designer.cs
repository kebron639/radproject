namespace radproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabpage = new Panel();
            btnLogout = new Button();
            tabpages = new TabControl();
            tabprofile = new TabPage();
            txtBoxPhonenumber = new TextBox();
            txtBoxPassword = new TextBox();
            txtBoxEmail = new TextBox();
            txtBoxFullname = new TextBox();
            txtBoxUsername = new TextBox();
            txtBoxUserid = new TextBox();
            cmbBoxRole = new ComboBox();
            lblPhonenumber = new Label();
            lblRole = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblFullname = new Label();
            lblUsername = new Label();
            lblUserid = new Label();
            pnlProfile = new Panel();
            btnChangepassword = new Button();
            btnEditprofile = new Button();
            tabProductlist = new TabPage();
            btnAddproduct = new Button();
            dataGridView = new DataGridView();
            ProductidColumn = new DataGridViewTextBoxColumn();
            ProductnameColumn = new DataGridViewTextBoxColumn();
            ProductimageColumn = new DataGridViewImageColumn();
            CatagoryColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            ActionColumn = new DataGridViewButtonColumn();
            EditColumn = new DataGridViewButtonColumn();
            RemoveColumn = new DataGridViewButtonColumn();
            tabAccounts = new TabPage();
            dgvAccounts = new DataGridView();
            tabViewproduct = new TabPage();
            tabMycart = new TabPage();
            tabVieworder = new TabPage();
            tabAddproduct = new TabPage();
            tabpage.SuspendLayout();
            tabpages.SuspendLayout();
            tabprofile.SuspendLayout();
            pnlProfile.SuspendLayout();
            tabProductlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // tabpage
            // 
            tabpage.Controls.Add(btnLogout);
            tabpage.Controls.Add(tabpages);
            tabpage.Dock = DockStyle.Fill;
            tabpage.Location = new Point(0, 0);
            tabpage.Name = "tabpage";
            tabpage.Size = new Size(1059, 452);
            tabpage.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Location = new Point(953, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // tabpages
            // 
            tabpages.Controls.Add(tabprofile);
            tabpages.Controls.Add(tabProductlist);
            tabpages.Controls.Add(tabAccounts);
            tabpages.Controls.Add(tabViewproduct);
            tabpages.Controls.Add(tabMycart);
            tabpages.Controls.Add(tabVieworder);
            tabpages.Controls.Add(tabAddproduct);
            tabpages.Dock = DockStyle.Fill;
            tabpages.Location = new Point(0, 0);
            tabpages.Name = "tabpages";
            tabpages.SelectedIndex = 0;
            tabpages.Size = new Size(1059, 452);
            tabpages.TabIndex = 0;
            tabpages.Tag = "";
            // 
            // tabprofile
            // 
            tabprofile.BackColor = Color.WhiteSmoke;
            tabprofile.Controls.Add(txtBoxPhonenumber);
            tabprofile.Controls.Add(txtBoxPassword);
            tabprofile.Controls.Add(txtBoxEmail);
            tabprofile.Controls.Add(txtBoxFullname);
            tabprofile.Controls.Add(txtBoxUsername);
            tabprofile.Controls.Add(txtBoxUserid);
            tabprofile.Controls.Add(cmbBoxRole);
            tabprofile.Controls.Add(lblPhonenumber);
            tabprofile.Controls.Add(lblRole);
            tabprofile.Controls.Add(lblPassword);
            tabprofile.Controls.Add(lblEmail);
            tabprofile.Controls.Add(lblFullname);
            tabprofile.Controls.Add(lblUsername);
            tabprofile.Controls.Add(lblUserid);
            tabprofile.Controls.Add(pnlProfile);
            tabprofile.Location = new Point(4, 29);
            tabprofile.Name = "tabprofile";
            tabprofile.Padding = new Padding(3);
            tabprofile.Size = new Size(1051, 419);
            tabprofile.TabIndex = 0;
            tabprofile.Text = "Profile";
            // 
            // txtBoxPhonenumber
            // 
            txtBoxPhonenumber.Location = new Point(144, 358);
            txtBoxPhonenumber.Name = "txtBoxPhonenumber";
            txtBoxPhonenumber.Size = new Size(443, 27);
            txtBoxPhonenumber.TabIndex = 14;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(144, 267);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(443, 27);
            txtBoxPassword.TabIndex = 13;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(144, 218);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(443, 27);
            txtBoxEmail.TabIndex = 12;
            // 
            // txtBoxFullname
            // 
            txtBoxFullname.Location = new Point(144, 172);
            txtBoxFullname.Name = "txtBoxFullname";
            txtBoxFullname.Size = new Size(443, 27);
            txtBoxFullname.TabIndex = 11;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Location = new Point(144, 127);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.Size = new Size(443, 27);
            txtBoxUsername.TabIndex = 10;
            // 
            // txtBoxUserid
            // 
            txtBoxUserid.Location = new Point(144, 79);
            txtBoxUserid.Name = "txtBoxUserid";
            txtBoxUserid.Size = new Size(443, 27);
            txtBoxUserid.TabIndex = 9;
            // 
            // cmbBoxRole
            // 
            cmbBoxRole.FormattingEnabled = true;
            cmbBoxRole.Items.AddRange(new object[] { "Admin", "Seller", "Customer" });
            cmbBoxRole.Location = new Point(144, 313);
            cmbBoxRole.Name = "cmbBoxRole";
            cmbBoxRole.Size = new Size(443, 28);
            cmbBoxRole.TabIndex = 8;
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.AutoSize = true;
            lblPhonenumber.Location = new Point(6, 365);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new Size(108, 20);
            lblPhonenumber.TabIndex = 7;
            lblPhonenumber.Text = "Phone Number";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(8, 321);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(8, 274);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(8, 179);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(76, 20);
            lblFullname.TabIndex = 3;
            lblFullname.Text = "Full Name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(6, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "User Name";
            // 
            // lblUserid
            // 
            lblUserid.AutoSize = true;
            lblUserid.Location = new Point(8, 86);
            lblUserid.Name = "lblUserid";
            lblUserid.Size = new Size(55, 20);
            lblUserid.TabIndex = 1;
            lblUserid.Text = "User Id";
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Brown;
            pnlProfile.Controls.Add(btnChangepassword);
            pnlProfile.Controls.Add(btnEditprofile);
            pnlProfile.Location = new Point(0, 0);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(1057, 64);
            pnlProfile.TabIndex = 0;
            // 
            // btnChangepassword
            // 
            btnChangepassword.BackColor = Color.Brown;
            btnChangepassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangepassword.ForeColor = Color.Transparent;
            btnChangepassword.Location = new Point(857, 6);
            btnChangepassword.Name = "btnChangepassword";
            btnChangepassword.Size = new Size(192, 45);
            btnChangepassword.TabIndex = 1;
            btnChangepassword.Text = "Change Password";
            btnChangepassword.UseVisualStyleBackColor = false;
            // 
            // btnEditprofile
            // 
            btnEditprofile.BackColor = Color.Brown;
            btnEditprofile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditprofile.ForeColor = Color.Transparent;
            btnEditprofile.Location = new Point(6, 6);
            btnEditprofile.Name = "btnEditprofile";
            btnEditprofile.Size = new Size(125, 45);
            btnEditprofile.TabIndex = 0;
            btnEditprofile.Text = "Edit Profile";
            btnEditprofile.UseVisualStyleBackColor = false;
            btnEditprofile.Click += button1_Click_1;
            // 
            // tabProductlist
            // 
            tabProductlist.Controls.Add(btnAddproduct);
            tabProductlist.Controls.Add(dataGridView);
            tabProductlist.Location = new Point(4, 29);
            tabProductlist.Name = "tabProductlist";
            tabProductlist.Padding = new Padding(3);
            tabProductlist.Size = new Size(1051, 419);
            tabProductlist.TabIndex = 1;
            tabProductlist.Text = "Product List";
            tabProductlist.UseVisualStyleBackColor = true;
            // 
            // btnAddproduct
            // 
            btnAddproduct.BackColor = Color.Lime;
            btnAddproduct.Location = new Point(36, 256);
            btnAddproduct.Name = "btnAddproduct";
            btnAddproduct.Size = new Size(145, 52);
            btnAddproduct.TabIndex = 1;
            btnAddproduct.Text = "Add Product";
            btnAddproduct.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ProductidColumn, ProductnameColumn, ProductimageColumn, CatagoryColumn, PriceColumn, QuantityColumn, StatusColumn, ActionColumn, EditColumn, RemoveColumn });
            dataGridView.Dock = DockStyle.Top;
            dataGridView.Location = new Point(3, 3);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1045, 209);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // ProductidColumn
            // 
            ProductidColumn.FillWeight = 68.15178F;
            ProductidColumn.HeaderText = "Product Id";
            ProductidColumn.MinimumWidth = 6;
            ProductidColumn.Name = "ProductidColumn";
            // 
            // ProductnameColumn
            // 
            ProductnameColumn.FillWeight = 72.6302948F;
            ProductnameColumn.HeaderText = "Product Name";
            ProductnameColumn.MinimumWidth = 6;
            ProductnameColumn.Name = "ProductnameColumn";
            // 
            // ProductimageColumn
            // 
            ProductimageColumn.FillWeight = 76.47006F;
            ProductimageColumn.HeaderText = "Product Image";
            ProductimageColumn.MinimumWidth = 6;
            ProductimageColumn.Name = "ProductimageColumn";
            ProductimageColumn.Resizable = DataGridViewTriState.True;
            ProductimageColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CatagoryColumn
            // 
            CatagoryColumn.FillWeight = 80.04896F;
            CatagoryColumn.HeaderText = "Catagory";
            CatagoryColumn.MinimumWidth = 6;
            CatagoryColumn.Name = "CatagoryColumn";
            // 
            // PriceColumn
            // 
            PriceColumn.FillWeight = 83.24367F;
            PriceColumn.HeaderText = "Price";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            // 
            // QuantityColumn
            // 
            QuantityColumn.FillWeight = 93.01772F;
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.MinimumWidth = 6;
            QuantityColumn.Name = "QuantityColumn";
            // 
            // StatusColumn
            // 
            StatusColumn.FillWeight = 105.902321F;
            StatusColumn.HeaderText = "Status";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            // 
            // ActionColumn
            // 
            ActionColumn.FillWeight = 121.071823F;
            ActionColumn.HeaderText = "Action";
            ActionColumn.MinimumWidth = 6;
            ActionColumn.Name = "ActionColumn";
            ActionColumn.Resizable = DataGridViewTriState.True;
            ActionColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // EditColumn
            // 
            EditColumn.FillWeight = 139.035019F;
            EditColumn.HeaderText = "Edit";
            EditColumn.MinimumWidth = 6;
            EditColumn.Name = "EditColumn";
            EditColumn.Resizable = DataGridViewTriState.True;
            EditColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // RemoveColumn
            // 
            RemoveColumn.FillWeight = 160.427719F;
            RemoveColumn.HeaderText = "Remove";
            RemoveColumn.MinimumWidth = 6;
            RemoveColumn.Name = "RemoveColumn";
            RemoveColumn.Resizable = DataGridViewTriState.True;
            RemoveColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabAccounts
            // 
            tabAccounts.Controls.Add(dgvAccounts);
            tabAccounts.Location = new Point(4, 29);
            tabAccounts.Name = "tabAccounts";
            tabAccounts.Padding = new Padding(3);
            tabAccounts.Size = new Size(1051, 419);
            tabAccounts.TabIndex = 2;
            tabAccounts.Text = "Accounts";
            tabAccounts.UseVisualStyleBackColor = true;
            // 
            // dgvAccounts
            // 
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(311, 41);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.RowHeadersWidth = 51;
            dgvAccounts.Size = new Size(300, 188);
            dgvAccounts.TabIndex = 0;
            // 
            // tabViewproduct
            // 
            tabViewproduct.Location = new Point(4, 29);
            tabViewproduct.Name = "tabViewproduct";
            tabViewproduct.Padding = new Padding(3);
            tabViewproduct.Size = new Size(1051, 419);
            tabViewproduct.TabIndex = 3;
            tabViewproduct.Text = "View Product";
            tabViewproduct.UseVisualStyleBackColor = true;
            // 
            // tabMycart
            // 
            tabMycart.Location = new Point(4, 29);
            tabMycart.Name = "tabMycart";
            tabMycart.Padding = new Padding(3);
            tabMycart.Size = new Size(1051, 419);
            tabMycart.TabIndex = 4;
            tabMycart.Text = "My Cart";
            tabMycart.UseVisualStyleBackColor = true;
            // 
            // tabVieworder
            // 
            tabVieworder.Location = new Point(4, 29);
            tabVieworder.Name = "tabVieworder";
            tabVieworder.Padding = new Padding(3);
            tabVieworder.Size = new Size(1051, 419);
            tabVieworder.TabIndex = 5;
            tabVieworder.Text = "View Order";
            tabVieworder.UseVisualStyleBackColor = true;
            // 
            // tabAddproduct
            // 
            tabAddproduct.Location = new Point(4, 29);
            tabAddproduct.Name = "tabAddproduct";
            tabAddproduct.Padding = new Padding(3);
            tabAddproduct.Size = new Size(1051, 419);
            tabAddproduct.TabIndex = 6;
            tabAddproduct.Text = "Add User";
            tabAddproduct.UseVisualStyleBackColor = true;
            tabAddproduct.Click += tabAddproduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 452);
            Controls.Add(tabpage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabpage.ResumeLayout(false);
            tabpages.ResumeLayout(false);
            tabprofile.ResumeLayout(false);
            tabprofile.PerformLayout();
            pnlProfile.ResumeLayout(false);
            tabProductlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel tabpage;
        private Button btnLogout;
        private TabControl tabpages;
        private TabPage tabprofile;
        private TabPage tabProductlist;
        private TabPage tabAccounts;
        private TabPage tabViewproduct;
        private TabPage tabMycart;
        private TabPage tabVieworder;
        private TabPage tabAddproduct;
        private Panel pnlProfile;
        private Button btnChangepassword;
        private Button btnEditprofile;
        private Label lblPhonenumber;
        private Label lblRole;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblFullname;
        private Label lblUsername;
        private Label lblUserid;
        private TextBox txtBoxPhonenumber;
        private TextBox txtBoxPassword;
        private TextBox txtBoxEmail;
        private TextBox txtBoxFullname;
        private TextBox txtBoxUsername;
        private TextBox txtBoxUserid;
        private ComboBox cmbBoxRole;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ProductidColumn;
        private DataGridViewTextBoxColumn ProductnameColumn;
        private DataGridViewImageColumn ProductimageColumn;
        private DataGridViewTextBoxColumn CatagoryColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewButtonColumn ActionColumn;
        private DataGridViewButtonColumn EditColumn;
        private DataGridViewButtonColumn RemoveColumn;
        private Button btnAddproduct;
        private DataGridView dgvAccounts;
    }
}
