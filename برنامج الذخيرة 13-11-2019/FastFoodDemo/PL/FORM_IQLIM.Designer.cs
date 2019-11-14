namespace FastFoodDemo.PL
{
    partial class FORM_IQLIM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_IQLIM));
            this.TXT_HEREM_NAME = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_HEREM = new System.Windows.Forms.DataGridView();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNEDIT = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNNEW = new System.Windows.Forms.Button();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HEREM)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_HEREM_NAME
            // 
            this.TXT_HEREM_NAME.BackColor = System.Drawing.Color.Beige;
            this.TXT_HEREM_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_HEREM_NAME.Location = new System.Drawing.Point(149, 118);
            this.TXT_HEREM_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_HEREM_NAME.Name = "TXT_HEREM_NAME";
            this.TXT_HEREM_NAME.Size = new System.Drawing.Size(212, 23);
            this.TXT_HEREM_NAME.TabIndex = 1;
            this.TXT_HEREM_NAME.TextChanged += new System.EventHandler(this.TXT_HEREM_NAME_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(19, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 26);
            this.label24.TabIndex = 82;
            this.label24.Text = "اسم الإقليم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_HEREM);
            this.groupBox1.Location = new System.Drawing.Point(373, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(364, 261);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // DGV_HEREM
            // 
            this.DGV_HEREM.AllowUserToAddRows = false;
            this.DGV_HEREM.AllowUserToDeleteRows = false;
            this.DGV_HEREM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_HEREM.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_HEREM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_HEREM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_HEREM.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_HEREM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_HEREM.Location = new System.Drawing.Point(3, 15);
            this.DGV_HEREM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_HEREM.MultiSelect = false;
            this.DGV_HEREM.Name = "DGV_HEREM";
            this.DGV_HEREM.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_HEREM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_HEREM.RowTemplate.Height = 26;
            this.DGV_HEREM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_HEREM.Size = new System.Drawing.Size(358, 244);
            this.DGV_HEREM.TabIndex = 1;
            this.DGV_HEREM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HEREM_CellContentClick);
            this.DGV_HEREM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVIQLIM_CellFormatting);
            this.DGV_HEREM.SelectionChanged += new System.EventHandler(this.DGV_HEREM_SelectionChanged);
            this.DGV_HEREM.Click += new System.EventHandler(this.DGVIQLIM_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNDELETE.Enabled = false;
            this.BTNDELETE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNDELETE.FlatAppearance.BorderSize = 0;
            this.BTNDELETE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDELETE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNDELETE.ForeColor = System.Drawing.Color.White;
            this.BTNDELETE.Location = new System.Drawing.Point(227, 248);
            this.BTNDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(110, 30);
            this.BTNDELETE.TabIndex = 5;
            this.BTNDELETE.Text = "حذف";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNEDIT.Enabled = false;
            this.BTNEDIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNEDIT.FlatAppearance.BorderSize = 0;
            this.BTNEDIT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNEDIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEDIT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNEDIT.ForeColor = System.Drawing.Color.White;
            this.BTNEDIT.Location = new System.Drawing.Point(105, 248);
            this.BTNEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(110, 30);
            this.BTNEDIT.TabIndex = 4;
            this.BTNEDIT.Text = "تعديل ";
            this.BTNEDIT.UseVisualStyleBackColor = false;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
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
            this.BTN_ADD.Location = new System.Drawing.Point(227, 201);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_ADD.TabIndex = 3;
            this.BTN_ADD.Text = "إضافة";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.BackColor = System.Drawing.Color.Beige;
            this.TXTNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNUM.Location = new System.Drawing.Point(149, 78);
            this.TXTNUM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(212, 24);
            this.TXTNUM.TabIndex = 0;
            this.TXTNUM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTNUM_KeyDown);
            this.TXTNUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 268;
            this.label1.Text = "رقم الإقليم";
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
            this.BTNNEW.Location = new System.Drawing.Point(105, 201);
            this.BTNNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(110, 30);
            this.BTNNEW.TabIndex = 2;
            this.BTNNEW.Text = "جديد";
            this.BTNNEW.UseVisualStyleBackColor = false;
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.BackColor = System.Drawing.Color.Beige;
            this.TXT_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(466, 19);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(239, 22);
            this.TXT_SEARCH.TabIndex = 6;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.Location = new System.Drawing.Point(399, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 270;
            this.label2.Text = "بحث";
            // 
            // FORM_IQLIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(757, 347);
            this.Controls.Add(this.TXT_SEARCH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNNEW);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNEDIT);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXT_HEREM_NAME);
            this.Controls.Add(this.label24);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_IQLIM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأقاليم";
            this.Load += new System.EventHandler(this.FORM_IQLIM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HEREM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_HEREM_NAME;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_HEREM;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNEDIT;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNNEW;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private System.Windows.Forms.Label label2;
    }
}