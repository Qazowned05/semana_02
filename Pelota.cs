using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Pelota
    {

        private string marca;
        private double pesoEnGramos;
        private double presionEnLibras;
        private double diametroEnCentimetros;
        private double precio;

        public Pelota(string marca, double pesoEnGramos, double presionEnLibras, double diametroEnCentimetros, double precio)
        {
            this.marca = marca;
            this.pesoEnGramos = pesoEnGramos;
            this.presionEnLibras = presionEnLibras;
            this.diametroEnCentimetros = diametroEnCentimetros;
            this.precio = precio;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double PesoEnGramos
        {
            get { return pesoEnGramos; }
            set { pesoEnGramos = value; }
        }

        public double PresionEnLibras
        {
            get { return presionEnLibras; }
            set { presionEnLibras = value; }
        }

        public double DiametroEnCentimetros
        {
            get { return diametroEnCentimetros; }
            set { diametroEnCentimetros = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public double Radio()
        {
            return diametroEnCentimetros / 2;
        }

        public double Volumen()
        {
            double radio = Radio();
            return (4 * 3.1416 * radio * radio * radio) / 3;
        }

        public double Descuento()
        {
            return precio * 0.10;
        }

        public double ImporteAPagar()
        {
            return precio - Descuento();
        }
    }
}
