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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Empleados
{
    /// <summary>
    /// Interaction logic for VentanaEmpleados.xaml
    /// </summary>
    public partial class VentanaEmpleados : Page
    {
        EmpleadosEntities db = new EmpleadosEntities();

        public VentanaEmpleados()
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

        public void eliminarEmpleado()
        {
            View_Empleado empleado = (View_Empleado)dataGrid1.SelectedItem;
            if (empleado != null)
            {
                try
                {
                    MessageBoxResult result = MessageBox.Show("Realmente desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButton.YesNo, MessageBoxImage.Stop);
                    if (result == MessageBoxResult.Yes)
                    {

                        //db.borrarEmpleado(empleado.Cédula);
                    }

                }
                catch (System.SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Empleado.");
            }

        }

        private void Eliminar_Empleado_Click(object sender, RoutedEventArgs e)
        {
            eliminarEmpleado();
            var empleados = db.View_Empleado;
            dataGrid1.ItemsSource = empleados.ToList();
            Refresh(dataGrid1);
        }

        private delegate void NoArgDelegate();
        public static void Refresh(DependencyObject obj)
        {
            obj.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                (NoArgDelegate)delegate { });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmpleadoDetalle frm1 = new EmpleadoDetalle();
            View_Empleado empleado = (View_Empleado)dataGrid1.SelectedItem;
            if (empleado != null)
            {
                frm1.EmpleadoID = empleado.Cédula;
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un Empleado.");
            }

        }

        private void Pagos_Button_Click(object sender, RoutedEventArgs e)
        {
            var wnd = (MainWindow)Window.GetWindow(this);
            wnd.FrameWithinGrid.Navigate(new System.Uri("Pages/VentanaPagos.xaml",
             UriKind.RelativeOrAbsolute));
        }
    }
}
