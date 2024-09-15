using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Video
    {
        private int codigo;
        private string nombreVideo;
        private double duracion;
        private double precioSoles;
        private double tipoCambio;

        public Video(int codigo, string nombreVideo, double duracion, double precioSoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.precioSoles = precioSoles;
            this.tipoCambio = tipoCambio;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string NombreVideo
        {
            get { return nombreVideo; }
            set { nombreVideo = value; }
        }

        public double Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public double PrecioSoles
        {
            get { return precioSoles; }
            set { precioSoles = value; }
        }

        public double TipoCambio
        {
            get { return tipoCambio; }
            set { tipoCambio = value; }
        }

        public double PrecioEnDolares()
        {
            return precioSoles / tipoCambio;
        }
    }
}
