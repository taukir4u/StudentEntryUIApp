using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryUIApp
{
    public partial class StudentEntryUI : Form
    {
        private Department aDepartment;

        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void departmentSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department();
            aDepartment.Code = departmentCodeTextBox.Text;
            aDepartment.DepartmentName = departmentNameTextBox.Text;
            MessageBox.Show("Department Info Saved");
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = studentRegNoTextBox.Text;
            aStudent.StudentName = studentNameTextBox.Text;
            aStudent.Email = studentEmailTextBox.Text;
            string msg = aDepartment.Add(aStudent);
            MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string info ="Department Info: \n"+ "Code: " + aDepartment.Code + " \nName: " + aDepartment.DepartmentName + "\n\n";
            info += "Student Info: \nReg no\tName\t\tEmail\n";
            foreach (Student aStudent in aDepartment.GetAllStudents())
            {
                string aRow = aStudent.RegNo + "\t" + aStudent.StudentName + "\t\t" + aStudent.Email+"\n";
                info += aRow;
            }
            MessageBox.Show(info);
        }
    }
}
