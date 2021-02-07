using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCOUNT
{
    
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;

        public Course()
        {

        }
        public Course(String courseName, String courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;


        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name:" + courseName);
            Console.WriteLine("Course code:" + courseCode);
            Console.WriteLine("Course credit:" + courseCredit);
        }
    }
}
