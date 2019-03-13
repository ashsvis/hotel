namespace Reception
{
    partial class AccordancePayChannelsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccordancePayChannelsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccordances = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewAccordance = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeAccordance = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAccordance = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccordances)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccordances
            // 
            this.dgvAccordances.AllowUserToAddRows = false;
            this.dgvAccordances.AllowUserToDeleteRows = false;
            this.dgvAccordances.AllowUserToResizeColumns = false;
            this.dgvAccordances.AllowUserToResizeRows = false;
            this.dgvAccordances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccordances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccordances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccordances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAccordances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccordances.Location = new System.Drawing.Point(0, 25);
            this.dgvAccordances.MultiSelect = false;
            this.dgvAccordances.Name = "dgvAccordances";
            this.dgvAccordances.ReadOnly = true;
            this.dgvAccordances.RowHeadersVisible = false;
            this.dgvAccordances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccordances.Size = new System.Drawing.Size(558, 292);
            this.dgvAccordances.TabIndex = 7;
            this.dgvAccordances.VirtualMode = true;
            this.dgvAccordances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccordances_RowEnter);
            this.dgvAccordances.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvAccordances_CellValueNeeded);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewAccordance,
            this.tsbChangeAccordance,
            this.tsbDeleteAccordance});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewAccordance
            // 
            this.tsbNewAccordance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewAccordance.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewAccordance.Image")));
            this.tsbNewAccordance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewAccordance.Name = "tsbNewAccordance";
            this.tsbNewAccordance.Size = new System.Drawing.Size(100, 22);
            this.tsbNewAccordance.Text = "Новая подписка";
            this.tsbNewAccordance.Click += new System.EventHandler(this.tsbNewAccordance_Click);
            // 
            // tsbChangeAccordance
            // 
            this.tsbChangeAccordance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeAccordance.Enabled = false;
            this.tsbChangeAccordance.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeAccordance.Image")));
            this.tsbChangeAccordance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeAccordance.Name = "tsbChangeAccordance";
            this.tsbChangeAccordance.Size = new System.Drawing.Size(109, 22);
            this.tsbChangeAccordance.Text = "Изменить данные";
            this.tsbChangeAccordance.Click += new System.EventHandler(this.tsbChangeAccordance_Click);
            // 
            // tsbDeleteAccordance
            // 
            this.tsbDeleteAccordance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteAccordance.Enabled = false;
            this.tsbDeleteAccordance.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAccordance.Image")));
            this.tsbDeleteAccordance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAccordance.Name = "tsbDeleteAccordance";
            this.tsbDeleteAccordance.Size = new System.Drawing.Size(131, 22);
            this.tsbDeleteAccordance.Text = "Удалить регистрацию";
            this.tsbDeleteAccordance.Click += new System.EventHandler(this.tsbDeleteAccordance_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия клиента";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 119;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Подключение в номер";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 112;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Количество каналов";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 132;
            // 
            // AccordancePayChannelsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAccordances);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AccordancePayChannelsControl";
            this.Size = new System.Drawing.Size(558, 317);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccordances)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccordances;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewAccordance;
        private System.Windows.Forms.ToolStripButton tsbChangeAccordance;
        private System.Windows.Forms.ToolStripButton tsbDeleteAccordance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
