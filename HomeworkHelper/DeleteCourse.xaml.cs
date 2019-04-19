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
    /// Interaction logic for DeleteCourse.xaml
    /// </summary>
    public partial class DeleteCourse : Window
    {
        Student student;
        int courseNums;
        public DeleteCourse(Student newStudent)
        {
            InitializeComponent();
            student = newStudent;
            for (int i = 0; i < student.CourseList.Count; i++)
            {
                courseNums = (student.CourseList[i].CourseNumber);
                deleteCB.Items.Add(courseNums);
            }
        }

        private void deleteCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
