using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOejer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> ListaDeEstudiantes = new List<Estudiante>();

            while (true)
            {
                Console.WriteLine("Cual es el nombre del estudiante (presiona Enter para salir): ");
                string nombre = Console.ReadLine();

                if (nombre.Equals(""))
                    break;

                Console.WriteLine("Cual es la Edad del estudiante:");
                string edad = Console.ReadLine();

                Console.WriteLine("Cual es el Carnet del estudiante:");
                string carnet = Console.ReadLine();

                Console.WriteLine("¿Esta solvente de pago? (si/no):");
                string solvente = Console.ReadLine();
                if (solvente.Equals("si", StringComparison.OrdinalIgnoreCase))
                {
                    solvente = "Si";
                }
                else if (solvente.Equals("no", StringComparison.OrdinalIgnoreCase))
                {
                    solvente = "No";
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Se considerará como 'No solvente'.");
                    solvente = "No";
                }

                Estudiante NuevoEstudiante = new Estudiante(nombre, edad, carnet, solvente);
                ListaDeEstudiantes.Add(NuevoEstudiante);
            }

            Console.WriteLine("\nLista de Estudiantes:");
            foreach (var estudiante in ListaDeEstudiantes)
            {
                estudiante.ImprimirLosDatos();
            }
            Console.ReadLine();
        }
    }
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Carnet { get; set; }
        public string Solvente { get; set; }

        public Estudiante(string nombre, string edad, string carnet, string solvente)
        {
            Nombre = nombre;
            Edad = edad;
            Carnet = carnet;
            Solvente = solvente;
        }

        public void ImprimirLosDatos()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Carnet: {2}, Solvente: {3}", Nombre, Edad, Carnet, Solvente);
        }

    }
}
