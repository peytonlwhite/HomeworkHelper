using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWorkHelperLibrary
{
    public class Course
    {
       
        public int CourseNumber { get; private set; }

        public string CourseTime { get; private set; }

        public string CourseName { get; private set; }

        public DateTime DateOfCourse { get; private set; }

        public Course(int courseNumber, string courseName,string time, DateTime date)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseTime = time;
            DateOfCourse = date;
            
        }
    }
}
