namespace Reception
{
    partial class ArrivalsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrivalsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArrivals = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbArrivalClient = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeArrivalClient = new System.Windows.Forms.ToolStripButton();
            this.tsbDepartureClient = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivals)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArrivals
            // 
            this.dgvArrivals.AllowUserToAddRows = false;
            this.dgvArrivals.AllowUserToDeleteRows = false;
            this.dgvArrivals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArrivals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArrivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvArrivals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArrivals.Location = new System.Drawing.Point(0, 25);
            this.dgvArrivals.MultiSelect = false;
            this.dgvArrivals.Name = "dgvArrivals";
            this.dgvArrivals.ReadOnly = true;
            this.dgvArrivals.RowHeadersVisible = false;
            this.dgvArrivals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArrivals.Size = new System.Drawing.Size(816, 148);
            this.dgvArrivals.TabIndex = 7;
            this.dgvArrivals.VirtualMode = true;
            this.dgvArrivals.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvArrivals_CellValueNeeded);
            this.dgvArrivals.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArrivals_RowEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbArrivalClient,
            this.tsbChangeArrivalClient,
            this.tsbDepartureClient});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbArrivalClient
            // 
            this.tsbArrivalClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbArrivalClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbArrivalClient.Image")));
            this.tsbArrivalClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArrivalClient.Name = "tsbArrivalClient";
            this.tsbArrivalClient.Size = new System.Drawing.Size(69, 22);
            this.tsbArrivalClient.Text = "Заселение";
            this.tsbArrivalClient.ToolTipText = "Добавить запись о заселении";
            this.tsbArrivalClient.Click += new System.EventHandler(this.tsbArrivalClient_Click);
            // 
            // tsbChangeArrivalClient
            // 
            this.tsbChangeArrivalClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeArrivalClient.Enabled = false;
            this.tsbChangeArrivalClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeArrivalClient.Image")));
            this.tsbChangeArrivalClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeArrivalClient.Name = "tsbChangeArrivalClient";
            this.tsbChangeArrivalClient.Size = new System.Drawing.Size(109, 22);
            this.tsbChangeArrivalClient.Text = "Изменить данные";
            this.tsbChangeArrivalClient.ToolTipText = "Изменить данные постояльца";
            this.tsbChangeArrivalClient.Click += new System.EventHandler(this.tsbChangeArrivalClient_Click);
            // 
            // tsbDepartureClient
            // 
            this.tsbDepartureClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDepartureClient.Enabled = false;
            this.tsbDepartureClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbDepartureClient.Image")));
            this.tsbDepartureClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDepartureClient.Name = "tsbDepartureClient";
            this.tsbDepartureClient.Size = new System.Drawing.Size(99, 22);
            this.tsbDepartureClient.Text = "Удалить данные";
            this.tsbDepartureClient.ToolTipText = "Удалить данные о заселении";
            this.tsbDepartureClient.Click += new System.EventHandler(this.tsbDepartureClient_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Фамилия Имя Отчество";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Информация о номере";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 109;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Дата заезда";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 87;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Дата выезда";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // ArrivalsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvArrivals);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ArrivalsControl";
            this.Size = new System.Drawing.Size(816, 173);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivals)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArrivals;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbArrivalClient;
        private System.Windows.Forms.ToolStripButton tsbChangeArrivalClient;
        private System.Windows.Forms.ToolStripButton tsbDepartureClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
