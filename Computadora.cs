using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Computadora
    {

        private int codigo { get; set; }
        private string marca { get; set; }
        private string color { get; set; }
        private double precioDolares { get; set; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double PrecioDolares
        {
            get { return precioDolares; }
            set { precioDolares = value; }
        }

        public double PrecioEnSoles()
        {
            return precioDolares * 3.35;
        }

        public double PrecioEnEuros()
        {
            return precioDolares / 1.20;
        }
    }
    
}

