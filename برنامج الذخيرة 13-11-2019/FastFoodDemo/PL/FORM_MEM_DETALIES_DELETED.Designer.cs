namespace FastFoodDemo.PL
{
    partial class FORM_MEM_DETALIES_DELETED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MEM_DETALIES_DELETED));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVMEM = new System.Windows.Forms.DataGridView();
            this.BTNDELETEALL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNDELETEMEM = new System.Windows.Forms.Button();
            this.BTNRETRIVE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMEM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVMEM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(894, 438);
            this.groupBox1.TabIndex = 296;
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
            this.DGVMEM.Size = new System.Drawing.Size(888, 420);
            this.DGVMEM.TabIndex = 0;
            this.DGVMEM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVMEM_CellFormatting);
            this.DGVMEM.SelectionChanged += new System.EventHandler(this.DGVMEM_SelectionChanged);
            this.DGVMEM.Click += new System.EventHandler(this.DGVMEM_Click);
            // 
            // BTNDELETEALL
            // 
            this.BTNDELETEALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(125)))), ((int)(((byte)(47)))));
            this.BTNDELETEALL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(72)))), ((int)(((byte)(64)))));
            this.BTNDELETEALL.FlatAppearance.BorderSize = 0;
            this.BTNDELETEALL.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETEALL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNDELETEALL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.BTNDELETEALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDELETEALL.Font = new System.Drawing.Font("Al-Jazeera-Arabic-Regular", 11.25F);
            this.BTNDELETEALL.ForeColor = System.Drawing.Color.White;
            this.BTNDELETEALL.Location = new System.Drawing.Point(524, 479);
            this.BTNDELETEALL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETEALL.Name = "BTNDELETEALL";
            this.BTNDELETEALL.Size = new System.Drawing.Size(263, 40);
            this.BTNDELETEALL.TabIndex = 300;
            this.BTNDELETEALL.Text = "حذف الكل بشكل نهائي";
            this.BTNDELETEALL.UseVisualStyleBackColor = false;
            this.BTNDELETEALL.Click += new System.EventHandler(this.BTNDELETEALL_Click);
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
            this.button2.Location = new System.Drawing.Point(524, 534);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 40);
            this.button2.TabIndex = 299;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.BTNDELETEMEM.Location = new System.Drawing.Point(178, 534);
            this.BTNDELETEMEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNDELETEMEM.Name = "BTNDELETEMEM";
            this.BTNDELETEMEM.Size = new System.Drawing.Size(339, 40);
            this.BTNDELETEMEM.TabIndex = 298;
            this.BTNDELETEMEM.Text = "حذف السطر المحدد بشكل نهائي";
            this.BTNDELETEMEM.UseVisualStyleBackColor = false;
            this.BTNDELETEMEM.Click += new System.EventHandler(this.BTNDELETEMEM_Click);
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
            this.BTNRETRIVE.Location = new System.Drawing.Point(178, 479);
            this.BTNRETRIVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNRETRIVE.Name = "BTNRETRIVE";
            this.BTNRETRIVE.Size = new System.Drawing.Size(339, 40);
            this.BTNRETRIVE.TabIndex = 297;
            this.BTNRETRIVE.Text = "استعادة السطر المحدد";
            this.BTNRETRIVE.UseVisualStyleBackColor = false;
            this.BTNRETRIVE.Click += new System.EventHandler(this.BTNRETRIVE_Click);
            // 
            // FORM_MEM_DETALIES_DELETED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTNDELETEALL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNDELETEMEM);
            this.Controls.Add(this.BTNRETRIVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FORM_MEM_DETALIES_DELETED";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التفاصيل";
            this.Load += new System.EventHandler(this.FORM_MEM_DETALIES_DELETED_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMEM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVMEM;
        private System.Windows.Forms.Button BTNDELETEALL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNDELETEMEM;
        private System.Windows.Forms.Button BTNRETRIVE;
    }
}