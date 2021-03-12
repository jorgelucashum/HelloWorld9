using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld9
{
    class Calculadora
    {
        // static:
        public static double Pi = 3.14; // ao se usar static a classe não precisa ser instanciada por um objeto, dessa forma tendo um valor estático/fixo toda vez que for chamada

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3 * Pi * r * r * r;
        } 
    }
}
