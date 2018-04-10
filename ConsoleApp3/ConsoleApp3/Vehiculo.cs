using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Vehiculo
    {
        string tipo;
        string patente;
        string color;

        public Vehiculo(string mitipo, string mipatente, string micolor)
        {
            tipo = mitipo;
            patente = mipatente;
            color = micolor;
        }
    }
    class camion : Vehiculo
    {
        string marca;
        string modelo;
        int ano;

        public camion(string mimarca, string mimodelo, int miano)
        {
            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
    class auto:Vehiculo
    {

    }
}
