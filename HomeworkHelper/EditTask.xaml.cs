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
            RemindOfTaskDP.SelectedDate = student.TaskList[index].RemindTime;
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
                reocurring = false;
        }

        private void save_task_button(object sender, RoutedEventArgs e)
        {
            Task_ editTask = new Task_(NameOfTaskTB.Text, Convert.ToString(TypeComboBox.Text), 
                reocurring,
                (DateTime) DueDateOfTaskDP.SelectedDate, (DateTime)EndDateOfTaskDP.SelectedDate, 
                (DateTime)RemindOfTaskDP.SelectedDate);
            student.TaskList[index] = editTask;

            homeScreen hs = new homeScreen(student);
            this.Close();
            hs.Show();
        }
    }
}
