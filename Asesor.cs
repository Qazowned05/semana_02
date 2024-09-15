﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_02
{
    internal class Asesor
    {
        private int codigo;
        private string nombre;
        private int horasTrabajadas;
        private double tarifaPorHora;

        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }

        public double TarifaPorHora
        {
            get { return tarifaPorHora; }
            set { tarifaPorHora = value; }
        }

        public double SueldoBruto()
        {
            return horasTrabajadas * tarifaPorHora;
        }

        public double Descuento()
        {
            return SueldoBruto() * 0.15;
        }

        public double SueldoNeto()
        {
            return SueldoBruto() - Descuento();
        }
    }
}
