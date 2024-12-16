namespace PrjOverhaulHotel.PopUps
{
    partial class PopUpReservationAddons
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnDeleteAddon = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.dtgAddons = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.txtEditDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEditPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEditAddonname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddAddon = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnAddSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnEditAddon = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnEditSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnlAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAddDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddAddonname = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddonName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddons)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImage = global::PrjOverhaulHotel.Properties.Resources.Rectangle_13__2_;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.BorderColor = System.Drawing.Color.Black;
            this.pnlLogin.Controls.Add(this.btnCancel);
            this.pnlLogin.Controls.Add(this.btnDeleteAddon);
            this.pnlLogin.Controls.Add(this.dtgAddons);
            this.pnlLogin.Controls.Add(this.pnlEdit);
            this.pnlLogin.Controls.Add(this.btnAddAddon);
            this.pnlLogin.Controls.Add(this.btnAddSave);
            this.pnlLogin.Controls.Add(this.btnEditAddon);
            this.pnlLogin.Controls.Add(this.btnEditSave);
            this.pnlLogin.Controls.Add(this.pnlAdd);
            this.pnlLogin.Controls.Add(this.pnlDetails);
            this.pnlLogin.Location = new System.Drawing.Point(14, 14);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(845, 403);
            this.pnlLogin.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = global::PrjOverhaulHotel.Properties.Resources.check;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnCancel.Location = new System.Drawing.Point(587, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(180, 32);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "DONE";
            this.btnCancel.TextOffset = new System.Drawing.Point(7, -13);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDeleteAddon
            // 
            this.btnDeleteAddon.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAddon.BorderRadius = 15;
            this.btnDeleteAddon.CheckedState.Parent = this.btnDeleteAddon;
            this.btnDeleteAddon.CustomImages.Parent = this.btnDeleteAddon;
            this.btnDeleteAddon.FillColor = System.Drawing.Color.Black;
            this.btnDeleteAddon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteAddon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAddon.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAddon.HoverState.Parent = this.btnDeleteAddon;
            this.btnDeleteAddon.Image = global::PrjOverhaulHotel.Properties.Resources.trash_2;
            this.btnDeleteAddon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteAddon.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnDeleteAddon.Location = new System.Drawing.Point(587, 289);
            this.btnDeleteAddon.Name = "btnDeleteAddon";
            this.btnDeleteAddon.ShadowDecoration.Parent = this.btnDeleteAddon;
            this.btnDeleteAddon.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteAddon.TabIndex = 40;
            this.btnDeleteAddon.Text = "DELETE";
            this.btnDeleteAddon.TextOffset = new System.Drawing.Point(7, -13);
            this.btnDeleteAddon.Click += new System.EventHandler(this.btnDeleteAddon_Click);
            // 
            // dtgAddons
            // 
            this.dtgAddons.AllowUserToAddRows = false;
            this.dtgAddons.AllowUserToDeleteRows = false;
            this.dtgAddons.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAddons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgAddons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAddons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgAddons.EnableHeadersVisualStyles = false;
            this.dtgAddons.GridColor = System.Drawing.Color.Black;
            this.dtgAddons.Location = new System.Drawing.Point(25, 22);
            this.dtgAddons.MultiSelect = false;
            this.dtgAddons.Name = "dtgAddons";
            this.dtgAddons.ReadOnly = true;
            this.dtgAddons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAddons.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgAddons.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgAddons.Size = new System.Drawing.Size(476, 359);
            this.dtgAddons.TabIndex = 37;
            this.dtgAddons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAddons_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Addon Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 253;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlEdit.BorderColor = System.Drawing.Color.Black;
            this.pnlEdit.BorderRadius = 15;
            this.pnlEdit.BorderThickness = 2;
            this.pnlEdit.Controls.Add(this.txtEditDescription);
            this.pnlEdit.Controls.Add(this.txtEditPrice);
            this.pnlEdit.Controls.Add(this.txtEditAddonname);
            this.pnlEdit.FillColor = System.Drawing.Color.White;
            this.pnlEdit.Location = new System.Drawing.Point(515, 36);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.ShadowDecoration.Parent = this.pnlEdit;
            this.pnlEdit.Size = new System.Drawing.Size(315, 156);
            this.pnlEdit.TabIndex = 49;
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtEditDescription.BorderColor = System.Drawing.Color.Black;
            this.txtEditDescription.BorderRadius = 12;
            this.txtEditDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditDescription.DefaultText = "";
            this.txtEditDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditDescription.DisabledState.Parent = this.txtEditDescription;
            this.txtEditDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditDescription.FocusedState.Parent = this.txtEditDescription;
            this.txtEditDescription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDescription.ForeColor = System.Drawing.Color.Black;
            this.txtEditDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtEditDescription.HoverState.Parent = this.txtEditDescription;
            this.txtEditDescription.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtEditDescription.Location = new System.Drawing.Point(15, 92);
            this.txtEditDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.PasswordChar = '\0';
            this.txtEditDescription.PlaceholderText = "Description";
            this.txtEditDescription.SelectedText = "";
            this.txtEditDescription.ShadowDecoration.Parent = this.txtEditDescription;
            this.txtEditDescription.Size = new System.Drawing.Size(284, 48);
            this.txtEditDescription.TabIndex = 17;
            this.txtEditDescription.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtEditPrice.BorderColor = System.Drawing.Color.Black;
            this.txtEditPrice.BorderRadius = 12;
            this.txtEditPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditPrice.DefaultText = "";
            this.txtEditPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditPrice.DisabledState.Parent = this.txtEditPrice;
            this.txtEditPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditPrice.FocusedState.Parent = this.txtEditPrice;
            this.txtEditPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrice.ForeColor = System.Drawing.Color.Black;
            this.txtEditPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtEditPrice.HoverState.Parent = this.txtEditPrice;
            this.txtEditPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtEditPrice.Location = new System.Drawing.Point(15, 52);
            this.txtEditPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.PasswordChar = '\0';
            this.txtEditPrice.PlaceholderText = "Price";
            this.txtEditPrice.SelectedText = "";
            this.txtEditPrice.ShadowDecoration.Parent = this.txtEditPrice;
            this.txtEditPrice.Size = new System.Drawing.Size(284, 30);
            this.txtEditPrice.TabIndex = 16;
            this.txtEditPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtEditAddonname
            // 
            this.txtEditAddonname.BackColor = System.Drawing.Color.Transparent;
            this.txtEditAddonname.BorderColor = System.Drawing.Color.Black;
            this.txtEditAddonname.BorderRadius = 12;
            this.txtEditAddonname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditAddonname.DefaultText = "";
            this.txtEditAddonname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditAddonname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditAddonname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditAddonname.DisabledState.Parent = this.txtEditAddonname;
            this.txtEditAddonname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditAddonname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditAddonname.FocusedState.Parent = this.txtEditAddonname;
            this.txtEditAddonname.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAddonname.ForeColor = System.Drawing.Color.Black;
            this.txtEditAddonname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtEditAddonname.HoverState.Parent = this.txtEditAddonname;
            this.txtEditAddonname.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtEditAddonname.Location = new System.Drawing.Point(15, 18);
            this.txtEditAddonname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditAddonname.Name = "txtEditAddonname";
            this.txtEditAddonname.PasswordChar = '\0';
            this.txtEditAddonname.PlaceholderText = "Addon Name";
            this.txtEditAddonname.SelectedText = "";
            this.txtEditAddonname.ShadowDecoration.Parent = this.txtEditAddonname;
            this.txtEditAddonname.Size = new System.Drawing.Size(284, 30);
            this.txtEditAddonname.TabIndex = 14;
            this.txtEditAddonname.TextOffset = new System.Drawing.Point(10, 0);
            this.txtEditAddonname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEditAddonname_MouseClick);
            // 
            // btnAddAddon
            // 
            this.btnAddAddon.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAddon.BorderRadius = 15;
            this.btnAddAddon.CheckedState.Parent = this.btnAddAddon;
            this.btnAddAddon.CustomImages.Parent = this.btnAddAddon;
            this.btnAddAddon.FillColor = System.Drawing.Color.Black;
            this.btnAddAddon.FillColor2 = System.Drawing.Color.Teal;
            this.btnAddAddon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAddon.ForeColor = System.Drawing.Color.White;
            this.btnAddAddon.HoverState.Parent = this.btnAddAddon;
            this.btnAddAddon.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.btnAddAddon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddAddon.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnAddAddon.Location = new System.Drawing.Point(587, 207);
            this.btnAddAddon.Name = "btnAddAddon";
            this.btnAddAddon.ShadowDecoration.Parent = this.btnAddAddon;
            this.btnAddAddon.Size = new System.Drawing.Size(180, 32);
            this.btnAddAddon.TabIndex = 38;
            this.btnAddAddon.Text = "ADD";
            this.btnAddAddon.TextOffset = new System.Drawing.Point(7, -13);
            this.btnAddAddon.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSave.BorderRadius = 15;
            this.btnAddSave.CheckedState.Parent = this.btnAddSave;
            this.btnAddSave.CustomImages.Parent = this.btnAddSave;
            this.btnAddSave.FillColor = System.Drawing.Color.Black;
            this.btnAddSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddSave.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.ForeColor = System.Drawing.Color.White;
            this.btnAddSave.HoverState.Parent = this.btnAddSave;
            this.btnAddSave.Image = global::PrjOverhaulHotel.Properties.Resources.check;
            this.btnAddSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddSave.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnAddSave.Location = new System.Drawing.Point(587, 207);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.ShadowDecoration.Parent = this.btnAddSave;
            this.btnAddSave.Size = new System.Drawing.Size(180, 32);
            this.btnAddSave.TabIndex = 45;
            this.btnAddSave.Text = "SAVE";
            this.btnAddSave.TextOffset = new System.Drawing.Point(7, -11);
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnEditAddon
            // 
            this.btnEditAddon.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAddon.BorderRadius = 15;
            this.btnEditAddon.CheckedState.Parent = this.btnEditAddon;
            this.btnEditAddon.CustomImages.Parent = this.btnEditAddon;
            this.btnEditAddon.FillColor = System.Drawing.Color.Black;
            this.btnEditAddon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditAddon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAddon.ForeColor = System.Drawing.Color.White;
            this.btnEditAddon.HoverState.Parent = this.btnEditAddon;
            this.btnEditAddon.Image = global::PrjOverhaulHotel.Properties.Resources.bolt;
            this.btnEditAddon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditAddon.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnEditAddon.Location = new System.Drawing.Point(587, 247);
            this.btnEditAddon.Name = "btnEditAddon";
            this.btnEditAddon.ShadowDecoration.Parent = this.btnEditAddon;
            this.btnEditAddon.Size = new System.Drawing.Size(180, 32);
            this.btnEditAddon.TabIndex = 39;
            this.btnEditAddon.Text = "EDIT";
            this.btnEditAddon.TextOffset = new System.Drawing.Point(7, -13);
            this.btnEditAddon.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSave.BorderRadius = 15;
            this.btnEditSave.CheckedState.Parent = this.btnEditSave;
            this.btnEditSave.CustomImages.Parent = this.btnEditSave;
            this.btnEditSave.FillColor = System.Drawing.Color.Black;
            this.btnEditSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditSave.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.ForeColor = System.Drawing.Color.White;
            this.btnEditSave.HoverState.Parent = this.btnEditSave;
            this.btnEditSave.Image = global::PrjOverhaulHotel.Properties.Resources.check;
            this.btnEditSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditSave.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnEditSave.Location = new System.Drawing.Point(587, 247);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.ShadowDecoration.Parent = this.btnEditSave;
            this.btnEditSave.Size = new System.Drawing.Size(180, 32);
            this.btnEditSave.TabIndex = 44;
            this.btnEditSave.Text = "SAVE";
            this.btnEditSave.TextOffset = new System.Drawing.Point(7, -11);
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.BorderColor = System.Drawing.Color.Black;
            this.pnlAdd.BorderRadius = 15;
            this.pnlAdd.BorderThickness = 2;
            this.pnlAdd.Controls.Add(this.txtAddDescription);
            this.pnlAdd.Controls.Add(this.txtAddPrice);
            this.pnlAdd.Controls.Add(this.txtAddAddonname);
            this.pnlAdd.FillColor = System.Drawing.Color.White;
            this.pnlAdd.Location = new System.Drawing.Point(515, 36);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.ShadowDecoration.Parent = this.pnlAdd;
            this.pnlAdd.Size = new System.Drawing.Size(315, 156);
            this.pnlAdd.TabIndex = 48;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtAddDescription.BorderColor = System.Drawing.Color.Black;
            this.txtAddDescription.BorderRadius = 12;
            this.txtAddDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddDescription.DefaultText = "";
            this.txtAddDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddDescription.DisabledState.Parent = this.txtAddDescription;
            this.txtAddDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddDescription.FocusedState.Parent = this.txtAddDescription;
            this.txtAddDescription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDescription.ForeColor = System.Drawing.Color.Black;
            this.txtAddDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddDescription.HoverState.Parent = this.txtAddDescription;
            this.txtAddDescription.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddDescription.Location = new System.Drawing.Point(15, 92);
            this.txtAddDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.PasswordChar = '\0';
            this.txtAddDescription.PlaceholderText = "Description";
            this.txtAddDescription.SelectedText = "";
            this.txtAddDescription.ShadowDecoration.Parent = this.txtAddDescription;
            this.txtAddDescription.Size = new System.Drawing.Size(284, 48);
            this.txtAddDescription.TabIndex = 18;
            this.txtAddDescription.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtAddPrice.BorderColor = System.Drawing.Color.Black;
            this.txtAddPrice.BorderRadius = 12;
            this.txtAddPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPrice.DefaultText = "";
            this.txtAddPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPrice.DisabledState.Parent = this.txtAddPrice;
            this.txtAddPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddPrice.FocusedState.Parent = this.txtAddPrice;
            this.txtAddPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPrice.ForeColor = System.Drawing.Color.Black;
            this.txtAddPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddPrice.HoverState.Parent = this.txtAddPrice;
            this.txtAddPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddPrice.Location = new System.Drawing.Point(15, 52);
            this.txtAddPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.PasswordChar = '\0';
            this.txtAddPrice.PlaceholderText = "Price";
            this.txtAddPrice.ReadOnly = true;
            this.txtAddPrice.SelectedText = "";
            this.txtAddPrice.ShadowDecoration.Parent = this.txtAddPrice;
            this.txtAddPrice.Size = new System.Drawing.Size(284, 30);
            this.txtAddPrice.TabIndex = 16;
            this.txtAddPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtAddAddonname
            // 
            this.txtAddAddonname.BackColor = System.Drawing.Color.Transparent;
            this.txtAddAddonname.BorderColor = System.Drawing.Color.Black;
            this.txtAddAddonname.BorderRadius = 12;
            this.txtAddAddonname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddAddonname.DefaultText = "";
            this.txtAddAddonname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddAddonname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddAddonname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddAddonname.DisabledState.Parent = this.txtAddAddonname;
            this.txtAddAddonname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddAddonname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddAddonname.FocusedState.Parent = this.txtAddAddonname;
            this.txtAddAddonname.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddonname.ForeColor = System.Drawing.Color.Black;
            this.txtAddAddonname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddAddonname.HoverState.Parent = this.txtAddAddonname;
            this.txtAddAddonname.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddAddonname.Location = new System.Drawing.Point(15, 18);
            this.txtAddAddonname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddAddonname.Name = "txtAddAddonname";
            this.txtAddAddonname.PasswordChar = '\0';
            this.txtAddAddonname.PlaceholderText = "Addon Name";
            this.txtAddAddonname.ReadOnly = true;
            this.txtAddAddonname.SelectedText = "";
            this.txtAddAddonname.ShadowDecoration.Parent = this.txtAddAddonname;
            this.txtAddAddonname.Size = new System.Drawing.Size(284, 30);
            this.txtAddAddonname.TabIndex = 14;
            this.txtAddAddonname.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetails.BorderColor = System.Drawing.Color.Black;
            this.pnlDetails.BorderRadius = 15;
            this.pnlDetails.BorderThickness = 2;
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Controls.Add(this.txtPrice);
            this.pnlDetails.Controls.Add(this.txtAddonName);
            this.pnlDetails.FillColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(515, 36);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.ShadowDecoration.Parent = this.pnlDetails;
            this.pnlDetails.Size = new System.Drawing.Size(315, 156);
            this.pnlDetails.TabIndex = 47;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(15, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(284, 47);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.BorderRadius = 12;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPrice.Location = new System.Drawing.Point(15, 52);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(284, 30);
            this.txtPrice.TabIndex = 16;
            this.txtPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtAddonName
            // 
            this.txtAddonName.BackColor = System.Drawing.Color.Transparent;
            this.txtAddonName.BorderColor = System.Drawing.Color.Black;
            this.txtAddonName.BorderRadius = 12;
            this.txtAddonName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddonName.DefaultText = "";
            this.txtAddonName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddonName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddonName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddonName.DisabledState.Parent = this.txtAddonName;
            this.txtAddonName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddonName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddonName.FocusedState.Parent = this.txtAddonName;
            this.txtAddonName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddonName.ForeColor = System.Drawing.Color.Black;
            this.txtAddonName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddonName.HoverState.Parent = this.txtAddonName;
            this.txtAddonName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddonName.Location = new System.Drawing.Point(15, 18);
            this.txtAddonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddonName.Name = "txtAddonName";
            this.txtAddonName.PasswordChar = '\0';
            this.txtAddonName.PlaceholderText = "Addon Name";
            this.txtAddonName.ReadOnly = true;
            this.txtAddonName.SelectedText = "";
            this.txtAddonName.ShadowDecoration.Parent = this.txtAddonName;
            this.txtAddonName.Size = new System.Drawing.Size(284, 30);
            this.txtAddonName.TabIndex = 14;
            this.txtAddonName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // PopUpReservationAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(875, 433);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpReservationAddons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpReservationRoom";
            this.Load += new System.EventHandler(this.PopUpReservationAddons_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddons)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDeleteAddon;
        private System.Windows.Forms.DataGridView dtgAddons;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEditAddon;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEditSave;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddAddon;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddSave;
        private Guna.UI2.WinForms.Guna2Panel pnlEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtEditDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtEditPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtEditAddonname;
        private Guna.UI2.WinForms.Guna2Panel pnlAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtAddAddonname;
        private Guna.UI2.WinForms.Guna2Panel pnlDetails;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtAddonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2TextBox txtAddDescription;
    }
}