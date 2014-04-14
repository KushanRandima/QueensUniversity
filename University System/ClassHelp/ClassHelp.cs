using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Text.RegularExpressions;



namespace QueensUniversityStudentRegistration
{
    class ClassHelp
    {     

        #region Allow Decimal With Length
        public static void AllowDecimalWithLength(Control control, KeyPressEventArgs e, int noOfIntegers, int noOfPrecisions)
        {
            string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

            if ((47 < e.KeyChar && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar.ToString() == decimalSeparator)
            {
                if (e.KeyChar.ToString() == decimalSeparator && control.Text != "")
                {
                    if (control.Text.Contains(decimalSeparator))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        CheckLenthForDecimal(control, e, noOfIntegers, noOfPrecisions);        
                    }
                }
                else
                {
                    CheckLenthForDecimal(control, e, noOfIntegers, noOfPrecisions);
                }
            }
            else
            {
                e.Handled = true;
            }

        }
        #endregion

        #region Check Length for Decimal
        private static void CheckLenthForDecimal(Control control, KeyPressEventArgs e, int noOfIntegers, int noOfPrecisions)
        {
            int cursorPosistion = ((TextBox)control).SelectionStart;
            string decimalSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

            if (e.KeyChar.ToString() == decimalSeparator || e.KeyChar == 8 || ((TextBox)control).SelectionLength > 0)
            {
                e.Handled = false;
            }
            else
            {
                if (control.Text.Contains(decimalSeparator))
                {
                    if (cursorPosistion > control.Text.IndexOf(decimalSeparator))
                    {
                        if (control.Text.Substring(control.Text.IndexOf(decimalSeparator) + 1).Length > (noOfPrecisions - 1))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                    else
                    {
                        if (control.Text.Substring(0, (control.Text.IndexOf(decimalSeparator) + 1)).Length > noOfIntegers)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                }
                else
                {
                    if (control.Text.Length > (noOfIntegers - 1))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
        }
        #endregion
    }
}
