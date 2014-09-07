using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {

        bool dep = true;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Moves the current funds to their highest value
        /// </summary>
        private void Exchange(bool deposit)
        {
            if (deposit == true)
            {
                if (nudCurCP.Value >= 10)
                {
                    while (nudCurCP.Value >= 10)
                    {
                        nudCurSP.Value += 1;
                        nudCurCP.Value -= 10;
                    }
                }
                if (nudCurSP.Value >= 5)
                {
                    while (nudCurSP.Value >= 5)
                    {
                        nudCurEP.Value += 1;
                        nudCurSP.Value -= 5;
                    }
                }
                if (nudCurEP.Value >= 2)
                {
                    while (nudCurEP.Value >= 2)
                    {
                        nudCurGP.Value += 1;
                        nudCurEP.Value -= 2;
                    }
                }
                if (nudCurGP.Value >= 10)
                {
                    while (nudCurGP.Value >= 10)
                    {
                        nudCurPP.Value += 1;
                        nudCurGP.Value -= 10;
                    }
                }
            }
            else
            { 
                if (nudCurCP.Value >= 10)
                {
                    while (nudCurCP.Value >= 10)
                    {
                        nudCurSP.Value += 1;
                        nudCurCP.Value -= 10;
                    }
                }
                if (nudCurSP.Value >= 5)
                {
                    while (nudCurSP.Value >= 5)
                    {
                        nudCurEP.Value += 1;
                        nudCurSP.Value -= 5;
                    }
                }
                if (nudCurEP.Value >= 2)
                {
                    while (nudCurEP.Value >= 2)
                    {
                        nudCurGP.Value += 1;
                        nudCurEP.Value -= 2;
                    }
                }
                if (nudCurGP.Value >= 10)
                {
                    while (nudCurGP.Value >= 10)
                    {
                        nudCurPP.Value += 1;
                        nudCurGP.Value -= 10;
                    }
                }
            }
        }

        /// <summary>
        /// Withdraw funds from your account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            dep = false;
            int currentFunds = (int)nudCurCP.Value * 1 + (int)nudCurSP.Value * 10
                                 + (int)nudCurEP.Value * 50 + (int)nudCurGP.Value * 100
                                 + (int)nudCurPP.Value * 1000;

            int withdrawingFunds = ((int)nudWithCP.Value * 1 + (int)nudWithSP.Value * 10 + (int)nudWithEP.Value * 50
                            + (int)nudWithGP.Value * 100 + (int)nudWithPP.Value * 1000);

            if( currentFunds < withdrawingFunds)

            {
                textBoxError.Text = "Not Enough Funds";
            }
            else
            {
                int tempCP = currentFunds;

                tempCP -= withdrawingFunds;

                nudCurSP.Value = 0;
                nudCurEP.Value = 0;
                nudCurGP.Value = 0;
                nudCurPP.Value = 0;

                nudCurCP.Value = tempCP;
                Exchange(dep);
            }
        }

        /// <summary>
        /// Deposit funds into your account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            dep = true;
            nudCurCP.Value += nudDepCP.Value;
            nudCurSP.Value += nudDepSP.Value;
            nudCurEP.Value += nudDepEP.Value;
            nudCurGP.Value += nudDepGP.Value;
            nudCurPP.Value += nudDepPP.Value;

            Exchange(dep);
        }

        /// <summary>
        /// Clears all the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            dep = true;

            nudCurCP.Value = 0;
            nudCurSP.Value = 0;
            nudCurEP.Value = 0;
            nudCurGP.Value = 0;
            nudCurPP.Value = 0;

            nudDepCP.Value = 0;
            nudDepSP.Value = 0;
            nudDepEP.Value = 0;
            nudDepGP.Value = 0;
            nudDepPP.Value = 0;

            nudWithCP.Value = 0;
            nudWithSP.Value = 0;
            nudWithEP.Value = 0;
            nudWithGP.Value = 0;
            nudWithPP.Value = 0;

            textBoxError.Text = "";
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonExchange_Click(object sender, EventArgs e)
        {
            dep = true;
            Exchange(dep);
        }


    }
}
