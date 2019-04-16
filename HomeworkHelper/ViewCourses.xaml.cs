using HomeWorkHelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeworkHelper
{
    /// <summary>
    /// Interaction logic for ViewCourses.xaml
    /// </summary>
    public partial class ViewCourses : Window
    {
        string[] rows = new string[100];
        public ViewCourses(Student newStudent)
        {
            InitializeComponent();
            List<Course> courses = new List<Course>();
            

            for (int i = 0; i < newStudent.CourseList.Count; i++)
            {
                rows[i] = newStudent.CourseList[0].CourseName;
                i++;
                rows[i] = Convert.ToString(newStudent.CourseList[0].CourseNumber);

                   //{ newStudent.CourseList[0].CourseName,Convert.ToString(newStudent.CourseList[0].CourseNumber),
                   //Convert.ToString(newStudent.CourseList[0].CourseTime), Convert.ToString(newStudent.CourseList[0].DateOfCourse)};

            }

            lVCourse.ItemsSource = rows;
        }
        public string Name
        {
            get;
            set;
        }
        private void LoadListView()
        {
            
        }
    }
}
