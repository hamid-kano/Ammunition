namespace FastFoodDemo.PL
{
    partial class FORM_STATISTIC_MEMBERS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_STATISTIC_MEMBERS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVLIST = new System.Windows.Forms.DataGridView();
            this.RBTN_HEREM = new System.Windows.Forms.RadioButton();
            this.RBTN_EYALET = new System.Windows.Forms.RadioButton();
            this.RBTN_ALAY = new System.Windows.Forms.RadioButton();
            this.RBTN_TUGAY = new System.Windows.Forms.RadioButton();
            this.RBTN_FORCE = new System.Windows.Forms.RadioButton();
            this.RBTN_TABUR = new System.Windows.Forms.RadioButton();
            this.BTNIQLIMSHOW = new System.Windows.Forms.Button();
            this.BTNPRINT = new System.Windows.Forms.Button();
            this.BTNCLO = new System.Windows.Forms.Button();
            this.CBOX_ALAY = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.CBOX_TUGAY = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.CBOXKATEBA = new System.Windows.Forms.ComboBox();
            this.CBOX_HEREM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBOX_EYALET = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBOX_FORCE = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVLIST);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1210, 467);
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
            this.DGVLIST.Size = new System.Drawing.Size(1204, 449);
            this.DGVLIST.TabIndex = 2;
            // 
            // RBTN_HEREM
            // 
            this.RBTN_HEREM.AutoSize = true;
            this.RBTN_HEREM.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_HEREM.Location = new System.Drawing.Point(145, 12);
            this.RBTN_HEREM.Name = "RBTN_HEREM";
            this.RBTN_HEREM.Size = new System.Drawing.Size(106, 30);
            this.RBTN_HEREM.TabIndex = 418;
            this.RBTN_HEREM.TabStop = true;
            this.RBTN_HEREM.Text = "حسب الإقليم";
            this.RBTN_HEREM.UseVisualStyleBackColor = true;
            this.RBTN_HEREM.CheckedChanged += new System.EventHandler(this.RBTN_HEREM_CheckedChanged);
            // 
            // RBTN_EYALET
            // 
            this.RBTN_EYALET.AutoSize = true;
            this.RBTN_EYALET.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_EYALET.Location = new System.Drawing.Point(302, 12);
            this.RBTN_EYALET.Name = "RBTN_EYALET";
            this.RBTN_EYALET.Size = new System.Drawing.Size(119, 30);
            this.RBTN_EYALET.TabIndex = 419;
            this.RBTN_EYALET.TabStop = true;
            this.RBTN_EYALET.Text = "حسب المنطقة";
            this.RBTN_EYALET.UseVisualStyleBackColor = true;
            this.RBTN_EYALET.CheckedChanged += new System.EventHandler(this.RBTN_EYALET_CheckedChanged);
            // 
            // RBTN_ALAY
            // 
            this.RBTN_ALAY.AutoSize = true;
            this.RBTN_ALAY.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_ALAY.Location = new System.Drawing.Point(636, 12);
            this.RBTN_ALAY.Name = "RBTN_ALAY";
            this.RBTN_ALAY.Size = new System.Drawing.Size(101, 30);
            this.RBTN_ALAY.TabIndex = 421;
            this.RBTN_ALAY.TabStop = true;
            this.RBTN_ALAY.Text = "حسب الفوج";
            this.RBTN_ALAY.UseVisualStyleBackColor = true;
            this.RBTN_ALAY.CheckedChanged += new System.EventHandler(this.RBTN_ALAY_CheckedChanged);
            // 
            // RBTN_TUGAY
            // 
            this.RBTN_TUGAY.AutoSize = true;
            this.RBTN_TUGAY.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_TUGAY.Location = new System.Drawing.Point(472, 12);
            this.RBTN_TUGAY.Name = "RBTN_TUGAY";
            this.RBTN_TUGAY.Size = new System.Drawing.Size(97, 30);
            this.RBTN_TUGAY.TabIndex = 420;
            this.RBTN_TUGAY.TabStop = true;
            this.RBTN_TUGAY.Text = "حسب اللواء";
            this.RBTN_TUGAY.UseVisualStyleBackColor = true;
            this.RBTN_TUGAY.CheckedChanged += new System.EventHandler(this.RBTN_TUGAY_CheckedChanged);
            // 
            // RBTN_FORCE
            // 
            this.RBTN_FORCE.AutoSize = true;
            this.RBTN_FORCE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_FORCE.Location = new System.Drawing.Point(987, 12);
            this.RBTN_FORCE.Name = "RBTN_FORCE";
            this.RBTN_FORCE.Size = new System.Drawing.Size(97, 30);
            this.RBTN_FORCE.TabIndex = 423;
            this.RBTN_FORCE.TabStop = true;
            this.RBTN_FORCE.Text = "حسب القوة";
            this.RBTN_FORCE.UseVisualStyleBackColor = true;
            this.RBTN_FORCE.CheckedChanged += new System.EventHandler(this.RBTN_FORCE_CheckedChanged);
            // 
            // RBTN_TABUR
            // 
            this.RBTN_TABUR.AutoSize = true;
            this.RBTN_TABUR.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.RBTN_TABUR.Location = new System.Drawing.Point(822, 12);
            this.RBTN_TABUR.Name = "RBTN_TABUR";
            this.RBTN_TABUR.Size = new System.Drawing.Size(111, 30);
            this.RBTN_TABUR.TabIndex = 422;
            this.RBTN_TABUR.TabStop = true;
            this.RBTN_TABUR.Text = "حسب الكتيبة";
            this.RBTN_TABUR.UseVisualStyleBackColor = true;
            this.RBTN_TABUR.CheckedChanged += new System.EventHandler(this.RBTN_TABUR_CheckedChanged);
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
            this.BTNIQLIMSHOW.Location = new System.Drawing.Point(419, 599);
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
            this.BTNPRINT.Location = new System.Drawing.Point(559, 599);
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
            this.BTNCLO.Location = new System.Drawing.Point(698, 599);
            this.BTNCLO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNCLO.Name = "BTNCLO";
            this.BTNCLO.Size = new System.Drawing.Size(110, 30);
            this.BTNCLO.TabIndex = 424;
            this.BTNCLO.Text = "خروج";
            this.BTNCLO.UseVisualStyleBackColor = false;
            this.BTNCLO.Click += new System.EventHandler(this.BTNCLO_Click_1);
            // 
            // CBOX_ALAY
            // 
            this.CBOX_ALAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_ALAY.Enabled = false;
            this.CBOX_ALAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_ALAY.FormattingEnabled = true;
            this.CBOX_ALAY.ItemHeight = 17;
            this.CBOX_ALAY.Location = new System.Drawing.Point(511, 89);
            this.CBOX_ALAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_ALAY.Name = "CBOX_ALAY";
            this.CBOX_ALAY.Size = new System.Drawing.Size(226, 25);
            this.CBOX_ALAY.TabIndex = 430;
            this.CBOX_ALAY.SelectedIndexChanged += new System.EventHandler(this.CBOX_ALAY_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(444, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 26);
            this.label24.TabIndex = 429;
            this.label24.Text = "فوج";
            // 
            // CBOX_TUGAY
            // 
            this.CBOX_TUGAY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_TUGAY.Enabled = false;
            this.CBOX_TUGAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_TUGAY.FormattingEnabled = true;
            this.CBOX_TUGAY.ItemHeight = 17;
            this.CBOX_TUGAY.Location = new System.Drawing.Point(511, 58);
            this.CBOX_TUGAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_TUGAY.Name = "CBOX_TUGAY";
            this.CBOX_TUGAY.Size = new System.Drawing.Size(226, 25);
            this.CBOX_TUGAY.TabIndex = 432;
            this.CBOX_TUGAY.SelectedIndexChanged += new System.EventHandler(this.CBOX_TUGAY_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(444, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 26);
            this.label4.TabIndex = 431;
            this.label4.Text = "لواء";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.SystemColors.Control;
            this.label41.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(795, 57);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(54, 26);
            this.label41.TabIndex = 434;
            this.label41.Text = "الكتيبة";
            // 
            // CBOXKATEBA
            // 
            this.CBOXKATEBA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXKATEBA.Enabled = false;
            this.CBOXKATEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CBOXKATEBA.Location = new System.Drawing.Point(887, 57);
            this.CBOXKATEBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXKATEBA.Name = "CBOXKATEBA";
            this.CBOXKATEBA.Size = new System.Drawing.Size(226, 24);
            this.CBOXKATEBA.TabIndex = 433;
            this.CBOXKATEBA.SelectedIndexChanged += new System.EventHandler(this.CBOXKATEBA_SelectedIndexChanged);
            // 
            // CBOX_HEREM
            // 
            this.CBOX_HEREM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_HEREM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_HEREM.FormattingEnabled = true;
            this.CBOX_HEREM.Location = new System.Drawing.Point(149, 58);
            this.CBOX_HEREM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_HEREM.Name = "CBOX_HEREM";
            this.CBOX_HEREM.Size = new System.Drawing.Size(232, 25);
            this.CBOX_HEREM.TabIndex = 435;
            this.CBOX_HEREM.SelectedIndexChanged += new System.EventHandler(this.CBOX_HEREM_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 26);
            this.label2.TabIndex = 436;
            this.label2.Text = "الإقليم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(51, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 438;
            this.label3.Text = "المنطقة";
            // 
            // CBOX_EYALET
            // 
            this.CBOX_EYALET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_EYALET.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_EYALET.FormattingEnabled = true;
            this.CBOX_EYALET.Location = new System.Drawing.Point(149, 88);
            this.CBOX_EYALET.Name = "CBOX_EYALET";
            this.CBOX_EYALET.Size = new System.Drawing.Size(232, 26);
            this.CBOX_EYALET.TabIndex = 437;
            this.CBOX_EYALET.SelectedIndexChanged += new System.EventHandler(this.CBOX_EYALET_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(795, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 440;
            this.label5.Text = "القوة";
            // 
            // CBOX_FORCE
            // 
            this.CBOX_FORCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_FORCE.Enabled = false;
            this.CBOX_FORCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_FORCE.FormattingEnabled = true;
            this.CBOX_FORCE.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.CBOX_FORCE.Location = new System.Drawing.Point(887, 85);
            this.CBOX_FORCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_FORCE.Name = "CBOX_FORCE";
            this.CBOX_FORCE.Size = new System.Drawing.Size(226, 24);
            this.CBOX_FORCE.TabIndex = 439;
            this.CBOX_FORCE.SelectedIndexChanged += new System.EventHandler(this.CBOX_FORCE_SelectedIndexChanged);
            // 
            // FORM_STATISTIC_MEMBERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1233, 655);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBOX_FORCE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBOX_EYALET);
            this.Controls.Add(this.CBOX_HEREM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.CBOXKATEBA);
            this.Controls.Add(this.CBOX_TUGAY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBOX_ALAY);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.BTNIQLIMSHOW);
            this.Controls.Add(this.BTNPRINT);
            this.Controls.Add(this.BTNCLO);
            this.Controls.Add(this.RBTN_FORCE);
            this.Controls.Add(this.RBTN_TABUR);
            this.Controls.Add(this.RBTN_ALAY);
            this.Controls.Add(this.RBTN_TUGAY);
            this.Controls.Add(this.RBTN_EYALET);
            this.Controls.Add(this.RBTN_HEREM);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_STATISTIC_MEMBERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.Load += new System.EventHandler(this.FORM_STATISTIC_MEMBERS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVLIST;
        private System.Windows.Forms.RadioButton RBTN_HEREM;
        private System.Windows.Forms.RadioButton RBTN_EYALET;
        private System.Windows.Forms.RadioButton RBTN_ALAY;
        private System.Windows.Forms.RadioButton RBTN_TUGAY;
        private System.Windows.Forms.RadioButton RBTN_FORCE;
        private System.Windows.Forms.RadioButton RBTN_TABUR;
        private System.Windows.Forms.Button BTNIQLIMSHOW;
        private System.Windows.Forms.Button BTNPRINT;
        private System.Windows.Forms.Button BTNCLO;
        public System.Windows.Forms.ComboBox CBOX_ALAY;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.ComboBox CBOX_TUGAY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox CBOXKATEBA;
        public System.Windows.Forms.ComboBox CBOX_HEREM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CBOX_EYALET;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBOX_FORCE;

    }
}