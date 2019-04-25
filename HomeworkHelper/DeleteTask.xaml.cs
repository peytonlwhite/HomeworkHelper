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
        Task_ oldTask;
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
            FileReadWrite file = new FileReadWrite();
            oldTask = student.TaskList[deleteCB.SelectedIndex];
            student.DeleteTask(deleteCB.SelectedIndex);
            file.DeleteTaskToFile(student,oldTask);
            homeScreen hs = new homeScreen(student);
            this.Close();
            hs.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            homeScreen home = new homeScreen(student);
            this.Close();
            home.Show();
        }
    }
}
