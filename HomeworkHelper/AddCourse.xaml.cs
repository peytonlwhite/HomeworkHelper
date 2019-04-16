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
    /// Interaction logic for AddCourse.xaml
    /// </summary>
    public partial class AddCourse : Window
    {
        Student newStudent;
        public AddCourse(Student stu)
        {
            InitializeComponent();
            newStudent = stu;
        }
        
        private void Add_Course_Button(object sender, RoutedEventArgs e)
        {
            
            Course course = new Course(Convert.ToInt32(CourseNumberTB.Text), courseNameTB.Text,
                                       MeetingTimeTB.Text,(DateTime)DateOfCourse.SelectedDate,CourseDescriptionTB.Text);
            newStudent.AddCourse(course);
            ViewCourses viewCourse = new ViewCourses(newStudent);
            viewCourse.Show();
        }

       
    }
}
