using System;

namespace ExercicioAula3 {
    class Program {
        static void Main (string[] args) {
            //Exercicio 1          
            for (int cont = 1; cont <= 100; cont++) {
                Console.WriteLine ((cont * cont) * cont);

            }
            //Exercicio 2

            int tabuada = 1;
            Console.WriteLine ("Digite um número:      ");
            tabuada = int.Parse (Console.ReadLine ());
            for (int resultado = 1; resultado <= 10; resultado++) {
                Console.WriteLine (tabuada * resultado);

            }
            //Exercicio 3
            int n1;

            Console.WriteLine ("Digite um número:    ");
            n1 = int.Parse (Console.ReadLine ());

            for (int ct = 1; ct <= n1; ct++) {
                if ((ct % 5) == 0) {
                    Console.WriteLine (ct);
                }
            }
        }
    }
}