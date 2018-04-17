using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Vehiculo
    {
        protected string tipo;
        string patente;
        string color;

        public Vehiculo(string mitipo, string mipatente, string micolor)
        {
            tipo = mitipo;
            patente = mipatente;
            color = micolor;
        }
    }
    public class camion : Vehiculo
    {
        string marca;
        string modelo;
        int ano;

        public camion(string mitipo, string mipatente, string micolor, string mimarca, string mimodelo, int miano)
            : base(mitipo, mipatente, micolor)
        {

            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
    public class maqpesada : Vehiculo
    {
        string marca;
        string modelo;
        int ano;
        public maqpesada(string mitipo, string mipatente, string micolor, string mimarca, string mimodelo, int miano)
            : base(mitipo, mipatente, micolor)
        {

            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
    public class auto : Vehiculo
    {
        string marca;
        string modelo;
        int ano;
        public auto(string mitipo, string mipatente, string micolor, string mimarca, string mimodelo, int miano)
            : base(mitipo, mipatente, micolor)
        {

            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
    public class acuatico : Vehiculo
    {
        string marca;
        string modelo;
        int ano;

        public acuatico(string mitipo, string mipatente, string micolor, string mimarca, string mimodelo, int miano)
            : base(mitipo, mipatente, micolor)
        {

            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
    public class moto : Vehiculo
    {
        string marca;
        string modelo;
        int ano;

        public moto(string mitipo, string mipatente, string micolor, string mimarca, string mimodelo, int miano)
            : base(mitipo, mipatente, micolor)
        {

            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
    public class bus : Vehiculo
    {
        string marca;
        string modelo;
        int ano;

        public bus(string mitipo, string mipatente, string micolor, string mimarca, string mimodelo, int miano)
            : base(mitipo, mipatente, micolor)
        {

            marca = mimarca;
            modelo = mimodelo;
            ano = miano;
        }
    }
}
