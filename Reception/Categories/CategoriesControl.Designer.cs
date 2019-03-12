namespace Reception
{
    partial class CategoriesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesControl));
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewCategory = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeCategory = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteCategory = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 25);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(569, 302);
            this.dgvCategories.TabIndex = 9;
            this.dgvCategories.VirtualMode = true;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            this.dgvCategories.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvCategories_CellValueNeeded);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewCategory,
            this.tsbChangeCategory,
            this.tsbDeleteCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewCategory
            // 
            this.tsbNewCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCategory.Image")));
            this.tsbNewCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCategory.Name = "tsbNewCategory";
            this.tsbNewCategory.Size = new System.Drawing.Size(103, 22);
            this.tsbNewCategory.Text = "Новая категория";
            this.tsbNewCategory.ToolTipText = "Добавить нового постояльца";
            this.tsbNewCategory.Click += new System.EventHandler(this.tsbNewCategory_Click);
            // 
            // tsbChangeCategory
            // 
            this.tsbChangeCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeCategory.Enabled = false;
            this.tsbChangeCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeCategory.Image")));
            this.tsbChangeCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeCategory.Name = "tsbChangeCategory";
            this.tsbChangeCategory.Size = new System.Drawing.Size(109, 22);
            this.tsbChangeCategory.Text = "Изменить данные";
            this.tsbChangeCategory.ToolTipText = "Изменить данные постояльца";
            this.tsbChangeCategory.Click += new System.EventHandler(this.tsbChangeCategory_Click);
            // 
            // tsbDeleteCategory
            // 
            this.tsbDeleteCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeleteCategory.Enabled = false;
            this.tsbDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteCategory.Image")));
            this.tsbDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteCategory.Name = "tsbDeleteCategory";
            this.tsbDeleteCategory.Size = new System.Drawing.Size(117, 22);
            this.tsbDeleteCategory.Text = "Удалить категорию";
            this.tsbDeleteCategory.ToolTipText = "Удалить регистрацию постояльца";
            this.tsbDeleteCategory.Click += new System.EventHandler(this.tsbDeleteCategory_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование категории";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 159;
            // 
            // CategoriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CategoriesControl";
            this.Size = new System.Drawing.Size(569, 327);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewCategory;
        private System.Windows.Forms.ToolStripButton tsbChangeCategory;
        private System.Windows.Forms.ToolStripButton tsbDeleteCategory;
    }
}
