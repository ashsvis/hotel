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
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccordancePayChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRentPlacements = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuningRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPayPlacements = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientsBlackList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPayChannelsTV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelView = new System.Windows.Forms.Panel();
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
            this.tsmiClients,
            this.tsmiReservations,
            this.tsmiTransfer,
            this.tsmiAccordancePayChannels,
            this.tsmiRentPlacements,
            this.toolStripMenuItem2,
            this.tsmiExit});
            this.tsmiReception.Name = "tsmiReception";
            this.tsmiReception.Size = new System.Drawing.Size(92, 20);
            this.tsmiReception.Text = "Регистратура";
            // 
            // tsmiClients
            // 
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(247, 22);
            this.tsmiClients.Text = "Оформление клиентов";
            this.tsmiClients.Click += new System.EventHandler(this.tsmiClients_Click);
            // 
            // tsmiReservations
            // 
            this.tsmiReservations.Name = "tsmiReservations";
            this.tsmiReservations.Size = new System.Drawing.Size(247, 22);
            this.tsmiReservations.Text = "Бронирование номеров";
            this.tsmiReservations.Click += new System.EventHandler(this.tsmiReservations_Click);
            // 
            // tsmiTransfer
            // 
            this.tsmiTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmiTransfer.Name = "tsmiTransfer";
            this.tsmiTransfer.Size = new System.Drawing.Size(247, 22);
            this.tsmiTransfer.Text = "Доставка клиентов в гостиницу";
            this.tsmiTransfer.Click += new System.EventHandler(this.tsmiTransfer_Click);
            // 
            // tsmiAccordancePayChannels
            // 
            this.tsmiAccordancePayChannels.Name = "tsmiAccordancePayChannels";
            this.tsmiAccordancePayChannels.Size = new System.Drawing.Size(247, 22);
            this.tsmiAccordancePayChannels.Text = "Услуга платных каналов";
            this.tsmiAccordancePayChannels.Click += new System.EventHandler(this.tsmiAccordancePayChannels_Click);
            // 
            // tsmiRentPlacements
            // 
            this.tsmiRentPlacements.Enabled = false;
            this.tsmiRentPlacements.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.tsmiRentPlacements.Name = "tsmiRentPlacements";
            this.tsmiRentPlacements.Size = new System.Drawing.Size(247, 22);
            this.tsmiRentPlacements.Text = "Прокат помещений";
            this.tsmiRentPlacements.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(244, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(247, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiTuning
            // 
            this.tsmiTuning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployees,
            this.tsmiTuningRooms,
            this.tsmiPayPlacements,
            this.tsmiClientsBlackList,
            this.toolStripMenuItem3,
            this.tsmiCategories,
            this.tsmiServices,
            this.tsmiEmployeeRoles,
            this.tsmiPayChannelsTV,
            this.toolStripMenuItem1,
            this.tsmiSaveToFile});
            this.tsmiTuning.Name = "tsmiTuning";
            this.tsmiTuning.Size = new System.Drawing.Size(78, 20);
            this.tsmiTuning.Text = "Настройка";
            // 
            // tsmiEmployees
            // 
            this.tsmiEmployees.Name = "tsmiEmployees";
            this.tsmiEmployees.Size = new System.Drawing.Size(314, 22);
            this.tsmiEmployees.Text = "Сотрудники";
            this.tsmiEmployees.Click += new System.EventHandler(this.tsmiEmployees_Click);
            // 
            // tsmiTuningRooms
            // 
            this.tsmiTuningRooms.Name = "tsmiTuningRooms";
            this.tsmiTuningRooms.Size = new System.Drawing.Size(314, 22);
            this.tsmiTuningRooms.Text = "Жилой фонд";
            this.tsmiTuningRooms.Click += new System.EventHandler(this.tsmiTuningRooms_Click);
            // 
            // tsmiPayPlacements
            // 
            this.tsmiPayPlacements.Enabled = false;
            this.tsmiPayPlacements.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.tsmiPayPlacements.Name = "tsmiPayPlacements";
            this.tsmiPayPlacements.Size = new System.Drawing.Size(314, 22);
            this.tsmiPayPlacements.Text = "Помещения для проката";
            this.tsmiPayPlacements.Visible = false;
            // 
            // tsmiClientsBlackList
            // 
            this.tsmiClientsBlackList.Enabled = false;
            this.tsmiClientsBlackList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.tsmiClientsBlackList.Name = "tsmiClientsBlackList";
            this.tsmiClientsBlackList.Size = new System.Drawing.Size(314, 22);
            this.tsmiClientsBlackList.Text = "Чёрный список клиентов";
            this.tsmiClientsBlackList.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(311, 6);
            // 
            // tsmiCategories
            // 
            this.tsmiCategories.Name = "tsmiCategories";
            this.tsmiCategories.Size = new System.Drawing.Size(314, 22);
            this.tsmiCategories.Text = "Категории номеров";
            this.tsmiCategories.Click += new System.EventHandler(this.tsmiCategories_Click);
            // 
            // tsmiServices
            // 
            this.tsmiServices.Name = "tsmiServices";
            this.tsmiServices.Size = new System.Drawing.Size(314, 22);
            this.tsmiServices.Text = "Перечень услуг";
            this.tsmiServices.Click += new System.EventHandler(this.tsmiServices_Click);
            // 
            // tsmiEmployeeRoles
            // 
            this.tsmiEmployeeRoles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmiEmployeeRoles.Name = "tsmiEmployeeRoles";
            this.tsmiEmployeeRoles.Size = new System.Drawing.Size(314, 22);
            this.tsmiEmployeeRoles.Text = "Должности сотрудников";
            this.tsmiEmployeeRoles.Click += new System.EventHandler(this.tsmiEmployeeRoles_Click);
            // 
            // tsmiPayChannelsTV
            // 
            this.tsmiPayChannelsTV.Name = "tsmiPayChannelsTV";
            this.tsmiPayChannelsTV.Size = new System.Drawing.Size(314, 22);
            this.tsmiPayChannelsTV.Text = "Перечень платных каналов ТВ";
            this.tsmiPayChannelsTV.Click += new System.EventHandler(this.tsmiPayChannelsTV_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiReservations;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiServices;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategories;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmiRentPlacements;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayPlacements;
        private System.Windows.Forms.ToolStripMenuItem tsmiTransfer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayChannelsTV;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccordancePayChannels;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientsBlackList;
    }
}

