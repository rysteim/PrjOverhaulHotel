namespace PrjOverhaulHotel.PopUps
{
    partial class PopUpPromos
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
            this.dtgPromos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPromos = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromos)).BeginInit();
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
            this.pnlLogin.Controls.Add(this.dtgPromos);
            this.pnlLogin.Controls.Add(this.btnAddPromos);
            this.pnlLogin.Location = new System.Drawing.Point(12, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(659, 403);
            this.pnlLogin.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = global::PrjOverhaulHotel.Properties.Resources.ban;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnCancel.Location = new System.Drawing.Point(453, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(180, 32);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextOffset = new System.Drawing.Point(7, -13);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtgPromos
            // 
            this.dtgPromos.AllowUserToAddRows = false;
            this.dtgPromos.AllowUserToDeleteRows = false;
            this.dtgPromos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            this.Column2,
            this.Column3,
            this.Column6});
            this.dtgPromos.EnableHeadersVisualStyles = false;
            this.dtgPromos.GridColor = System.Drawing.Color.Black;
            this.dtgPromos.Location = new System.Drawing.Point(25, 19);
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
            this.dtgPromos.Size = new System.Drawing.Size(608, 328);
            this.dtgPromos.TabIndex = 46;
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
            this.Column2.HeaderText = "Promo Name";
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
            this.Column6.HeaderText = "Discount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnAddPromos
            // 
            this.btnAddPromos.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPromos.BorderRadius = 15;
            this.btnAddPromos.CheckedState.Parent = this.btnAddPromos;
            this.btnAddPromos.CustomImages.Parent = this.btnAddPromos;
            this.btnAddPromos.FillColor = System.Drawing.Color.Black;
            this.btnAddPromos.FillColor2 = System.Drawing.Color.Teal;
            this.btnAddPromos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPromos.ForeColor = System.Drawing.Color.White;
            this.btnAddPromos.HoverState.Parent = this.btnAddPromos;
            this.btnAddPromos.Image = global::PrjOverhaulHotel.Properties.Resources.plus;
            this.btnAddPromos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddPromos.ImageOffset = new System.Drawing.Point(5, 13);
            this.btnAddPromos.Location = new System.Drawing.Point(267, 357);
            this.btnAddPromos.Name = "btnAddPromos";
            this.btnAddPromos.ShadowDecoration.Parent = this.btnAddPromos;
            this.btnAddPromos.Size = new System.Drawing.Size(180, 32);
            this.btnAddPromos.TabIndex = 38;
            this.btnAddPromos.Text = "ADD";
            this.btnAddPromos.TextOffset = new System.Drawing.Point(7, -13);
            this.btnAddPromos.Click += new System.EventHandler(this.btnAddPromos_Click);
            // 
            // PopUpPromos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 427);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpPromos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpPromos";
            this.Load += new System.EventHandler(this.PopUpPromos_Load);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPromos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCancel;
        private System.Windows.Forms.DataGridView dtgPromos;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddPromos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}