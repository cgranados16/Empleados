using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RealizarPago.xaml
    /// </summary>
    public partial class RealizarPago : Window
    {
        EmpleadosEntity db = new EmpleadosEntity();
        public int EmpleadoID { get; set; }

        public RealizarPago()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.Print(montoTextBox.Text.ToString());
            int result = db.sp_PagoSalario(EmpleadoID, Convert.ToDecimal(montoTextBox.Text.ToString()), fechaDatePicker.SelectedDate);
            if (result == 1)
            {
                MessageBox.Show("Pago Realizado con éxito.", "Confirmation");
            }
            Close();
        }


        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }

        private void PreviewTextInputHandler(Object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void montoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
