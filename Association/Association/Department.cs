using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {

        private string deptName;

        public string Deptname
        {
            get { return deptName; }
            set { deptName = value; }
        }
        private string  deptid;

        public string DeptId
        {
            get { return deptid; }
            set { deptid = value; }
        }

        private Student[] students;
        public int studentCount;

        public void AddStudent(params Student[]students)
        {
            foreach (var s in students)
            {
                students[studentCount++] = s;
                s.Dept = this;
            }
        }

        public void AllStudent()
        {
            for(int i = 0; i < studentCount; i++)
            {
                students[i].ShowInfo();
            }
        }
        public Department()
        {
          
        }
        public Department(string deptName,string deptid,Student students )
        {
            this.deptName = deptName;
            this.deptid = deptid;
            this.students = students;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Department Name:" + deptName);
            Console.WriteLine("Department Id:" + deptid);

        }


    }
}
