using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Mekele
{
    public partial class Case_Convertor : Form
    {
        public Case_Convertor()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Convert_case();
        }

        private void Case_Convertor_Load(object sender, EventArgs e)
        {
            rdoLower.Enabled = false;
            rdoUpper.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            rdoLower.Enabled = true;
            rdoUpper.Enabled = true;
        }

        private void rdoUpper_CheckedChanged(object sender, EventArgs e)
        {
            //Convert_case();
            lblResult.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtString.Text.ToUpper());
        }

        private void Convert_case()
        {
            //string text_string = txtString.Text;
            if (rdoUpper.Checked)
                lblResult.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtString.Text.ToUpper());
            else
                lblResult.Text = txtString.Text.ToLower();
        }

        private void rdoLower_CheckedChanged(object sender, EventArgs e)
        {
            //Convert_case();
        }
    }
}
