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
    public partial class FileHadle : Form
    {
        string pathName;
        public FileHadle()
        {
            InitializeComponent();
            pathName = txtString.Text + ".txt";
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //if (File.Exists(txtBrowsefile.Text))
            //    richtxtDisplay.Text = File.ReadAllText(txtBrowsefile.Text);

            ////using StringReader - to traverse via line of the file content

            //string fileContents = File.ReadAllText(txtBrowsefile.Text);

            //using (StringReader reader = new StringReader(fileContents))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        richtxtDisplay.AppendText(line + "\n");
            //    }
            //}

            //read the last line of the file

            string line, lastLine ="";
            //lastLine = File.ReadAllLines(txtBrowsefile.Text).Last();
            //richtxtDisplay.Text = lastLine;//ORRRRRRR
            using (StreamReader reader = new StreamReader(txtBrowsefile.Text))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    lastLine = line;
                }
            }
            //Use Delimiter character to find a particular character/number
            char delimiter = '.';
            string[] parts = lastLine.Split(delimiter);
            string first_Part = parts[0];
            int next_Num = int.Parse(first_Part) + 1;
            MessageBox.Show("The next number is " + next_Num);
            
            ////using FileStream class
            //using (FileStream fileStream = File.OpenRead(txtBrowsefile.Text))
            //using (StreamReader reader = new StreamReader(fileStream))
            //{
            //    string line;
            //    // Read each line and process it
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        // Do something with the line, e.g., print to console
            //        richtxtDisplay.AppendText(line + "\n");
            //    }
            //}

            ////using StreamReader class
            //try
            //{
            //    // Create a StreamReader object to read the file
            //    using (StreamReader reader = new StreamReader(txtBrowsefile.Text))
            //    {
            //        if (File.Exists(txtBrowsefile.Text))
            //        {
            //            // Read the entire file into a string
            //            string fileContents = reader.ReadToEnd();
            //            // Print the file contents to the text area
            //            richtxtDisplay.Text = fileContents;
            //        }
            //    }
            //}
            //catch (FileNotFoundException ex)
            //{
            //    MessageBox.Show("File not found: " + ex.Message);
            //}
            //catch (IOException ex)
            //{
            //    MessageBox.Show("Error reading file: " + ex.Message);
            //}
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            string path = txtBrowsefile.Text;
            if (File.Exists(txtBrowsefile.Text))
            {
                string name = Path.GetFileName(txtBrowsefile.Text);
                File.AppendAllText(txtBrowsefile.Text, txtString.Text);
                string con = File.ReadAllText(path);
                richtxtDisplay.Text = con;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(txtBrowsefile.Text, txtString.Text);
            richtxtDisplay.Text = File.ReadAllText(txtBrowsefile.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            try
            {
                if (opnfd.ShowDialog() == DialogResult.OK)
                {
                    txtBrowsefile.Text = opnfd.FileName;
                    string name = Path.GetFileName(txtBrowsefile.Text);
                    string name3 = Path.GetFileNameWithoutExtension(txtBrowsefile.Text);
                    //if (File.Exists(txtBrowsefile.Text))
                    //{
                    //    //richtxtDisplay.Text = File.ReadAllText(txtBrowsefile.Text);
                    //    //= str;
                    //    //string[] lines = File.ReadAllLines(txtBrowsefile.Text);
                    //    //txtString.Text = lines[1];
                    //}
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FileHadle_Load(object sender, EventArgs e)
        {

        }

        private void btnFile_Info_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(txtBrowsefile.Text);
                richtxtDisplay.BackColor = Color.Aqua;
                richtxtDisplay.Font = new Font("Georgia", 16);
                richtxtDisplay.Text = "***File Informations***\n" + "File Name = " + fi.Name + "\nFile Extension = " + fi.Extension + "\nDirectory Name = " + fi.DirectoryName + "\nFile Size = " + fi.Length + "\nCreation Time = " + fi.CreationTime + "\nLast Access Time = " + fi.LastAccessTime + "\nLast Write Time = " + fi.LastWriteTime;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //// creates a file at pathName with File class
            //FileStream fs = File.Create(txtString.Text);
            //// check if myFile.txt file is created at the specified path 
            //if (File.Exists(pathName))
            //    MessageBox.Show("File is created.");
            //else
            //    MessageBox.Show("File is not created.");

            //with FileInfo class
            FileInfo fi = new FileInfo(txtString.Text);
            using (StreamWriter str = fi.CreateText())
            {
                // Write "hello" to the file
                str.WriteLine("hello");
                MessageBox.Show("File has been created with text!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //File.Delete(txtString.Text);
            FileInfo fi = new FileInfo(txtString.Text);
            fi.Delete();
            MessageBox.Show("File has been deleted.");
        }

        private void btnMove_Click(object sender, EventArgs e)
        {  
            string path = @"D:\\Educational\\Event Driven Programming\\SE Stud.txt";
            string path2 = @"D:\\Educational\\Event Driven Programming\\Lab Manual\\SE Stud.txt";
            FileInfo fi1 = new FileInfo(path);
            FileInfo fi2 = new FileInfo(path2);
            // Move the first file to the second file
            fi1.MoveTo(path2);
            MessageBox.Show("The file successfully moved!");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtString.Text))
            {
                //File.Copy(txtString.Text, txtBrowsefile.Text, true);
                FileInfo fi1 = new FileInfo(txtBrowsefile.Text);
                FileInfo fi2 = new FileInfo(txtString.Text);
                // Copy the first file to the second file
                fi1.CopyTo(txtString.Text);

                MessageBox.Show(txtBrowsefile.Text + "content was copied to " + txtString.Text + "successfully!");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(txtBrowsefile.Text);
            // Check if file is there  
            if (fi.Exists)
            {
                // Move file with a new name.  
                fi.MoveTo(txtString.Text);
                //File.Move(txtBrowsefile.Text, txtString.Text);
                MessageBox.Show("File Renamed.");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDirectoryInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\Educational\Event Driven Programming");
            try
            {
                if (di.Exists)
                {
                    richtxtDisplay.BackColor = Color.AliceBlue;
                    richtxtDisplay.Font = new Font("Georgia", 12);
                    richtxtDisplay.Text = "***Directory Informations***\n";
                    richtxtDisplay.AppendText("\nDirectory Name = " + di.Name);
                    richtxtDisplay.AppendText("\nPath = " + di.FullName);
                    richtxtDisplay.AppendText("\nDirectory is created on : " + di.CreationTime.ToLongTimeString());
                    richtxtDisplay.AppendText("\nDirectory is Last Accessed on " + di.LastAccessTime);
                    richtxtDisplay.AppendText("\nDirectory is Last Written on " + di.LastWriteTime);
                    richtxtDisplay.AppendText("\nRoot = " + di.Root);
                    richtxtDisplay.AppendText("\nAttributes = " + di.Attributes);
                    richtxtDisplay.AppendText("\nParent = " + di.Parent);

                    DirectoryInfo[] dirs = di.GetDirectories();
                    MessageBox.Show("The number of directories containing is " + dirs.Length);
                    foreach (DirectoryInfo diNext in dirs)
                    {
                        MessageBox.Show("The number of files in " + diNext + " is " + diNext.GetFiles().Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirCreate_Click(object sender, EventArgs e)
        {
            String path = @"D:\MyExercise";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                MessageBox.Show("Directory has been created");
            }
            //Subdirectory
            DirectoryInfo dis = fl.CreateSubdirectory("MyToday'sExercise");
            {
                MessageBox.Show("Sub-directory has been created");
            }
        }

        private void btnDirDelete_Click(object sender, EventArgs e)
        {
            //The Delete method deletes a directory, specifying whether to delete subdirectories and files.
            string path = @"D:\MyExercise";
            //DirectoryInfo f1 = new DirectoryInfo(path);
            //f1.Delete();
            //    MessageBox.Show("Directory has been deleted");
            Directory.Delete(path, true);
            MessageBox.Show("Directory has been deleted");
        }

        private void btnDirMove_Click(object sender, EventArgs e)
        {
            //String path = @"D:\MyTestFile1.txt";
            //string path1 = @"D:\NewFile1.txt";
            //DirectoryInfo f1 = new DirectoryInfo(path);
            //DirectoryInfo f2 = new DirectoryInfo(path1);
            //f1.MoveTo(path1);
            //{
            //    MessageBox.Show("Directory has been Moved");
            //}

            //Directory.Move method moves an existing directory to a new specified directory with a full path.
            string sourceDirName = @"D:\Recommendations\UG";
            string destDirName = @"D:\NewProject";
            try
            {
                Directory.Move(sourceDirName, destDirName);
                MessageBox.Show("Directory has been Moved");
            }
            catch (IOException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnDirLists_Click(object sender, EventArgs e)
        {
            string root = @"D:\Educational\Event Driven Programming";
            //to get root directory
            Directory.GetDirectoryRoot(root);
            // Get all subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(root);
            // Loop through them to see if they have any other subdirectories
            richtxtDisplay.Text = "***List of sub directories***\n";
            foreach (string subdirectory in subdirectoryEntries)
            {
                //richtxtDisplay.AppendText(subdirectory + "\n");
                FileInfo f = new FileInfo(subdirectory);

                richtxtDisplay.AppendText(f.Name + "\n");
            }
                
            //LoadSubDirs(subdirectory);

            // gets a list of files in the specified directory.
            ////string[] fileEntries = Directory.GetFiles(root);
            ////foreach (string fName in fileEntries) ;
            ////    richtxtDisplay.AppendText(fName + "\n");
        }

        private void LoadSubDirs(string subdir)
        {
            richtxtDisplay.AppendText(subdir + "\n");
            string[] subdirectoryEntries = Directory.GetDirectories(subdir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                LoadSubDirs(subdirectory);
            }

        }
    }
}
