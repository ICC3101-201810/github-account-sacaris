using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Arriendo
    {
        string cliente;
        string vehiculo;
        string sucursal;
        List<Accesorios> a;
        DateTime inicio;
        DateTime fin;
        int sumatotal;
        public Arriendo(string micliente, string mivehiculo, string misucursal, List<Accesorios> miaccesorios, DateTime miinicio, DateTime mifin, int misumatotal)
        {
            cliente = micliente;
            vehiculo = mivehiculo;
            sucursal = misucursal;
            a = miaccesorios;
            inicio = miinicio;
            fin = mifin;
            sumatotal = misumatotal;
        }
    }
}
