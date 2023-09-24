using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Clases
{
    internal class Telefono
    {
        public string Marca { get; set; }
        public string Gamma { get; set; }
        public string PaisDeEnsamblaje { get; set; }
        public decimal precio { get; set; }
        public decimal porcentajeAincrementar { get; set; }
        public string color {  get; set; }
        public DateTime FechaDeRegistro { get; set; }
    }
}
