namespace FastFoodDemo.PL
{
    partial class FORM_SILAH_MNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SILAH_MNG));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SILAH_MODEL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBOX_CAT_NAME = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_SILAH = new System.Windows.Forms.DataGridView();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.TXT_NOTES = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_QTY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBOX_CAT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbox_unit = new System.Windows.Forms.ComboBox();
            this.lblUnite = new System.Windows.Forms.Label();
            this.CBOX_HER = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBOX_EYALET = new System.Windows.Forms.ComboBox();
            this.CBOX_TUGAY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBOX_ALAY = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.CBOXKATEBA = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SILAH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label1.Location = new System.Drawing.Point(405, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "السلاح";
            // 
            // TXT_SILAH_MODEL
            // 
            this.TXT_SILAH_MODEL.BackColor = System.Drawing.Color.Beige;
            this.TXT_SILAH_MODEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SILAH_MODEL.Location = new System.Drawing.Point(499, 72);
            this.TXT_SILAH_MODEL.Name = "TXT_SILAH_MODEL";
            this.TXT_SILAH_MODEL.Size = new System.Drawing.Size(232, 21);
            this.TXT_SILAH_MODEL.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.Location = new System.Drawing.Point(405, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "الموديل";
            // 
            // CBOX_CAT_NAME
            // 
            this.CBOX_CAT_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_CAT_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_CAT_NAME.FormattingEnabled = true;
            this.CBOX_CAT_NAME.Location = new System.Drawing.Point(499, 42);
            this.CBOX_CAT_NAME.Name = "CBOX_CAT_NAME";
            this.CBOX_CAT_NAME.Size = new System.Drawing.Size(232, 23);
            this.CBOX_CAT_NAME.TabIndex = 1;
            this.CBOX_CAT_NAME.SelectedIndexChanged += new System.EventHandler(this.CBOX_CAT_NAME_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label6.Location = new System.Drawing.Point(900, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "الكمية";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_SILAH);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1230, 481);
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
            this.DGV_SILAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SILAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_SILAH.Location = new System.Drawing.Point(3, 19);
            this.DGV_SILAH.Name = "DGV_SILAH";
            this.DGV_SILAH.ReadOnly = true;
            this.DGV_SILAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_SILAH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SILAH.Size = new System.Drawing.Size(1224, 459);
            this.DGV_SILAH.TabIndex = 7;
            this.DGV_SILAH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_SILAH_CellContentClick);
            this.DGV_SILAH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_SILAH_CellFormatting);
            this.DGV_SILAH.SelectionChanged += new System.EventHandler(this.DGV_SILAH_SelectionChanged);
            this.DGV_SILAH.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.BackColor = System.Drawing.Color.Beige;
            this.TXT_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(505, 157);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(223, 21);
            this.TXT_SEARCH.TabIndex = 6;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label4.Location = new System.Drawing.Point(435, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "بحث";
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_DELETE.FlatAppearance.BorderSize = 0;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_DELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_DELETE.Location = new System.Drawing.Point(755, 673);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(110, 30);
            this.BTN_DELETE.TabIndex = 11;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_EDIT.FlatAppearance.BorderSize = 0;
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_EDIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_EDIT.Location = new System.Drawing.Point(626, 673);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(110, 30);
            this.BTN_EDIT.TabIndex = 10;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_ADD.FlatAppearance.BorderSize = 0;
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_ADD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_ADD.Location = new System.Drawing.Point(498, 673);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_ADD.TabIndex = 9;
            this.BTN_ADD.Text = "إضافة";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_NEW.FlatAppearance.BorderSize = 0;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_NEW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_NEW.Location = new System.Drawing.Point(366, 673);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(110, 30);
            this.BTN_NEW.TabIndex = 8;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // TXT_NOTES
            // 
            this.TXT_NOTES.BackColor = System.Drawing.Color.Beige;
            this.TXT_NOTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOTES.Location = new System.Drawing.Point(1032, 66);
            this.TXT_NOTES.Multiline = true;
            this.TXT_NOTES.Name = "TXT_NOTES";
            this.TXT_NOTES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_NOTES.Size = new System.Drawing.Size(210, 60);
            this.TXT_NOTES.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label5.Location = new System.Drawing.Point(900, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "ملاحظات";
            // 
            // TXT_QTY
            // 
            this.TXT_QTY.BackColor = System.Drawing.Color.Beige;
            this.TXT_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_QTY.Location = new System.Drawing.Point(1032, 12);
            this.TXT_QTY.Name = "TXT_QTY";
            this.TXT_QTY.Size = new System.Drawing.Size(210, 21);
            this.TXT_QTY.TabIndex = 4;
            this.TXT_QTY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_QTY_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(759, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBOX_CAT
            // 
            this.CBOX_CAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBOX_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.CBOX_CAT.Location = new System.Drawing.Point(499, 14);
            this.CBOX_CAT.Name = "CBOX_CAT";
            this.CBOX_CAT.Size = new System.Drawing.Size(232, 24);
            this.CBOX_CAT.TabIndex = 0;
            this.CBOX_CAT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.CBOX_CAT.TextChanged += new System.EventHandler(this.CBOX_CAT_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label8.Location = new System.Drawing.Point(405, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "النوع";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(755, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 37);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbox_unit
            // 
            this.cbox_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_unit.FormattingEnabled = true;
            this.cbox_unit.Items.AddRange(new object[] {
            "عدد",
            "قطعة",
            "علبة",
            "صندوق"});
            this.cbox_unit.Location = new System.Drawing.Point(1032, 39);
            this.cbox_unit.Name = "cbox_unit";
            this.cbox_unit.Size = new System.Drawing.Size(210, 23);
            this.cbox_unit.TabIndex = 29;
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.lblUnite.Location = new System.Drawing.Point(900, 37);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(54, 26);
            this.lblUnite.TabIndex = 28;
            this.lblUnite.Text = "الواحدة";
            // 
            // CBOX_HER
            // 
            this.CBOX_HER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_HER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_HER.FormattingEnabled = true;
            this.CBOX_HER.Location = new System.Drawing.Point(134, 12);
            this.CBOX_HER.Name = "CBOX_HER";
            this.CBOX_HER.Size = new System.Drawing.Size(232, 24);
            this.CBOX_HER.TabIndex = 277;
            this.CBOX_HER.SelectedIndexChanged += new System.EventHandler(this.CBOX_HER_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(30, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 26);
            this.label24.TabIndex = 278;
            this.label24.Text = "الإقليم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 293;
            this.label2.Text = "المنطقة";
            // 
            // CBOX_EYALET
            // 
            this.CBOX_EYALET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_EYALET.Enabled = false;
            this.CBOX_EYALET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_EYALET.FormattingEnabled = true;
            this.CBOX_EYALET.Location = new System.Drawing.Point(134, 42);
            this.CBOX_EYALET.Name = "CBOX_EYALET";
            this.CBOX_EYALET.Size = new System.Drawing.Size(232, 24);
            this.CBOX_EYALET.TabIndex = 292;
            this.CBOX_EYALET.SelectedIndexChanged += new System.EventHandler(this.CBOX_EYALET_SelectedIndexChanged);
            // 
            // CBOX_TUGAY
            // 
            this.CBOX_TUGAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_TUGAY.Enabled = false;
            this.CBOX_TUGAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_TUGAY.FormattingEnabled = true;
            this.CBOX_TUGAY.Location = new System.Drawing.Point(134, 72);
            this.CBOX_TUGAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_TUGAY.Name = "CBOX_TUGAY";
            this.CBOX_TUGAY.Size = new System.Drawing.Size(232, 24);
            this.CBOX_TUGAY.TabIndex = 294;
            this.CBOX_TUGAY.SelectedIndexChanged += new System.EventHandler(this.CBOX_TUGAY_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(30, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 26);
            this.label7.TabIndex = 295;
            this.label7.Text = "لواء";
            // 
            // CBOX_ALAY
            // 
            this.CBOX_ALAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_ALAY.Enabled = false;
            this.CBOX_ALAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_ALAY.FormattingEnabled = true;
            this.CBOX_ALAY.ItemHeight = 16;
            this.CBOX_ALAY.Location = new System.Drawing.Point(134, 101);
            this.CBOX_ALAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_ALAY.Name = "CBOX_ALAY";
            this.CBOX_ALAY.Size = new System.Drawing.Size(232, 24);
            this.CBOX_ALAY.TabIndex = 303;
            this.CBOX_ALAY.SelectedIndexChanged += new System.EventHandler(this.CBOX_ALAY_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 26);
            this.label9.TabIndex = 302;
            this.label9.Text = "فوج";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.SystemColors.Control;
            this.label41.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(30, 129);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(54, 26);
            this.label41.TabIndex = 305;
            this.label41.Text = "الكتيبة";
            // 
            // CBOXKATEBA
            // 
            this.CBOXKATEBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXKATEBA.Enabled = false;
            this.CBOXKATEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXKATEBA.FormattingEnabled = true;
            this.CBOXKATEBA.Location = new System.Drawing.Point(134, 130);
            this.CBOXKATEBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXKATEBA.Name = "CBOXKATEBA";
            this.CBOXKATEBA.Size = new System.Drawing.Size(232, 24);
            this.CBOXKATEBA.TabIndex = 304;
            this.CBOXKATEBA.SelectedIndexChanged += new System.EventHandler(this.CBOXKATEBA_SelectedIndexChanged);
            // 
            // FORM_SILAH_MNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 722);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.CBOXKATEBA);
            this.Controls.Add(this.CBOX_ALAY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBOX_TUGAY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBOX_EYALET);
            this.Controls.Add(this.CBOX_HER);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cbox_unit);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CBOX_CAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXT_QTY);
            this.Controls.Add(this.TXT_NOTES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.TXT_SEARCH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBOX_CAT_NAME);
            this.Controls.Add(this.TXT_SILAH_MODEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_SILAH_MNG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأسلحة";
            this.Load += new System.EventHandler(this.FORM_SILAH_MNG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SILAH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SILAH_MODEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_SILAH;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.TextBox TXT_NOTES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_QTY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox CBOX_CAT_NAME;
        public System.Windows.Forms.ComboBox CBOX_CAT;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cbox_unit;
        private System.Windows.Forms.Label lblUnite;
        public System.Windows.Forms.ComboBox CBOX_HER;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CBOX_EYALET;
        public System.Windows.Forms.ComboBox CBOX_TUGAY;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox CBOX_ALAY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox CBOXKATEBA;
    }
}