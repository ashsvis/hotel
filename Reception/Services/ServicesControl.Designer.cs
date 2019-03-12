namespace Reception
{
    partial class ServicesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewService = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeService = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteService = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(0, 25);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(718, 290);
            this.dgvServices.TabIndex = 7;
            this.dgvServices.VirtualMode = true;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            this.dgvServices.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvServices_CellValueNeeded);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewService,
            this.tsbChangeService,
            this.tsbDeleteService});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewService
            // 
            this.tsbNewService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewService.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewService.Image")));
            this.tsbNewService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewService.Name = "tsbNewService";
            this.tsbNewService.Size = new System.Drawing.Size(84, 22);
            this.tsbNewService.Text = "Новая услуга";
            this.tsbNewService.ToolTipText = "Добавить нового постояльца";
            this.tsbNewService.Click += new System.EventHandler(this.tsbNewService_Click);
            // 
            // tsbChangeService
            // 
            this.tsbChangeService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeService.Enabled = false;
            this.tsbChangeService.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeService.Image")));
            this.tsbChangeService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeService.Name = "tsbChangeService";
            this.tsbChangeService.Size = new System.Drawing.Size(109, 22);
            this.tsbChangeService.Text = "Изменить данные";
            this.tsbChangeService.ToolTipText = "Изменить данные постояльца";
            this.tsbChangeService.Click += new System.EventHandler(this.tsbChangeService_Click);
            // 
            // tsbDeleteService
            // 
            this.tsbDeleteService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteService.Enabled = false;
            this.tsbDeleteService.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteService.Image")));
            this.tsbDeleteService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteService.Name = "tsbDeleteService";
            this.tsbDeleteService.Size = new System.Drawing.Size(94, 22);
            this.tsbDeleteService.Text = "Удалить услугу";
            this.tsbDeleteService.ToolTipText = "Удалить регистрацию постояльца";
            this.tsbDeleteService.Click += new System.EventHandler(this.tsbDeleteService_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование услуги";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 141;
            // 
            // Column2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "Стоимость за сутки";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ServicesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ServicesControl";
            this.Size = new System.Drawing.Size(718, 315);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewService;
        private System.Windows.Forms.ToolStripButton tsbChangeService;
        private System.Windows.Forms.ToolStripButton tsbDeleteService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
