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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFName.Text + " " + txtLName.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtLName.Text = "";
            txtFName.Text = "";
            txtFName.Focus();
            txtFName.BackColor = Color.Bisque;
            btnShow.Text = "Thanks";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            Label lblMessage = new Label();

            lblMessage.Text = "yes";
            lblMessage.Location = new Point(25, 106);
            // Set the AutoSize property of the Label control
            lblMessage.AutoSize = true;

            // Set the font of the content present in the Label Control
            lblMessage.Font = new Font("Calibri", 18);

            // Set the foreground color of the Label control
            lblMessage.ForeColor = Color.Green;

            this.Controls.Add(lblMessage);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close this window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)

                this.Close();

        }
    }
}
