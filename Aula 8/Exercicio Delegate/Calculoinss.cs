using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Delegate
{
    public class Calculoinss
    {
        public delegate double CalcularInss(double salario);

        public void Executar()
        {
            Console.WriteLine("Entre com o seu sálario: ");
            var salario = Convert.ToDouble(Console.ReadLine());
            CalcularInss calcularInss;

            if (salario > 0 && salario < 1320)
            {
                calcularInss = CalcularFaixa1;

                Console.WriteLine(calcularInss(salario));
            }

            else if (salario > 1320 && salario < 2571.29)
            {
                calcularInss = CalcularFaixa2;

                Console.WriteLine(calcularInss(salario));
            }

            else if (salario > 2571.29 && salario < 3856.94)
            {
                calcularInss = CalcularFaixa3;

                Console.WriteLine(calcularInss(salario));
            }

            else if (salario > 3856.94 && salario < 7507.29)
            {
                calcularInss = CalcularFaixa4;

                Console.WriteLine(calcularInss(salario));
            }



        }
            public static double CalcularFaixa1(double salario)
            {

                var faixa1 = salario * 0.075;

                return faixa1;
            }

            public static double CalcularFaixa2(double salario)
            {

                var faixa2 = salario * 0.09;

                return faixa2;
            }

            public static double CalcularFaixa3(double salario)
            {

                var faixa3 = salario * 0.12;

                return faixa3;
            }

            public static double CalcularFaixa4(double salario)
            {

                var faixa4 = salario * 0.14;

                return faixa4;
            }
    }
}

