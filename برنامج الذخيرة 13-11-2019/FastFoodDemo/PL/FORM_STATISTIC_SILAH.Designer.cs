namespace FastFoodDemo.PL
{
    partial class FORM_STATISTIC_SILAH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_STATISTIC_SILAH));
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CBOXSTA = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVLIST = new System.Windows.Forms.DataGridView();
            this.RBTN_IMPORT = new System.Windows.Forms.RadioButton();
            this.RBTN_ALL = new System.Windows.Forms.RadioButton();
            this.BTNIQLIMSHOW = new System.Windows.Forms.Button();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.BTNCLO = new System.Windows.Forms.Button();
            this.CBOX_CAT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBOX_CAT_NAME = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RBTN_EXPORT = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RBTN_MUSTERED = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP2
            // 
            this.DTP2.CustomFormat = "dd/MM/yyyy";
            this.DTP2.Enabled = false;
            this.DTP2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP2.Location = new System.Drawing.Point(546, 113);
            this.DTP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(193, 26);
            this.DTP2.TabIndex = 413;
            // 
            // DTP1
            // 
            this.DTP1.CustomFormat = "dd/MM/yyyy";
            this.DTP1.Enabled = false;
            this.DTP1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP1.Location = new System.Drawing.Point(546, 143);
            this.DTP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(193, 26);
            this.DTP1.TabIndex = 412;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 411;
            this.label1.Text = "نوع الإحصائية";
            // 
            // CBOXSTA
            // 
            this.CBOXSTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXSTA.Enabled = false;
            this.CBOXSTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXSTA.FormattingEnabled = true;
            this.CBOXSTA.Items.AddRange(new object[] {
            "الكل",
            "نوع السلاح",
            "اسم السلاح"});
            this.CBOXSTA.Location = new System.Drawing.Point(208, 72);
            this.CBOXSTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXSTA.Name = "CBOXSTA";
            this.CBOXSTA.Size = new System.Drawing.Size(232, 25);
            this.CBOXSTA.TabIndex = 410;
            this.CBOXSTA.SelectedIndexChanged += new System.EventHandler(this.CBOXSTA1_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVLIST);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 173);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1210, 437);
            this.groupBox1.TabIndex = 409;
            this.groupBox1.TabStop = false;
            // 
            // DGVLIST
            // 
            this.DGVLIST.AllowUserToAddRows = false;
            this.DGVLIST.AllowUserToDeleteRows = false;
            this.DGVLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLIST.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVLIST.Location = new System.Drawing.Point(3, 16);
            this.DGVLIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVLIST.MultiSelect = false;
            this.DGVLIST.Name = "DGVLIST";
            this.DGVLIST.ReadOnly = true;
            this.DGVLIST.RowTemplate.Height = 26;
            this.DGVLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLIST.Size = new System.Drawing.Size(1204, 419);
            this.DGVLIST.TabIndex = 2;
            // 
            // RBTN_IMPORT
            // 
            this.RBTN_IMPORT.AutoSize = true;
            this.RBTN_IMPORT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_IMPORT.Location = new System.Drawing.Point(464, 24);
            this.RBTN_IMPORT.Name = "RBTN_IMPORT";
            this.RBTN_IMPORT.Size = new System.Drawing.Size(59, 30);
            this.RBTN_IMPORT.TabIndex = 418;
            this.RBTN_IMPORT.TabStop = true;
            this.RBTN_IMPORT.Text = "الوارد";
            this.RBTN_IMPORT.UseVisualStyleBackColor = true;
            this.RBTN_IMPORT.CheckedChanged += new System.EventHandler(this.RBTN_HEREM_CheckedChanged);
            // 
            // RBTN_ALL
            // 
            this.RBTN_ALL.AutoSize = true;
            this.RBTN_ALL.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_ALL.Location = new System.Drawing.Point(581, 24);
            this.RBTN_ALL.Name = "RBTN_ALL";
            this.RBTN_ALL.Size = new System.Drawing.Size(164, 30);
            this.RBTN_ALL.TabIndex = 419;
            this.RBTN_ALL.TabStop = true;
            this.RBTN_ALL.Text = "الموجود في المستودع";
            this.RBTN_ALL.UseVisualStyleBackColor = true;
            this.RBTN_ALL.CheckedChanged += new System.EventHandler(this.RBTN_EYALET_CheckedChanged);
            // 
            // BTNIQLIMSHOW
            // 
            this.BTNIQLIMSHOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNIQLIMSHOW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNIQLIMSHOW.FlatAppearance.BorderSize = 0;
            this.BTNIQLIMSHOW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNIQLIMSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIQLIMSHOW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNIQLIMSHOW.ForeColor = System.Drawing.Color.White;
            this.BTNIQLIMSHOW.Location = new System.Drawing.Point(406, 620);
            this.BTNIQLIMSHOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNIQLIMSHOW.Name = "BTNIQLIMSHOW";
            this.BTNIQLIMSHOW.Size = new System.Drawing.Size(110, 30);
            this.BTNIQLIMSHOW.TabIndex = 426;
            this.BTNIQLIMSHOW.Text = "معاينة";
            this.BTNIQLIMSHOW.UseVisualStyleBackColor = false;
            this.BTNIQLIMSHOW.Click += new System.EventHandler(this.BTNIQLIMSHOW_Click_1);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNPRINT.Enabled = false;
            this.BTNPRINT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNPRINT.FlatAppearance.BorderSize = 0;
            this.BTNPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPRINT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNPRINT.ForeColor = System.Drawing.Color.White;
            this.BTNPRINT.Location = new System.Drawing.Point(546, 620);
            this.BTNPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(110, 30);
            this.BTNPRINT.TabIndex = 425;
            this.BTNPRINT.Text = "طباعة";
            this.BTNPRINT.UseVisualStyleBackColor = false;
            this.BTNPRINT.Click += new System.EventHandler(this.BTNIQLIMPRINT_Click_1);
            // 
            // BTNCLO
            // 
            this.BTNCLO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNCLO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNCLO.FlatAppearance.BorderSize = 0;
            this.BTNCLO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNCLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCLO.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNCLO.ForeColor = System.Drawing.Color.White;
            this.BTNCLO.Location = new System.Drawing.Point(685, 620);
            this.BTNCLO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNCLO.Name = "BTNCLO";
            this.BTNCLO.Size = new System.Drawing.Size(110, 30);
            this.BTNCLO.TabIndex = 424;
            this.BTNCLO.Text = "خروج";
            this.BTNCLO.UseVisualStyleBackColor = false;
            this.BTNCLO.Click += new System.EventHandler(this.BTNCLO_Click_1);
            // 
            // CBOX_CAT
            // 
            this.CBOX_CAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBOX_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_CAT.Enabled = false;
            this.CBOX_CAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_CAT.FormattingEnabled = true;
            this.CBOX_CAT.Items.AddRange(new object[] {
            "",
            "سلاح خفيف",
            "سلاح متوسط",
            "سلاح ثقيل",
            "آليات مسلحة",
            "آليات حمل السلاح",
            "جعب",
            "ذخيرة",
            "معدات عسكرية",
            "أخرى"});
            this.CBOX_CAT.Location = new System.Drawing.Point(555, 73);
            this.CBOX_CAT.Name = "CBOX_CAT";
            this.CBOX_CAT.Size = new System.Drawing.Size(232, 24);
            this.CBOX_CAT.TabIndex = 441;
            this.CBOX_CAT.SelectedIndexChanged += new System.EventHandler(this.CBOX_CAT_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label8.Location = new System.Drawing.Point(493, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 26);
            this.label8.TabIndex = 444;
            this.label8.Text = "النوع";
            // 
            // CBOX_CAT_NAME
            // 
            this.CBOX_CAT_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_CAT_NAME.Enabled = false;
            this.CBOX_CAT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_CAT_NAME.FormattingEnabled = true;
            this.CBOX_CAT_NAME.Location = new System.Drawing.Point(916, 72);
            this.CBOX_CAT_NAME.Name = "CBOX_CAT_NAME";
            this.CBOX_CAT_NAME.Size = new System.Drawing.Size(232, 23);
            this.CBOX_CAT_NAME.TabIndex = 443;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label6.Location = new System.Drawing.Point(835, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 26);
            this.label6.TabIndex = 442;
            this.label6.Text = " السلاح";
            // 
            // RBTN_EXPORT
            // 
            this.RBTN_EXPORT.AutoSize = true;
            this.RBTN_EXPORT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_EXPORT.Location = new System.Drawing.Point(359, 24);
            this.RBTN_EXPORT.Name = "RBTN_EXPORT";
            this.RBTN_EXPORT.Size = new System.Drawing.Size(64, 30);
            this.RBTN_EXPORT.TabIndex = 445;
            this.RBTN_EXPORT.TabStop = true;
            this.RBTN_EXPORT.Text = "الصادر";
            this.RBTN_EXPORT.UseVisualStyleBackColor = true;
            this.RBTN_EXPORT.CheckedChanged += new System.EventHandler(this.RBTN_EXPORT_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.Location = new System.Drawing.Point(448, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 446;
            this.label2.Text = "إلى تاريخ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.Location = new System.Drawing.Point(449, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 447;
            this.label3.Text = "من تاريخ";
            // 
            // RBTN_MUSTERED
            // 
            this.RBTN_MUSTERED.AutoSize = true;
            this.RBTN_MUSTERED.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_MUSTERED.Location = new System.Drawing.Point(858, 24);
            this.RBTN_MUSTERED.Name = "RBTN_MUSTERED";
            this.RBTN_MUSTERED.Size = new System.Drawing.Size(77, 30);
            this.RBTN_MUSTERED.TabIndex = 448;
            this.RBTN_MUSTERED.TabStop = true;
            this.RBTN_MUSTERED.Text = "المسترد";
            this.RBTN_MUSTERED.UseVisualStyleBackColor = true;
            this.RBTN_MUSTERED.CheckedChanged += new System.EventHandler(this.RBTN_MUSTERED_CheckedChanged);
            // 
            // FORM_STATISTIC_SILAH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1233, 671);
            this.Controls.Add(this.RBTN_MUSTERED);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RBTN_EXPORT);
            this.Controls.Add(this.CBOX_CAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBOX_CAT_NAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTNIQLIMSHOW);
            this.Controls.Add(this.BTNPRINT);
            this.Controls.Add(this.BTNCLO);
            this.Controls.Add(this.RBTN_ALL);
            this.Controls.Add(this.RBTN_IMPORT);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBOXSTA);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_STATISTIC_SILAH";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.Load += new System.EventHandler(this.FORM_STATISTIC_SILAH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBOXSTA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVLIST;
        private System.Windows.Forms.RadioButton RBTN_IMPORT;
        private System.Windows.Forms.RadioButton RBTN_ALL;
        private System.Windows.Forms.Button BTNIQLIMSHOW;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Button BTNCLO;
        public System.Windows.Forms.ComboBox CBOX_CAT;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox CBOX_CAT_NAME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RBTN_EXPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RBTN_MUSTERED;

    }
}