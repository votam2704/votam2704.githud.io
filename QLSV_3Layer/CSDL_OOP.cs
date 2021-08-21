using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer
{
    class CSDL_OOP
    {
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static CSDL_OOP _Instance;
        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            foreach (DataRow student in CSDL.Instance.DTSV.Rows)
            {
                students.Add(loadStudent(student));
            }
            return students;
        }
        private Student loadStudent(DataRow student)
        {
            Student s = new Student();
            s.StudentID = student["StudentID"].ToString();
            s.Name = student["Name"].ToString();
            s.Gender = Convert.ToBoolean(student["Gender"]);
            s.DateOfBirth = Convert.ToDateTime(student["DateOfBirth"]);
            s.ClassID = Convert.ToInt32(student["ClassID"]);
            return s;
        }
        
    }
}
