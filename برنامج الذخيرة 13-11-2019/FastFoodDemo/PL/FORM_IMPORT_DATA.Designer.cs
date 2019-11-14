namespace FastFoodDemo.PL
{
    partial class FORM_IMPORT_DATA
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_IMPORT_DATA));
            this.BTNADD = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.BTNSHOW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVSCEDULE = new System.Windows.Forms.DataGridView();
            this.BTNIMPORT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CBOXEXTYPE = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSCEDULE)).BeginInit();
            this.SuspendLayout();
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
            this.BTNADD.Location = new System.Drawing.Point(182, 14);
            this.BTNADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(137, 30);
            this.BTNADD.TabIndex = 301;
            this.BTNADD.Text = "اختيار ملف";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.Location = new System.Drawing.Point(353, 11);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPath.Multiline = true;
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(281, 33);
            this.textBoxPath.TabIndex = 302;
            // 
            // BTNSHOW
            // 
            this.BTNSHOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNSHOW.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNSHOW.FlatAppearance.BorderSize = 0;
            this.BTNSHOW.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNSHOW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNSHOW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSHOW.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNSHOW.ForeColor = System.Drawing.Color.White;
            this.BTNSHOW.Location = new System.Drawing.Point(671, 11);
            this.BTNSHOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNSHOW.Name = "BTNSHOW";
            this.BTNSHOW.Size = new System.Drawing.Size(121, 30);
            this.BTNSHOW.TabIndex = 303;
            this.BTNSHOW.Text = "معاينة";
            this.BTNSHOW.UseVisualStyleBackColor = false;
            this.BTNSHOW.Click += new System.EventHandler(this.BTNSHOW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVSCEDULE);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(936, 420);
            this.groupBox1.TabIndex = 305;
            this.groupBox1.TabStop = false;
            // 
            // DGVSCEDULE
            // 
            this.DGVSCEDULE.AllowUserToAddRows = false;
            this.DGVSCEDULE.AllowUserToDeleteRows = false;
            this.DGVSCEDULE.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSCEDULE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSCEDULE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSCEDULE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSCEDULE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSCEDULE.Location = new System.Drawing.Point(3, 15);
            this.DGVSCEDULE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVSCEDULE.MultiSelect = false;
            this.DGVSCEDULE.Name = "DGVSCEDULE";
            this.DGVSCEDULE.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSCEDULE.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVSCEDULE.RowTemplate.Height = 26;
            this.DGVSCEDULE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSCEDULE.Size = new System.Drawing.Size(930, 403);
            this.DGVSCEDULE.TabIndex = 1;
            this.DGVSCEDULE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVSCEDULE_CellFormatting);
            // 
            // BTNIMPORT
            // 
            this.BTNIMPORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNIMPORT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNIMPORT.FlatAppearance.BorderSize = 0;
            this.BTNIMPORT.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNIMPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNIMPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNIMPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIMPORT.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNIMPORT.ForeColor = System.Drawing.Color.White;
            this.BTNIMPORT.Location = new System.Drawing.Point(389, 549);
            this.BTNIMPORT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNIMPORT.Name = "BTNIMPORT";
            this.BTNIMPORT.Size = new System.Drawing.Size(110, 30);
            this.BTNIMPORT.TabIndex = 306;
            this.BTNIMPORT.Text = "استيراد";
            this.BTNIMPORT.UseVisualStyleBackColor = false;
            this.BTNIMPORT.Click += new System.EventHandler(this.BTNIMPORT_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(521, 549);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 307;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(207, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 318;
            this.label3.Text = "تحديد الجدول";
            // 
            // CBOXEXTYPE
            // 
            this.CBOXEXTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOXEXTYPE.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOXEXTYPE.FormattingEnabled = true;
            this.CBOXEXTYPE.Items.AddRange(new object[] {
            "",
            "1-الأقاليم",
            "2-المناطق",
            "3-الألوية",
            "4-الأفواج",
            "5-الكتائب",
            "6-القوات"});
            this.CBOXEXTYPE.Location = new System.Drawing.Point(355, 70);
            this.CBOXEXTYPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBOXEXTYPE.Name = "CBOXEXTYPE";
            this.CBOXEXTYPE.Size = new System.Drawing.Size(281, 29);
            this.CBOXEXTYPE.TabIndex = 317;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FORM_IMPORT_DATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(962, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBOXEXTYPE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTNIMPORT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNSHOW);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.BTNADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_IMPORT_DATA";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استيراد البيانات";
            this.Load += new System.EventHandler(this.FORM_IMPORT_DATA_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSCEDULE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button BTNSHOW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVSCEDULE;
        private System.Windows.Forms.Button BTNIMPORT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBOXEXTYPE;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}