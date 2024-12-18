namespace PrjOverhaulHotel.Form_for_Guests
{
    partial class FrmGuestDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuestDashboard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHistory = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAP = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReservation = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnProfile = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.imgProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlDashboard = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgPromos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTotalRooms = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmployeeView = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnlReservation = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.btnProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromos)).BeginInit();
            this.pnlReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AutoSize = true;
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox3);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnHide);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnExit);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1000, 45);
            this.guna2CustomGradientPanel1.TabIndex = 14;
            this.guna2CustomGradientPanel1.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::PrjOverhaulHotel.Properties.Resources.HôtellerieIcon;
            this.pictureBox3.Location = new System.Drawing.Point(10, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PrjOverhaulHotel.Properties.Resources.Hôtelliere__1_;
            this.pictureBox2.Location = new System.Drawing.Point(45, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.CheckedState.Parent = this.btnHide;
            this.btnHide.CustomImages.Parent = this.btnHide;
            this.btnHide.FillColor = System.Drawing.Color.Lime;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.HoverState.Parent = this.btnHide;
            this.btnHide.Image = global::PrjOverhaulHotel.Properties.Resources.minus;
            this.btnHide.Location = new System.Drawing.Point(920, 5);
            this.btnHide.Margin = new System.Windows.Forms.Padding(1);
            this.btnHide.Name = "btnHide";
            this.btnHide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHide.ShadowDecoration.Parent = this.btnHide;
            this.btnHide.Size = new System.Drawing.Size(35, 35);
            this.btnHide.TabIndex = 2;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = global::PrjOverhaulHotel.Properties.Resources.x;
            this.btnExit.Location = new System.Drawing.Point(958, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Controls.Add(this.btnHistory);
            this.pnlButtons.Controls.Add(this.btnAP);
            this.pnlButtons.Controls.Add(this.btnReservation);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Controls.Add(this.guna2VSeparator2);
            this.pnlButtons.Location = new System.Drawing.Point(0, 45);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.ShadowDecoration.Parent = this.pnlButtons;
            this.pnlButtons.Size = new System.Drawing.Size(60, 555);
            this.pnlButtons.TabIndex = 15;
            this.pnlButtons.MouseEnter += new System.EventHandler(this.button_Move);
            this.pnlButtons.MouseLeave += new System.EventHandler(this.button_Move);
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.FillColor2 = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Image = global::PrjOverhaulHotel.Properties.Resources.log_out;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::PrjOverhaulHotel.Properties.Resources.log_out__1_;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogout.Location = new System.Drawing.Point(0, 510);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(30, 0);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.button_Move);
            this.btnLogout.MouseLeave += new System.EventHandler(this.button_Move);
            // 
            // btnHistory
            // 
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.FillColor = System.Drawing.Color.White;
            this.btnHistory.FillColor2 = System.Drawing.Color.White;
            this.btnHistory.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnHistory.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnHistory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.Image = global::PrjOverhaulHotel.Properties.Resources.history__1_;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.Image = global::PrjOverhaulHotel.Properties.Resources.history;
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHistory.Location = new System.Drawing.Point(0, 135);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(200, 45);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.TextOffset = new System.Drawing.Point(30, 1);
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.button_Move);
            this.btnHistory.MouseLeave += new System.EventHandler(this.button_Move);
            // 
            // btnAP
            // 
            this.btnAP.CheckedState.Parent = this.btnAP;
            this.btnAP.CustomImages.Parent = this.btnAP;
            this.btnAP.FillColor = System.Drawing.Color.White;
            this.btnAP.FillColor2 = System.Drawing.Color.White;
            this.btnAP.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAP.ForeColor = System.Drawing.Color.Black;
            this.btnAP.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnAP.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnAP.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAP.HoverState.Image = global::PrjOverhaulHotel.Properties.Resources.circle_plus__1_;
            this.btnAP.HoverState.Parent = this.btnAP;
            this.btnAP.Image = global::PrjOverhaulHotel.Properties.Resources.circle_plus;
            this.btnAP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAP.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnAP.Location = new System.Drawing.Point(0, 90);
            this.btnAP.Name = "btnAP";
            this.btnAP.ShadowDecoration.Parent = this.btnAP;
            this.btnAP.Size = new System.Drawing.Size(200, 45);
            this.btnAP.TabIndex = 2;
            this.btnAP.Text = "Additionals";
            this.btnAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAP.TextOffset = new System.Drawing.Point(30, 1);
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            this.btnAP.MouseEnter += new System.EventHandler(this.button_Move);
            this.btnAP.MouseLeave += new System.EventHandler(this.button_Move);
            // 
            // btnReservation
            // 
            this.btnReservation.CheckedState.Parent = this.btnReservation;
            this.btnReservation.CustomImages.Parent = this.btnReservation;
            this.btnReservation.FillColor = System.Drawing.Color.White;
            this.btnReservation.FillColor2 = System.Drawing.Color.White;
            this.btnReservation.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.Black;
            this.btnReservation.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnReservation.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnReservation.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReservation.HoverState.Image = global::PrjOverhaulHotel.Properties.Resources.signpost__2_;
            this.btnReservation.HoverState.Parent = this.btnReservation;
            this.btnReservation.Image = global::PrjOverhaulHotel.Properties.Resources.signpost__1_;
            this.btnReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservation.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnReservation.Location = new System.Drawing.Point(0, 45);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.ShadowDecoration.Parent = this.btnReservation;
            this.btnReservation.Size = new System.Drawing.Size(200, 45);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Reservations";
            this.btnReservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservation.TextOffset = new System.Drawing.Point(30, 1);
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            this.btnReservation.MouseEnter += new System.EventHandler(this.button_Move);
            this.btnReservation.MouseLeave += new System.EventHandler(this.button_Move);
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Black;
            this.btnDashboard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Image = global::PrjOverhaulHotel.Properties.Resources.layout_dashboard;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::PrjOverhaulHotel.Properties.Resources.layout_dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(200, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(30, 1);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.button_Move);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.button_Move);
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            this.guna2VSeparator2.Location = new System.Drawing.Point(195, 0);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 555);
            this.guna2VSeparator2.TabIndex = 8;
            // 
            // btnProfile
            // 
            this.btnProfile.BorderColor = System.Drawing.Color.Black;
            this.btnProfile.BorderRadius = 15;
            this.btnProfile.BorderThickness = 2;
            this.btnProfile.Controls.Add(this.imgProfile);
            this.btnProfile.Controls.Add(this.lblName);
            this.btnProfile.Controls.Add(this.lblPosition);
            this.btnProfile.Location = new System.Drawing.Point(792, 9);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Parent = this.btnProfile;
            this.btnProfile.Size = new System.Drawing.Size(200, 102);
            this.btnProfile.TabIndex = 24;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // imgProfile
            // 
            this.imgProfile.BackColor = System.Drawing.Color.Transparent;
            this.imgProfile.Image = global::PrjOverhaulHotel.Properties.Resources.rb_8551;
            this.imgProfile.Location = new System.Drawing.Point(12, 42);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgProfile.ShadowDecoration.Parent = this.imgProfile;
            this.imgProfile.Size = new System.Drawing.Size(50, 50);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 13;
            this.imgProfile.TabStop = false;
            this.imgProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.imgProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.imgProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(64, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Sample Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Click += new System.EventHandler(this.btnProfile_Click);
            this.lblName.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Black;
            this.lblPosition.Location = new System.Drawing.Point(65, 65);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(134, 23);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Sample Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.Click += new System.EventHandler(this.btnProfile_Click);
            this.lblPosition.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.lblPosition.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashboard.BackgroundImage = global::PrjOverhaulHotel.Properties.Resources.Group_282;
            this.pnlDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDashboard.BorderRadius = 15;
            this.pnlDashboard.Controls.Add(this.dtgPromos);
            this.pnlDashboard.Controls.Add(this.label8);
            this.pnlDashboard.FillColor = System.Drawing.Color.Gainsboro;
            this.pnlDashboard.Location = new System.Drawing.Point(600, 122);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.pnlDashboard.ShadowDecoration.Enabled = true;
            this.pnlDashboard.ShadowDecoration.Parent = this.pnlDashboard;
            this.pnlDashboard.Size = new System.Drawing.Size(375, 301);
            this.pnlDashboard.TabIndex = 26;
            this.pnlDashboard.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // dtgPromos
            // 
            this.dtgPromos.AllowUserToAddRows = false;
            this.dtgPromos.AllowUserToDeleteRows = false;
            this.dtgPromos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPromos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgPromos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPromos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgPromos.EnableHeadersVisualStyles = false;
            this.dtgPromos.GridColor = System.Drawing.Color.Black;
            this.dtgPromos.Location = new System.Drawing.Point(24, 43);
            this.dtgPromos.MultiSelect = false;
            this.dtgPromos.Name = "dtgPromos";
            this.dtgPromos.ReadOnly = true;
            this.dtgPromos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPromos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgPromos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPromos.Size = new System.Drawing.Size(329, 230);
            this.dtgPromos.TabIndex = 106;
            this.dtgPromos.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 152.2843F;
            this.Column2.HeaderText = "Promo Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 105;
            this.label8.Text = "AVAILABLE PROMOS";
            this.label8.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // btnTotalRooms
            // 
            this.btnTotalRooms.BackColor = System.Drawing.Color.Transparent;
            this.btnTotalRooms.BorderRadius = 15;
            this.btnTotalRooms.CheckedState.Parent = this.btnTotalRooms;
            this.btnTotalRooms.CustomImages.Parent = this.btnTotalRooms;
            this.btnTotalRooms.FillColor = System.Drawing.Color.Black;
            this.btnTotalRooms.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTotalRooms.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalRooms.ForeColor = System.Drawing.Color.White;
            this.btnTotalRooms.HoverState.Parent = this.btnTotalRooms;
            this.btnTotalRooms.Image = global::PrjOverhaulHotel.Properties.Resources.signpost__2_;
            this.btnTotalRooms.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnTotalRooms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTotalRooms.Location = new System.Drawing.Point(81, 122);
            this.btnTotalRooms.Name = "btnTotalRooms";
            this.btnTotalRooms.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.btnTotalRooms.ShadowDecoration.Depth = 20;
            this.btnTotalRooms.ShadowDecoration.Enabled = true;
            this.btnTotalRooms.ShadowDecoration.Parent = this.btnTotalRooms;
            this.btnTotalRooms.Size = new System.Drawing.Size(504, 140);
            this.btnTotalRooms.TabIndex = 132;
            this.btnTotalRooms.Text = "GO TO RESERVATION";
            this.btnTotalRooms.TextOffset = new System.Drawing.Point(7, 0);
            this.btnTotalRooms.Click += new System.EventHandler(this.btnReservation_Click);
            this.btnTotalRooms.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.BorderRadius = 15;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Teal;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.guna2GradientTileButton1.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2GradientTileButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(81, 273);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.guna2GradientTileButton1.ShadowDecoration.Depth = 20;
            this.guna2GradientTileButton1.ShadowDecoration.Enabled = true;
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(504, 140);
            this.guna2GradientTileButton1.TabIndex = 133;
            this.guna2GradientTileButton1.Text = "AVAIL ADDITIONALS";
            this.guna2GradientTileButton1.TextOffset = new System.Drawing.Point(7, 0);
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.btnAP_Click);
            this.guna2GradientTileButton1.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.BorderRadius = 15;
            this.guna2GradientTileButton2.CheckedState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.CustomImages.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.Black;
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.HoverState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Image = global::PrjOverhaulHotel.Properties.Resources.history__1_;
            this.guna2GradientTileButton2.ImageOffset = new System.Drawing.Point(5, 0);
            this.guna2GradientTileButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(81, 425);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.guna2GradientTileButton2.ShadowDecoration.Depth = 20;
            this.guna2GradientTileButton2.ShadowDecoration.Enabled = true;
            this.guna2GradientTileButton2.ShadowDecoration.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(504, 140);
            this.guna2GradientTileButton2.TabIndex = 134;
            this.guna2GradientTileButton2.Text = "VIEW RESERVATION HISTORY";
            this.guna2GradientTileButton2.TextOffset = new System.Drawing.Point(7, 0);
            this.guna2GradientTileButton2.Click += new System.EventHandler(this.btnHistory_Click);
            this.guna2GradientTileButton2.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 39);
            this.label1.TabIndex = 107;
            this.label1.Text = "WELCOME TO THE DASHBOARD";
            this.label1.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // btnEmployeeView
            // 
            this.btnEmployeeView.BorderColor = System.Drawing.Color.Transparent;
            this.btnEmployeeView.BorderRadius = 15;
            this.btnEmployeeView.BorderThickness = 1;
            this.btnEmployeeView.CheckedState.Parent = this.btnEmployeeView;
            this.btnEmployeeView.CustomImages.Parent = this.btnEmployeeView;
            this.btnEmployeeView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployeeView.FillColor2 = System.Drawing.Color.Black;
            this.btnEmployeeView.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeView.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeView.HoverState.Parent = this.btnEmployeeView;
            this.btnEmployeeView.Location = new System.Drawing.Point(600, 440);
            this.btnEmployeeView.Name = "btnEmployeeView";
            this.btnEmployeeView.ShadowDecoration.Parent = this.btnEmployeeView;
            this.btnEmployeeView.Size = new System.Drawing.Size(375, 126);
            this.btnEmployeeView.TabIndex = 136;
            this.btnEmployeeView.Text = "Back to Employee View";
            this.btnEmployeeView.TextOffset = new System.Drawing.Point(0, 2);
            this.btnEmployeeView.Click += new System.EventHandler(this.btnEmployeeView_Click);
            this.btnEmployeeView.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // pnlReservation
            // 
            this.pnlReservation.BackColor = System.Drawing.Color.Transparent;
            this.pnlReservation.BackgroundImage = global::PrjOverhaulHotel.Properties.Resources.Group_282;
            this.pnlReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReservation.BorderRadius = 15;
            this.pnlReservation.Controls.Add(this.btnCheckOut);
            this.pnlReservation.Controls.Add(this.lblMessage);
            this.pnlReservation.FillColor = System.Drawing.Color.Gainsboro;
            this.pnlReservation.Location = new System.Drawing.Point(600, 440);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(220)))), ((int)(((byte)(195)))));
            this.pnlReservation.ShadowDecoration.Enabled = true;
            this.pnlReservation.ShadowDecoration.Parent = this.pnlReservation;
            this.pnlReservation.Size = new System.Drawing.Size(375, 126);
            this.pnlReservation.TabIndex = 107;
            this.pnlReservation.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Myriad Pro Cond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(49, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(287, 102);
            this.lblMessage.TabIndex = 105;
            this.lblMessage.Text = "NO CURRENT RESERVATION";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BorderRadius = 15;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Image = global::PrjOverhaulHotel.Properties.Resources.log_out__1_;
            this.btnCheckOut.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnCheckOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckOut.Location = new System.Drawing.Point(17, 12);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Color = System.Drawing.Color.WhiteSmoke;
            this.btnCheckOut.ShadowDecoration.Enabled = true;
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(343, 102);
            this.btnCheckOut.TabIndex = 137;
            this.btnCheckOut.Text = "CHECK OUT ";
            this.btnCheckOut.TextOffset = new System.Drawing.Point(7, 0);
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // FrmGuestDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientTileButton2);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.btnTotalRooms);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlReservation);
            this.Controls.Add(this.btnEmployeeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGuestDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelliere";
            this.Load += new System.EventHandler(this.FrmGuestDashboard_Load);
            this.MouseEnter += new System.EventHandler(this.pnlButtons_MouseLeave);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.btnProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromos)).EndInit();
            this.pnlReservation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CircleButton btnHide;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton btnHistory;
        private Guna.UI2.WinForms.Guna2GradientButton btnAP;
        private Guna.UI2.WinForms.Guna2GradientButton btnReservation;
        private Guna.UI2.WinForms.Guna2GradientButton btnDashboard;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel btnProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox imgProfile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private Guna.UI2.WinForms.Guna2Panel pnlDashboard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgPromos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnTotalRooms;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnEmployeeView;
        private Guna.UI2.WinForms.Guna2Panel pnlReservation;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCheckOut;
    }
}