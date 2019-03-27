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
    public class Courses : Student
    {
        int _courseNumber;
        string _courseName;
        string _courseDescription;
        DateTime _courseTime;
        string _courseDay;

       

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

        public DateTime CourseTime
        {
            get
            {
                return _courseTime;
            }
            private set
            {
                _courseTime = value;
            }

        }

        public string CourseDay
        {
            get
            {
                return _courseDay;
            }
            private set
            {
                _courseDay = value;
            }

        }


        public void AddCourse(Courses Course)
        {


        }
        public void EditCourse(Courses Course)
        {

        }
        public void DeleteCourse(Courses Course)
        {
            int i = 0;
            foreach (Courses c in _courseList)
            {
                if (c.Name == Course.Name)
                {
                    _courseList.RemoveAt(i);
                }
                i++;
            }

        }

    }
}
