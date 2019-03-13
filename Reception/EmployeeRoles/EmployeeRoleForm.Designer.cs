namespace Reception
{
    partial class EmployeeRoleForm
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
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameRole = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbAllowManageEmployees = new System.Windows.Forms.CheckBox();
            this.cbAllowManageClients = new System.Windows.Forms.CheckBox();
            this.gbAllowed = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.gbAllowed.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudSalary
            // 
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Location = new System.Drawing.Point(87, 41);
            this.nudSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(92, 23);
            this.nudSalary.TabIndex = 1;
            this.nudSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSalary.ValueChanged += new System.EventHandler(this.tbNameRole_TextChanged);
            this.nudSalary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudSalary_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Оклад:";
            // 
            // tbNameRole
            // 
            this.tbNameRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameRole.Location = new System.Drawing.Point(87, 12);
            this.tbNameRole.Name = "tbNameRole";
            this.tbNameRole.Size = new System.Drawing.Size(193, 23);
            this.tbNameRole.TabIndex = 0;
            this.tbNameRole.TextChanged += new System.EventHandler(this.tbNameRole_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Должность:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(124, 155);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ввод";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbAllowManageEmployees
            // 
            this.cbAllowManageEmployees.AutoSize = true;
            this.cbAllowManageEmployees.Location = new System.Drawing.Point(11, 22);
            this.cbAllowManageEmployees.Name = "cbAllowManageEmployees";
            this.cbAllowManageEmployees.Size = new System.Drawing.Size(249, 19);
            this.cbAllowManageEmployees.TabIndex = 0;
            this.cbAllowManageEmployees.Text = "Может настраивать список сотрудников";
            this.cbAllowManageEmployees.UseVisualStyleBackColor = true;
            this.cbAllowManageEmployees.CheckedChanged += new System.EventHandler(this.tbNameRole_TextChanged);
            // 
            // cbAllowManageClients
            // 
            this.cbAllowManageClients.AutoSize = true;
            this.cbAllowManageClients.Location = new System.Drawing.Point(11, 47);
            this.cbAllowManageClients.Name = "cbAllowManageClients";
            this.cbAllowManageClients.Size = new System.Drawing.Size(230, 19);
            this.cbAllowManageClients.TabIndex = 1;
            this.cbAllowManageClients.Text = "Может настраивать список клиентов";
            this.cbAllowManageClients.UseVisualStyleBackColor = true;
            this.cbAllowManageClients.CheckedChanged += new System.EventHandler(this.tbNameRole_TextChanged);
            // 
            // gbAllowed
            // 
            this.gbAllowed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAllowed.Controls.Add(this.cbAllowManageEmployees);
            this.gbAllowed.Controls.Add(this.cbAllowManageClients);
            this.gbAllowed.Location = new System.Drawing.Point(12, 70);
            this.gbAllowed.Name = "gbAllowed";
            this.gbAllowed.Size = new System.Drawing.Size(268, 74);
            this.gbAllowed.TabIndex = 2;
            this.gbAllowed.TabStop = false;
            this.gbAllowed.Text = "Права доступа:";
            // 
            // EmployeeRoleForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(292, 190);
            this.Controls.Add(this.gbAllowed);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeRoleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Должности сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.gbAllowed.ResumeLayout(false);
            this.gbAllowed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbAllowManageEmployees;
        private System.Windows.Forms.CheckBox cbAllowManageClients;
        private System.Windows.Forms.GroupBox gbAllowed;
    }
}