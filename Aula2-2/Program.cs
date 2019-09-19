using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Declaramos as notas que utilizaremos
        double nota1, nota2, nota3, media;

        //capturamos a 1º nota
        Console.Write("Digite sua primeira nota:");
        nota1 = double.Parse(Console.ReadLine());

         //capturamos a 2ºnota
        Console.Write("Digite sua primeira :");
        nota2 = double.Parse(Console.ReadLine());

         //capturamos a 3º nota
        Console.Write("Digite sua primeira nota:");
        nota3 = double.Parse(Console.ReadLine());

       //Calculamos a media das notas
        media = (nota1 + nota2 + nota3) / 3;

        //verificamos se a media do aulo é maior ou igual á 6
        if (media >= 6){
            Console.WriteLine ($"Média: {media} Aluno Aprovado!");

        } else{
            Console.WriteLine($"Média: {media} Aluno Reprovado");

        }




        }
    }
}
