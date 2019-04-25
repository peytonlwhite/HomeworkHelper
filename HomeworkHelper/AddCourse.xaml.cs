using HomeWorkHelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (CourseNumberTB.Text == "" || courseNameTB.Text == ""
                || MeetingTimeTB.Text == "" || DateOfCourse.SelectedDate == null)
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {

                FileReadWrite file = new FileReadWrite();
                int courseNum = Convert.ToInt32(CourseNumberTB.Text);
                string courseName = courseNameTB.Text;
                string meetingTime = MeetingTimeTB.Text;
                DateTime courseDate = (DateTime)DateOfCourse.SelectedDate;


                Course course = new Course(courseNum, courseName, meetingTime, courseDate);
                newStudent.AddCourse(course);
                file.AddCourseToFile(newStudent, course);
                ViewCourses viewCourse = new ViewCourses(newStudent);

                this.Close();
                viewCourse.Show();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ViewCourses vs = new ViewCourses(newStudent);
            this.Close();
            vs.Show();
        }

        private void courseNameTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
