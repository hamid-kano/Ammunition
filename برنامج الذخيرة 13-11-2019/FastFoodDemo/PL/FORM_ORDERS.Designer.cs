﻿namespace FastFoodDemo.PL
{
    partial class FORM_ORDERS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_ORDERS));
            this.TXT_SOURCE = new System.Windows.Forms.TextBox();
            this.TXT_CONTENT = new System.Windows.Forms.TextBox();
            this.TXT_NOTES = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.CBOX_TYPE = new System.Windows.Forms.ComboBox();
            this.DTP_DATE = new System.Windows.Forms.DateTimePicker();
            this.btnNEW = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_ORDERS = new System.Windows.Forms.DataGridView();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNADD_DOCS = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BTNEDIT = new System.Windows.Forms.Button();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_SOURCE
            // 
            this.TXT_SOURCE.BackColor = System.Drawing.Color.Beige;
            this.TXT_SOURCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SOURCE.Location = new System.Drawing.Point(183, 66);
            this.TXT_SOURCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_SOURCE.Name = "TXT_SOURCE";
            this.TXT_SOURCE.Size = new System.Drawing.Size(226, 22);
            this.TXT_SOURCE.TabIndex = 95;
            // 
            // TXT_CONTENT
            // 
            this.TXT_CONTENT.BackColor = System.Drawing.Color.Beige;
            this.TXT_CONTENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CONTENT.Location = new System.Drawing.Point(570, 11);
            this.TXT_CONTENT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_CONTENT.Multiline = true;
            this.TXT_CONTENT.Name = "TXT_CONTENT";
            this.TXT_CONTENT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_CONTENT.Size = new System.Drawing.Size(226, 47);
            this.TXT_CONTENT.TabIndex = 96;
            // 
            // TXT_NOTES
            // 
            this.TXT_NOTES.BackColor = System.Drawing.Color.Beige;
            this.TXT_NOTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOTES.Location = new System.Drawing.Point(570, 61);
            this.TXT_NOTES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_NOTES.Multiline = true;
            this.TXT_NOTES.Name = "TXT_NOTES";
            this.TXT_NOTES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_NOTES.Size = new System.Drawing.Size(226, 41);
            this.TXT_NOTES.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 100;
            this.label1.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 101;
            this.label2.Text = "الجهة المرسلة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(446, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 102;
            this.label4.Text = "المضمون";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(32, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 26);
            this.label23.TabIndex = 103;
            this.label23.Text = "نوع الطلب";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // CBOX_TYPE
            // 
            this.CBOX_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_TYPE.FormattingEnabled = true;
            this.CBOX_TYPE.Items.AddRange(new object[] {
            " ",
            "طلب عوائل الشهداء",
            "طلب سلاح",
            "أخرى"});
            this.CBOX_TYPE.Location = new System.Drawing.Point(183, 11);
            this.CBOX_TYPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_TYPE.Name = "CBOX_TYPE";
            this.CBOX_TYPE.Size = new System.Drawing.Size(226, 24);
            this.CBOX_TYPE.TabIndex = 105;
            // 
            // DTP_DATE
            // 
            this.DTP_DATE.CalendarMonthBackground = System.Drawing.Color.Beige;
            this.DTP_DATE.CalendarTitleBackColor = System.Drawing.Color.Beige;
            this.DTP_DATE.CustomFormat = "dd/MM/yyyy";
            this.DTP_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DATE.Location = new System.Drawing.Point(183, 38);
            this.DTP_DATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP_DATE.Name = "DTP_DATE";
            this.DTP_DATE.Size = new System.Drawing.Size(226, 22);
            this.DTP_DATE.TabIndex = 104;
            // 
            // btnNEW
            // 
            this.btnNEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.btnNEW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.btnNEW.FlatAppearance.BorderSize = 0;
            this.btnNEW.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNEW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.btnNEW.ForeColor = System.Drawing.Color.White;
            this.btnNEW.Location = new System.Drawing.Point(205, 590);
            this.btnNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(110, 30);
            this.btnNEW.TabIndex = 177;
            this.btnNEW.Text = "جديد";
            this.btnNEW.UseVisualStyleBackColor = false;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(446, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 180;
            this.label3.Text = "ملاحظات";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(403, 636);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 287;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNADD.FlatAppearance.BorderSize = 0;
            this.BTNADD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNADD.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNADD.ForeColor = System.Drawing.Color.White;
            this.BTNADD.Location = new System.Drawing.Point(337, 590);
            this.BTNADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(110, 30);
            this.BTNADD.TabIndex = 286;
            this.BTNADD.Text = "إضافة";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_ORDERS);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(805, 411);
            this.groupBox1.TabIndex = 289;
            this.groupBox1.TabStop = false;
            // 
            // DGV_ORDERS
            // 
            this.DGV_ORDERS.AllowUserToAddRows = false;
            this.DGV_ORDERS.AllowUserToDeleteRows = false;
            this.DGV_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ORDERS.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ORDERS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ORDERS.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_ORDERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_ORDERS.Location = new System.Drawing.Point(3, 15);
            this.DGV_ORDERS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_ORDERS.MultiSelect = false;
            this.DGV_ORDERS.Name = "DGV_ORDERS";
            this.DGV_ORDERS.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ORDERS.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_ORDERS.RowTemplate.Height = 26;
            this.DGV_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDERS.Size = new System.Drawing.Size(799, 394);
            this.DGV_ORDERS.TabIndex = 1;
            this.DGV_ORDERS.SelectionChanged += new System.EventHandler(this.DGV_ORDERS_SelectionChanged);
            this.DGV_ORDERS.Click += new System.EventHandler(this.DGV_ORDERS_Click);
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
            this.BTNDELETE.Location = new System.Drawing.Point(270, 636);
            this.BTNDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(110, 30);
            this.BTNDELETE.TabIndex = 291;
            this.BTNDELETE.Text = "حذف";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNADD_DOCS
            // 
            this.BTNADD_DOCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNADD_DOCS.Enabled = false;
            this.BTNADD_DOCS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNADD_DOCS.FlatAppearance.BorderSize = 0;
            this.BTNADD_DOCS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNADD_DOCS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNADD_DOCS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNADD_DOCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNADD_DOCS.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNADD_DOCS.ForeColor = System.Drawing.Color.White;
            this.BTNADD_DOCS.Location = new System.Drawing.Point(631, 634);
            this.BTNADD_DOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNADD_DOCS.Name = "BTNADD_DOCS";
            this.BTNADD_DOCS.Size = new System.Drawing.Size(110, 30);
            this.BTNADD_DOCS.TabIndex = 290;
            this.BTNADD_DOCS.Text = "إضافة مرفق";
            this.BTNADD_DOCS.UseVisualStyleBackColor = false;
            this.BTNADD_DOCS.Visible = false;
            this.BTNADD_DOCS.Click += new System.EventHandler(this.BTNSHOW_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.BTNEDIT.Location = new System.Drawing.Point(470, 590);
            this.BTNEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(110, 30);
            this.BTNEDIT.TabIndex = 292;
            this.BTNEDIT.Text = "تعديل";
            this.BTNEDIT.UseVisualStyleBackColor = false;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.BackColor = System.Drawing.Color.Beige;
            this.TXT_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(264, 138);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(239, 22);
            this.TXT_SEARCH.TabIndex = 300;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label5.Location = new System.Drawing.Point(192, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 301;
            this.label5.Text = "بحث";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(538, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 37);
            this.button1.TabIndex = 302;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FORM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXT_SEARCH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNEDIT);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNADD_DOCS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNEW);
            this.Controls.Add(this.CBOX_TYPE);
            this.Controls.Add(this.DTP_DATE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TXT_SOURCE);
            this.Controls.Add(this.TXT_CONTENT);
            this.Controls.Add(this.TXT_NOTES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الطلبات";
            this.Load += new System.EventHandler(this.FORM_ORDERS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_SOURCE;
        private System.Windows.Forms.TextBox TXT_CONTENT;
        private System.Windows.Forms.TextBox TXT_NOTES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox CBOX_TYPE;
        private System.Windows.Forms.DateTimePicker DTP_DATE;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_ORDERS;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNADD_DOCS;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BTNEDIT;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}