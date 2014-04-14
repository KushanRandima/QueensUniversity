using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;

namespace QueensUniversityStudentRegistration
{
    public partial class StudentDetails : Form
    {

        #region Variables
        //to manage update and insert
        public static List<Registration> NewRegistrations ;
        #endregion

        #region Form Load
        private void StudentDetails_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearFields();
        }
        public StudentDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region Btn New
        private void btnNew_Click(object sender, EventArgs e)
        {
            StudentRegistration Registration = new StudentRegistration();
            StudentRegistration.studentID = 0;
            Registration.ShowDialog();
            RefreshGrid();
            buttonSave.Focus();
        } 
        #endregion
                

        #region Refresh Grid
        private void RefreshGrid()
        {
            int iRow;
            dataGridViewStudentDetails.Rows.Clear();
            List<Registration> details;
            if (NewRegistrations != null && NewRegistrations.Count > 0)
                details = NewRegistrations;
            else
                details = Registration.SelectAll().Where(p => p.Name.Contains(textBoxStudentName.Text)).ToList();

            foreach (Registration detail in details)
            {
                dataGridViewStudentDetails.Rows.Add();
                iRow = dataGridViewStudentDetails.Rows.Count - 1;
                dataGridViewStudentDetails["StudentID", iRow].Value = detail.StudentID;
                dataGridViewStudentDetails["StudentName", iRow].Value = detail.Name;
                dataGridViewStudentDetails["DateBirth", iRow].Value = detail.DateOfBirth.Date.ToString("dd-MMM-yyyy");
                dataGridViewStudentDetails["GPA", iRow].Value = detail.GradePointAvg;
                dataGridViewStudentDetails["Active", iRow].Value = detail.Active ? "Active" : "Deactivate";
            }
        }
        #endregion       

        #region Clear Fields
        private void ClearFields()
        {
            textBoxStudentName.Clear();
        }
        #endregion

        #region Events Text Changed
        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        } 
        #endregion

        #region Btn Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (NewRegistrations != null)
                {
                    foreach (Registration Registration in NewRegistrations)
                    {
                        Registration oldRecord = Registration.Select(Registration.StudentID);
                        if (oldRecord != null)
                        {
                            Registration.Update();
                        }
                        else
                        {
                            Registration.Insert();
                        }
                    }
                    MessageBox.Show(" Records are Saved Successfully ", "Queens University Student Registration System ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewRegistrations.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                ClearFields();
                RefreshGrid();
            }
        }
        #endregion

        #region DataGrid Event
        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int sID = int.Parse(dataGridViewStudentDetails["StudentID", e.RowIndex].Value.ToString());
                if (sID > 0)
                {
                    //fills the values to controls
                    StudentRegistration Registration = new StudentRegistration();
                    StudentRegistration.studentID = sID;
                    Registration.ShowDialog();
                    RefreshGrid();
                    buttonSave.Focus();
                }
            }
        } 
        #endregion        
    }
}
