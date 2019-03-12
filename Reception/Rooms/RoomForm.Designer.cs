namespace Reception
{
    partial class RoomForm
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFoor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumberSeat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPriceDay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = " Категория:";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(135, 41);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(180, 23);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectionChangeCommitted += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Этаж:";
            // 
            // nudFoor
            // 
            this.nudFoor.Location = new System.Drawing.Point(135, 99);
            this.nudFoor.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudFoor.Name = "nudFoor";
            this.nudFoor.Size = new System.Drawing.Size(54, 23);
            this.nudFoor.TabIndex = 3;
            this.nudFoor.ValueChanged += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Количество гостей:";
            // 
            // cbNumberSeat
            // 
            this.cbNumberSeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNumberSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumberSeat.FormattingEnabled = true;
            this.cbNumberSeat.Location = new System.Drawing.Point(135, 70);
            this.cbNumberSeat.Name = "cbNumberSeat";
            this.cbNumberSeat.Size = new System.Drawing.Size(180, 23);
            this.cbNumberSeat.TabIndex = 2;
            this.cbNumberSeat.SelectionChangeCommitted += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Стоимость за сутки:";
            // 
            // nudPriceDay
            // 
            this.nudPriceDay.DecimalPlaces = 2;
            this.nudPriceDay.Location = new System.Drawing.Point(135, 128);
            this.nudPriceDay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPriceDay.Name = "nudPriceDay";
            this.nudPriceDay.Size = new System.Drawing.Size(92, 23);
            this.nudPriceDay.TabIndex = 4;
            this.nudPriceDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPriceDay.ValueChanged += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            this.nudPriceDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudPriceDay_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "руб.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Услуги в номере:";
            // 
            // clbServices
            // 
            this.clbServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbServices.FormattingEnabled = true;
            this.clbServices.Location = new System.Drawing.Point(13, 180);
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(300, 148);
            this.clbServices.TabIndex = 5;
            this.clbServices.Click += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            this.clbServices.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(156, 364);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ввод";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(237, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер комнаты:";
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(135, 12);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(54, 23);
            this.tbRoomNumber.TabIndex = 0;
            this.tbRoomNumber.TextChanged += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Стоимость за сутки с услугами:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(199, 338);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(12, 15);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "-";
            // 
            // RoomForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(325, 399);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.clbServices);
            this.Controls.Add(this.nudPriceDay);
            this.Controls.Add(this.nudFoor);
            this.Controls.Add(this.cbNumberSeat);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка свойств номера";
            ((System.ComponentModel.ISupportInitialize)(this.nudFoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNumberSeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPriceDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotal;
    }
}