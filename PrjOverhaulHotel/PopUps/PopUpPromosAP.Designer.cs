namespace PrjOverhaulHotel.PopUps
{
    partial class PopUpPromosAP
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
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPromoDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPromoName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavePromo = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnAddPromo = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtmEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
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
            this.pnlLogin.Controls.Add(this.dtmEnd);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.dtmStart);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.btnCancel);
            this.pnlLogin.Controls.Add(this.txtDescription);
            this.pnlLogin.Controls.Add(this.txtPromoDiscount);
            this.pnlLogin.Controls.Add(this.txtPromoName);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.btnSavePromo);
            this.pnlLogin.Controls.Add(this.btnAddPromo);
            this.pnlLogin.Location = new System.Drawing.Point(12, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(397, 572);
            this.pnlLogin.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnCancel.Location = new System.Drawing.Point(101, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderRadius = 15;
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
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(19, 180);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(366, 179);
            this.txtDescription.TabIndex = 51;
            this.txtDescription.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPromoDiscount
            // 
            this.txtPromoDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtPromoDiscount.BorderRadius = 15;
            this.txtPromoDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPromoDiscount.DefaultText = "";
            this.txtPromoDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPromoDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPromoDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPromoDiscount.DisabledState.Parent = this.txtPromoDiscount;
            this.txtPromoDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPromoDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPromoDiscount.FocusedState.Parent = this.txtPromoDiscount;
            this.txtPromoDiscount.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoDiscount.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPromoDiscount.HoverState.Parent = this.txtPromoDiscount;
            this.txtPromoDiscount.Location = new System.Drawing.Point(19, 108);
            this.txtPromoDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPromoDiscount.Name = "txtPromoDiscount";
            this.txtPromoDiscount.PasswordChar = '\0';
            this.txtPromoDiscount.PlaceholderText = "";
            this.txtPromoDiscount.SelectedText = "";
            this.txtPromoDiscount.ShadowDecoration.Parent = this.txtPromoDiscount;
            this.txtPromoDiscount.Size = new System.Drawing.Size(366, 36);
            this.txtPromoDiscount.TabIndex = 50;
            this.txtPromoDiscount.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtPromoName
            // 
            this.txtPromoName.BackColor = System.Drawing.Color.Transparent;
            this.txtPromoName.BorderRadius = 15;
            this.txtPromoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPromoName.DefaultText = "";
            this.txtPromoName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPromoName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPromoName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPromoName.DisabledState.Parent = this.txtPromoName;
            this.txtPromoName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPromoName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPromoName.FocusedState.Parent = this.txtPromoName;
            this.txtPromoName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoName.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPromoName.HoverState.Parent = this.txtPromoName;
            this.txtPromoName.Location = new System.Drawing.Point(19, 42);
            this.txtPromoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPromoName.Name = "txtPromoName";
            this.txtPromoName.PasswordChar = '\0';
            this.txtPromoName.PlaceholderText = "";
            this.txtPromoName.SelectedText = "";
            this.txtPromoName.ShadowDecoration.Parent = this.txtPromoName;
            this.txtPromoName.Size = new System.Drawing.Size(366, 36);
            this.txtPromoName.TabIndex = 49;
            this.txtPromoName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Promo Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Discount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Description:";
            // 
            // btnSavePromo
            // 
            this.btnSavePromo.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePromo.BorderRadius = 15;
            this.btnSavePromo.CheckedState.Parent = this.btnSavePromo;
            this.btnSavePromo.CustomImages.Parent = this.btnSavePromo;
            this.btnSavePromo.FillColor = System.Drawing.Color.Black;
            this.btnSavePromo.FillColor2 = System.Drawing.Color.Teal;
            this.btnSavePromo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePromo.ForeColor = System.Drawing.Color.White;
            this.btnSavePromo.HoverState.Parent = this.btnSavePromo;
            this.btnSavePromo.Image = global::PrjOverhaulHotel.Properties.Resources.check;
            this.btnSavePromo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSavePromo.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnSavePromo.Location = new System.Drawing.Point(205, 522);
            this.btnSavePromo.Name = "btnSavePromo";
            this.btnSavePromo.ShadowDecoration.Parent = this.btnSavePromo;
            this.btnSavePromo.Size = new System.Drawing.Size(180, 32);
            this.btnSavePromo.TabIndex = 56;
            this.btnSavePromo.Text = "SAVE";
            this.btnSavePromo.TextOffset = new System.Drawing.Point(7, -13);
            this.btnSavePromo.Click += new System.EventHandler(this.btnSaveAddon_Click);
            // 
            // btnAddPromo
            // 
            this.btnAddPromo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPromo.BorderRadius = 15;
            this.btnAddPromo.CheckedState.Parent = this.btnAddPromo;
            this.btnAddPromo.CustomImages.Parent = this.btnAddPromo;
            this.btnAddPromo.FillColor = System.Drawing.Color.Black;
            this.btnAddPromo.FillColor2 = System.Drawing.Color.Teal;
            this.btnAddPromo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPromo.ForeColor = System.Drawing.Color.White;
            this.btnAddPromo.HoverState.Parent = this.btnAddPromo;
            this.btnAddPromo.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.btnAddPromo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddPromo.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnAddPromo.Location = new System.Drawing.Point(205, 522);
            this.btnAddPromo.Name = "btnAddPromo";
            this.btnAddPromo.ShadowDecoration.Parent = this.btnAddPromo;
            this.btnAddPromo.Size = new System.Drawing.Size(180, 32);
            this.btnAddPromo.TabIndex = 38;
            this.btnAddPromo.Text = "ADD";
            this.btnAddPromo.TextOffset = new System.Drawing.Point(7, -13);
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Date Start:";
            // 
            // dtmStart
            // 
            this.dtmStart.BackColor = System.Drawing.Color.Transparent;
            this.dtmStart.BorderRadius = 15;
            this.dtmStart.CheckedState.Parent = this.dtmStart;
            this.dtmStart.FillColor = System.Drawing.Color.White;
            this.dtmStart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmStart.HoverState.Parent = this.dtmStart;
            this.dtmStart.Location = new System.Drawing.Point(19, 397);
            this.dtmStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmStart.Name = "dtmStart";
            this.dtmStart.ShadowDecoration.Parent = this.dtmStart;
            this.dtmStart.Size = new System.Drawing.Size(366, 36);
            this.dtmStart.TabIndex = 58;
            this.dtmStart.Value = new System.DateTime(2024, 10, 31, 18, 33, 6, 824);
            // 
            // dtmEnd
            // 
            this.dtmEnd.BackColor = System.Drawing.Color.Transparent;
            this.dtmEnd.BorderRadius = 15;
            this.dtmEnd.CheckedState.Parent = this.dtmEnd;
            this.dtmEnd.FillColor = System.Drawing.Color.White;
            this.dtmEnd.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmEnd.HoverState.Parent = this.dtmEnd;
            this.dtmEnd.Location = new System.Drawing.Point(19, 463);
            this.dtmEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmEnd.Name = "dtmEnd";
            this.dtmEnd.ShadowDecoration.Parent = this.dtmEnd;
            this.dtmEnd.Size = new System.Drawing.Size(366, 36);
            this.dtmEnd.TabIndex = 60;
            this.dtmEnd.Value = new System.DateTime(2024, 10, 31, 18, 33, 6, 824);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Date End:";
            // 
            // PopUpPromosAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(421, 596);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpPromosAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpPromosAP";
            this.Load += new System.EventHandler(this.PopUpPromosAP_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddPromo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtPromoDiscount;
        private Guna.UI2.WinForms.Guna2TextBox txtPromoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSavePromo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmEnd;
        private System.Windows.Forms.Label label5;
    }
}