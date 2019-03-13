namespace Reception
{
    partial class EmployeeRolesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRolesControl));
            this.dgvEmployeeRoles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewEmployeeRole = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeEmployeeRole = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteEmployeeRole = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeRoles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployeeRoles
            // 
            this.dgvEmployeeRoles.AllowUserToAddRows = false;
            this.dgvEmployeeRoles.AllowUserToDeleteRows = false;
            this.dgvEmployeeRoles.AllowUserToResizeRows = false;
            this.dgvEmployeeRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployeeRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvEmployeeRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeRoles.Location = new System.Drawing.Point(0, 25);
            this.dgvEmployeeRoles.MultiSelect = false;
            this.dgvEmployeeRoles.Name = "dgvEmployeeRoles";
            this.dgvEmployeeRoles.ReadOnly = true;
            this.dgvEmployeeRoles.RowHeadersVisible = false;
            this.dgvEmployeeRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeRoles.Size = new System.Drawing.Size(504, 313);
            this.dgvEmployeeRoles.TabIndex = 9;
            this.dgvEmployeeRoles.VirtualMode = true;
            this.dgvEmployeeRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeRoles_CellClick);
            this.dgvEmployeeRoles.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvEmployeeRoles_CellValueNeeded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование должности";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 163;
            // 
            // Column2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Оклад жалования за месяц";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 134;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewEmployeeRole,
            this.tsbChangeEmployeeRole,
            this.tsbDeleteEmployeeRole});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewEmployeeRole
            // 
            this.tsbNewEmployeeRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewEmployeeRole.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewEmployeeRole.Image")));
            this.tsbNewEmployeeRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewEmployeeRole.Name = "tsbNewEmployeeRole";
            this.tsbNewEmployeeRole.Size = new System.Drawing.Size(108, 22);
            this.tsbNewEmployeeRole.Text = "Новая должность";
            this.tsbNewEmployeeRole.ToolTipText = "Добавить должность";
            this.tsbNewEmployeeRole.Click += new System.EventHandler(this.tsbNewEmployeeRole_Click);
            // 
            // tsbChangeEmployeeRole
            // 
            this.tsbChangeEmployeeRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeEmployeeRole.Enabled = false;
            this.tsbChangeEmployeeRole.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeEmployeeRole.Image")));
            this.tsbChangeEmployeeRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeEmployeeRole.Name = "tsbChangeEmployeeRole";
            this.tsbChangeEmployeeRole.Size = new System.Drawing.Size(109, 22);
            this.tsbChangeEmployeeRole.Text = "Изменить данные";
            this.tsbChangeEmployeeRole.ToolTipText = "Изменить данные";
            this.tsbChangeEmployeeRole.Click += new System.EventHandler(this.tsbChangeEmployeeRole_Click);
            // 
            // tsbDeleteEmployeeRole
            // 
            this.tsbDeleteEmployeeRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteEmployeeRole.Enabled = false;
            this.tsbDeleteEmployeeRole.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteEmployeeRole.Image")));
            this.tsbDeleteEmployeeRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteEmployeeRole.Name = "tsbDeleteEmployeeRole";
            this.tsbDeleteEmployeeRole.Size = new System.Drawing.Size(118, 22);
            this.tsbDeleteEmployeeRole.Text = "Удалить должность";
            this.tsbDeleteEmployeeRole.ToolTipText = "Удалить должность";
            this.tsbDeleteEmployeeRole.Click += new System.EventHandler(this.tsbDeleteEmployeeRole_Click);
            // 
            // EmployeeRolesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployeeRoles);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EmployeeRolesControl";
            this.Size = new System.Drawing.Size(504, 338);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeRoles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeRoles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewEmployeeRole;
        private System.Windows.Forms.ToolStripButton tsbChangeEmployeeRole;
        private System.Windows.Forms.ToolStripButton tsbDeleteEmployeeRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
