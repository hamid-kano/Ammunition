namespace FastFoodDemo.PL
{
    partial class FORM_LOAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LOAA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_TUGAY = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_TUGAY_NAME = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTLOCATION = new System.Windows.Forms.TextBox();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.CBOX_HER = new System.Windows.Forms.ComboBox();
            this.CBOX_EYALET = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TUGAY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_TUGAY);
            this.groupBox1.Location = new System.Drawing.Point(392, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(613, 350);
            this.groupBox1.TabIndex = 277;
            this.groupBox1.TabStop = false;
            // 
            // DGV_TUGAY
            // 
            this.DGV_TUGAY.AllowUserToAddRows = false;
            this.DGV_TUGAY.AllowUserToDeleteRows = false;
            this.DGV_TUGAY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TUGAY.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TUGAY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TUGAY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TUGAY.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TUGAY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_TUGAY.Location = new System.Drawing.Point(3, 15);
            this.DGV_TUGAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_TUGAY.MultiSelect = false;
            this.DGV_TUGAY.Name = "DGV_TUGAY";
            this.DGV_TUGAY.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TUGAY.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TUGAY.RowTemplate.Height = 26;
            this.DGV_TUGAY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TUGAY.Size = new System.Drawing.Size(607, 333);
            this.DGV_TUGAY.TabIndex = 11;
            this.DGV_TUGAY.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVLOAA_CellFormatting);
            this.DGV_TUGAY.SelectionChanged += new System.EventHandler(this.DGV_TUGAY_SelectionChanged);
            this.DGV_TUGAY.Click += new System.EventHandler(this.DGVLOAA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 282;
            this.label1.Text = "اسم اللواء";
            // 
            // TXT_TUGAY_NAME
            // 
            this.TXT_TUGAY_NAME.BackColor = System.Drawing.Color.Beige;
            this.TXT_TUGAY_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TUGAY_NAME.Location = new System.Drawing.Point(153, 64);
            this.TXT_TUGAY_NAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXT_TUGAY_NAME.Name = "TXT_TUGAY_NAME";
            this.TXT_TUGAY_NAME.Size = new System.Drawing.Size(212, 23);
            this.TXT_TUGAY_NAME.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(21, 125);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 26);
            this.label24.TabIndex = 276;
            this.label24.Text = "الإقليم";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_DELETE.Enabled = false;
            this.BTN_DELETE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTN_DELETE.FlatAppearance.BorderSize = 0;
            this.BTN_DELETE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_DELETE.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE.Location = new System.Drawing.Point(262, 342);
            this.BTN_DELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(110, 30);
            this.BTN_DELETE.TabIndex = 10;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_EDIT.Enabled = false;
            this.BTN_EDIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTN_EDIT.FlatAppearance.BorderSize = 0;
            this.BTN_EDIT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_EDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_EDIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_EDIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT.Location = new System.Drawing.Point(134, 342);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(110, 30);
            this.BTN_EDIT.TabIndex = 9;
            this.BTN_EDIT.Text = "تعديل ";
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
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
            this.BTN_ADD.Location = new System.Drawing.Point(262, 300);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_ADD.TabIndex = 8;
            this.BTN_ADD.Text = "إضافة";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 284;
            this.label2.Text = "موقع اللواء";
            // 
            // TXTLOCATION
            // 
            this.TXTLOCATION.BackColor = System.Drawing.Color.Beige;
            this.TXTLOCATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTLOCATION.Location = new System.Drawing.Point(153, 95);
            this.TXTLOCATION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTLOCATION.Name = "TXTLOCATION";
            this.TXTLOCATION.Size = new System.Drawing.Size(212, 23);
            this.TXTLOCATION.TabIndex = 2;
            // 
            // TXTNUM
            // 
            this.TXTNUM.BackColor = System.Drawing.Color.Beige;
            this.TXTNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNUM.Location = new System.Drawing.Point(153, 33);
            this.TXTNUM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(212, 23);
            this.TXTNUM.TabIndex = 0;
            this.TXTNUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUM_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 286;
            this.label3.Text = "رقم اللواء";
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_NEW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTN_NEW.FlatAppearance.BorderSize = 0;
            this.BTN_NEW.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_NEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_NEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_NEW.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW.Location = new System.Drawing.Point(135, 300);
            this.BTN_NEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(110, 30);
            this.BTN_NEW.TabIndex = 7;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // CBOX_HER
            // 
            this.CBOX_HER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_HER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_HER.FormattingEnabled = true;
            this.CBOX_HER.Location = new System.Drawing.Point(153, 125);
            this.CBOX_HER.Name = "CBOX_HER";
            this.CBOX_HER.Size = new System.Drawing.Size(212, 24);
            this.CBOX_HER.TabIndex = 3;
            this.CBOX_HER.SelectedIndexChanged += new System.EventHandler(this.CBOX_HER_SelectedIndexChanged);
            // 
            // CBOX_EYALET
            // 
            this.CBOX_EYALET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_EYALET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_EYALET.FormattingEnabled = true;
            this.CBOX_EYALET.Location = new System.Drawing.Point(153, 201);
            this.CBOX_EYALET.Name = "CBOX_EYALET";
            this.CBOX_EYALET.Size = new System.Drawing.Size(212, 24);
            this.CBOX_EYALET.TabIndex = 5;
            this.CBOX_EYALET.SelectedIndexChanged += new System.EventHandler(this.CBOX_EYALET_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 26);
            this.label4.TabIndex = 291;
            this.label4.Text = "المنطقة";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(210, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "إضافة إقليم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Location = new System.Drawing.Point(209, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "إضافة منطقة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.BackColor = System.Drawing.Color.Beige;
            this.TXT_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(595, 18);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(239, 22);
            this.TXT_SEARCH.TabIndex = 11;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label5.Location = new System.Drawing.Point(516, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 295;
            this.label5.Text = "بحث";
            // 
            // FORM_LOAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 408);
            this.Controls.Add(this.TXT_SEARCH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBOX_HER);
            this.Controls.Add(this.CBOX_EYALET);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTLOCATION);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_TUGAY_NAME);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_LOAA";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الألوية";
            this.Load += new System.EventHandler(this.FORM_LOAA_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TUGAY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_TUGAY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_TUGAY_NAME;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTLOCATION;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_NEW;
        public System.Windows.Forms.ComboBox CBOX_EYALET;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CBOX_HER;
    }
}