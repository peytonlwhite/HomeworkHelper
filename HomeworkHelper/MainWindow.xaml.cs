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
    /// Interaction logic for loginForm.xaml
    /// </summary>
    public partial class loginForm : Window
    {
        private Student student = new Student();
      //  private FileReadWrite file;
        public loginForm()
        {
            InitializeComponent();
     
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newUser newU = new newUser();
            this.Close();
            newU.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FileReadWrite file = new FileReadWrite();
            if (usernameTB.Text.Trim() == "" && passwordBox.Password == "")
            {
                MessageBox.Show("Please enter Username and Password.");
            }
            else
            {
                if (file.readStudentFromFile(ref student, usernameTB.Text.Trim(), passwordBox.Password.Trim()))
                {
                    homeScreen studentForm = new homeScreen(student);
                    this.Close();
                    studentForm.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Username and password is incorrect.");
                }
            }
        }
    }
}
