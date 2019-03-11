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
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tvRooms = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия клиента:";
            // 
            // cbClientFullName
            // 
            this.cbClientFullName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientFullName.FormattingEnabled = true;
            this.cbClientFullName.Location = new System.Drawing.Point(128, 12);
            this.cbClientFullName.Name = "cbClientFullName";
            this.cbClientFullName.Size = new System.Drawing.Size(270, 23);
            this.cbClientFullName.TabIndex = 0;
            this.cbClientFullName.SelectionChangeCommitted += new System.EventHandler(this.cbClientFullName_SelectionChangeCommitted);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(327, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(246, 331);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ввод";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Заезд:";
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(260, 70);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(141, 23);
            this.dtpArrivalDate.TabIndex = 5;
            this.dtpArrivalDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Выезд:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Location = new System.Drawing.Point(260, 99);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(141, 23);
            this.dtpDepartureDate.TabIndex = 6;
            this.dtpDepartureDate.ValueChanged += new System.EventHandler(this.dtpArrivalDate_ValueChanged);
            // 
            // clbServices
            // 
            this.clbServices.FormattingEnabled = true;
            this.clbServices.Location = new System.Drawing.Point(215, 153);
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(186, 166);
            this.clbServices.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Услуги в номере:";
            // 
            // tvRooms
            // 
            this.tvRooms.HideSelection = false;
            this.tvRooms.Location = new System.Drawing.Point(12, 70);
            this.tvRooms.Name = "tvRooms";
            this.tvRooms.Size = new System.Drawing.Size(189, 249);
            this.tvRooms.TabIndex = 13;
            this.tvRooms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRooms_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер:";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Location = new System.Drawing.Point(128, 42);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(12, 15);
            this.lbRoom.TabIndex = 14;
            this.lbRoom.Text = "-";
            // 
            // ArrivalForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 366);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.tvRooms);
            this.Controls.Add(this.clbServices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDepartureDate);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbClientFullName);
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
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView tvRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRoom;
    }
}