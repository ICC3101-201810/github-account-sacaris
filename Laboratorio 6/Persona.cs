using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Persona
    {
        string nombre;
        string rut;
        string direccion;
        string licencia;
        public Persona(string minombre, string mirut, string midireccion, string milicencia)
        {
            nombre = minombre;
            rut = mirut;
            direccion = midireccion;
            licencia = milicencia;
            
        }
    }
}
