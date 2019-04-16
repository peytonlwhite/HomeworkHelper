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
        public List<Course> courses { get; set; }

        public ViewCourses(Student newStudent)
        {
            InitializeComponent();
            courses = new List<Course>();

            for(int i = 0; i < newStudent.CourseList.Count; i++)
            {
                courses.Add(newStudent.CourseList[i]);
            }
            DataContext = this;


        }
     
        private void LoadListView()
        {
            
        }
    }
}
