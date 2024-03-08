using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Mekele
{
    public partial class PatientRegistration_File : Form
    {
        public static string richBox, pat, fullname, kebele, age, phone_No, sex, diseaase;

        private void PatientRegistration_File_Load(object sender, EventArgs e)
        {
            cboDisease.Items.Add("HIV/AIDS");
            cboDisease.Items.Add("Bilharzia");
            cboDisease.Items.Add("Cholera");
        }
        public PatientRegistration_File()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fullname = txtFname.Text + " " + txtLname.Text;
            kebele = txtKebele.Text;
            age = txtAge.Text;
            phone_No = txtPhoneNo.Text;
            sex = "male";
            if (radMale.Checked)
                sex = "male";
            else sex = "female";
            diseaase = cboDisease.SelectedItem.ToString();
            PatientManagement patMag = new PatientManagement();// pat, fullname, keb, ag, phone, sex, diseaase);
            patMag.Register_To_File(fullname);
            MessageBox.Show("written to the file secccussfully");
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            richBoxDisplay.Text = File.ReadAllText(PatientManagement.file_name);// PatientManagement.getAll();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            radFemale.Checked = false;
            radMale.Checked = false;
            txtAge.Clear();
            txtFname.Clear();
            txtKebele.Clear();
            txtLname.Clear();
            txtPhoneNo.Clear();
            richBoxDisplay.Clear();
        }
    }
}
