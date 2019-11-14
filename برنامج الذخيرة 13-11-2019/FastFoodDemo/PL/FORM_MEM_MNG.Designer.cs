namespace FastFoodDemo.PL
{
    partial class FORM_MEM_MNG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MEM_MNG));
            this.BTNREFRESH = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNEDIT = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNDETALIES = new System.Windows.Forms.Button();
            this.BTN_DOCs = new System.Windows.Forms.Button();
            this.RBALL = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVMEM = new System.Windows.Forms.DataGridView();
            this.RBKTEBA = new System.Windows.Forms.RadioButton();
            this.CBOXKATEBA = new System.Windows.Forms.ComboBox();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.RBGLOBAL = new System.Windows.Forms.RadioButton();
            this.RBFORCE = new System.Windows.Forms.RadioButton();
            this.CBOXFORCE = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MEM_PIC = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMEM)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MEM_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNREFRESH
            // 
            this.BTNREFRESH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNREFRESH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNREFRESH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNREFRESH.FlatAppearance.BorderSize = 0;
            this.BTNREFRESH.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNREFRESH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNREFRESH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNREFRESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNREFRESH.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNREFRESH.ForeColor = System.Drawing.Color.White;
            this.BTNREFRESH.Location = new System.Drawing.Point(1065, 550);
            this.BTNREFRESH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNREFRESH.Name = "BTNREFRESH";
            this.BTNREFRESH.Size = new System.Drawing.Size(205, 46);
            this.BTNREFRESH.TabIndex = 262;
            this.BTNREFRESH.Text = "تحديث";
            this.BTNREFRESH.UseVisualStyleBackColor = false;
            this.BTNREFRESH.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNADD.FlatAppearance.BorderSize = 0;
            this.BTNADD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNADD.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNADD.ForeColor = System.Drawing.Color.White;
            this.BTNADD.Location = new System.Drawing.Point(853, 550);
            this.BTNADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(206, 46);
            this.BTNADD.TabIndex = 263;
            this.BTNADD.Text = "إضافة";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BTNEDIT.Location = new System.Drawing.Point(641, 550);
            this.BTNEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(206, 46);
            this.BTNEDIT.TabIndex = 47;
            this.BTNEDIT.Text = "تعديل البيانات";
            this.BTNEDIT.UseVisualStyleBackColor = false;
            this.BTNEDIT.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BTNDELETE.Location = new System.Drawing.Point(3, 550);
            this.BTNDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(208, 46);
            this.BTNDELETE.TabIndex = 257;
            this.BTNDELETE.Text = "حذف";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNDETALIES
            // 
            this.BTNDETALIES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNDETALIES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNDETALIES.Enabled = false;
            this.BTNDETALIES.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNDETALIES.FlatAppearance.BorderSize = 0;
            this.BTNDETALIES.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDETALIES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDETALIES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNDETALIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDETALIES.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNDETALIES.ForeColor = System.Drawing.Color.White;
            this.BTNDETALIES.Location = new System.Drawing.Point(217, 550);
            this.BTNDETALIES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDETALIES.Name = "BTNDETALIES";
            this.BTNDETALIES.Size = new System.Drawing.Size(206, 46);
            this.BTNDETALIES.TabIndex = 272;
            this.BTNDETALIES.Text = "أسلحة المقاتل";
            this.BTNDETALIES.UseVisualStyleBackColor = false;
            this.BTNDETALIES.Click += new System.EventHandler(this.BTNDETALIES_Click);
            // 
            // BTN_DOCs
            // 
            this.BTN_DOCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DOCs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTN_DOCs.Enabled = false;
            this.BTN_DOCs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTN_DOCs.FlatAppearance.BorderSize = 0;
            this.BTN_DOCs.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DOCs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DOCs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTN_DOCs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DOCs.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTN_DOCs.ForeColor = System.Drawing.Color.White;
            this.BTN_DOCs.Location = new System.Drawing.Point(429, 550);
            this.BTN_DOCs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_DOCs.Name = "BTN_DOCs";
            this.BTN_DOCs.Size = new System.Drawing.Size(206, 46);
            this.BTN_DOCs.TabIndex = 276;
            this.BTN_DOCs.Text = "وثائق المقاتل";
            this.BTN_DOCs.UseVisualStyleBackColor = false;
            this.BTN_DOCs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RBALL
            // 
            this.RBALL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBALL.AutoSize = true;
            this.RBALL.Checked = true;
            this.RBALL.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBALL.ForeColor = System.Drawing.Color.Black;
            this.RBALL.Location = new System.Drawing.Point(1140, 13);
            this.RBALL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBALL.Name = "RBALL";
            this.RBALL.Size = new System.Drawing.Size(55, 30);
            this.RBALL.TabIndex = 264;
            this.RBALL.TabStop = true;
            this.RBALL.Text = "الكل";
            this.RBALL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBALL.UseVisualStyleBackColor = true;
            this.RBALL.CheckedChanged += new System.EventHandler(this.RBALL_CheckedChanged);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 6);
            this.groupBox1.Controls.Add(this.DGVMEM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(1267, 368);
            this.groupBox1.TabIndex = 256;
            this.groupBox1.TabStop = false;
            // 
            // DGVMEM
            // 
            this.DGVMEM.AllowUserToAddRows = false;
            this.DGVMEM.AllowUserToDeleteRows = false;
            this.DGVMEM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMEM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVMEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMEM.Location = new System.Drawing.Point(3, 16);
            this.DGVMEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVMEM.MultiSelect = false;
            this.DGVMEM.Name = "DGVMEM";
            this.DGVMEM.ReadOnly = true;
            this.DGVMEM.RowTemplate.Height = 26;
            this.DGVMEM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMEM.Size = new System.Drawing.Size(1261, 350);
            this.DGVMEM.TabIndex = 0;
            this.DGVMEM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVMEM_CellFormatting);
            this.DGVMEM.SelectionChanged += new System.EventHandler(this.DGVMEM_SelectionChanged);
            this.DGVMEM.Click += new System.EventHandler(this.DGVMEM_Click);
            // 
            // RBKTEBA
            // 
            this.RBKTEBA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBKTEBA.AutoSize = true;
            this.RBKTEBA.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBKTEBA.ForeColor = System.Drawing.Color.Black;
            this.RBKTEBA.Location = new System.Drawing.Point(689, 13);
            this.RBKTEBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBKTEBA.Name = "RBKTEBA";
            this.RBKTEBA.Size = new System.Drawing.Size(111, 30);
            this.RBKTEBA.TabIndex = 265;
            this.RBKTEBA.Text = "حسب الكتيبة";
            this.RBKTEBA.UseVisualStyleBackColor = true;
            this.RBKTEBA.CheckedChanged += new System.EventHandler(this.RBKTEBA_CheckedChanged);
            // 
            // CBOXKATEBA
            // 
            this.CBOXKATEBA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.CBOXKATEBA, 2);
            this.CBOXKATEBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXKATEBA.DropDownWidth = 650;
            this.CBOXKATEBA.Enabled = false;
            this.CBOXKATEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXKATEBA.FormattingEnabled = true;
            this.CBOXKATEBA.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.CBOXKATEBA.Location = new System.Drawing.Point(429, 58);
            this.CBOXKATEBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXKATEBA.Name = "CBOXKATEBA";
            this.CBOXKATEBA.Size = new System.Drawing.Size(418, 23);
            this.CBOXKATEBA.TabIndex = 259;
            this.CBOXKATEBA.SelectedIndexChanged += new System.EventHandler(this.CBOXKATEBA_SelectedIndexChanged);
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSEARCH.BackColor = System.Drawing.Color.Beige;
            this.txtSEARCH.Enabled = false;
            this.txtSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(853, 58);
            this.txtSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(206, 24);
            this.txtSEARCH.TabIndex = 252;
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            // 
            // RBGLOBAL
            // 
            this.RBGLOBAL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBGLOBAL.AutoSize = true;
            this.RBGLOBAL.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBGLOBAL.ForeColor = System.Drawing.Color.Black;
            this.RBGLOBAL.Location = new System.Drawing.Point(914, 13);
            this.RBGLOBAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBGLOBAL.Name = "RBGLOBAL";
            this.RBGLOBAL.Size = new System.Drawing.Size(84, 30);
            this.RBGLOBAL.TabIndex = 265;
            this.RBGLOBAL.Text = "بحث عام";
            this.RBGLOBAL.UseVisualStyleBackColor = true;
            this.RBGLOBAL.CheckedChanged += new System.EventHandler(this.RBGLOBAL_CheckedChanged);
            // 
            // RBFORCE
            // 
            this.RBFORCE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBFORCE.AutoSize = true;
            this.RBFORCE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBFORCE.ForeColor = System.Drawing.Color.Black;
            this.RBFORCE.Location = new System.Drawing.Point(272, 13);
            this.RBFORCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RBFORCE.Name = "RBFORCE";
            this.RBFORCE.Size = new System.Drawing.Size(97, 30);
            this.RBFORCE.TabIndex = 266;
            this.RBFORCE.Text = "حسب القوة";
            this.RBFORCE.UseVisualStyleBackColor = true;
            this.RBFORCE.CheckedChanged += new System.EventHandler(this.RBFORCE_CheckedChanged);
            // 
            // CBOXFORCE
            // 
            this.CBOXFORCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBOXFORCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXFORCE.Enabled = false;
            this.CBOXFORCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXFORCE.FormattingEnabled = true;
            this.CBOXFORCE.Location = new System.Drawing.Point(217, 58);
            this.CBOXFORCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXFORCE.Name = "CBOXFORCE";
            this.CBOXFORCE.Size = new System.Drawing.Size(206, 25);
            this.CBOXFORCE.TabIndex = 261;
            this.CBOXFORCE.SelectedIndexChanged += new System.EventHandler(this.CBOXFORCE_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.64861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67069F));
            this.tableLayoutPanel1.Controls.Add(this.CBOXFORCE, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.RBFORCE, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.RBGLOBAL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSEARCH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CBOXKATEBA, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RBKTEBA, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MEM_PIC, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.RBALL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_DOCs, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNDETALIES, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNDELETE, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNEDIT, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNADD, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTNREFRESH, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.84337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.25301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.23219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1273, 610);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MEM_PIC
            // 
            this.MEM_PIC.BackColor = System.Drawing.SystemColors.Control;
            this.MEM_PIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MEM_PIC.Location = new System.Drawing.Point(3, 2);
            this.MEM_PIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MEM_PIC.Name = "MEM_PIC";
            this.tableLayoutPanel1.SetRowSpan(this.MEM_PIC, 3);
            this.MEM_PIC.Size = new System.Drawing.Size(208, 172);
            this.MEM_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MEM_PIC.TabIndex = 275;
            this.MEM_PIC.TabStop = false;
            // 
            // FORM_MEM_MNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1273, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_MEM_MNG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة بيانات المقاتلين";
            this.Load += new System.EventHandler(this.FORM_MEM_MNG_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMEM)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MEM_PIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNREFRESH;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNEDIT;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNDETALIES;
        private System.Windows.Forms.Button BTN_DOCs;
        private System.Windows.Forms.RadioButton RBALL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CBOXFORCE;
        private System.Windows.Forms.RadioButton RBFORCE;
        private System.Windows.Forms.RadioButton RBGLOBAL;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.ComboBox CBOXKATEBA;
        private System.Windows.Forms.RadioButton RBKTEBA;
        public System.Windows.Forms.PictureBox MEM_PIC;
        public System.Windows.Forms.DataGridView DGVMEM;
    }
}