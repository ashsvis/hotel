namespace Reception
{
    partial class ArrivalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbClientFullName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tvRooms = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbServices = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPriceDay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbArrivalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbEmployeeFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия клиента:";
            // 
            // cbClientFullName
            // 
            this.cbClientFullName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbClientFullName.FormattingEnabled = true;
            this.cbClientFullName.Location = new System.Drawing.Point(128, 12);
            this.cbClientFullName.Name = "cbClientFullName";
            this.cbClientFullName.Size = new System.Drawing.Size(274, 23);
            this.cbClientFullName.TabIndex = 0;
            this.cbClientFullName.SelectionChangeCommitted += new System.EventHandler(this.cbClientFullName_SelectionChangeCommitted);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(246, 375);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ввод";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(214, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Заезд:";
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpArrivalDate.Location = new System.Drawing.Point(260, 70);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(141, 23);
            this.dtpArrivalDate.TabIndex = 2;
            this.dtpArrivalDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(211, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Выезд:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDepartureDate.Location = new System.Drawing.Point(260, 99);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(141, 23);
            this.dtpDepartureDate.TabIndex = 3;
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(214, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Услуги в номере:";
            // 
            // tvRooms
            // 
            this.tvRooms.HideSelection = false;
            this.tvRooms.Location = new System.Drawing.Point(12, 87);
            this.tvRooms.Name = "tvRooms";
            this.tvRooms.Size = new System.Drawing.Size(189, 232);
            this.tvRooms.TabIndex = 1;
            this.tvRooms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRooms_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер:";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoom.Location = new System.Drawing.Point(128, 42);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(12, 15);
            this.lbRoom.TabIndex = 14;
            this.lbRoom.Text = "-";
            // 
            // lbServices
            // 
            this.lbServices.FormattingEnabled = true;
            this.lbServices.ItemHeight = 15;
            this.lbServices.Location = new System.Drawing.Point(214, 180);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(184, 139);
            this.lbServices.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выбор номера:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(214, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цена за сутки:";
            // 
            // lbPriceDay
            // 
            this.lbPriceDay.AutoSize = true;
            this.lbPriceDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPriceDay.Location = new System.Drawing.Point(304, 137);
            this.lbPriceDay.Name = "lbPriceDay";
            this.lbPriceDay.Size = new System.Drawing.Size(12, 15);
            this.lbPriceDay.TabIndex = 11;
            this.lbPriceDay.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(215, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Всего стоимость:";
            // 
            // lbArrivalPrice
            // 
            this.lbArrivalPrice.AutoSize = true;
            this.lbArrivalPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbArrivalPrice.Location = new System.Drawing.Point(323, 324);
            this.lbArrivalPrice.Name = "lbArrivalPrice";
            this.lbArrivalPrice.Size = new System.Drawing.Size(12, 15);
            this.lbArrivalPrice.TabIndex = 11;
            this.lbArrivalPrice.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Зарегистрировал:";
            // 
            // lbEmployeeFullName
            // 
            this.lbEmployeeFullName.AutoSize = true;
            this.lbEmployeeFullName.Location = new System.Drawing.Point(126, 343);
            this.lbEmployeeFullName.Name = "lbEmployeeFullName";
            this.lbEmployeeFullName.Size = new System.Drawing.Size(12, 15);
            this.lbEmployeeFullName.TabIndex = 16;
            this.lbEmployeeFullName.Text = "-";
            // 
            // ArrivalForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 410);
            this.Controls.Add(this.lbEmployeeFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbServices);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.tvRooms);
            this.Controls.Add(this.lbArrivalPrice);
            this.Controls.Add(this.lbPriceDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbClientFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArrivalForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заселение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClientFullName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView tvRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.ListBox lbServices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPriceDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbArrivalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbEmployeeFullName;
    }
}