using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Mekele
{
    class PatientManagement
    {
       private String format = "";
        public static string file_name = "AMGH_Patients.txt";

        public void Register_To_File(string full_name)
        {
            format = "\n1\t" +
                    PatientRegistration_File.fullname + "\t" +
                    PatientRegistration_File.kebele + "\t" +
                    PatientRegistration_File.age + "\t" +
                    PatientRegistration_File.diseaase + "\t";
            if (File.Exists(file_name))
                File.AppendAllText(file_name, format);
            else
            {
                FileInfo file_create = new FileInfo(file_name);
                format = "Arba Minch Institute of Technology\n" + 
                    "\tFaculty of Computing & Software Engineering\n" +
                    "\tPatient Information Management System\n" +
                    "===============================================\n" + 
                    "Roll No. \tFull Name\tKebele\tAge\tDisease" + "\r\n";
                using (StreamWriter str = file_create.CreateText())
                {
                    str.WriteLine(format);
                }
            }
        }
    }
}
