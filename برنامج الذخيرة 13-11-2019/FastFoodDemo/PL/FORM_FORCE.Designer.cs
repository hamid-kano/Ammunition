namespace FastFoodDemo.PL
{
    partial class FORM_FORCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_FORCE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVFORCE = new System.Windows.Forms.DataGridView();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNEDIT = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.TXTNUM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNNEW = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFORCE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVFORCE);
            this.groupBox1.Location = new System.Drawing.Point(17, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(476, 348);
            this.groupBox1.TabIndex = 269;
            this.groupBox1.TabStop = false;
            // 
            // DGVFORCE
            // 
            this.DGVFORCE.AllowUserToAddRows = false;
            this.DGVFORCE.AllowUserToDeleteRows = false;
            this.DGVFORCE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFORCE.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFORCE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFORCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFORCE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVFORCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVFORCE.Location = new System.Drawing.Point(3, 15);
            this.DGVFORCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVFORCE.MultiSelect = false;
            this.DGVFORCE.Name = "DGVFORCE";
            this.DGVFORCE.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFORCE.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVFORCE.RowTemplate.Height = 26;
            this.DGVFORCE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFORCE.Size = new System.Drawing.Size(470, 331);
            this.DGVFORCE.TabIndex = 2;
            this.DGVFORCE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFORCE_CellContentClick);
            this.DGVFORCE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVFORCE_CellFormatting);
            this.DGVFORCE.SelectionChanged += new System.EventHandler(this.DGVFORCE_SelectionChanged);
            this.DGVFORCE.Click += new System.EventHandler(this.DGVFORCE_Click);
            // 
            // TXTNAME
            // 
            this.TXTNAME.BackColor = System.Drawing.Color.Beige;
            this.TXTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNAME.Location = new System.Drawing.Point(176, 58);
            this.TXTNAME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(259, 23);
            this.TXTNAME.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(65, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 26);
            this.label24.TabIndex = 268;
            this.label24.Text = "اسم القوة";
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
            this.BTNDELETE.Location = new System.Drawing.Point(277, 503);
            this.BTNDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(110, 30);
            this.BTNDELETE.TabIndex = 6;
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
            this.BTNEDIT.Location = new System.Drawing.Point(146, 504);
            this.BTNEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(110, 30);
            this.BTNEDIT.TabIndex = 5;
            this.BTNEDIT.Text = "تعديل ";
            this.BTNEDIT.UseVisualStyleBackColor = false;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
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
            this.BTNADD.Location = new System.Drawing.Point(275, 458);
            this.BTNADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(110, 30);
            this.BTNADD.TabIndex = 4;
            this.BTNADD.Text = "إضافة";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // TXTNUM
            // 
            this.TXTNUM.BackColor = System.Drawing.Color.Beige;
            this.TXTNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNUM.Location = new System.Drawing.Point(176, 18);
            this.TXTNUM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTNUM.Name = "TXTNUM";
            this.TXTNUM.Size = new System.Drawing.Size(259, 23);
            this.TXTNUM.TabIndex = 0;
            this.TXTNUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUM_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(68, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 308;
            this.label3.Text = "رقم القوة";
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
            this.BTNNEW.Location = new System.Drawing.Point(146, 459);
            this.BTNNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(110, 30);
            this.BTNNEW.TabIndex = 3;
            this.BTNNEW.Text = "جديد";
            this.BTNNEW.UseVisualStyleBackColor = false;
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // FORM_FORCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(508, 551);
            this.Controls.Add(this.BTNNEW);
            this.Controls.Add(this.TXTNUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNEDIT);
            this.Controls.Add(this.BTNADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_FORCE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القوات";
            this.Load += new System.EventHandler(this.FORM_FORCE_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFORCE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVFORCE;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNEDIT;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.TextBox TXTNUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNNEW;
    }
}