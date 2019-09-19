using System;

namespace exercicio2Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precototal;

            Console.Write("Digite o preço total:  ");
            precototal = Double.Parse(Console.ReadLine());

            if(precototal <= 100){
                precototal -=  25;
            }

            Console.Write(precototal);


        }
    }
}
