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
    /// Interaction logic for DeleteTask.xaml
    /// </summary>
    public partial class DeleteTask : Window
    {
        Student student;
        string taskNames;
        public DeleteTask(Student newStudent)
        {
            InitializeComponent();
            student = newStudent;
            for (int i = 0; i < student.TaskList.Count; i++)
            {
                taskNames = (student.TaskList[i].TaskName);
                deleteCB.Items.Add(taskNames);
            }
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            student.DeleteTask(deleteCB.SelectedIndex);

            homeScreen hs = new homeScreen(student);
            this.Close();
            hs.Show();
        }
    }
}
