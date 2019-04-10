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
    /// Interaction logic for newUser.xaml
    /// </summary>
    public partial class newUser : Window
    {

        String name;
        String userName;
        String password;

        public newUser()
        {
            InitializeComponent();


            firstNameTB.Text = name;

            usernameTB1.Text = userName;

            passwordTB.Text = password;

            Student student = new Student(name, userName, password);


        }

    }

}
