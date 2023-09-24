using ExamenFinal.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Interfaces
{
    internal interface ITelefonos
    {
        public void Save(Telefono telefono);
        public DataSet GetTelefonoByGamma(string gamma);
        public DataSet GetAllTelefonos();
    }
}
