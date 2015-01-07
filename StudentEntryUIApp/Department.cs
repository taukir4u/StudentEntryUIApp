using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryUIApp
{
    class Department
    {
        private const int MAX_NO_OF_STUDENTS = 30;
        public string Code { set; get; }
        public string DepartmentName { set; get; }
        private List<Student> studentList;

        public Department()
        {
            studentList = new List<Student>();
        }

        public string Add(Student aStudent)
        {
            if (studentList.Count < MAX_NO_OF_STUDENTS)
            {
                foreach (Student studentObj in studentList)
                {
                    if (studentObj.RegNo == aStudent.RegNo)
                    {
                        return "This Reg No already exists";
                    }
                }

                studentList.Add(aStudent);
                return "Student Added";
            }
            else
            {
                return "Overflow";
            }
            
        }

        public Student[] GetAllStudents()
        {
            return studentList.ToArray();
        }


    }
}
