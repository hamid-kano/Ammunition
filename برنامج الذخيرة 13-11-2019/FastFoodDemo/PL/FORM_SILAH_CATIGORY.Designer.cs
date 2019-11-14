namespace FastFoodDemo.PL
{
    partial class FORM_SILAH_CATIGORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SILAH_CATIGORY));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SILAH_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBOX_SILAH_TYPE = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_SILAH = new System.Windows.Forms.DataGridView();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.TXT_NOTES = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SILAH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم";
            // 
            // TXT_SILAH_NAME
            // 
            this.TXT_SILAH_NAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_SILAH_NAME.BackColor = System.Drawing.Color.Beige;
            this.TXT_SILAH_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SILAH_NAME.Location = new System.Drawing.Point(133, 54);
            this.TXT_SILAH_NAME.Name = "TXT_SILAH_NAME";
            this.TXT_SILAH_NAME.Size = new System.Drawing.Size(230, 22);
            this.TXT_SILAH_NAME.TabIndex = 1;
            this.TXT_SILAH_NAME.TextChanged += new System.EventHandler(this.TXT_SILAH_NAME_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "النوع";
            // 
            // CBOX_SILAH_TYPE
            // 
            this.CBOX_SILAH_TYPE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBOX_SILAH_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_SILAH_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_SILAH_TYPE.FormattingEnabled = true;
            this.CBOX_SILAH_TYPE.Location = new System.Drawing.Point(133, 25);
            this.CBOX_SILAH_TYPE.Name = "CBOX_SILAH_TYPE";
            this.CBOX_SILAH_TYPE.Size = new System.Drawing.Size(230, 24);
            this.CBOX_SILAH_TYPE.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DGV_SILAH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 429);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // DGV_SILAH
            // 
            this.DGV_SILAH.AllowUserToAddRows = false;
            this.DGV_SILAH.AllowUserToDeleteRows = false;
            this.DGV_SILAH.AllowUserToResizeRows = false;
            this.DGV_SILAH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_SILAH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_SILAH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGV_SILAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SILAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SILAH.Location = new System.Drawing.Point(3, 19);
            this.DGV_SILAH.Name = "DGV_SILAH";
            this.DGV_SILAH.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_SILAH.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_SILAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_SILAH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SILAH.Size = new System.Drawing.Size(752, 407);
            this.DGV_SILAH.TabIndex = 3;
            this.DGV_SILAH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SILAH_CellContentClick);
            this.DGV_SILAH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_SILAH_CellFormatting);
            this.DGV_SILAH.SelectionChanged += new System.EventHandler(this.DGV_SILAH_SelectionChanged);
            this.DGV_SILAH.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_DELETE.FlatAppearance.BorderSize = 0;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_DELETE.Location = new System.Drawing.Point(551, 532);
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
            this.BTN_EDIT.Location = new System.Drawing.Point(415, 532);
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
            this.BTN_ADD.Location = new System.Drawing.Point(281, 532);
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
            this.BTN_NEW.Location = new System.Drawing.Point(149, 532);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(110, 30);
            this.BTN_NEW.TabIndex = 4;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // TXT_NOTES
            // 
            this.TXT_NOTES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TXT_NOTES.BackColor = System.Drawing.Color.Beige;
            this.TXT_NOTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOTES.Location = new System.Drawing.Point(506, 26);
            this.TXT_NOTES.Multiline = true;
            this.TXT_NOTES.Name = "TXT_NOTES";
            this.TXT_NOTES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_NOTES.Size = new System.Drawing.Size(232, 53);
            this.TXT_NOTES.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label5.Location = new System.Drawing.Point(409, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "ملاحظات";
            // 
            // FORM_SILAH_CATIGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 581);
            this.Controls.Add(this.TXT_NOTES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBOX_SILAH_TYPE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_SILAH_NAME);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 620);
            this.Name = "FORM_SILAH_CATIGORY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.Load += new System.EventHandler(this.FORM_SILAH_MNG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SILAH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SILAH_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBOX_SILAH_TYPE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_SILAH;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.TextBox TXT_NOTES;
        private System.Windows.Forms.Label label5;
    }
}