using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Celular
    {

        private int numero { get; set; }
        private string usuario { get; set; }
        private int segundosConsumidos { get; set; }
        private double precioPorSegundo { get; set; }

        public Celular(int numero, string usuario, int segundosConsumidos, double precioPorSegundo)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precioPorSegundo = precioPorSegundo;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int SegundosConsumidos
        {
            get { return segundosConsumidos; }
            set { segundosConsumidos = value; }
        }

        public double PrecioPorSegundo
        {
            get { return precioPorSegundo; }
            set { precioPorSegundo = value; }
        }

        public double CostoPorConsumo()
        {
            return segundosConsumidos * precioPorSegundo;
        }

        public double ImpuestoIGV()
        {
            return CostoPorConsumo() * 0.18;
        }

        public double TotalAPagar()
        {
            return CostoPorConsumo() + ImpuestoIGV();
        }

    }
}
