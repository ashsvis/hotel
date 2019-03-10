namespace Reception
{
    partial class EmployeesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteEmployee = new System.Windows.Forms.ToolStripButton();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewEmployee,
            this.tsbChangeEmployee,
            this.tsbDeleteEmployee});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(691, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewEmployee
            // 
            this.tsbNewEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewEmployee.Image")));
            this.tsbNewEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewEmployee.Name = "tsbNewEmployee";
            this.tsbNewEmployee.Size = new System.Drawing.Size(116, 22);
            this.tsbNewEmployee.Text = "Нанять сотрудника";
            this.tsbNewEmployee.ToolTipText = "Добавить нового сотрудника";
            this.tsbNewEmployee.Click += new System.EventHandler(this.tsbNewEmployee_Click);
            // 
            // tsbChangeEmployee
            // 
            this.tsbChangeEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeEmployee.Enabled = false;
            this.tsbChangeEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeEmployee.Image")));
            this.tsbChangeEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeEmployee.Name = "tsbChangeEmployee";
            this.tsbChangeEmployee.Size = new System.Drawing.Size(109, 22);
            this.tsbChangeEmployee.Text = "Изменить данные";
            this.tsbChangeEmployee.ToolTipText = "Изменить данные сотрудника";
            this.tsbChangeEmployee.Click += new System.EventHandler(this.tsbChangeEmployee_Click);
            // 
            // tsbDeleteEmployee
            // 
            this.tsbDeleteEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteEmployee.Enabled = false;
            this.tsbDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteEmployee.Image")));
            this.tsbDeleteEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteEmployee.Name = "tsbDeleteEmployee";
            this.tsbDeleteEmployee.Size = new System.Drawing.Size(122, 22);
            this.tsbDeleteEmployee.Text = "Уволить сотрудника";
            this.tsbDeleteEmployee.ToolTipText = "Удалить выбранного сотрудника";
            this.tsbDeleteEmployee.Click += new System.EventHandler(this.tsbDeleteEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 25);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(691, 240);
            this.dgvEmployees.TabIndex = 3;
            this.dgvEmployees.VirtualMode = true;
            this.dgvEmployees.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvEmployees_CellValueNeeded);
            this.dgvEmployees.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_ColumnHeaderMouseClick);
            this.dgvEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_RowEnter);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 83;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 56;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 83;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Телефонный номер";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 131;
            // 
            // EmployeesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "EmployeesControl";
            this.Size = new System.Drawing.Size(691, 265);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewEmployee;
        private System.Windows.Forms.ToolStripButton tsbChangeEmployee;
        private System.Windows.Forms.ToolStripButton tsbDeleteEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
