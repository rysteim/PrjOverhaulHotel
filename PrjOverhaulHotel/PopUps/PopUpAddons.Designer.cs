namespace PrjOverhaulHotel.PopUps
{
    partial class PopUpAddons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.dtgAddons = new System.Windows.Forms.DataGridView();
            this.btnAddAddon = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddons)).BeginInit();
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
            this.pnlLogin.Controls.Add(this.dtgAddons);
            this.pnlLogin.Controls.Add(this.btnAddAddon);
            this.pnlLogin.Location = new System.Drawing.Point(15, 15);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(659, 403);
            this.pnlLogin.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = global::PrjOverhaulHotel.Properties.Resources.ban;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnCancel.Location = new System.Drawing.Point(453, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(180, 32);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextOffset = new System.Drawing.Point(7, -11);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtgAddons
            // 
            this.dtgAddons.AllowUserToAddRows = false;
            this.dtgAddons.AllowUserToDeleteRows = false;
            this.dtgAddons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgAddons.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAddons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgAddons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAddons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6});
            this.dtgAddons.EnableHeadersVisualStyles = false;
            this.dtgAddons.GridColor = System.Drawing.Color.Black;
            this.dtgAddons.Location = new System.Drawing.Point(25, 19);
            this.dtgAddons.MultiSelect = false;
            this.dtgAddons.Name = "dtgAddons";
            this.dtgAddons.ReadOnly = true;
            this.dtgAddons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAddons.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dtgAddons.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgAddons.Size = new System.Drawing.Size(608, 328);
            this.dtgAddons.TabIndex = 46;
            // 
            // btnAddAddon
            // 
            this.btnAddAddon.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAddon.BorderRadius = 15;
            this.btnAddAddon.CheckedState.Parent = this.btnAddAddon;
            this.btnAddAddon.CustomImages.Parent = this.btnAddAddon;
            this.btnAddAddon.FillColor = System.Drawing.Color.Black;
            this.btnAddAddon.FillColor2 = System.Drawing.Color.Teal;
            this.btnAddAddon.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAddon.ForeColor = System.Drawing.Color.White;
            this.btnAddAddon.HoverState.Parent = this.btnAddAddon;
            this.btnAddAddon.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.btnAddAddon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddAddon.ImageOffset = new System.Drawing.Point(5, 12);
            this.btnAddAddon.Location = new System.Drawing.Point(267, 357);
            this.btnAddAddon.Name = "btnAddAddon";
            this.btnAddAddon.ShadowDecoration.Parent = this.btnAddAddon;
            this.btnAddAddon.Size = new System.Drawing.Size(180, 32);
            this.btnAddAddon.TabIndex = 38;
            this.btnAddAddon.Text = "ADD";
            this.btnAddAddon.TextOffset = new System.Drawing.Point(7, -11);
            this.btnAddAddon.Click += new System.EventHandler(this.btnAddAddon_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 152.2843F;
            this.Column2.HeaderText = "Addon Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 143.2897F;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 314;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 4.426022F;
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // PopUpAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(689, 433);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpAddons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpAddons";
            this.Load += new System.EventHandler(this.PopUpAddons_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAddons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCancel;
        private System.Windows.Forms.DataGridView dtgAddons;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddAddon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}