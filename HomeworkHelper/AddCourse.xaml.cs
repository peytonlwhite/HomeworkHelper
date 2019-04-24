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
            FileReadWrite file = new FileReadWrite();
            int courseNum = Convert.ToInt32(CourseNumberTB.Text);
            string courseName = courseNameTB.Text;
            string meetingTime = MeetingTimeTB.Text;
            DateTime courseDate = (DateTime)DateOfCourse.SelectedDate;

            if (courseNum <= 0 || courseName.Length == 0 || meetingTime.Length == 0)
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {
                Course course = new Course(courseNum, courseName, meetingTime, courseDate);
                newStudent.AddCourse(course);
                file.AddCourseToFile(newStudent,course);
                ViewCourses viewCourse = new ViewCourses(newStudent);

                this.Close();
                viewCourse.Show();
            }
            
        }
       
    }
}
