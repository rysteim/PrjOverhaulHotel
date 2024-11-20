namespace PrjOverhaulHotel.PopUps
{
    partial class PopUpRoomMain
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlRoom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPricePerDay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnlRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlRoom
            // 
            this.pnlRoom.BackgroundImage = global::PrjOverhaulHotel.Properties.Resources.Rectangle_13__2_;
            this.pnlRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRoom.BorderColor = System.Drawing.Color.Black;
            this.pnlRoom.Controls.Add(this.btnCancel);
            this.pnlRoom.Controls.Add(this.cmbStatus);
            this.pnlRoom.Controls.Add(this.label5);
            this.pnlRoom.Controls.Add(this.txtPricePerDay);
            this.pnlRoom.Controls.Add(this.label4);
            this.pnlRoom.Controls.Add(this.txtDescription);
            this.pnlRoom.Controls.Add(this.cmbRoomType);
            this.pnlRoom.Controls.Add(this.txtRoomName);
            this.pnlRoom.Controls.Add(this.label1);
            this.pnlRoom.Controls.Add(this.label2);
            this.pnlRoom.Controls.Add(this.label3);
            this.pnlRoom.Controls.Add(this.btnAdd);
            this.pnlRoom.Controls.Add(this.btnSave);
            this.pnlRoom.Location = new System.Drawing.Point(10, 13);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.ShadowDecoration.Parent = this.pnlRoom;
            this.pnlRoom.Size = new System.Drawing.Size(341, 531);
            this.pnlRoom.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnCancel.Location = new System.Drawing.Point(27, 477);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextOffset = new System.Drawing.Point(0, 1);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.Black;
            this.cmbStatus.BorderRadius = 15;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.FocusedState.Parent = this.cmbStatus;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.HoverState.Parent = this.cmbStatus;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "",
            "Available",
            "Occupied",
            "Reserved",
            "For Cleaning",
            "Cleaning",
            "Out of Order"});
            this.cmbStatus.ItemsAppearance.Parent = this.cmbStatus;
            this.cmbStatus.Location = new System.Drawing.Point(27, 427);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.ShadowDecoration.Parent = this.cmbStatus;
            this.cmbStatus.Size = new System.Drawing.Size(284, 36);
            this.cmbStatus.TabIndex = 47;
            this.cmbStatus.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Status:";
            // 
            // txtPricePerDay
            // 
            this.txtPricePerDay.BackColor = System.Drawing.Color.Transparent;
            this.txtPricePerDay.BorderColor = System.Drawing.Color.Black;
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
            this.txtPricePerDay.Location = new System.Drawing.Point(27, 139);
            this.txtPricePerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPricePerDay.Name = "txtPricePerDay";
            this.txtPricePerDay.PasswordChar = '\0';
            this.txtPricePerDay.PlaceholderText = "";
            this.txtPricePerDay.SelectedText = "";
            this.txtPricePerDay.ShadowDecoration.Parent = this.txtPricePerDay;
            this.txtPricePerDay.Size = new System.Drawing.Size(284, 30);
            this.txtPricePerDay.TabIndex = 45;
            this.txtPricePerDay.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Price Per Day:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.BorderRadius = 12;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtDescription.Location = new System.Drawing.Point(27, 191);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(284, 212);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomType.BorderColor = System.Drawing.Color.Black;
            this.cmbRoomType.BorderRadius = 15;
            this.cmbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRoomType.FocusedState.Parent = this.cmbRoomType;
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.ForeColor = System.Drawing.Color.Black;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.HoverState.Parent = this.cmbRoomType;
            this.cmbRoomType.ItemHeight = 30;
            this.cmbRoomType.ItemsAppearance.Parent = this.cmbRoomType;
            this.cmbRoomType.Location = new System.Drawing.Point(27, 83);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.ShadowDecoration.Parent = this.cmbRoomType;
            this.cmbRoomType.Size = new System.Drawing.Size(284, 36);
            this.cmbRoomType.TabIndex = 16;
            this.cmbRoomType.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomName.BorderColor = System.Drawing.Color.Black;
            this.txtRoomName.BorderRadius = 12;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.DefaultText = "";
            this.txtRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.DisabledState.Parent = this.txtRoomName;
            this.txtRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomName.FocusedState.Parent = this.txtRoomName;
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.ForeColor = System.Drawing.Color.Black;
            this.txtRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(154)))), ((int)(((byte)(136)))));
            this.txtRoomName.HoverState.Parent = this.txtRoomName;
            this.txtRoomName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtRoomName.Location = new System.Drawing.Point(27, 33);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PlaceholderText = "";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.ShadowDecoration.Parent = this.txtRoomName;
            this.txtRoomName.Size = new System.Drawing.Size(284, 30);
            this.txtRoomName.TabIndex = 15;
            this.txtRoomName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Room Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Room Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Description:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.FillColor2 = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::PrjOverhaulHotel.Properties.Resources.check;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnSave.Location = new System.Drawing.Point(131, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 32);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextOffset = new System.Drawing.Point(7, -11);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Black;
            this.btnAdd.FillColor2 = System.Drawing.Color.Teal;
            this.btnAdd.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnAdd.Location = new System.Drawing.Point(131, 477);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(180, 32);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextOffset = new System.Drawing.Point(7, -11);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PopUpRoomMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(363, 557);
            this.Controls.Add(this.pnlRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpRoomMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpRoomMain";
            this.Load += new System.EventHandler(this.PopUpRoomMain_Load);
            this.pnlRoom.ResumeLayout(false);
            this.pnlRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlRoom;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRoomType;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPricePerDay;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCancel;
    }
}