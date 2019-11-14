namespace FastFoodDemo.PL
{
    partial class FORM_ADD_DOCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_ADD_DOCS));
            this.TXTPATH = new System.Windows.Forms.TextBox();
            this.btnBrowe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVDOCS = new System.Windows.Forms.DataGridView();
            this.BTNSHOW = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CBOXTYPE = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDOCS)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTPATH
            // 
            this.TXTPATH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPATH.Location = new System.Drawing.Point(285, 311);
            this.TXTPATH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTPATH.Name = "TXTPATH";
            this.TXTPATH.ReadOnly = true;
            this.TXTPATH.Size = new System.Drawing.Size(27, 27);
            this.TXTPATH.TabIndex = 79;
            this.TXTPATH.Visible = false;
            // 
            // btnBrowe
            // 
            this.btnBrowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.btnBrowe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.btnBrowe.FlatAppearance.BorderSize = 0;
            this.btnBrowe.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.btnBrowe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowe.ForeColor = System.Drawing.Color.White;
            this.btnBrowe.Location = new System.Drawing.Point(243, 308);
            this.btnBrowe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowe.Name = "btnBrowe";
            this.btnBrowe.Size = new System.Drawing.Size(27, 32);
            this.btnBrowe.TabIndex = 83;
            this.btnBrowe.Text = "...";
            this.btnBrowe.UseVisualStyleBackColor = false;
            this.btnBrowe.Visible = false;
            this.btnBrowe.Click += new System.EventHandler(this.btnADD_Click);
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
            this.button2.Location = new System.Drawing.Point(276, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 85;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVDOCS);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(385, 240);
            this.groupBox1.TabIndex = 278;
            this.groupBox1.TabStop = false;
            // 
            // DGVDOCS
            // 
            this.DGVDOCS.AllowUserToAddRows = false;
            this.DGVDOCS.AllowUserToDeleteRows = false;
            this.DGVDOCS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDOCS.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDOCS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDOCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDOCS.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDOCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDOCS.Location = new System.Drawing.Point(3, 15);
            this.DGVDOCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVDOCS.MultiSelect = false;
            this.DGVDOCS.Name = "DGVDOCS";
            this.DGVDOCS.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDOCS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDOCS.RowTemplate.Height = 26;
            this.DGVDOCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDOCS.Size = new System.Drawing.Size(379, 223);
            this.DGVDOCS.TabIndex = 1;
            this.DGVDOCS.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVDOCS_CellFormatting);
            this.DGVDOCS.SelectionChanged += new System.EventHandler(this.DGVDOCS_SelectionChanged);
            this.DGVDOCS.Click += new System.EventHandler(this.DGVDOCS_Click);
            // 
            // BTNSHOW
            // 
            this.BTNSHOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNSHOW.Enabled = false;
            this.BTNSHOW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNSHOW.FlatAppearance.BorderSize = 0;
            this.BTNSHOW.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNSHOW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNSHOW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSHOW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNSHOW.ForeColor = System.Drawing.Color.White;
            this.BTNSHOW.Location = new System.Drawing.Point(33, 268);
            this.BTNSHOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNSHOW.Name = "BTNSHOW";
            this.BTNSHOW.Size = new System.Drawing.Size(110, 30);
            this.BTNSHOW.TabIndex = 279;
            this.BTNSHOW.Text = "فتح";
            this.BTNSHOW.UseVisualStyleBackColor = false;
            this.BTNSHOW.Click += new System.EventHandler(this.BTNSHOW_Click);
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
            this.BTNDELETE.Location = new System.Drawing.Point(154, 267);
            this.BTNDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(110, 30);
            this.BTNDELETE.TabIndex = 280;
            this.BTNDELETE.Text = "حذف";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CBOXTYPE
            // 
            this.CBOXTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXTYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXTYPE.FormattingEnabled = true;
            this.CBOXTYPE.Items.AddRange(new object[] {
            "",
            "صورة السجل",
            "مجلد للعنصر",
            "مجلد مرفقات أخرى "});
            this.CBOXTYPE.Location = new System.Drawing.Point(318, 311);
            this.CBOXTYPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXTYPE.Name = "CBOXTYPE";
            this.CBOXTYPE.Size = new System.Drawing.Size(36, 25);
            this.CBOXTYPE.TabIndex = 387;
            this.CBOXTYPE.Visible = false;
            // 
            // FORM_ADD_DOCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(409, 315);
            this.Controls.Add(this.CBOXTYPE);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNSHOW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBrowe);
            this.Controls.Add(this.TXTPATH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_ADD_DOCS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة وثائق";
            this.Load += new System.EventHandler(this.FORM_ADD_DOCS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDOCS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTPATH;
        private System.Windows.Forms.Button btnBrowe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVDOCS;
        private System.Windows.Forms.Button BTNSHOW;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CBOXTYPE;
    }
}