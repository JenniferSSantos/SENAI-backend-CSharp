using System;

namespace Ex1Aula4 {
    class Program {
        static void Main (string[] args) {
            int[] valores = new int[10];
            double resultado;

            for (int i = 0; i <= 9; i++) {

                Console.Write ("Digite um número:  ");
                valores[i] = int.Parse(Console.ReadLine ());

        
            }
            
            for(int i = 0 ; i <= 9; i++){

                Console.WriteLine($"O valor é:   {valores[i]} ");
            }

            resultado = valores[9] * 5;
            
            Console.WriteLine(resultado);


        }
    }
}