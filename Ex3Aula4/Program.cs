using System;

namespace Ex3Aula4 {
    class Program {
        static void Main (string[] args) {
            string[] nproduto = new string[12];
            string[] cor = new string[12];
            int[] tamanho = new int[12];
            double[] preco = new double[12];

            for (int i = 0; i <= 11; i++) {

                Console.Write ("Digite o nome do produto:   ");
                nproduto[i] = Console.ReadLine ();

                Console.Write ("Digite a cor:    ");
                cor[i] = Console.ReadLine ();

                Console.Write ("Digite o tamanho:    ");
                tamanho[i] = int.Parse (Console.ReadLine ());

                Console.Write ("Digite o preço:     ");
                preco[i] = double.Parse (Console.ReadLine ());

            }
            for (int i = 0; i <= 11; i++){
                Console.WriteLine(nproduto[i]);
                Console.WriteLine(cor [i]);
                Console.WriteLine(tamanho[i]);
                Console.WriteLine(preco[i]);

            }
        }
    }
}