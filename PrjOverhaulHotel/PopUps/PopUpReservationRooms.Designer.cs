namespace PrjOverhaulHotel.PopUps
{
    partial class PopUpReservationRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpReservationRooms));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgRooms = new System.Windows.Forms.DataGridView();
            this.btnDeleteReservation = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnEditReservation = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnAddReservation = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnlDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.txtRoomname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCheckoutDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCheckinDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAddRoomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbAddRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtmAddCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmAddCheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlEdit = new Guna.UI2.WinForms.Guna2Panel();
            this.dtmEditCheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmEditCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbEditRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEditRoomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEditPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEditRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRooms)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlEdit.SuspendLayout();
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
            this.pnlLogin.Controls.Add(this.btnDeleteReservation);
            this.pnlLogin.Controls.Add(this.dtgRooms);
            this.pnlLogin.Controls.Add(this.pnlDetails);
            this.pnlLogin.Controls.Add(this.pnlAdd);
            this.pnlLogin.Controls.Add(this.pnlEdit);
            this.pnlLogin.Controls.Add(this.btnEditReservation);
            this.pnlLogin.Controls.Add(this.btnAddReservation);
            this.pnlLogin.Controls.Add(this.btnAddSave);
            this.pnlLogin.Controls.Add(this.btnEditSave);
            this.pnlLogin.Location = new System.Drawing.Point(14, 14);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(868, 403);
            this.pnlLogin.TabIndex = 12;
            this.pnlLogin.Click += new System.EventHandler(this.pnlLogin_Click);
            // 
            // dtgRooms
            // 
            this.dtgRooms.AllowUserToAddRows = false;
            this.dtgRooms.AllowUserToDeleteRows = false;
            this.dtgRooms.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column5});
            this.dtgRooms.EnableHeadersVisualStyles = false;
            this.dtgRooms.GridColor = System.Drawing.Color.Black;
            this.dtgRooms.Location = new System.Drawing.Point(25, 22);
            this.dtgRooms.MultiSelect = false;
            this.dtgRooms.Name = "dtgRooms";
            this.dtgRooms.ReadOnly = true;
            this.dtgRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRooms.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRooms.Size = new System.Drawing.Size(814, 177);
            this.dtgRooms.TabIndex = 37;
            this.dtgRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRooms_CellClick);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteReservation.BorderRadius = 15;
            this.btnDeleteReservation.CheckedState.Parent = this.btnDeleteReservation;
            this.btnDeleteReservation.CustomImages.Parent = this.btnDeleteReservation;
            this.btnDeleteReservation.FillColor = System.Drawing.Color.Black;
            this.btnDeleteReservation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteReservation.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReservation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReservation.HoverState.Parent = this.btnDeleteReservation;
            this.btnDeleteReservation.Image = global::PrjOverhaulHotel.Properties.Resources.trash_2;
            this.btnDeleteReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteReservation.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnDeleteReservation.Location = new System.Drawing.Point(659, 333);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.ShadowDecoration.Parent = this.btnDeleteReservation;
            this.btnDeleteReservation.Size = new System.Drawing.Size(180, 32);
            this.btnDeleteReservation.TabIndex = 40;
            this.btnDeleteReservation.Text = "DELETE";
            this.btnDeleteReservation.TextOffset = new System.Drawing.Point(7, -11);
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnEditReservation.BorderRadius = 15;
            this.btnEditReservation.CheckedState.Parent = this.btnEditReservation;
            this.btnEditReservation.CustomImages.Parent = this.btnEditReservation;
            this.btnEditReservation.FillColor = System.Drawing.Color.Black;
            this.btnEditReservation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditReservation.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReservation.ForeColor = System.Drawing.Color.White;
            this.btnEditReservation.HoverState.Parent = this.btnEditReservation;
            this.btnEditReservation.Image = global::PrjOverhaulHotel.Properties.Resources.bolt;
            this.btnEditReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditReservation.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnEditReservation.Location = new System.Drawing.Point(659, 288);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.ShadowDecoration.Parent = this.btnEditReservation;
            this.btnEditReservation.Size = new System.Drawing.Size(180, 32);
            this.btnEditReservation.TabIndex = 39;
            this.btnEditReservation.Text = "EDIT";
            this.btnEditReservation.TextOffset = new System.Drawing.Point(7, -11);
            this.btnEditReservation.Click += new System.EventHandler(this.btnEditReservation_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnAddReservation.BorderRadius = 15;
            this.btnAddReservation.CheckedState.Parent = this.btnAddReservation;
            this.btnAddReservation.CustomImages.Parent = this.btnAddReservation;
            this.btnAddReservation.FillColor = System.Drawing.Color.Black;
            this.btnAddReservation.FillColor2 = System.Drawing.Color.Teal;
            this.btnAddReservation.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.HoverState.Parent = this.btnAddReservation;
            this.btnAddReservation.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.btnAddReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddReservation.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnAddReservation.Location = new System.Drawing.Point(659, 243);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.ShadowDecoration.Parent = this.btnAddReservation;
            this.btnAddReservation.Size = new System.Drawing.Size(180, 32);
            this.btnAddReservation.TabIndex = 38;
            this.btnAddReservation.Text = "ADD";
            this.btnAddReservation.TextOffset = new System.Drawing.Point(7, -11);
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetails.BorderColor = System.Drawing.Color.Black;
            this.pnlDetails.BorderRadius = 15;
            this.pnlDetails.BorderThickness = 2;
            this.pnlDetails.Controls.Add(this.txtCheckoutDate);
            this.pnlDetails.Controls.Add(this.txtCheckinDate);
            this.pnlDetails.Controls.Add(this.txtTotalPrice);
            this.pnlDetails.Controls.Add(this.txtPricePerDay);
            this.pnlDetails.Controls.Add(this.txtRoomType);
            this.pnlDetails.Controls.Add(this.txtRoomname);
            this.pnlDetails.FillColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(25, 225);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.ShadowDecoration.Parent = this.pnlDetails;
            this.pnlDetails.Size = new System.Drawing.Size(608, 156);
            this.pnlDetails.TabIndex = 41;
            // 
            // txtRoomname
            // 
            this.txtRoomname.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomname.BorderRadius = 12;
            this.txtRoomname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomname.DefaultText = "";
            this.txtRoomname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomname.DisabledState.Parent = this.txtRoomname;
            this.txtRoomname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomname.FocusedState.Parent = this.txtRoomname;
            this.txtRoomname.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomname.ForeColor = System.Drawing.Color.Black;
            this.txtRoomname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtRoomname.HoverState.Parent = this.txtRoomname;
            this.txtRoomname.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtRoomname.Location = new System.Drawing.Point(15, 20);
            this.txtRoomname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomname.Name = "txtRoomname";
            this.txtRoomname.PasswordChar = '\0';
            this.txtRoomname.PlaceholderText = "Room Name";
            this.txtRoomname.ReadOnly = true;
            this.txtRoomname.SelectedText = "";
            this.txtRoomname.ShadowDecoration.Parent = this.txtRoomname;
            this.txtRoomname.Size = new System.Drawing.Size(284, 30);
            this.txtRoomname.TabIndex = 14;
            this.txtRoomname.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomType.BorderRadius = 12;
            this.txtRoomType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomType.DefaultText = "";
            this.txtRoomType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomType.DisabledState.Parent = this.txtRoomType;
            this.txtRoomType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomType.FocusedState.Parent = this.txtRoomType;
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.ForeColor = System.Drawing.Color.Black;
            this.txtRoomType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtRoomType.HoverState.Parent = this.txtRoomType;
            this.txtRoomType.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtRoomType.Location = new System.Drawing.Point(307, 20);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.PasswordChar = '\0';
            this.txtRoomType.PlaceholderText = "Room Type";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.SelectedText = "";
            this.txtRoomType.ShadowDecoration.Parent = this.txtRoomType;
            this.txtRoomType.Size = new System.Drawing.Size(284, 30);
            this.txtRoomType.TabIndex = 15;
            this.txtRoomType.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.BackColor = System.Drawing.Color.Transparent;
            this.txtPricePerDay.BorderRadius = 12;
            this.txtPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerDay.DefaultText = "";
            this.txtPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerDay.DisabledState.Parent = this.txtPricePerDay;
            this.txtPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPricePerDay.FocusedState.Parent = this.txtPricePerDay;
            this.txtPricePerDay.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtPricePerDay.HoverState.Parent = this.txtPricePerDay;
            this.txtPricePerDay.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPricePerDay.Location = new System.Drawing.Point(15, 63);
            this.txtPricePerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.PasswordChar = '\0';
            this.txtPricePerDay.PlaceholderText = "Price Per Day";
            this.txtPricePerDay.ReadOnly = true;
            this.txtPricePerDay.SelectedText = "";
            this.txtPricePerDay.ShadowDecoration.Parent = this.txtPricePerDay;
            this.txtPricePerDay.Size = new System.Drawing.Size(284, 30);
            this.txtPricePerDay.TabIndex = 16;
            this.txtPricePerDay.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtCheckoutDate
            // 
            this.txtCheckoutDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckoutDate.BorderRadius = 12;
            this.txtCheckoutDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckoutDate.DefaultText = "";
            this.txtCheckoutDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCheckoutDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCheckoutDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckoutDate.DisabledState.Parent = this.txtCheckoutDate;
            this.txtCheckoutDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckoutDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCheckoutDate.FocusedState.Parent = this.txtCheckoutDate;
            this.txtCheckoutDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckoutDate.ForeColor = System.Drawing.Color.Black;
            this.txtCheckoutDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtCheckoutDate.HoverState.Parent = this.txtCheckoutDate;
            this.txtCheckoutDate.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCheckoutDate.Location = new System.Drawing.Point(307, 108);
            this.txtCheckoutDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckoutDate.Name = "txtCheckoutDate";
            this.txtCheckoutDate.PasswordChar = '\0';
            this.txtCheckoutDate.PlaceholderText = "Check-out Date";
            this.txtCheckoutDate.ReadOnly = true;
            this.txtCheckoutDate.SelectedText = "";
            this.txtCheckoutDate.ShadowDecoration.Parent = this.txtCheckoutDate;
            this.txtCheckoutDate.Size = new System.Drawing.Size(284, 30);
            this.txtCheckoutDate.TabIndex = 19;
            this.txtCheckoutDate.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtCheckinDate
            // 
            this.txtCheckinDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckinDate.BorderRadius = 12;
            this.txtCheckinDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckinDate.DefaultText = "";
            this.txtCheckinDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCheckinDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCheckinDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckinDate.DisabledState.Parent = this.txtCheckinDate;
            this.txtCheckinDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCheckinDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCheckinDate.FocusedState.Parent = this.txtCheckinDate;
            this.txtCheckinDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckinDate.ForeColor = System.Drawing.Color.Black;
            this.txtCheckinDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtCheckinDate.HoverState.Parent = this.txtCheckinDate;
            this.txtCheckinDate.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCheckinDate.Location = new System.Drawing.Point(15, 108);
            this.txtCheckinDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCheckinDate.Name = "txtCheckinDate";
            this.txtCheckinDate.PasswordChar = '\0';
            this.txtCheckinDate.PlaceholderText = "Check-in Date";
            this.txtCheckinDate.ReadOnly = true;
            this.txtCheckinDate.SelectedText = "";
            this.txtCheckinDate.ShadowDecoration.Parent = this.txtCheckinDate;
            this.txtCheckinDate.Size = new System.Drawing.Size(284, 30);
            this.txtCheckinDate.TabIndex = 18;
            this.txtCheckinDate.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.BorderRadius = 12;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtTotalPrice.Location = new System.Drawing.Point(307, 63);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "Total Price";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(284, 30);
            this.txtTotalPrice.TabIndex = 17;
            this.txtTotalPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.BorderColor = System.Drawing.Color.Black;
            this.pnlAdd.BorderRadius = 15;
            this.pnlAdd.BorderThickness = 2;
            this.pnlAdd.Controls.Add(this.dtmAddCheckout);
            this.pnlAdd.Controls.Add(this.dtmAddCheckin);
            this.pnlAdd.Controls.Add(this.cmbAddRoomType);
            this.pnlAdd.Controls.Add(this.txtAddRoomPrice);
            this.pnlAdd.Controls.Add(this.txtAddPricePerDay);
            this.pnlAdd.Controls.Add(this.txtAddRoomName);
            this.pnlAdd.FillColor = System.Drawing.Color.White;
            this.pnlAdd.Location = new System.Drawing.Point(25, 225);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.ShadowDecoration.Parent = this.pnlAdd;
            this.pnlAdd.Size = new System.Drawing.Size(608, 156);
            this.pnlAdd.TabIndex = 42;
            // 
            // txtAddRoomPrice
            // 
            this.txtAddRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtAddRoomPrice.BorderColor = System.Drawing.Color.Black;
            this.txtAddRoomPrice.BorderRadius = 12;
            this.txtAddRoomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddRoomPrice.DefaultText = "";
            this.txtAddRoomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddRoomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddRoomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddRoomPrice.DisabledState.Parent = this.txtAddRoomPrice;
            this.txtAddRoomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddRoomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddRoomPrice.FocusedState.Parent = this.txtAddRoomPrice;
            this.txtAddRoomPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtAddRoomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddRoomPrice.HoverState.Parent = this.txtAddRoomPrice;
            this.txtAddRoomPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddRoomPrice.Location = new System.Drawing.Point(15, 63);
            this.txtAddRoomPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddRoomPrice.Name = "txtAddRoomPrice";
            this.txtAddRoomPrice.PasswordChar = '\0';
            this.txtAddRoomPrice.PlaceholderText = "Room Price";
            this.txtAddRoomPrice.ReadOnly = true;
            this.txtAddRoomPrice.SelectedText = "";
            this.txtAddRoomPrice.ShadowDecoration.Parent = this.txtAddRoomPrice;
            this.txtAddRoomPrice.Size = new System.Drawing.Size(284, 30);
            this.txtAddRoomPrice.TabIndex = 17;
            this.txtAddRoomPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtAddPricePerDay
            // 
            this.txtAddPricePerDay.BackColor = System.Drawing.Color.Transparent;
            this.txtAddPricePerDay.BorderColor = System.Drawing.Color.Black;
            this.txtAddPricePerDay.BorderRadius = 12;
            this.txtAddPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddPricePerDay.DefaultText = "";
            this.txtAddPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPricePerDay.DisabledState.Parent = this.txtAddPricePerDay;
            this.txtAddPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddPricePerDay.FocusedState.Parent = this.txtAddPricePerDay;
            this.txtAddPricePerDay.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtAddPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddPricePerDay.HoverState.Parent = this.txtAddPricePerDay;
            this.txtAddPricePerDay.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddPricePerDay.Location = new System.Drawing.Point(307, 63);
            this.txtAddPricePerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddPricePerDay.Name = "txtAddPricePerDay";
            this.txtAddPricePerDay.PasswordChar = '\0';
            this.txtAddPricePerDay.PlaceholderText = "Price Per Day";
            this.txtAddPricePerDay.SelectedText = "";
            this.txtAddPricePerDay.ShadowDecoration.Parent = this.txtAddPricePerDay;
            this.txtAddPricePerDay.Size = new System.Drawing.Size(284, 30);
            this.txtAddPricePerDay.TabIndex = 16;
            this.txtAddPricePerDay.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtAddRoomName
            // 
            this.txtAddRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtAddRoomName.BorderColor = System.Drawing.Color.Black;
            this.txtAddRoomName.BorderRadius = 12;
            this.txtAddRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddRoomName.DefaultText = "";
            this.txtAddRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddRoomName.DisabledState.Parent = this.txtAddRoomName;
            this.txtAddRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddRoomName.FocusedState.Parent = this.txtAddRoomName;
            this.txtAddRoomName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtAddRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtAddRoomName.HoverState.Parent = this.txtAddRoomName;
            this.txtAddRoomName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAddRoomName.Location = new System.Drawing.Point(15, 20);
            this.txtAddRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddRoomName.Name = "txtAddRoomName";
            this.txtAddRoomName.PasswordChar = '\0';
            this.txtAddRoomName.PlaceholderText = "Room Name";
            this.txtAddRoomName.SelectedText = "";
            this.txtAddRoomName.ShadowDecoration.Parent = this.txtAddRoomName;
            this.txtAddRoomName.Size = new System.Drawing.Size(284, 30);
            this.txtAddRoomName.TabIndex = 14;
            this.txtAddRoomName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // cmbAddRoomType
            // 
            this.cmbAddRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbAddRoomType.BorderColor = System.Drawing.Color.Black;
            this.cmbAddRoomType.BorderRadius = 15;
            this.cmbAddRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAddRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAddRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAddRoomType.FocusedState.Parent = this.cmbAddRoomType;
            this.cmbAddRoomType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAddRoomType.FormattingEnabled = true;
            this.cmbAddRoomType.HoverState.Parent = this.cmbAddRoomType;
            this.cmbAddRoomType.ItemHeight = 30;
            this.cmbAddRoomType.ItemsAppearance.Parent = this.cmbAddRoomType;
            this.cmbAddRoomType.Location = new System.Drawing.Point(307, 16);
            this.cmbAddRoomType.Name = "cmbAddRoomType";
            this.cmbAddRoomType.ShadowDecoration.Parent = this.cmbAddRoomType;
            this.cmbAddRoomType.Size = new System.Drawing.Size(284, 36);
            this.cmbAddRoomType.TabIndex = 20;
            // 
            // dtmAddCheckin
            // 
            this.dtmAddCheckin.BorderRadius = 15;
            this.dtmAddCheckin.BorderThickness = 1;
            this.dtmAddCheckin.CheckedState.Parent = this.dtmAddCheckin;
            this.dtmAddCheckin.FillColor = System.Drawing.Color.White;
            this.dtmAddCheckin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmAddCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmAddCheckin.HoverState.Parent = this.dtmAddCheckin;
            this.dtmAddCheckin.Location = new System.Drawing.Point(15, 104);
            this.dtmAddCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmAddCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmAddCheckin.Name = "dtmAddCheckin";
            this.dtmAddCheckin.ShadowDecoration.Parent = this.dtmAddCheckin;
            this.dtmAddCheckin.Size = new System.Drawing.Size(284, 36);
            this.dtmAddCheckin.TabIndex = 21;
            this.dtmAddCheckin.TextOffset = new System.Drawing.Point(0, 1);
            this.dtmAddCheckin.Value = new System.DateTime(2024, 11, 8, 23, 42, 22, 823);
            // 
            // dtmAddCheckout
            // 
            this.dtmAddCheckout.BorderRadius = 15;
            this.dtmAddCheckout.BorderThickness = 1;
            this.dtmAddCheckout.CheckedState.Parent = this.dtmAddCheckout;
            this.dtmAddCheckout.FillColor = System.Drawing.Color.White;
            this.dtmAddCheckout.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmAddCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmAddCheckout.HoverState.Parent = this.dtmAddCheckout;
            this.dtmAddCheckout.Location = new System.Drawing.Point(307, 104);
            this.dtmAddCheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmAddCheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmAddCheckout.Name = "dtmAddCheckout";
            this.dtmAddCheckout.ShadowDecoration.Parent = this.dtmAddCheckout;
            this.dtmAddCheckout.Size = new System.Drawing.Size(284, 36);
            this.dtmAddCheckout.TabIndex = 22;
            this.dtmAddCheckout.TextOffset = new System.Drawing.Point(0, 1);
            this.dtmAddCheckout.Value = new System.DateTime(2024, 11, 8, 23, 42, 22, 823);
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlEdit.BorderColor = System.Drawing.Color.Black;
            this.pnlEdit.BorderRadius = 15;
            this.pnlEdit.BorderThickness = 2;
            this.pnlEdit.Controls.Add(this.dtmEditCheckout);
            this.pnlEdit.Controls.Add(this.dtmEditCheckin);
            this.pnlEdit.Controls.Add(this.cmbEditRoomType);
            this.pnlEdit.Controls.Add(this.txtEditRoomPrice);
            this.pnlEdit.Controls.Add(this.txtEditPricePerDay);
            this.pnlEdit.Controls.Add(this.txtEditRoomName);
            this.pnlEdit.FillColor = System.Drawing.Color.White;
            this.pnlEdit.Location = new System.Drawing.Point(25, 225);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.ShadowDecoration.Parent = this.pnlEdit;
            this.pnlEdit.Size = new System.Drawing.Size(608, 156);
            this.pnlEdit.TabIndex = 43;
            // 
            // dtmEditCheckout
            // 
            this.dtmEditCheckout.BorderRadius = 15;
            this.dtmEditCheckout.BorderThickness = 1;
            this.dtmEditCheckout.CheckedState.Parent = this.dtmEditCheckout;
            this.dtmEditCheckout.FillColor = System.Drawing.Color.White;
            this.dtmEditCheckout.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEditCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmEditCheckout.HoverState.Parent = this.dtmEditCheckout;
            this.dtmEditCheckout.Location = new System.Drawing.Point(307, 104);
            this.dtmEditCheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmEditCheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmEditCheckout.Name = "dtmEditCheckout";
            this.dtmEditCheckout.ShadowDecoration.Parent = this.dtmEditCheckout;
            this.dtmEditCheckout.Size = new System.Drawing.Size(284, 36);
            this.dtmEditCheckout.TabIndex = 22;
            this.dtmEditCheckout.TextOffset = new System.Drawing.Point(0, 1);
            this.dtmEditCheckout.Value = new System.DateTime(2024, 11, 8, 23, 42, 22, 823);
            // 
            // dtmEditCheckin
            // 
            this.dtmEditCheckin.BorderRadius = 15;
            this.dtmEditCheckin.BorderThickness = 1;
            this.dtmEditCheckin.CheckedState.Parent = this.dtmEditCheckin;
            this.dtmEditCheckin.FillColor = System.Drawing.Color.White;
            this.dtmEditCheckin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEditCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmEditCheckin.HoverState.Parent = this.dtmEditCheckin;
            this.dtmEditCheckin.Location = new System.Drawing.Point(15, 104);
            this.dtmEditCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmEditCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmEditCheckin.Name = "dtmEditCheckin";
            this.dtmEditCheckin.ShadowDecoration.Parent = this.dtmEditCheckin;
            this.dtmEditCheckin.Size = new System.Drawing.Size(284, 36);
            this.dtmEditCheckin.TabIndex = 21;
            this.dtmEditCheckin.TextOffset = new System.Drawing.Point(0, 1);
            this.dtmEditCheckin.Value = new System.DateTime(2024, 11, 8, 23, 42, 22, 823);
            // 
            // cmbEditRoomType
            // 
            this.cmbEditRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbEditRoomType.BorderColor = System.Drawing.Color.Black;
            this.cmbEditRoomType.BorderRadius = 15;
            this.cmbEditRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEditRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEditRoomType.FocusedState.Parent = this.cmbEditRoomType;
            this.cmbEditRoomType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEditRoomType.FormattingEnabled = true;
            this.cmbEditRoomType.HoverState.Parent = this.cmbEditRoomType;
            this.cmbEditRoomType.ItemHeight = 30;
            this.cmbEditRoomType.ItemsAppearance.Parent = this.cmbEditRoomType;
            this.cmbEditRoomType.Location = new System.Drawing.Point(307, 16);
            this.cmbEditRoomType.Name = "cmbEditRoomType";
            this.cmbEditRoomType.ShadowDecoration.Parent = this.cmbEditRoomType;
            this.cmbEditRoomType.Size = new System.Drawing.Size(284, 36);
            this.cmbEditRoomType.TabIndex = 20;
            // 
            // txtEditRoomPrice
            // 
            this.txtEditRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtEditRoomPrice.BorderColor = System.Drawing.Color.Black;
            this.txtEditRoomPrice.BorderRadius = 12;
            this.txtEditRoomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditRoomPrice.DefaultText = "";
            this.txtEditRoomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditRoomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditRoomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditRoomPrice.DisabledState.Parent = this.txtEditRoomPrice;
            this.txtEditRoomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditRoomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditRoomPrice.FocusedState.Parent = this.txtEditRoomPrice;
            this.txtEditRoomPrice.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtEditRoomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtEditRoomPrice.HoverState.Parent = this.txtEditRoomPrice;
            this.txtEditRoomPrice.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtEditRoomPrice.Location = new System.Drawing.Point(15, 63);
            this.txtEditRoomPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditRoomPrice.Name = "txtEditRoomPrice";
            this.txtEditRoomPrice.PasswordChar = '\0';
            this.txtEditRoomPrice.PlaceholderText = "Room Price";
            this.txtEditRoomPrice.ReadOnly = true;
            this.txtEditRoomPrice.SelectedText = "";
            this.txtEditRoomPrice.ShadowDecoration.Parent = this.txtEditRoomPrice;
            this.txtEditRoomPrice.Size = new System.Drawing.Size(284, 30);
            this.txtEditRoomPrice.TabIndex = 17;
            this.txtEditRoomPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtEditPricePerDay
            // 
            this.txtEditPricePerDay.BackColor = System.Drawing.Color.Transparent;
            this.txtEditPricePerDay.BorderColor = System.Drawing.Color.Black;
            this.txtEditPricePerDay.BorderRadius = 12;
            this.txtEditPricePerDay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditPricePerDay.DefaultText = "";
            this.txtEditPricePerDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditPricePerDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditPricePerDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditPricePerDay.DisabledState.Parent = this.txtEditPricePerDay;
            this.txtEditPricePerDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditPricePerDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditPricePerDay.FocusedState.Parent = this.txtEditPricePerDay;
            this.txtEditPricePerDay.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPricePerDay.ForeColor = System.Drawing.Color.Black;
            this.txtEditPricePerDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtEditPricePerDay.HoverState.Parent = this.txtEditPricePerDay;
            this.txtEditPricePerDay.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtEditPricePerDay.Location = new System.Drawing.Point(307, 63);
            this.txtEditPricePerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditPricePerDay.Name = "txtEditPricePerDay";
            this.txtEditPricePerDay.PasswordChar = '\0';
            this.txtEditPricePerDay.PlaceholderText = "Price Per Day";
            this.txtEditPricePerDay.SelectedText = "";
            this.txtEditPricePerDay.ShadowDecoration.Parent = this.txtEditPricePerDay;
            this.txtEditPricePerDay.Size = new System.Drawing.Size(284, 30);
            this.txtEditPricePerDay.TabIndex = 16;
            this.txtEditPricePerDay.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtEditRoomName
            // 
            this.txtEditRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtEditRoomName.BorderColor = System.Drawing.Color.Black;
            this.txtEditRoomName.BorderRadius = 12;
            this.txtEditRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditRoomName.DefaultText = "";
            this.txtEditRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEditRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEditRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditRoomName.DisabledState.Parent = this.txtEditRoomName;
            this.txtEditRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEditRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditRoomName.FocusedState.Parent = this.txtEditRoomName;
            this.txtEditRoomName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtEditRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtEditRoomName.HoverState.Parent = this.txtEditRoomName;
            this.txtEditRoomName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtEditRoomName.Location = new System.Drawing.Point(15, 20);
            this.txtEditRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditRoomName.Name = "txtEditRoomName";
            this.txtEditRoomName.PasswordChar = '\0';
            this.txtEditRoomName.PlaceholderText = "Room Name";
            this.txtEditRoomName.SelectedText = "";
            this.txtEditRoomName.ShadowDecoration.Parent = this.txtEditRoomName;
            this.txtEditRoomName.Size = new System.Drawing.Size(284, 30);
            this.txtEditRoomName.TabIndex = 14;
            this.txtEditRoomName.TextOffset = new System.Drawing.Point(10, 0);
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
            this.btnEditSave.Location = new System.Drawing.Point(659, 288);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.ShadowDecoration.Parent = this.btnEditSave;
            this.btnEditSave.Size = new System.Drawing.Size(180, 32);
            this.btnEditSave.TabIndex = 44;
            this.btnEditSave.Text = "SAVE";
            this.btnEditSave.TextOffset = new System.Drawing.Point(7, -11);
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
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
            this.Column2.FillWeight = 101.1673F;
            this.Column2.HeaderText = "Room Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 55.71321F;
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 112.6534F;
            this.Column6.HeaderText = "Price Per Day";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 136;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 93.84643F;
            this.Column7.HeaderText = "Total Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 115.6023F;
            this.Column4.HeaderText = "Check-in Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 121.0173F;
            this.Column5.HeaderText = "Check-out Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 155;
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
            this.btnAddSave.Location = new System.Drawing.Point(659, 243);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.ShadowDecoration.Parent = this.btnAddSave;
            this.btnAddSave.Size = new System.Drawing.Size(180, 32);
            this.btnAddSave.TabIndex = 45;
            this.btnAddSave.Text = "SAVE";
            this.btnAddSave.TextOffset = new System.Drawing.Point(7, -11);
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // PopUpReservationAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(898, 433);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopUpReservationAddons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpReservationAddons";
            this.Load += new System.EventHandler(this.PopUpReservationAddons_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRooms)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlAdd.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private System.Windows.Forms.DataGridView dtgRooms;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDeleteReservation;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEditReservation;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddReservation;
        private Guna.UI2.WinForms.Guna2Panel pnlDetails;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomType;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomname;
        private Guna.UI2.WinForms.Guna2TextBox txtCheckoutDate;
        private Guna.UI2.WinForms.Guna2TextBox txtCheckinDate;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private Guna.UI2.WinForms.Guna2Panel pnlAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtAddRoomPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtAddPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtAddRoomName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmAddCheckout;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmAddCheckin;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAddRoomType;
        private Guna.UI2.WinForms.Guna2Panel pnlEdit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmEditCheckout;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmEditCheckin;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEditRoomType;
        private Guna.UI2.WinForms.Guna2TextBox txtEditRoomPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtEditPricePerDay;
        private Guna.UI2.WinForms.Guna2TextBox txtEditRoomName;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEditSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddSave;
    }
}