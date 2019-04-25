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
    /// Interaction logic for EditCourse.xaml
    /// </summary>
    public partial class EditCourse : Window
    {
        Student student;
        int courseNums;
        int index;
        public EditCourse(Student newStudent)
        {
            InitializeComponent();
            student = newStudent;
            for (int i = 0; i < student.CourseList.Count; i++)
            {
                courseNums = (student.CourseList[i].CourseNumber);
                editCourseCB.Items.Add(courseNums);
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            index = editCourseCB.SelectedIndex;

            courseNameTb.Text = student.CourseList[index].CourseName;
            courseNumberTB.Text = Convert.ToString(student.CourseList[index].CourseNumber);
            courseMeetingTimeTB.Text = student.CourseList[index].CourseTime;
            datepicker.SelectedDate = student.CourseList[index].DateOfCourse;


        }

        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            Course EditCourse = new Course(Convert.ToInt32(courseNumberTB.Text), courseNameTb.Text, courseMeetingTimeTB.Text, (DateTime)datepicker.SelectedDate);

            student.CourseList[index] = EditCourse;

            ViewCourses vc = new ViewCourses(student);
            this.Close();
            vc.Show();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ViewCourses vs = new ViewCourses(student);
            this.Close();
            vs.Show();
        }
    }
}
