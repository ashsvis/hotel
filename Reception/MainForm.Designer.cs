namespace Reception
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiReception = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuningRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelView = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReception,
            this.tsmiTuning});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiReception
            // 
            this.tsmiReception.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiReception.Name = "tsmiReception";
            this.tsmiReception.Size = new System.Drawing.Size(92, 20);
            this.tsmiReception.Text = "Регистратура";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiTuning
            // 
            this.tsmiTuning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTuningRooms,
            this.tsmiEmployees,
            this.toolStripMenuItem1,
            this.tsmiSaveToFile});
            this.tsmiTuning.Name = "tsmiTuning";
            this.tsmiTuning.Size = new System.Drawing.Size(78, 20);
            this.tsmiTuning.Text = "Настройка";
            // 
            // tsmiTuningRooms
            // 
            this.tsmiTuningRooms.Name = "tsmiTuningRooms";
            this.tsmiTuningRooms.Size = new System.Drawing.Size(314, 22);
            this.tsmiTuningRooms.Text = "Номерной фонд";
            this.tsmiTuningRooms.Click += new System.EventHandler(this.tsmiTuningRooms_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 24);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(933, 473);
            this.panelView.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(311, 6);
            // 
            // tsmiSaveToFile
            // 
            this.tsmiSaveToFile.Name = "tsmiSaveToFile";
            this.tsmiSaveToFile.Size = new System.Drawing.Size(314, 22);
            this.tsmiSaveToFile.Text = "Сохранить настройки в локальном файле...";
            this.tsmiSaveToFile.Click += new System.EventHandler(this.tsmiSaveToFile_Click);
            // 
            // tsmiEmployees
            // 
            this.tsmiEmployees.Name = "tsmiEmployees";
            this.tsmiEmployees.Size = new System.Drawing.Size(314, 22);
            this.tsmiEmployees.Text = "Данные сотрудников";
            this.tsmiEmployees.Click += new System.EventHandler(this.tsmiEmployees_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Гостиница";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiReception;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuning;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuningRooms;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveToFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployees;
    }
}

