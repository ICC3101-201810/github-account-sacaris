using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{   class Sucursal
    {

    }
    public class Arriendo
    {
        string cliente;
        string vehiculo;
        string sucursal;
        List accesorios;
        DateTime inicio;
        DateTime fin;
        int sumatotal;
        public Arriendo(string micliente, string mivehiculo, string misucursal, List miaccesorios, DateTime miinicio, DateTime mifin, int misumatotal)
        {
            cliente = micliente;
            vehiculo = mivehiculo;
            sucursal = misucursal;
            accesorios = miaccesorios;
            inicio = miinicio;
            fin = mifin;
            sumatotal = misumatotal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
