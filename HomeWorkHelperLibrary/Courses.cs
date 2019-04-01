using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace HomeWorkHelperLibrary
{
    public class Courses
    {
        int _courseNumber;
        string _courseName;
        string _courseDescription;
        List<DateTime> _courseTime;
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


        public Courses(int courseNumber,string courseName,string courseDescription,
                       List<DateTime> courseTime,List<DateTime> courseDay)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseDescription = courseDescription;
            _courseTime = courseTime;
            _courseDay = courseDay;
        }
        

        public void EditCourseNumber(Courses course,int newNumber)
        {
            course.CourseNumber = newNumber;
        }
        public void EditCourseName(Courses course, string newName)
        {
            course.CourseName = newName;
        }
        public void EditCourseDescription(Courses course, string newDescription)
        {
            course.CourseDescription = newDescription;
        }
        public void EditCourseTime(Courses course, List<DateTime> newTime)
        {
            course._courseTime = newTime;
        }
        public void EditCourseDay(Courses course, List<DateTime> newDay)
        {
            course._courseDay = newDay;
        }

        public void DeleteCourse(Courses Course,Student student)
        {
            int i = 0;
            foreach (Courses c in student._courseList)
            {
                if (c == Course)
                {
                    student._courseList.RemoveAt(i);
                }
                i++;
            }

        }

    }
}
