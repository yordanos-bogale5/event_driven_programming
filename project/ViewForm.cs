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
    public partial class frmViewForm : Form
    {
        public frmViewForm()
        {
            InitializeComponent();
        }
        public void SetValues(string fName, string lName, string email, string title,
            string hobbies, string gender, string address)
        {
            lblFName.Text = fName;
            lblLName.Text = lName;
            lblEmail.Text = email;
            lblHobbies.Text = hobbies;
            lblTitle.Text = title;
            lblGender.Text = gender;
            lblAddress.Text = address;
        }
    }
}
