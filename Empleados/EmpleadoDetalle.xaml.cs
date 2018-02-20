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
    /// Interaction logic for EmpleadoDetalle.xaml
    /// </summary>
    public partial class EmpleadoDetalle : Window
    {
        public EmpleadoDetalle()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Empleados.Tarea3DataSet tarea3DataSet = ((Empleados.Tarea3DataSet)(this.FindResource("tarea3DataSet")));
            // Load data into the table Empleado. You can modify this code as needed.
            Empleados.Tarea3DataSetTableAdapters.EmpleadoTableAdapter tarea3DataSetEmpleadoTableAdapter = new Empleados.Tarea3DataSetTableAdapters.EmpleadoTableAdapter();
            tarea3DataSetEmpleadoTableAdapter.Fill(tarea3DataSet.Empleado);
            System.Windows.Data.CollectionViewSource empleadoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("empleadoViewSource")));
            empleadoViewSource.View.MoveCurrentToFirst();
            // Load data into the table Familiares. You can modify this code as needed.
            Empleados.Tarea3DataSetTableAdapters.FamiliaresTableAdapter tarea3DataSetFamiliaresTableAdapter = new Empleados.Tarea3DataSetTableAdapters.FamiliaresTableAdapter();
            tarea3DataSetFamiliaresTableAdapter.Fill(tarea3DataSet.Familiares);
            System.Windows.Data.CollectionViewSource familiaresViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("familiaresViewSource")));
            familiaresViewSource.View.MoveCurrentToFirst();
            // Load data into the table Persona. You can modify this code as needed.
            Empleados.Tarea3DataSetTableAdapters.PersonaTableAdapter tarea3DataSetPersonaTableAdapter = new Empleados.Tarea3DataSetTableAdapters.PersonaTableAdapter();
            tarea3DataSetPersonaTableAdapter.Fill(tarea3DataSet.Persona);
            System.Windows.Data.CollectionViewSource personaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("personaViewSource")));
            personaViewSource.View.MoveCurrentToFirst();
        }
    }
}
