using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do Raio");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio); // Como os métodos são estáticos, não precisa de instancia, podendo ser chamado direto pela classe 'Calculadora.'
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2") + "\nVolume: " + volume.ToString("F2") + "\nPi: " + Calculadora.Pi);

            Console.ReadLine();

        }
    }
}
