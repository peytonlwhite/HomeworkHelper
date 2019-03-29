using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};

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
        

        public void EditCourseNumber(Courses Course,int newNumber)
        {
            Course.CourseNumber = newNumber;
        }
        public void EditCourseName(Courses Course, string newName)
        {
            Course.CourseName = newName;
        }
        public void EditCourseDescription(Courses Course, string newDescription)
        {
            Course.CourseDescription = newDescription;
        }
        public void EditCourseTime(Courses Course, List<DateTime> newTime)
        {
            Course._courseTime = newTime;
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
                if (c._courseName == Course.CourseName)
                {
                    student._courseList.RemoveAt(i);
                }
                i++;
            }

        }

    }
}
