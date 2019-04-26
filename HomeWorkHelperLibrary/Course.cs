using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace HomeWorkHelperLibrary
{
    public class Course
    {
        private int _courseNumber;
        private string _courseName;
        private string _courseTime;
        private DateTime _courseDay;
       
        public int CourseNumber
        {
            get
            {
                return _courseNumber;
            }
            private set
            {
                _courseNumber = value;
            }

        }
        public string CourseTime
        {
            get
            {
                return _courseTime;
            }
            set
            {
                _courseTime = value;
            }
        }

        public string CourseName
        {
            get
            {
                return _courseName;
            }
            private set
            {
                _courseName = value;
            }

        }


    
        public DateTime DateOfCourse
        {
            get
            {
                return _courseDay;
            }
            set
            {
                _courseDay = value;
            }
        }
        public Course(int courseNumber, string courseName,string time,DateTime date)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseTime = time;
            DateOfCourse = date;
            
        }
        public Course(string name)
        {
            CourseName = name;
        }
    }
}
