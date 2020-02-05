using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public static class Collections
    {
        public static object TrabalhandoComDico { get; internal set; }

        /// <summary>
        /// Arrays sao colecoes nao dinamicas, ou seja, nao se adiciona em tempo de execucao.
        /// </summary>
        public static void TrabalhandoComArray()
        {
            var nome = new string[5];
            nome[0] = "Marcia";
            nome[1] = "Diogo";
            nome[2] = "Leonam";
            nome[3] = "Gabriel";
            nome[4] = "Maria";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nome[i]);
            }

            System.Console.WriteLine("Passou aqui");
            System.Console.ReadKey();
        }
        public static void TrabalhandoComLista()
        {
            var nomes = new List<string>()
            {
            "Gabi",
            "tony"
            };
            while (true)
            {
                //Foreach--> tudo que ta na lista
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }
                System.Console.WriteLine("Informe o nome: ");
                // ReadLine --> Espere.
                var novo = System.Console.ReadLine();

                nomes.Add(novo);

                System.Console.Clear();
            }
        }
        public static void TrabalhandoComFila()
        {
            // Queue --> lista, com FIFO( First In e First Out)
            var nomes = new Queue<String>();
            nomes.Enqueue("Joana");
            nomes.Enqueue("Pedro");


            while (true)
            {
                //Foreach--> mostrar tudo que ta na lista
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }
                System.Console.WriteLine("Exclua alguem: ");
                // ReadLine --> Espere.

                //var novo = System.Console.ReadLine();
                // Novo  e Enqueue--> Adicionar na lista.
                //nomes.Enqueue(novo);

                System.Console.ReadKey();
                // Dequeue --> Ecxcluir da lista na ordem Fifo
                nomes.Dequeue();

                System.Console.Clear();
            }
        }

        public static void TrabalhandoComPilha()
        {

            var nomes = new Stack<String>();
            nomes.Push("Joana");
            nomes.Push("Pedro");


            while (true)
            {
                //Foreach--> mostrar tudo que ta na lista
                foreach (var n in nomes)
                {
                    System.Console.WriteLine(n);
                }
                System.Console.WriteLine("Exclua alguem: ");
                // ReadLine --> Espere.

                //var novo = System.Console.ReadLine();

                System.Console.ReadKey();

                nomes.Pop();

                System.Console.Clear();
            }


        }

        public static void TrabalhandoComDicionario()
        {
            var nomes = new Dictionary<string, int>();
            {
                nomes.Add("Joana", 24);
                nomes.Add("Marcia", 16);
                nomes.Add("Catharina", 19);

                //var resultado = nomes.First(item => item.Key == "Marcia");
                var resultado = nomes.First(item => item.Value == 16);

                //Ordenar por valor -->
                nomes
                    //.OrderBy(Item => Item.key)
                    .OrderBy(item => item.Value)
                    .ToList()
                    .ForEach(x => System.Console.WriteLine(x));


                        System.Console.WriteLine(resultado);
            }
            //Foreach--> mostrar tudo que ta na lista
            //foreach (var n in nomes)
            //{
            //    System.Console.WriteLine(n);
            //}


        }
        public static void FiltrandoLista()
        {
            //Criando uma lista
            var nomes = new List<string>()
            {
                "Marcia",
                "Amanda"
            };
            //Usando LinQ (SingleOrDefault) e Lambda(=>)
            //var resultado = nomes.SingleOrDefault(item => item == "Marcia");


            //Concatenacao-->
            //var resultado = nomes
            //    .Select(item => item == "Marcia" || item == "Amanda");

            //System.Console.WriteLine(resultado);


            //Ordenar Lista-->
            nomes
                .OrderByDescending(nome => nome)
                .ToList()
                .ForEach(nomes => System.Console.WriteLine(nomes));



        }
    }
}
