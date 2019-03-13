namespace Reception
{
    partial class TransferForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFeedAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReservation = new System.Windows.Forms.ComboBox();
            this.dtpFeedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFeedTime = new System.Windows.Forms.DateTimePicker();
            this.nudNumberSeat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Бронирование:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(362, 162);
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
            this.btnOk.Location = new System.Drawing.Point(281, 162);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ввод";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Адрес подачи:";
            // 
            // tbFeedAddress
            // 
            this.tbFeedAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFeedAddress.Location = new System.Drawing.Point(122, 41);
            this.tbFeedAddress.Multiline = true;
            this.tbFeedAddress.Name = "tbFeedAddress";
            this.tbFeedAddress.Size = new System.Drawing.Size(315, 64);
            this.tbFeedAddress.TabIndex = 1;
            this.tbFeedAddress.TextChanged += new System.EventHandler(this.tbFeedAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Дата подачи:";
            // 
            // cbReservation
            // 
            this.cbReservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReservation.FormattingEnabled = true;
            this.cbReservation.Location = new System.Drawing.Point(122, 12);
            this.cbReservation.Name = "cbReservation";
            this.cbReservation.Size = new System.Drawing.Size(315, 23);
            this.cbReservation.TabIndex = 0;
            this.cbReservation.SelectionChangeCommitted += new System.EventHandler(this.tbFeedAddress_TextChanged);
            // 
            // dtpFeedDate
            // 
            this.dtpFeedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFeedDate.Location = new System.Drawing.Point(122, 111);
            this.dtpFeedDate.Name = "dtpFeedDate";
            this.dtpFeedDate.Size = new System.Drawing.Size(142, 23);
            this.dtpFeedDate.TabIndex = 2;
            this.dtpFeedDate.ValueChanged += new System.EventHandler(this.tbFeedAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Время подачи:";
            // 
            // dtpFeedTime
            // 
            this.dtpFeedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpFeedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFeedTime.Location = new System.Drawing.Point(364, 111);
            this.dtpFeedTime.Name = "dtpFeedTime";
            this.dtpFeedTime.ShowUpDown = true;
            this.dtpFeedTime.Size = new System.Drawing.Size(72, 23);
            this.dtpFeedTime.TabIndex = 3;
            this.dtpFeedTime.ValueChanged += new System.EventHandler(this.tbFeedAddress_TextChanged);
            // 
            // nudNumberSeat
            // 
            this.nudNumberSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudNumberSeat.Location = new System.Drawing.Point(122, 140);
            this.nudNumberSeat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberSeat.Name = "nudNumberSeat";
            this.nudNumberSeat.Size = new System.Drawing.Size(54, 23);
            this.nudNumberSeat.TabIndex = 4;
            this.nudNumberSeat.ValueChanged += new System.EventHandler(this.tbFeedAddress_TextChanged);
            this.nudNumberSeat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumberSeat_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Количество мест:";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 197);
            this.Controls.Add(this.nudNumberSeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFeedTime);
            this.Controls.Add(this.dtpFeedDate);
            this.Controls.Add(this.cbReservation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFeedAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заявка на подачу транспорта";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFeedAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbReservation;
        private System.Windows.Forms.DateTimePicker dtpFeedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFeedTime;
        private System.Windows.Forms.NumericUpDown nudNumberSeat;
        private System.Windows.Forms.Label label4;
    }
}