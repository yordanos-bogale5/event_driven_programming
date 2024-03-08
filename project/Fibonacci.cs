using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Mekele
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void txtFibNo_TextChanged(object sender, EventArgs e)
        {
            int firstNumber = 0, secondNumber = 1, result = 0, Number;
            lstView.Items.Clear();
            lstView.BackColor = Color.Yellow;
            lstView.ForeColor = Color.Red;
            lstView.Font = new Font("Broadway", 14);

            Regex r = new Regex("^[a-zA-Z]*$");

            if (txtFibNo.Text != "")
            {
                if (!r.IsMatch(txtFibNo.Text))
                {
                    try
                    {
                        Number = int.Parse(txtFibNo.Text);
                        lstView.Items.Add(firstNumber);
                        lstView.Items.Add(secondNumber);
                        for (int i = 2; i < Number; i++)
                        {
                            result = firstNumber + secondNumber;
                            lstView.Items.Add(result);

                            firstNumber = secondNumber;
                            secondNumber = result;
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("You are required to enter alphabet only!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
