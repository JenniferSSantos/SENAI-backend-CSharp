using System;

namespace ExercicioRepitido
{
    class Program
    {
        static void Main(string[] args)
        {  int n1;

                Console.WriteLine("Digite um número:    ");
                n1 = int.Parse(Console.ReadLine());

                for(int ct = 1 ; ct <= n1; ct++){
                      if((ct % 5) == 0){
                        Console.WriteLine(ct);
                    }
                }
        }
    }
}
