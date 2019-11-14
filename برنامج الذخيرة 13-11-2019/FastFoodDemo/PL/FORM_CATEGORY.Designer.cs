namespace FastFoodDemo.PL
{
    partial class FORM_CATEGORY
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_CATEGORY));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_CAT = new System.Windows.Forms.DataGridView();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CAT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_NAME.BackColor = System.Drawing.Color.Beige;
            this.TXT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NAME.Location = new System.Drawing.Point(114, 24);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(232, 22);
            this.TXT_NAME.TabIndex = 1;
            this.TXT_NAME.TextChanged += new System.EventHandler(this.TXT_SILAH_NAME_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_CAT);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // DGV_CAT
            // 
            this.DGV_CAT.AllowUserToAddRows = false;
            this.DGV_CAT.AllowUserToDeleteRows = false;
            this.DGV_CAT.AllowUserToResizeRows = false;
            this.DGV_CAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CAT.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_CAT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGV_CAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CAT.Location = new System.Drawing.Point(3, 19);
            this.DGV_CAT.Name = "DGV_CAT";
            this.DGV_CAT.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_CAT.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CAT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_CAT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CAT.Size = new System.Drawing.Size(362, 152);
            this.DGV_CAT.TabIndex = 3;
            this.DGV_CAT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SILAH_CellContentClick);
            this.DGV_CAT.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_SILAH_CellFormatting);
            this.DGV_CAT.SelectionChanged += new System.EventHandler(this.DGV_CAT_SelectionChanged);
            this.DGV_CAT.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_DELETE.FlatAppearance.BorderSize = 0;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_DELETE.Location = new System.Drawing.Point(212, 294);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(110, 30);
            this.BTN_DELETE.TabIndex = 7;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_EDIT.FlatAppearance.BorderSize = 0;
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_EDIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_EDIT.Location = new System.Drawing.Point(90, 294);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(110, 30);
            this.BTN_EDIT.TabIndex = 6;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_ADD.FlatAppearance.BorderSize = 0;
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_ADD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_ADD.Location = new System.Drawing.Point(212, 256);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_ADD.TabIndex = 5;
            this.BTN_ADD.Text = "إضافة";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_NEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_NEW.FlatAppearance.BorderSize = 0;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_NEW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_NEW.Location = new System.Drawing.Point(90, 256);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(110, 30);
            this.BTN_NEW.TabIndex = 4;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // FORM_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 347);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXT_NAME);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_CATEGORY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.Load += new System.EventHandler(this.FORM_SILAH_MNG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_CAT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_NEW;
    }
}