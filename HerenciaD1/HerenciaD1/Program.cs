using System;

namespace HerenciaD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 128;
            double n2 = 8;
            Calculadora calc = new Calculadora("Casio", "fx=50");
            double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);
            double diferencia = calc.Restar(n1, n2);
            Console.WriteLine(diferencia);


            CalculadoraCientifica cientifica = new CalculadoraCientifica("Xiaomi", "CalX");
            double raiz = cientifica.Raiz(n1);
            Console.WriteLine(raiz);

            CalculadoraCientifica cientifica1 = new CalculadoraCientifica("Casio", "Fx991lax");
            double Logaritmo = cientifica.Logaritmo(n1);
            Console.WriteLine(Logaritmo);

            MostrarTipo(calc);
            MostrarTipo(cientifica); cientifica.Tipo(); 

            Console.ReadLine();

        }
        public static void MostrarTipo(Calculadora calculadora)
        {
            Console.WriteLine(calculadora.Tipo());
        }
    }
    public class Calculadora

    {
        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;

        }

        public  string Tipo()
        {
            return "Es Calculador Basica";
        }

    }

    public class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }
        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Raiz(double n1)
        {
            return Math.Sqrt(n1);

        }

        public double Modulo(double n1, double n2)
        {
            return (n1 % n2);

        }

        public double Logaritmo (double n1)
        {
            return Math.Log(n1);

        }
        
           
        public new virtual string Tipo()
        {
            return "Cientifica";
        }
    }
}
