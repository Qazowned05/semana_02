using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Semana_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Celular celular = new Celular(917287980, "Diego Rivera", 100, 2);
            ListarDatosCelular(celular);
            celular.SegundosConsumidos += 20;
            celular.PrecioPorSegundo *= 0.95;
            ListarDatosCelular(celular);

            
            Computadora computadora = new Computadora(101, "Lenovo", "Negro", 1200);
            ListarDatosComputadora(computadora);
            computadora.PrecioDolares *= 0.90;
            ListarDatosComputadora(computadora);

            // clase Edificio bloque 

            Console.Write("Ingrese el código del departamento: ");
            int codigoEdificio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de departamentos: ");
            int numeroDepartamentos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de pisos: ");
            int cantidadPisos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio del departamento en $: ");
            double precioDepartamentoDolares = double.Parse(Console.ReadLine());

            Edificio edificio = new Edificio(codigoEdificio, numeroDepartamentos, cantidadPisos, precioDepartamentoDolares);

            ListarDatosEdificio(edificio);
            edificio.PrecioDepartamentoDolares *= 1.20;
            ListarDatosEdificio(edificio);

          // clase edificio bloque 


            Obrero obrero = new Obrero(1001, "Juan Pérez", 160, 25.0);
            ListarDatosObrero(obrero);
            obrero.HorasTrabajadas += 8;
            obrero.TarifaPorHora *= 0.985;
            ListarDatosObrero(obrero);

          
            Video video = new Video(1, "Película Ejemplo", 120.0, 100.0, 3.35);
            ListarDatosVideo(video);
            video.PrecioSoles += 5.50;
            ListarDatosVideo(video);

          
            Paciente paciente = new Paciente("Diego", "Rivera", 17, 1.79, 90.0);
            ListarDatosPaciente(paciente);
            paciente.Edad = 18;
            ListarDatosPaciente(paciente);

            // clase empleado bloque

            Console.Write("Ingrese el código del empleado: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el número de celular del empleado: ");
            int numeroCelular = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el sueldo en soles del empleado: ");
            double sueldoSoles = double.Parse(Console.ReadLine());

         
            Empleado empleado = new Empleado(codigo, nombre, numeroCelular, sueldoSoles);

            ListarDatosEmpleado(empleado);
            empleado.NumeroCelular = 999888777;
            empleado.SueldoSoles += 200;
            ListarDatosEmpleado(empleado);

            // clase empleado bloque

            Asesor asesor = new Asesor(1234, "Carlos Mendoza", 40, 50.0);
            ListarDatosAsesor(asesor);
            asesor.HorasTrabajadas += 10;
            asesor.TarifaPorHora *= 0.85;
            ListarDatosAsesor(asesor);

            Pelota pelota = new Pelota("Nike", 500.0, 8.0, 22.0, 100.0);
            ListarDatosPelota(pelota);
            pelota.Precio *= 0.75;
            pelota.DiametroEnCentimetros += 1.0;
            ListarDatosPelota(pelota);


            Console.ReadKey();
        }

        static void ListarDatosCelular(Celular celular)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Número: " + celular.Numero);
            Console.WriteLine("Usuario: " + celular.Usuario);
            Console.WriteLine("Segundos Consumidos: " + celular.SegundosConsumidos);
            Console.WriteLine("Precio por Segundo: " + celular.PrecioPorSegundo);
            Console.WriteLine("Costo por Consumo: " + celular.CostoPorConsumo());
            Console.WriteLine("Impuesto IGV: " + celular.ImpuestoIGV());
            Console.WriteLine("Total a Pagar: " + celular.TotalAPagar());
            Console.WriteLine("-----------------------------------");
        }

        static void ListarDatosComputadora(Computadora computadora)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Código: " + computadora.Codigo);
            Console.WriteLine("Marca: " + computadora.Marca);
            Console.WriteLine("Color: " + computadora.Color);
            Console.WriteLine("Precio en Dólares: $" + computadora.PrecioDolares);
            Console.WriteLine("Precio en Soles: S/. " + computadora.PrecioEnSoles());
            Console.WriteLine("Precio en Euros: " + computadora.PrecioEnEuros());
            Console.WriteLine("-----------------------------------");
        }

        static void ListarDatosEdificio(Edificio edificio)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Código: " + edificio.Codigo);
            Console.WriteLine("Número de Departamentos: " + edificio.NumeroDepartamentos);
            Console.WriteLine("Cantidad de Pisos: " + edificio.CantidadPisos);
            Console.WriteLine("Precio por Departamento en Dólares: $" + edificio.PrecioDepartamentoDolares);
            Console.WriteLine("Precio Total del Edificio en Dólares: $" + edificio.PrecioTotalEdificio());
            Console.WriteLine("-----------------------------------");
        }

        static void ListarDatosObrero(Obrero obrero)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Código: " + obrero.Codigo);
            Console.WriteLine("Nombre: " + obrero.Nombre);
            Console.WriteLine("Horas Trabajadas: " + obrero.HorasTrabajadas);
            Console.WriteLine("Tarifa por Hora: $" + obrero.TarifaPorHora);
            Console.WriteLine("Sueldo Bruto: $" + obrero.SueldoBruto());
            Console.WriteLine("Descuento AFP: $" + obrero.DescuentoAFP());
            Console.WriteLine("Descuento EPS: $" + obrero.DescuentoEPS());
            Console.WriteLine("Sueldo Neto: $" + obrero.SueldoNeto());
            Console.WriteLine("-----------------------------------");
        }

        static void ListarDatosVideo(Video video)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Código: " + video.Codigo);
            Console.WriteLine("Nombre del Video: " + video.NombreVideo);
            Console.WriteLine("Duración: " + video.Duracion + " minutos");
            Console.WriteLine("Precio en Soles: S/" + video.PrecioSoles);
            Console.WriteLine("Tipo de Cambio: $" + video.TipoCambio + " por Sol");
            Console.WriteLine("Precio en Dólares: $" + video.PrecioEnDolares());
            Console.WriteLine("-----------------------------------");
        }

        static void ListarDatosPaciente(Paciente paciente)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nombre: " + paciente.Nombre);
            Console.WriteLine("Apellido: " + paciente.Apellido);
            Console.WriteLine("Edad: " + paciente.Edad + " (" + paciente.EsMayorDeEdad() + ")");
            Console.WriteLine("Talla: " + paciente.Talla + " metros");
            Console.WriteLine("Peso: " + paciente.Peso + " kg");
            Console.WriteLine("-----------------------------------");
        }
        static void ListarDatosEmpleado(Empleado empleado)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Código: " + empleado.Codigo);
            Console.WriteLine("Nombre: " + empleado.Nombre);
            Console.WriteLine("Número de Celular: " + empleado.NumeroCelular);
            Console.WriteLine("Sueldo en Soles: " + empleado.SueldoSoles);
            Console.WriteLine("Verificación de Sueldo: " + empleado.VerificarSueldo());
            Console.WriteLine("-----------------------------------");
        }
        static void ListarDatosAsesor(Asesor asesor)
        {
            Console.WriteLine("Código: " + asesor.Codigo);
            Console.WriteLine("Nombre: " + asesor.Nombre);
            Console.WriteLine("Horas Trabajadas: " + asesor.HorasTrabajadas);
            Console.WriteLine("Tarifa por Hora: " + asesor.TarifaPorHora);
            Console.WriteLine("Sueldo Bruto: " + asesor.SueldoBruto());
            Console.WriteLine("Descuento: " + asesor.Descuento());
            Console.WriteLine("Sueldo Neto: " + asesor.SueldoNeto());
            Console.WriteLine("-----------------------------------");
        }
        static void ListarDatosPelota(Pelota pelota)
        {
            Console.WriteLine("Marca: " + pelota.Marca);
            Console.WriteLine("Peso en Gramos: " + pelota.PesoEnGramos);
            Console.WriteLine("Presión en Libras: " + pelota.PresionEnLibras);
            Console.WriteLine("Diámetro en Centímetros: " + pelota.DiametroEnCentimetros);
            Console.WriteLine("Precio: $" + pelota.Precio);
            Console.WriteLine("Radio: " + pelota.Radio() + " cm");
            Console.WriteLine("Volumen: " + pelota.Volumen() + " cm³");
            Console.WriteLine("Descuento: $" + pelota.Descuento());
            Console.WriteLine("Importe a Pagar: $" + pelota.ImporteAPagar());
            Console.WriteLine("-----------------------------------");
        }

    }
}
