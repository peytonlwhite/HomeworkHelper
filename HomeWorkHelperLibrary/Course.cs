using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace HomeWorkHelperLibrary
{
    public class Course
    {
        int _courseNumber;
        string _courseName;
        string _courseDescription;
        string _courseTime;
        DateTime _courseDay;
       


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


        public string CourseDescription
        {
            get
            {
                return _courseDescription;
            }
            private set
            {
                _courseDescription = value;
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
        public Course(int courseNumber, string courseName,string time,DateTime date,string courseDes)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseTime = time;
            DateOfCourse = date;
            CourseDescription = courseDes;
        }
        public Course(string name)
        {
            CourseName = name;
        }

    

    }
}
