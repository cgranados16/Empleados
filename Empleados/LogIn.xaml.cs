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

namespace Empleados
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (usernameTextBox.Text.Equals("Admin") && passwordTextBox.Password.Equals("Admin"))
            {
                MainWindow frm1 = new MainWindow();
                frm1.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
