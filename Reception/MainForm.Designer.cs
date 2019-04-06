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
            this.tsmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccordancePayChannels = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveToBase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCurrentClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmptyRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBusyRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.заПоследнийМесяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLastMonthClients = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuning = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuningRooms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPayChannelsTV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiConnectionString = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelView = new System.Windows.Forms.Panel();
            this.заУказаннуюДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiByDateClients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReception,
            this.tsmiReports,
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
            this.tsmiLogin,
            this.toolStripMenuItem4,
            this.tsmiClients,
            this.tsmiReservations,
            this.tsmiTransfer,
            this.tsmiAccordancePayChannels,
            this.toolStripMenuItem2,
            this.tsmiSaveToBase,
            this.tsmiExit});
            this.tsmiReception.Name = "tsmiReception";
            this.tsmiReception.Size = new System.Drawing.Size(92, 20);
            this.tsmiReception.Text = "Регистратура";
            this.tsmiReception.DropDownOpening += new System.EventHandler(this.tsmiReception_DropDownOpening);
            // 
            // tsmiLogin
            // 
            this.tsmiLogin.Name = "tsmiLogin";
            this.tsmiLogin.Size = new System.Drawing.Size(247, 22);
            this.tsmiLogin.Text = "Вход...";
            this.tsmiLogin.Click += new System.EventHandler(this.tsmiLogin_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(244, 6);
            // 
            // tsmiClients
            // 
            this.tsmiClients.Enabled = false;
            this.tsmiClients.Name = "tsmiClients";
            this.tsmiClients.Size = new System.Drawing.Size(247, 22);
            this.tsmiClients.Text = "Оформление клиентов";
            this.tsmiClients.Click += new System.EventHandler(this.tsmiClients_Click);
            // 
            // tsmiReservations
            // 
            this.tsmiReservations.Enabled = false;
            this.tsmiReservations.Name = "tsmiReservations";
            this.tsmiReservations.Size = new System.Drawing.Size(247, 22);
            this.tsmiReservations.Text = "Бронирование номеров";
            this.tsmiReservations.Click += new System.EventHandler(this.tsmiReservations_Click);
            // 
            // tsmiTransfer
            // 
            this.tsmiTransfer.Enabled = false;
            this.tsmiTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmiTransfer.Name = "tsmiTransfer";
            this.tsmiTransfer.Size = new System.Drawing.Size(247, 22);
            this.tsmiTransfer.Text = "Доставка клиентов в гостиницу";
            this.tsmiTransfer.Click += new System.EventHandler(this.tsmiTransfer_Click);
            // 
            // tsmiAccordancePayChannels
            // 
            this.tsmiAccordancePayChannels.Enabled = false;
            this.tsmiAccordancePayChannels.Name = "tsmiAccordancePayChannels";
            this.tsmiAccordancePayChannels.Size = new System.Drawing.Size(247, 22);
            this.tsmiAccordancePayChannels.Text = "Услуга платных каналов";
            this.tsmiAccordancePayChannels.Click += new System.EventHandler(this.tsmiAccordancePayChannels_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(244, 6);
            // 
            // tsmiSaveToBase
            // 
            this.tsmiSaveToBase.Enabled = false;
            this.tsmiSaveToBase.Name = "tsmiSaveToBase";
            this.tsmiSaveToBase.Size = new System.Drawing.Size(247, 22);
            this.tsmiSaveToBase.Text = "Сохранить данные";
            this.tsmiSaveToBase.Click += new System.EventHandler(this.tsmiSaveToBase_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(247, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiReports
            // 
            this.tsmiReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentTime,
            this.заПоследнийМесяцToolStripMenuItem,
            this.заУказаннуюДатуToolStripMenuItem,
            this.toolStripMenuItem6,
            this.tsmiFind});
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(60, 20);
            this.tsmiReports.Text = "Отчёты";
            // 
            // tsmiCurrentTime
            // 
            this.tsmiCurrentTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCurrentClients,
            this.tsmiEmptyRooms,
            this.tsmiBusyRooms});
            this.tsmiCurrentTime.Name = "tsmiCurrentTime";
            this.tsmiCurrentTime.Size = new System.Drawing.Size(187, 22);
            this.tsmiCurrentTime.Text = "На текущий момент";
            // 
            // tsmiCurrentClients
            // 
            this.tsmiCurrentClients.Name = "tsmiCurrentClients";
            this.tsmiCurrentClients.Size = new System.Drawing.Size(188, 22);
            this.tsmiCurrentClients.Text = "Список постояльцев";
            this.tsmiCurrentClients.Click += new System.EventHandler(this.tsmiCurrentClients_Click);
            // 
            // tsmiEmptyRooms
            // 
            this.tsmiEmptyRooms.Name = "tsmiEmptyRooms";
            this.tsmiEmptyRooms.Size = new System.Drawing.Size(188, 22);
            this.tsmiEmptyRooms.Text = "Свободные номера";
            this.tsmiEmptyRooms.Click += new System.EventHandler(this.tsmiEmptyRooms_Click);
            // 
            // tsmiBusyRooms
            // 
            this.tsmiBusyRooms.Name = "tsmiBusyRooms";
            this.tsmiBusyRooms.Size = new System.Drawing.Size(188, 22);
            this.tsmiBusyRooms.Text = "Занятые номера";
            this.tsmiBusyRooms.Click += new System.EventHandler(this.tsmiBusyRooms_Click);
            // 
            // заПоследнийМесяцToolStripMenuItem
            // 
            this.заПоследнийМесяцToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLastMonthClients});
            this.заПоследнийМесяцToolStripMenuItem.Name = "заПоследнийМесяцToolStripMenuItem";
            this.заПоследнийМесяцToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.заПоследнийМесяцToolStripMenuItem.Text = "За последний месяц";
            // 
            // tsmiLastMonthClients
            // 
            this.tsmiLastMonthClients.Name = "tsmiLastMonthClients";
            this.tsmiLastMonthClients.Size = new System.Drawing.Size(188, 22);
            this.tsmiLastMonthClients.Text = "Список постояльцев";
            this.tsmiLastMonthClients.Click += new System.EventHandler(this.tsmiLastMonthClients_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiFind
            // 
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.Size = new System.Drawing.Size(187, 22);
            this.tsmiFind.Text = "Поиск...";
            this.tsmiFind.Click += new System.EventHandler(this.tsmiFind_Click);
            // 
            // tsmiTuning
            // 
            this.tsmiTuning.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployees,
            this.tsmiTuningRooms,
            this.toolStripMenuItem3,
            this.tsmiCategories,
            this.tsmiServices,
            this.tsmiEmployeeRoles,
            this.tsmiPayChannelsTV,
            this.toolStripMenuItem1,
            this.tsmiConnectionString,
            this.toolStripMenuItem5,
            this.tsmiSaveToFile,
            this.tsmiLoadFromFile});
            this.tsmiTuning.Name = "tsmiTuning";
            this.tsmiTuning.Size = new System.Drawing.Size(78, 20);
            this.tsmiTuning.Text = "Настройка";
            this.tsmiTuning.DropDownOpening += new System.EventHandler(this.tsmiTuning_DropDownOpening);
            // 
            // tsmiEmployees
            // 
            this.tsmiEmployees.Enabled = false;
            this.tsmiEmployees.Name = "tsmiEmployees";
            this.tsmiEmployees.Size = new System.Drawing.Size(257, 22);
            this.tsmiEmployees.Text = "Сотрудники";
            this.tsmiEmployees.Click += new System.EventHandler(this.tsmiEmployees_Click);
            // 
            // tsmiTuningRooms
            // 
            this.tsmiTuningRooms.Enabled = false;
            this.tsmiTuningRooms.Name = "tsmiTuningRooms";
            this.tsmiTuningRooms.Size = new System.Drawing.Size(257, 22);
            this.tsmiTuningRooms.Text = "Жилой фонд";
            this.tsmiTuningRooms.Click += new System.EventHandler(this.tsmiTuningRooms_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmiCategories
            // 
            this.tsmiCategories.Enabled = false;
            this.tsmiCategories.Name = "tsmiCategories";
            this.tsmiCategories.Size = new System.Drawing.Size(257, 22);
            this.tsmiCategories.Text = "Категории номеров";
            this.tsmiCategories.Click += new System.EventHandler(this.tsmiCategories_Click);
            // 
            // tsmiServices
            // 
            this.tsmiServices.Enabled = false;
            this.tsmiServices.Name = "tsmiServices";
            this.tsmiServices.Size = new System.Drawing.Size(257, 22);
            this.tsmiServices.Text = "Перечень услуг";
            this.tsmiServices.Click += new System.EventHandler(this.tsmiServices_Click);
            // 
            // tsmiEmployeeRoles
            // 
            this.tsmiEmployeeRoles.Enabled = false;
            this.tsmiEmployeeRoles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsmiEmployeeRoles.Name = "tsmiEmployeeRoles";
            this.tsmiEmployeeRoles.Size = new System.Drawing.Size(257, 22);
            this.tsmiEmployeeRoles.Text = "Должности сотрудников";
            this.tsmiEmployeeRoles.Click += new System.EventHandler(this.tsmiEmployeeRoles_Click);
            // 
            // tsmiPayChannelsTV
            // 
            this.tsmiPayChannelsTV.Enabled = false;
            this.tsmiPayChannelsTV.Name = "tsmiPayChannelsTV";
            this.tsmiPayChannelsTV.Size = new System.Drawing.Size(257, 22);
            this.tsmiPayChannelsTV.Text = "Перечень платных каналов ТВ";
            this.tsmiPayChannelsTV.Click += new System.EventHandler(this.tsmiPayChannelsTV_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmiConnectionString
            // 
            this.tsmiConnectionString.Name = "tsmiConnectionString";
            this.tsmiConnectionString.Size = new System.Drawing.Size(257, 22);
            this.tsmiConnectionString.Text = "Строка подключения к серверу...";
            this.tsmiConnectionString.Click += new System.EventHandler(this.tsmiConnectionString_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmiSaveToFile
            // 
            this.tsmiSaveToFile.Enabled = false;
            this.tsmiSaveToFile.Name = "tsmiSaveToFile";
            this.tsmiSaveToFile.Size = new System.Drawing.Size(257, 22);
            this.tsmiSaveToFile.Text = "Сохранить данные в файл";
            this.tsmiSaveToFile.Click += new System.EventHandler(this.tsmiSaveToFile_Click);
            // 
            // tsmiLoadFromFile
            // 
            this.tsmiLoadFromFile.Enabled = false;
            this.tsmiLoadFromFile.Name = "tsmiLoadFromFile";
            this.tsmiLoadFromFile.Size = new System.Drawing.Size(257, 22);
            this.tsmiLoadFromFile.Text = "Загрузить данные из файла";
            this.tsmiLoadFromFile.Click += new System.EventHandler(this.tsmiLoadFromFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatusLabel
            // 
            this.tsslStatusLabel.Name = "tsslStatusLabel";
            this.tsslStatusLabel.Size = new System.Drawing.Size(45, 17);
            this.tsslStatusLabel.Text = "Готово";
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 24);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(933, 473);
            this.panelView.TabIndex = 2;
            // 
            // заУказаннуюДатуToolStripMenuItem
            // 
            this.заУказаннуюДатуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiByDateClients});
            this.заУказаннуюДатуToolStripMenuItem.Name = "заУказаннуюДатуToolStripMenuItem";
            this.заУказаннуюДатуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.заУказаннуюДатуToolStripMenuItem.Text = "За указанную дату";
            // 
            // tsmiByDateClients
            // 
            this.tsmiByDateClients.Name = "tsmiByDateClients";
            this.tsmiByDateClients.Size = new System.Drawing.Size(197, 22);
            this.tsmiByDateClients.Text = "Список постояльцев...";
            this.tsmiByDateClients.Click += new System.EventHandler(this.tsmiByDateClients_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsmiClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiReservations;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiServices;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCategories;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmiTransfer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPayChannelsTV;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccordancePayChannels;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiCurrentClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmptyRooms;
        private System.Windows.Forms.ToolStripMenuItem tsmiBusyRooms;
        private System.Windows.Forms.ToolStripMenuItem заПоследнийМесяцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLastMonthClients;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectionString;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveToBase;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveToFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem заУказаннуюДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiByDateClients;
    }
}

