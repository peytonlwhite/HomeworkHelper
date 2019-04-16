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
        public ViewCourses(Student newStudent)
        {
            InitializeComponent();
            List<Course> courses = new List<Course>();
            courses.Add(newStudent.CourseList.ElementAt(0));

            lVCourse.ItemsSource = newStudent.CourseList;
        }
    }
}
