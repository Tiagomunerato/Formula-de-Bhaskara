using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;

            Console.Write("Informe o valor de A => ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B => ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C => ");
            c = int.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - (4 * a * c);

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);

            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Valor de Delta => " + delta);
            Console.WriteLine("Valor de X1 => {0:N}", x1);
            Console.WriteLine("Valor de X2 => {0:N}", x2);
            Console.ReadKey();


        }
    }
}
