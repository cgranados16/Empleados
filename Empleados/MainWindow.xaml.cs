using Empleados.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public MainWindow()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "tarea03.database.windows.net",
                UserID = "Carlos",
                Password = "Caca1234",
                InitialCatalog = "Tarea3"
            };

        }

        public ObservableCollection<Empleado> GetEmpleados(string connectionString)
        {
            const string GetProductsQuery = "SELECT * FROM HumanResources.Employee;";

            var products = new ObservableCollection<Empleado>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetProductsQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var product = new Empleado();
                                    product.Cedula = reader.GetInt32(0);
                                    product.Nombre = reader.GetString(1);
                                    product.PrimerApellido = reader.GetString(2);
                                    product.SegundoApellido = reader.GetString(3);
                                    product.PuestoTrabajo = reader.GetString(4);
                                    product.FechaContratacion = reader.GetDateTime(5);
                                    product.Genero = reader.GetString(6);
                                    product.Nacionalidad = reader.GetString(7);
                                    product.EstadoCivil = reader.GetString(7);
                                    products.Add(product);
                                }
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
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

        private void view_EmpleadoDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmpleadoDetalle frm1 = new EmpleadoDetalle();
            frm1.Show();
        }
    }
}
