namespace FastFoodDemo.PL
{
    partial class FORM_IMP_EXP_DETAILS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_IMP_EXP_DETAILS));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGV_imp_exp_SILAH = new System.Windows.Forms.DataGridView();
            this.BTN_ADD_TO_LIST = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_SILAH = new System.Windows.Forms.DataGridView();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTNNEW = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_imp_exp_SILAH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SILAH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGV_imp_exp_SILAH);
            this.groupBox4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.groupBox4.Location = new System.Drawing.Point(613, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 408);
            this.groupBox4.TabIndex = 352;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "القائمة المراد تصديرها / توريدها";
            // 
            // DGV_imp_exp_SILAH
            // 
            this.DGV_imp_exp_SILAH.AllowUserToAddRows = false;
            this.DGV_imp_exp_SILAH.AllowUserToDeleteRows = false;
            this.DGV_imp_exp_SILAH.AllowUserToResizeRows = false;
            this.DGV_imp_exp_SILAH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_imp_exp_SILAH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_imp_exp_SILAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_imp_exp_SILAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_imp_exp_SILAH.Location = new System.Drawing.Point(3, 29);
            this.DGV_imp_exp_SILAH.Name = "DGV_imp_exp_SILAH";
            this.DGV_imp_exp_SILAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_imp_exp_SILAH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_imp_exp_SILAH.Size = new System.Drawing.Size(481, 376);
            this.DGV_imp_exp_SILAH.TabIndex = 0;
            // 
            // BTN_ADD_TO_LIST
            // 
            this.BTN_ADD_TO_LIST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_ADD_TO_LIST.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BTN_ADD_TO_LIST.FlatAppearance.BorderSize = 0;
            this.BTN_ADD_TO_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD_TO_LIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_TO_LIST.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_TO_LIST.Location = new System.Drawing.Point(500, 170);
            this.BTN_ADD_TO_LIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ADD_TO_LIST.Name = "BTN_ADD_TO_LIST";
            this.BTN_ADD_TO_LIST.Size = new System.Drawing.Size(110, 30);
            this.BTN_ADD_TO_LIST.TabIndex = 353;
            this.BTN_ADD_TO_LIST.Text = ">>";
            this.BTN_ADD_TO_LIST.UseVisualStyleBackColor = false;
            this.BTN_ADD_TO_LIST.Click += new System.EventHandler(this.BTN_ADD_TO_LIST_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGV_SILAH);
            this.groupBox3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(8, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 408);
            this.groupBox3.TabIndex = 351;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "قائمة الأسلحة";
            // 
            // DGV_SILAH
            // 
            this.DGV_SILAH.AllowUserToAddRows = false;
            this.DGV_SILAH.AllowUserToDeleteRows = false;
            this.DGV_SILAH.AllowUserToResizeRows = false;
            this.DGV_SILAH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SILAH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_SILAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SILAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SILAH.Location = new System.Drawing.Point(3, 29);
            this.DGV_SILAH.Name = "DGV_SILAH";
            this.DGV_SILAH.ReadOnly = true;
            this.DGV_SILAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_SILAH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SILAH.Size = new System.Drawing.Size(481, 376);
            this.DGV_SILAH.TabIndex = 0;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_DELETE.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BTN_DELETE.FlatAppearance.BorderSize = 0;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_DELETE.Location = new System.Drawing.Point(500, 211);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(110, 30);
            this.BTN_DELETE.TabIndex = 354;
            this.BTN_DELETE.Text = "XX";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTNNEW
            // 
            this.BTNNEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNNEW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNNEW.FlatAppearance.BorderSize = 0;
            this.BTNNEW.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNNEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNNEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNEW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNNEW.ForeColor = System.Drawing.Color.White;
            this.BTNNEW.Location = new System.Drawing.Point(564, 448);
            this.BTNNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(110, 30);
            this.BTNNEW.TabIndex = 355;
            this.BTNNEW.Text = "خروج";
            this.BTNNEW.UseVisualStyleBackColor = false;
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_ADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTN_ADD.FlatAppearance.BorderSize = 0;
            this.BTN_ADD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_ADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_ADD.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD.Location = new System.Drawing.Point(443, 448);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_ADD.TabIndex = 356;
            this.BTN_ADD.Text = "إضافة";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // FORM_IMP_EXP_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 497);
            this.Controls.Add(this.BTNNEW);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BTN_ADD_TO_LIST);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_IMP_EXP_DETAILS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة التفاصيل";
            this.Load += new System.EventHandler(this.FORM_IMP_EXP_DETAILS_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_imp_exp_SILAH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SILAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DGV_imp_exp_SILAH;
        private System.Windows.Forms.Button BTN_ADD_TO_LIST;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView DGV_SILAH;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTNNEW;
        private System.Windows.Forms.Button BTN_ADD;
    }
}