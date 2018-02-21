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
        EmpleadosEntities db = new EmpleadosEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        
    }
}
