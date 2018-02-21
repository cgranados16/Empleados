using Empleados.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Empleados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmpleadosEntity db = new EmpleadosEntity();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getEmpleados();
        }

        private void getEmpleados()
        {
            var empleados = db.View_Empleado;
            dataGrid1.ItemsSource = empleados.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //EmpleadoDetalle frm1 = new EmpleadoDetalle();
            View_Empleado customer = (View_Empleado)dataGrid1.SelectedItem;
            Debug.Print(customer.Nombre);
            //frm1.Show();
        }
    }
}
