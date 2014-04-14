using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueensUniversityStudentRegistration
{
    public partial class Main : Form
    {
        #region Form Load
        public Main()
        {
            InitializeComponent();
        }   
        #endregion     

        #region Menu Items 
        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails frmStudentDetails = new StudentDetails();
            frmStudentDetails.MdiParent = this;
            frmStudentDetails.Show();
        }        

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to leave the System?", "Exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        #endregion
    }
}
