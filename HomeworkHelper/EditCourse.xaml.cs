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
           
         
        }
    }
}
