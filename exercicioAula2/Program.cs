using System;

namespace exercicioAula2
{
    class Program
    {
        static void Main(string[] args)
        {
             double salario, s1, d1;
            double resultado;

            Console.Write("Digite seu salário");
            salario = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da divida");
            d1 = Double.Parse(Console.ReadLine());

            
            if(salario > d1){
                Console.WriteLine("Positivo");
            }
            else{
                Console.WriteLine("Negativo");
            }
        }
    }
}
