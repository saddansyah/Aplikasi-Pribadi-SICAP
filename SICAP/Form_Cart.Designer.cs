
namespace SICAP
{
    partial class Form_Cart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cbSearchCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPayment = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuy = new Guna.UI2.WinForms.Guna2Button();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.cbSearchCategory);
            this.pnlSearch.Controls.Add(this.tbSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(398, 88);
            this.pnlSearch.TabIndex = 9;
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchCategory.Animated = true;
            this.cbSearchCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchCategory.FocusedState.Parent = this.cbSearchCategory;
            this.cbSearchCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.cbSearchCategory.HoverState.Parent = this.cbSearchCategory;
            this.cbSearchCategory.ItemHeight = 30;
            this.cbSearchCategory.ItemsAppearance.Parent = this.cbSearchCategory;
            this.cbSearchCategory.Location = new System.Drawing.Point(181, 30);
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.ShadowDecoration.Parent = this.cbSearchCategory;
            this.cbSearchCategory.Size = new System.Drawing.Size(187, 36);
            this.cbSearchCategory.TabIndex = 10;
            this.cbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategory_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Animated = true;
            this.tbSearch.AutoRoundedCorners = true;
            this.tbSearch.BorderRadius = 20;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbSearch.Location = new System.Drawing.Point(38, 27);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "Search by item name";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(136, 43);
            this.tbSearch.TabIndex = 9;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.ColumnHeadersHeight = 45;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column8,
            this.Column5});
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.GridColor = System.Drawing.SystemColors.Control;
            this.dgvInventory.Location = new System.Drawing.Point(38, 113);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInventory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.dgvInventory.RowTemplate.Height = 35;
            this.dgvInventory.Size = new System.Drawing.Size(330, 632);
            this.dgvInventory.TabIndex = 11;
            this.dgvInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDBarang";
            this.Column1.FillWeight = 32.76981F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NamaBarang";
            this.Column2.FillWeight = 227.1179F;
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HargaJual";
            this.Column4.FillWeight = 124.5338F;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NamaKategori";
            this.Column8.HeaderText = "Category Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.FillWeight = 64.6355F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Text = "Add";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(203, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 47);
            this.label2.TabIndex = 16;
            this.label2.Text = "Shopping Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.ColumnHeadersHeight = 45;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column3,
            this.dataGridViewButtonColumn1,
            this.Column6});
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.GridColor = System.Drawing.Color.White;
            this.dgvCart.Location = new System.Drawing.Point(37, 190);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.dgvCart.RowTemplate.Height = 35;
            this.dgvCart.Size = new System.Drawing.Size(584, 288);
            this.dgvCart.TabIndex = 17;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemID";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.FillWeight = 34.36313F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn2.FillWeight = 238.1608F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.FillWeight = 130.5888F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.FillWeight = 104.8622F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.FillWeight = 104.8622F;
            this.Column3.HeaderText = "Amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewButtonColumn1.FillWeight = 67.77818F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn1.Text = "-";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(68)))), ((int)(((byte)(141)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column6.FillWeight = 68.44176F;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Text = "Delete";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(74, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(52, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Change :";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.lblReturn.Location = new System.Drawing.Point(125, 93);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(16, 21);
            this.lblReturn.TabIndex = 25;
            this.lblReturn.Text = "-";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCRUD.Controls.Add(this.lblTotal);
            this.pnlCRUD.Controls.Add(this.btnClear);
            this.pnlCRUD.Controls.Add(this.pnlPayment);
            this.pnlCRUD.Controls.Add(this.label1);
            this.pnlCRUD.Controls.Add(this.dgvCart);
            this.pnlCRUD.Controls.Add(this.label2);
            this.pnlCRUD.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCRUD.Location = new System.Drawing.Point(398, 0);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(655, 775);
            this.pnlCRUD.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Animated = true;
            this.lblTotal.AutoRoundedCorners = true;
            this.lblTotal.BorderRadius = 16;
            this.lblTotal.CheckedState.Parent = this.lblTotal;
            this.lblTotal.CustomImages.Parent = this.lblTotal;
            this.lblTotal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.HoverState.Parent = this.lblTotal;
            this.lblTotal.Location = new System.Drawing.Point(148, 504);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.ShadowDecoration.Parent = this.lblTotal;
            this.lblTotal.Size = new System.Drawing.Size(450, 35);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BorderRadius = 16;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Gray;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = global::SICAP.Properties.Resources.round_clear_white_481;
            this.btnClear.Location = new System.Drawing.Point(481, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(140, 34);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear the cart";
            this.btnClear.TextOffset = new System.Drawing.Point(0, -1);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlPayment
            // 
            this.pnlPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPayment.BackColor = System.Drawing.Color.Transparent;
            this.pnlPayment.Controls.Add(this.label4);
            this.pnlPayment.Controls.Add(this.tbPayment);
            this.pnlPayment.Controls.Add(this.lblReturn);
            this.pnlPayment.Controls.Add(this.btnBuy);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.FillColor = System.Drawing.Color.White;
            this.pnlPayment.Location = new System.Drawing.Point(37, 566);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.ShadowColor = System.Drawing.Color.Black;
            this.pnlPayment.Size = new System.Drawing.Size(584, 163);
            this.pnlPayment.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(73, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cash :";
            // 
            // tbPayment
            // 
            this.tbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPayment.Animated = true;
            this.tbPayment.AutoRoundedCorners = true;
            this.tbPayment.BorderRadius = 21;
            this.tbPayment.BorderThickness = 2;
            this.tbPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPayment.DefaultText = "";
            this.tbPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPayment.DisabledState.Parent = this.tbPayment;
            this.tbPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPayment.FocusedState.Parent = this.tbPayment;
            this.tbPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.tbPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPayment.HoverState.Parent = this.tbPayment;
            this.tbPayment.Location = new System.Drawing.Point(140, 28);
            this.tbPayment.Margin = new System.Windows.Forms.Padding(4);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.PasswordChar = '\0';
            this.tbPayment.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbPayment.PlaceholderText = "Enter your money amount here";
            this.tbPayment.SelectedText = "";
            this.tbPayment.ShadowDecoration.Parent = this.tbPayment;
            this.tbPayment.Size = new System.Drawing.Size(421, 45);
            this.tbPayment.TabIndex = 16;
            this.tbPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPayment.TextChanged += new System.EventHandler(this.tbPayment_TextChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.Animated = true;
            this.btnBuy.AutoRoundedCorners = true;
            this.btnBuy.BorderRadius = 18;
            this.btnBuy.CheckedState.Parent = this.btnBuy;
            this.btnBuy.CustomImages.Parent = this.btnBuy;
            this.btnBuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            this.btnBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.HoverState.Parent = this.btnBuy;
            this.btnBuy.Image = global::SICAP.Properties.Resources.outline_payments_white_48;
            this.btnBuy.Location = new System.Drawing.Point(388, 91);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ShadowDecoration.Parent = this.btnBuy;
            this.btnBuy.Size = new System.Drawing.Size(173, 38);
            this.btnBuy.TabIndex = 13;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextOffset = new System.Drawing.Point(2, 0);
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Form_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 775);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.dgvInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1069, 814);
            this.Name = "Form_Cart";
            this.Load += new System.EventHandler(this.Form_Cart_Load);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private Guna.UI2.WinForms.Guna2Button btnBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Panel pnlCRUD;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlPayment;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchCategory;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox tbPayment;
        private Guna.UI2.WinForms.Guna2GradientButton lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label label4;
    }
}