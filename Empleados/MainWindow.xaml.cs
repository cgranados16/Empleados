using System.Diagnostics;
using System.Linq;
using System.Windows;

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
            EmpleadoDetalle frm1 = new EmpleadoDetalle();
            View_Empleado empleado = (View_Empleado)dataGrid1.SelectedItem;
            frm1.EmpleadoID = empleado.Cédula;
            frm1.Show();
        }
    }
}
