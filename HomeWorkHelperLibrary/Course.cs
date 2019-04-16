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
        List<DateTime> _courseDay;
       


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

        public Course(int courseNumber, string courseName,string time)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseTime = time;
        }

        /// <summary>
        /// Sets the member variables that defines a course
        /// </summary>
        /// <param name="courseNumber">Int for Course number. EX- 2010</param>
        /// <param name="courseName">String for the coursename</param>
        /// <param name="courseDescription">String to describe the course</param>
        /// <param name="courseTime">List of datetime to set the time for the course</param>
        /// <param name="courseDay">List of datetime to set the days of the courses</param>
        public Course(int courseNumber,string courseName,string courseDescription,
                       string courseTime,List<DateTime> courseDay)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseDescription = courseDescription;
            _courseTime = courseTime;
            _courseDay = courseDay;
        }

    }
}
