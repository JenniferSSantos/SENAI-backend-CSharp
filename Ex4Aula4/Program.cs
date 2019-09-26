using System;

namespace Ex4Aula4
{
    class Program 
    {
        static void Main(string[] args)
        {
            string[] A = new string [15];
            string[] B = new string [15];
            string[] C = new string [15];

            for(int i = 0; i <= 14; i++){
                Console.Write("Digite uma palavra:    ");
                A[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 14; i++){
                Console.Write("Digite outra palavra:      ");
                B[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 15; i++){

                if(i < 15){

                    C[i] = A[i];
                }
                else if(i > 14){
                    C[i] = B[i -14];
                }
                Console.WriteLine(C[i]);
            }



        }
    }
}
