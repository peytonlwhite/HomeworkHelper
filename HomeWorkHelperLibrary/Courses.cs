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

        /// <summary>
        /// Sets the member variables that defines a course
        /// </summary>
        /// <param name="courseNumber">Int for Course number. EX- 2010</param>
        /// <param name="courseName">String for the coursename</param>
        /// <param name="courseDescription">String to describe the course</param>
        /// <param name="courseTime">List of datetime to set the time for the course</param>
        /// <param name="courseDay">List of datetime to set the days of the courses</param>
        public Courses(int courseNumber,string courseName,string courseDescription,
                       List<DateTime> courseTime,List<DateTime> courseDay)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
            CourseDescription = courseDescription;
            _courseTime = courseTime;
            _courseDay = courseDay;
        }
        

        /// <summary>
        /// Edits the course number
        /// </summary>
        /// <param name="course">Which course to edit</param>
        /// <param name="newNumber">The new course number</param>
        public void EditCourseNumber(Courses course,int newNumber)
        {
            course.CourseNumber = newNumber;
        }

        /// <summary>
        /// Edits the course name
        /// </summary>
        /// <param name="course">Which course to edit</param>
        /// <param name="newName">The new name</param>
        public void EditCourseName(Courses course, string newName)
        {
            course.CourseName = newName;
        }

        /// <summary>
        /// Edits course description
        /// </summary>
        /// <param name="course">Which course to edit</param>
        /// <param name="newDescription"> String for new description</param>
        public void EditCourseDescription(Courses course, string newDescription)
        {
            course.CourseDescription = newDescription;
        }

        /// <summary>
        /// Edits the course time
        /// </summary>
        /// <param name="course">Which course to edit</param>
        /// <param name="newTime">The new times for the course</param>
        public void EditCourseTime(Courses course, List<DateTime> newTime)
        {
            course._courseTime = newTime;
        }

        /// <summary>
        /// Edits the days that the course happens on
        /// </summary>
        /// <param name="course">Which course to edit</param>
        /// <param name="newDay">A list of the new days</param>
        public void EditCourseDay(Courses course, List<DateTime> newDay)
        {
            course._courseDay = newDay;
        }

        /// <summary>
        /// Deletes a certain course
        /// </summary>
        /// <param name="Course">Which course to delete</param>
        /// <param name="student">Which student to delete it from</param>
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
