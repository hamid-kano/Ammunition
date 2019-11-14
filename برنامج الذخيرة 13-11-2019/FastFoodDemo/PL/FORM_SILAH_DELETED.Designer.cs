namespace FastFoodDemo.PL
{
    partial class FORM_SILAH_DELETED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SILAH_DELETED));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVSILAH = new System.Windows.Forms.DataGridView();
            this.BTNRETRIVE = new System.Windows.Forms.Button();
            this.BTNDELETEMEM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNDELETEALL = new System.Windows.Forms.Button();
            this.CBOX_TYPE = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSILAH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVSILAH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(874, 405);
            this.groupBox1.TabIndex = 257;
            this.groupBox1.TabStop = false;
            // 
            // DGVSILAH
            // 
            this.DGVSILAH.AllowUserToAddRows = false;
            this.DGVSILAH.AllowUserToDeleteRows = false;
            this.DGVSILAH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSILAH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVSILAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSILAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSILAH.Location = new System.Drawing.Point(3, 16);
            this.DGVSILAH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVSILAH.MultiSelect = false;
            this.DGVSILAH.Name = "DGVSILAH";
            this.DGVSILAH.ReadOnly = true;
            this.DGVSILAH.RowTemplate.Height = 26;
            this.DGVSILAH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSILAH.Size = new System.Drawing.Size(868, 387);
            this.DGVSILAH.TabIndex = 0;
            this.DGVSILAH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVMEM_CellFormatting);
            this.DGVSILAH.SelectionChanged += new System.EventHandler(this.DGVSILAH_SelectionChanged);
            this.DGVSILAH.Click += new System.EventHandler(this.DGVMEM_Click);
            // 
            // BTNRETRIVE
            // 
            this.BTNRETRIVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNRETRIVE.Enabled = false;
            this.BTNRETRIVE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNRETRIVE.FlatAppearance.BorderSize = 0;
            this.BTNRETRIVE.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNRETRIVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNRETRIVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNRETRIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRETRIVE.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNRETRIVE.ForeColor = System.Drawing.Color.White;
            this.BTNRETRIVE.Location = new System.Drawing.Point(82, 465);
            this.BTNRETRIVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRETRIVE.Name = "BTNRETRIVE";
            this.BTNRETRIVE.Size = new System.Drawing.Size(376, 40);
            this.BTNRETRIVE.TabIndex = 292;
            this.BTNRETRIVE.Text = "استعادة السطر المحدد مع كامل بياناته";
            this.BTNRETRIVE.UseVisualStyleBackColor = false;
            this.BTNRETRIVE.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNDELETEMEM
            // 
            this.BTNDELETEMEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNDELETEMEM.Enabled = false;
            this.BTNDELETEMEM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNDELETEMEM.FlatAppearance.BorderSize = 0;
            this.BTNDELETEMEM.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETEMEM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETEMEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNDELETEMEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDELETEMEM.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNDELETEMEM.ForeColor = System.Drawing.Color.White;
            this.BTNDELETEMEM.Location = new System.Drawing.Point(82, 519);
            this.BTNDELETEMEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETEMEM.Name = "BTNDELETEMEM";
            this.BTNDELETEMEM.Size = new System.Drawing.Size(376, 40);
            this.BTNDELETEMEM.TabIndex = 293;
            this.BTNDELETEMEM.Text = "حذف السطر المحدد بشكل نهائي";
            this.BTNDELETEMEM.UseVisualStyleBackColor = false;
            this.BTNDELETEMEM.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Location = new System.Drawing.Point(472, 519);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 40);
            this.button2.TabIndex = 294;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNDELETEALL
            // 
            this.BTNDELETEALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNDELETEALL.Enabled = false;
            this.BTNDELETEALL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNDELETEALL.FlatAppearance.BorderSize = 0;
            this.BTNDELETEALL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETEALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETEALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNDELETEALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDELETEALL.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNDELETEALL.ForeColor = System.Drawing.Color.White;
            this.BTNDELETEALL.Location = new System.Drawing.Point(472, 465);
            this.BTNDELETEALL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETEALL.Name = "BTNDELETEALL";
            this.BTNDELETEALL.Size = new System.Drawing.Size(319, 40);
            this.BTNDELETEALL.TabIndex = 295;
            this.BTNDELETEALL.Text = "حذف الكل بشكل نهائي";
            this.BTNDELETEALL.UseVisualStyleBackColor = false;
            this.BTNDELETEALL.Click += new System.EventHandler(this.BTNDELETEALL_Click);
            // 
            // CBOX_TYPE
            // 
            this.CBOX_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOX_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOX_TYPE.FormattingEnabled = true;
            this.CBOX_TYPE.Items.AddRange(new object[] {
            "الأقاليم",
            "المناطق",
            "الألوية",
            "الأفواج",
            "الكتائب",
            "القوات",
            "الأصناف",
            "المصادرات",
            "الغنائم",
            "الطلبات",
            "الأسلحة",
            "المستودع",
            "الأسلحة الصادرة",
            "الأسلحة الواردة",
            "الأسلحة المستردة",
            "الأسلحة الواردة من خارج قسد"});
            this.CBOX_TYPE.Location = new System.Drawing.Point(359, 11);
            this.CBOX_TYPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOX_TYPE.Name = "CBOX_TYPE";
            this.CBOX_TYPE.Size = new System.Drawing.Size(226, 24);
            this.CBOX_TYPE.TabIndex = 305;
            this.CBOX_TYPE.SelectedIndexChanged += new System.EventHandler(this.CBOX_TYPE_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(253, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 26);
            this.label23.TabIndex = 304;
            this.label23.Text = "المحذوف";
            // 
            // FORM_SILAH_DELETED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(898, 588);
            this.Controls.Add(this.CBOX_TYPE);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.BTNDELETEALL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNDELETEMEM);
            this.Controls.Add(this.BTNRETRIVE);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_SILAH_DELETED";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المحذوفات";
            this.Load += new System.EventHandler(this.FORM_SILAH_DELETED_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSILAH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVSILAH;
        private System.Windows.Forms.Button BTNRETRIVE;
        private System.Windows.Forms.Button BTNDELETEMEM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNDELETEALL;
        private System.Windows.Forms.ComboBox CBOX_TYPE;
        private System.Windows.Forms.Label label23;
    }
}