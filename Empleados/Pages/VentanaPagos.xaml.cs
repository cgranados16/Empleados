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

namespace Empleados.Pages
{
    /// <summary>
    /// Interaction logic for VentanaEmpleados.xaml
    /// </summary>
    public partial class VentanaPagos : Page
    {
        EmpleadosEntities db = new EmpleadosEntities();

        public VentanaPagos()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getPagos();
        }

        private void getPagos()
        {
            var pagos = db.view_Pagos;
            dataGrid1.ItemsSource = pagos.ToList();
        }

        private void Empleados_Button_Click(object sender, RoutedEventArgs e)
        {
            var wnd = (MainWindow)Window.GetWindow(this);
            wnd.FrameWithinGrid.Navigate(new System.Uri("Pages/VentanaEmpleados.xaml",
             UriKind.RelativeOrAbsolute));
        }
    }
}
