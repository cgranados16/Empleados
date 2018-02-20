using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Models
{
    public class Empleado : INotifyPropertyChanged
    {

        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PuestoTrabajo { get; set; }
        public DateTime FechaContratacion { get; set; }
        public String FechaContratacionString { get { return FechaContratacion.ToShortDateString(); } }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string EstadoCivil { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
