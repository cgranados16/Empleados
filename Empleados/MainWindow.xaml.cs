using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public MainWindow()
        {
            InitializeComponent();

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Empleados.Tarea3DataSet tarea3DataSet = ((Empleados.Tarea3DataSet)(this.FindResource("tarea3DataSet")));
            // Load data into the table Empleado. You can modify this code as needed.
            Empleados.Tarea3DataSetTableAdapters.EmpleadoTableAdapter tarea3DataSetEmpleadoTableAdapter = new Empleados.Tarea3DataSetTableAdapters.EmpleadoTableAdapter();
            tarea3DataSetEmpleadoTableAdapter.Fill(tarea3DataSet.Empleado);
            System.Windows.Data.CollectionViewSource empleadoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("empleadoViewSource")));
            empleadoViewSource.View.MoveCurrentToFirst();
            // Load data into the table View_Empleado. You can modify this code as needed.
            Empleados.Tarea3DataSetTableAdapters.View_EmpleadoTableAdapter tarea3DataSetView_EmpleadoTableAdapter = new Empleados.Tarea3DataSetTableAdapters.View_EmpleadoTableAdapter();
            tarea3DataSetView_EmpleadoTableAdapter.Fill(tarea3DataSet.View_Empleado);
            System.Windows.Data.CollectionViewSource view_EmpleadoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("view_EmpleadoViewSource")));
            view_EmpleadoViewSource.View.MoveCurrentToFirst();
        }
    }
}
