using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Edificio
    {
        private int codigoEdificio;

        private int numeroDepartamentos;

        private int cantidadPisos;

        private double precioDepartamentoDolares;


        public Edificio(int codigoEdificio, int numeroDepartamentos, int cantidadPisos, double precioDepartamentoDolares)
        {
            this.codigoEdificio = codigoEdificio;
            this.numeroDepartamentos = numeroDepartamentos;
            this.cantidadPisos = cantidadPisos;
            this.precioDepartamentoDolares = precioDepartamentoDolares;
        }

        public int Codigo
        {
            get { return codigoEdificio; }
            set { codigoEdificio = value; }
        }

        public int NumeroDepartamentos
        {
            get { return numeroDepartamentos; }
            set { numeroDepartamentos = value; }
        }

        public int CantidadPisos
        {
            get { return cantidadPisos; }
            set { cantidadPisos = value; }
        }

        public double PrecioDepartamentoDolares
        {
            get { return precioDepartamentoDolares; }
            set { precioDepartamentoDolares = value; }
        }

        public double PrecioTotalEdificio()
        {
            return numeroDepartamentos * precioDepartamentoDolares;
        }
    }
}
