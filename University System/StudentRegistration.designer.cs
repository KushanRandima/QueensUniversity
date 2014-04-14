namespace QueensUniversityStudentRegistration
{
    partial class StudentRegistration
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
            this.PnlGreen = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labeGPA = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.PnlGreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGreen
            // 
            this.PnlGreen.BackColor = System.Drawing.Color.Black;
            this.PnlGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGreen.Controls.Add(this.buttonOK);
            this.PnlGreen.Controls.Add(this.buttonCancel);
            this.PnlGreen.Controls.Add(this.checkBoxActive);
            this.PnlGreen.Controls.Add(this.textBoxGPA);
            this.PnlGreen.Controls.Add(this.buttonAddNew);
            this.PnlGreen.Controls.Add(this.labeGPA);
            this.PnlGreen.Controls.Add(this.labelStudentName);
            this.PnlGreen.Controls.Add(this.labelDateOfBirth);
            this.PnlGreen.Controls.Add(this.textBoxStudentName);
            this.PnlGreen.Controls.Add(this.dateTimePickerDateOfBirth);
            this.PnlGreen.Controls.Add(this.labelStudentID);
            this.PnlGreen.Controls.Add(this.textBoxStudentID);
            this.PnlGreen.Location = new System.Drawing.Point(10, 10);
            this.PnlGreen.Name = "PnlGreen";
            this.PnlGreen.Size = new System.Drawing.Size(376, 225);
            this.PnlGreen.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(131, 180);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(114, 31);
            this.buttonOK.TabIndex = 473;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(251, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 31);
            this.buttonCancel.TabIndex = 472;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.ForeColor = System.Drawing.Color.White;
            this.checkBoxActive.Location = new System.Drawing.Point(262, 44);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxActive.Size = new System.Drawing.Size(57, 18);
            this.checkBoxActive.TabIndex = 471;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGPA.Location = new System.Drawing.Point(101, 100);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(108, 22);
            this.textBoxGPA.TabIndex = 27;
            this.textBoxGPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGPA_KeyPress);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddNew.Location = new System.Drawing.Point(11, 180);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(114, 31);
            this.buttonAddNew.TabIndex = 8;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // labeGPA
            // 
            this.labeGPA.AutoSize = true;
            this.labeGPA.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeGPA.ForeColor = System.Drawing.Color.White;
            this.labeGPA.Location = new System.Drawing.Point(8, 104);
            this.labeGPA.Name = "labeGPA";
            this.labeGPA.Size = new System.Drawing.Size(87, 14);
            this.labeGPA.TabIndex = 26;
            this.labeGPA.Text = "Grade Point Avg";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.ForeColor = System.Drawing.Color.White;
            this.labelStudentName.Location = new System.Drawing.Point(8, 76);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(78, 14);
            this.labelStudentName.TabIndex = 25;
            this.labelStudentName.Text = "Student Name";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.labelDateOfBirth.Location = new System.Drawing.Point(8, 132);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(79, 14);
            this.labelDateOfBirth.TabIndex = 24;
            this.labelDateOfBirth.Text = "Date Of Birth  ";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.Location = new System.Drawing.Point(101, 72);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(264, 22);
            this.textBoxStudentName.TabIndex = 23;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(101, 128);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(108, 22);
            this.dateTimePickerDateOfBirth.TabIndex = 5;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.ForeColor = System.Drawing.Color.White;
            this.labelStudentID.Location = new System.Drawing.Point(8, 48);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(59, 14);
            this.labelStudentID.TabIndex = 21;
            this.labelStudentID.Text = "Student ID";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(101, 44);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.ReadOnly = true;
            this.textBoxStudentID.Size = new System.Drawing.Size(126, 22);
            this.textBoxStudentID.TabIndex = 22;
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 246);
            this.Controls.Add(this.PnlGreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "StudentRegistration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.PnlGreen.ResumeLayout(false);
            this.PnlGreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGreen;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.Label labeGPA;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}