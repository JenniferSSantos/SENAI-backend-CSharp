using System;

namespace Ex1Funcoes {
    class Program {

        static void Main (string[] args) {
            Console.Write ("Digite o valor do produto:   ");
            double B = double.Parse (Console.ReadLine ());

            Console.Write ("Digite o valor para ter o desconto:     ");
            double porcentagem = double.Parse (Console.ReadLine ());

            Console.Write($"Você vai pagar:  {desc (B, porcentagem)}");

        }
        static double desc (double B, double desconto) {

           double resultado = 0; double conta = 0;

           conta = (B * desconto) /100;
           resultado = conta;

           return resultado;



        }

    }

}
