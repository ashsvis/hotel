namespace Reception
{
    partial class PayChannelsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayChannelsControl));
            this.dgvPayChannels = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewPayChannel = new System.Windows.Forms.ToolStripButton();
            this.tsbChangePayChannel = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletePayChannel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayChannels)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPayChannels
            // 
            this.dgvPayChannels.AllowUserToAddRows = false;
            this.dgvPayChannels.AllowUserToDeleteRows = false;
            this.dgvPayChannels.AllowUserToResizeRows = false;
            this.dgvPayChannels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayChannels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayChannels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayChannels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPayChannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayChannels.Location = new System.Drawing.Point(0, 25);
            this.dgvPayChannels.MultiSelect = false;
            this.dgvPayChannels.Name = "dgvPayChannels";
            this.dgvPayChannels.ReadOnly = true;
            this.dgvPayChannels.RowHeadersVisible = false;
            this.dgvPayChannels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayChannels.Size = new System.Drawing.Size(593, 265);
            this.dgvPayChannels.TabIndex = 9;
            this.dgvPayChannels.VirtualMode = true;
            this.dgvPayChannels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayChannel_CellClick);
            this.dgvPayChannels.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvPayChannel_CellValueNeeded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование канала";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 142;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Стоимость за час";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewPayChannel,
            this.tsbChangePayChannel,
            this.tsbDeletePayChannel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewPayChannel
            // 
            this.tsbNewPayChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewPayChannel.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPayChannel.Image")));
            this.tsbNewPayChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPayChannel.Name = "tsbNewPayChannel";
            this.tsbNewPayChannel.Size = new System.Drawing.Size(84, 22);
            this.tsbNewPayChannel.Text = "Новый канал";
            this.tsbNewPayChannel.ToolTipText = "Добавить новый канал";
            this.tsbNewPayChannel.Click += new System.EventHandler(this.tsbNewPayChannel_Click);
            // 
            // tsbChangePayChannel
            // 
            this.tsbChangePayChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangePayChannel.Enabled = false;
            this.tsbChangePayChannel.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangePayChannel.Image")));
            this.tsbChangePayChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangePayChannel.Name = "tsbChangePayChannel";
            this.tsbChangePayChannel.Size = new System.Drawing.Size(109, 22);
            this.tsbChangePayChannel.Text = "Изменить данные";
            this.tsbChangePayChannel.ToolTipText = "Изменить данные канала";
            this.tsbChangePayChannel.Click += new System.EventHandler(this.tsbChangePayChannel_Click);
            // 
            // tsbDeletePayChannel
            // 
            this.tsbDeletePayChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeletePayChannel.Enabled = false;
            this.tsbDeletePayChannel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletePayChannel.Image")));
            this.tsbDeletePayChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletePayChannel.Name = "tsbDeletePayChannel";
            this.tsbDeletePayChannel.Size = new System.Drawing.Size(90, 22);
            this.tsbDeletePayChannel.Text = "Удалить канал";
            this.tsbDeletePayChannel.ToolTipText = "Удалить канал";
            this.tsbDeletePayChannel.Click += new System.EventHandler(this.tsbDeletePayChannel_Click);
            // 
            // PayChannelsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPayChannels);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "PayChannelsControl";
            this.Size = new System.Drawing.Size(593, 290);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayChannels)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayChannels;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewPayChannel;
        private System.Windows.Forms.ToolStripButton tsbChangePayChannel;
        private System.Windows.Forms.ToolStripButton tsbDeletePayChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
