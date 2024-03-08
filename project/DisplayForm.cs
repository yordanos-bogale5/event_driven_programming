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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
            rdoMale.Checked = true;
            cboTitle.Items.Add("Mr");
            cboTitle.Items.Add("Mss");
            cboTitle.Items.Add("Dr");
            cboTitle.Items.Add("Prof");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstCustomer.Items.Add(txtFirstName.Text);
            lstCustomer.Items.Add(txtLastName.Text);
            lstCustomer.Items.Add(txtEmail.Text);
            lstCustomer.Items.Add(cboTitle.Text);

            string Gender = "", Hobby = "";
            if (rdoMale.Checked == true)
            {
                lstCustomer.Items.Add(rdoMale.Text);
                Gender = "Male";
            }
            else if (rdoFemale.Checked == true)
            {
                lstCustomer.Items.Add(rdoFemale.Text);
                Gender = "Female";
            }

            if (chkReading.Checked)
            {
                lstCustomer.Items.Add(chkReading.Text);
                Hobby = "Reading";
            }
            if (chkPlaying.Checked)
            {
                lstCustomer.Items.Add(chkPlaying.Text);
                Hobby = "Playing";
            }
            //if (chkPlaying.Checked && chkReading.Checked)
            lstCustomer.Items.Add(txtAddress.Text);
            lstCustomer.Items.Add("________________");

            try
            {
                Validation objVal = new Validation();
                objVal.CheckCustomerName(txtFirstName.Text, txtLastName.Text);

                //Additionally send info to other form
                frmViewForm view = new frmViewForm();
                view.SetValues(txtFirstName.Text, txtLastName.Text, txtEmail.Text, cboTitle.Text, Hobby, Gender, txtAddress.Text);
                view.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            //opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            this.openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                                            "All files (*.*)|*.*";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                txtBrowse.Text = opnfd.FileName;
            }

            MemoryStream mmst = new MemoryStream();
            pictureBox1.Image.Save(mmst, pictureBox1.Image.RawFormat);
        }
    }
}
