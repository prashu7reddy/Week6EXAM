
namespace Week6EXAM
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmployeeId = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.BtnAddNew = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BoxGroup = new System.Windows.Forms.GroupBox();
            this.RadPayRoll = new System.Windows.Forms.RadioButton();
            this.RadConsultant = new System.Windows.Forms.RadioButton();
            this.LblMessage = new System.Windows.Forms.Label();
            this.BoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // TxtEmployeeId
            // 
            this.TxtEmployeeId.Location = new System.Drawing.Point(252, 114);
            this.TxtEmployeeId.Name = "TxtEmployeeId";
            this.TxtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeId.TabIndex = 3;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(252, 175);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeName.TabIndex = 4;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(252, 231);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 20);
            this.TxtSalary.TabIndex = 5;
            // 
            // BtnAddNew
            // 
            this.BtnAddNew.Location = new System.Drawing.Point(168, 285);
            this.BtnAddNew.Name = "BtnAddNew";
            this.BtnAddNew.Size = new System.Drawing.Size(75, 23);
            this.BtnAddNew.TabIndex = 6;
            this.BtnAddNew.Text = "Add New";
            this.BtnAddNew.UseVisualStyleBackColor = true;
            this.BtnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(287, 285);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BoxGroup
            // 
            this.BoxGroup.Controls.Add(this.RadConsultant);
            this.BoxGroup.Controls.Add(this.RadPayRoll);
            this.BoxGroup.Location = new System.Drawing.Point(491, 121);
            this.BoxGroup.Name = "BoxGroup";
            this.BoxGroup.Size = new System.Drawing.Size(240, 157);
            this.BoxGroup.TabIndex = 8;
            this.BoxGroup.TabStop = false;
            this.BoxGroup.Text = "EmployeeType";
            // 
            // RadPayRoll
            // 
            this.RadPayRoll.AutoSize = true;
            this.RadPayRoll.Location = new System.Drawing.Point(63, 53);
            this.RadPayRoll.Name = "RadPayRoll";
            this.RadPayRoll.Size = new System.Drawing.Size(61, 17);
            this.RadPayRoll.TabIndex = 9;
            this.RadPayRoll.TabStop = true;
            this.RadPayRoll.Text = "PayRoll";
            this.RadPayRoll.UseVisualStyleBackColor = true;
            this.RadPayRoll.CheckedChanged += new System.EventHandler(this.RadPayRoll_CheckedChanged);
            // 
            // RadConsultant
            // 
            this.RadConsultant.AutoSize = true;
            this.RadConsultant.Location = new System.Drawing.Point(63, 95);
            this.RadConsultant.Name = "RadConsultant";
            this.RadConsultant.Size = new System.Drawing.Size(75, 17);
            this.RadConsultant.TabIndex = 10;
            this.RadConsultant.TabStop = true;
            this.RadConsultant.Text = "Consultant";
            this.RadConsultant.UseVisualStyleBackColor = true;
            this.RadConsultant.CheckedChanged += new System.EventHandler(this.RadConsultant_CheckedChanged);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(554, 318);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 13);
            this.LblMessage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.BoxGroup);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnAddNew);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtEmployeeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BoxGroup.ResumeLayout(false);
            this.BoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmployeeId;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Button BtnAddNew;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox BoxGroup;
        private System.Windows.Forms.RadioButton RadConsultant;
        private System.Windows.Forms.RadioButton RadPayRoll;
        private System.Windows.Forms.Label LblMessage;
    }
}

