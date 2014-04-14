namespace QueensUniversityStudentRegistration
{
    partial class StudentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetails));
            this.dataGridViewStudentDetails = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlGreen = new System.Windows.Forms.Panel();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelInfor = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentDetails)).BeginInit();
            this.PnlGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentDetails
            // 
            this.dataGridViewStudentDetails.AllowUserToAddRows = false;
            this.dataGridViewStudentDetails.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewStudentDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudentDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.GPA,
            this.DateBirth,
            this.Active});
            this.dataGridViewStudentDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewStudentDetails.Location = new System.Drawing.Point(10, 104);
            this.dataGridViewStudentDetails.MultiSelect = false;
            this.dataGridViewStudentDetails.Name = "dataGridViewStudentDetails";
            this.dataGridViewStudentDetails.RowHeadersVisible = false;
            this.dataGridViewStudentDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentDetails.Size = new System.Drawing.Size(762, 433);
            this.dataGridViewStudentDetails.TabIndex = 12;
            this.dataGridViewStudentDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellDoubleClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 90;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 370;
            // 
            // GPA
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.GPA.DefaultCellStyle = dataGridViewCellStyle2;
            this.GPA.HeaderText = "Grade Point Avg";
            this.GPA.Name = "GPA";
            this.GPA.Width = 150;
            // 
            // DateBirth
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateBirth.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateBirth.HeaderText = "Date Of Birth";
            this.DateBirth.Name = "DateBirth";
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            // 
            // PnlGreen
            // 
            this.PnlGreen.BackColor = System.Drawing.Color.Black;
            this.PnlGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGreen.Controls.Add(this.pictureBoxStudent);
            this.PnlGreen.Controls.Add(this.textBoxStudentName);
            this.PnlGreen.Controls.Add(this.labelInfor);
            this.PnlGreen.Controls.Add(this.labelStudentName);
            this.PnlGreen.Controls.Add(this.buttonSave);
            this.PnlGreen.Controls.Add(this.buttonNew);
            this.PnlGreen.Location = new System.Drawing.Point(10, 10);
            this.PnlGreen.Name = "PnlGreen";
            this.PnlGreen.Size = new System.Drawing.Size(762, 88);
            this.PnlGreen.TabIndex = 13;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.Location = new System.Drawing.Point(203, 44);
            this.textBoxStudentName.Multiline = true;
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(363, 32);
            this.textBoxStudentName.TabIndex = 23;
            this.textBoxStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // labelInfor
            // 
            this.labelInfor.AutoSize = true;
            this.labelInfor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfor.ForeColor = System.Drawing.Color.White;
            this.labelInfor.Location = new System.Drawing.Point(203, 23);
            this.labelInfor.Name = "labelInfor";
            this.labelInfor.Size = new System.Drawing.Size(279, 17);
            this.labelInfor.TabIndex = 25;
            this.labelInfor.Text = "Please Type the Student Name for Searching . . . ";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.ForeColor = System.Drawing.Color.White;
            this.labelStudentName.Location = new System.Drawing.Point(104, 52);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(91, 17);
            this.labelStudentName.TabIndex = 25;
            this.labelStudentName.Text = "Student Name";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::University_System.Properties.Resources.Student;
            this.pictureBoxStudent.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(95, 88);
            this.pictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudent.TabIndex = 26;
            this.pictureBoxStudent.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::University_System.Properties.Resources.Save;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(667, 18);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 58);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "  Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Image = global::University_System.Properties.Resources.Add;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew.Location = new System.Drawing.Point(577, 18);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(84, 58);
            this.buttonNew.TabIndex = 8;
            this.buttonNew.Text = "  Add New";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 545);
            this.Controls.Add(this.PnlGreen);
            this.Controls.Add(this.dataGridViewStudentDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentDetails)).EndInit();
            this.PnlGreen.ResumeLayout(false);
            this.PnlGreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentDetails;
        private System.Windows.Forms.Panel PnlGreen;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Label labelInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}