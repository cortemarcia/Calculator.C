using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class Calculator
    {
        public static void Calcular()
        {
            while (true)
            {
                // mensagens no console
                System.Console.WriteLine("Escolha a operação:");
                System.Console.WriteLine("1 - DIVISÃO");
                System.Console.WriteLine("2 - MULTIPLICAÇÃO");
                System.Console.WriteLine("3 - SOMA");
                System.Console.WriteLine("4 - SUBTRAÇÃO");
                System.Console.WriteLine("Digite o número");
                var op = System.Console.ReadLine();


                // declaração de valor de variáveis
                var a = 2;
                var b = 3;

                // lógica
                switch (op)
                {
                    case "1":
                        System.Console.WriteLine(Div(a, b));
                        break;

                    case "2":
                        System.Console.WriteLine(Mult(a, b));
                        break;

                    case "3":
                        System.Console.WriteLine(Soma(a, b));
                        break;

                    case "4":
                        System.Console.WriteLine(Sub(a, b));
                        break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                        break;
                }

                System.Console.ReadKey();
                System.Console.Clear();
            }
        }

        #region Metodos
        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static double Div(int a, int b)
        {
            return (double)a / b;
        }
        #endregion
    }
}
