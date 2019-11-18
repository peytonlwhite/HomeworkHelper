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
    /// Interaction logic for EditTask.xaml
    /// </summary>
    public partial class EditTask : Window
    {

        Student student;
        Task_ oldTask;
        string taskNames;
        int index;
        bool reocurring;
        public EditTask(Student newStudent)
        {
            InitializeComponent();
            student = newStudent;
            for (int i = 0; i < student.TaskList.Count; i++)
            {
                taskNames = (student.TaskList[i].TaskName);
                editTaskCB.Items.Add(taskNames);
            }
        }

        private void editTaskCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            index = editTaskCB.SelectedIndex;
            reocurring = student.TaskList[index].ReoccuringTask;

            NameOfTaskTB.Text = student.TaskList[index].TaskName;
            TypeComboBox.SelectedItem = student.TaskList[index].Type;
            DueDateOfTaskDP.SelectedDate = student.TaskList[index].DueDate;
            EndDateOfTaskDP.SelectedDate = student.TaskList[index].DueDateEnd;
            if (reocurring)
            {
                YesRB.IsChecked = true;
            }
            else
            {
                NoRB.IsChecked = true;
            }

            if (YesRB.IsChecked == true)
            {
                reocurring = true;
            }
            else
            {
                reocurring = false;
            }

            for (int i = 0; i < student.TaskList.Count; i++)
            {
                if (student.TaskList[i].TaskName == NameOfTaskTB.Text)
                {
                    oldTask = student.TaskList[i];
                }
            }

        }

        private void save_task_button(object sender, RoutedEventArgs e)
        {
            if (NameOfTaskTB.Text == "" || TypeComboBox.Text == "" || DueDateOfTaskDP.SelectedDate == null
                || EndDateOfTaskDP.SelectedDate == null)
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {
                string taskName = NameOfTaskTB.Text;
                string type = Convert.ToString(TypeComboBox.Text);
                DateTime dueDate = (DateTime)DueDateOfTaskDP.SelectedDate;
                DateTime endDate = (DateTime)EndDateOfTaskDP.SelectedDate;
                FileReadWrite file = new FileReadWrite();


                Task_ editTask = new Task_(taskName, type, reocurring, dueDate, endDate);

                student.TaskList[index] = editTask;
                file.EditTaskToFile(student, editTask, oldTask);
                homeScreen hs = new homeScreen(student);
                this.Close();
                hs.Show();

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            homeScreen home = new homeScreen(student);
            this.Close();
            home.Show();
        }
    }
}
