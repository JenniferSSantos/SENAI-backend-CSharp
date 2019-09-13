using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //somente declaramos, sem atribuir valor
            int num1;

           //declaramos atribuindo um valor
            int num2 = 5;

            //declaramos diversas variáveis de varios tipos
            int num3,num4,num5;

           //variável do tipo decimal (real)
            float media;

            //variável do tipo lógico (booleana)
            bool resultado = false; 

           //variável do tipo texto (caracteres)
            string nomeAluno; 

            //quebra  de linha
           Console.WriteLine(); 
            
            //Escrever uma linha quabrando-a
            Console.WriteLine ("Bem vindo a nossa primeira aplicação!");

            //continua escrevendo na mesma linha
            Console.Write ("digite");
            Console.Write ("seu nome:");

            //capituro o dado digitado e salvo na variável 
            nomeAluno = Console.ReadLine();

            //Concatenação
            Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota:");

            //Converter o texto capturado para o tipo inteiro 
            num3 = int.Parse(Console.ReadLine());

            //interpolação 
            Console.WriteLine($"Sua primeira nota é {num3} ");


            Console.WriteLine("Digite sua segunda nota");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite sua terceira nota");
            num5 = int.Parse(Console.ReadLine());


            media = (num3 + num4 + num5) / 3;


            Console.WriteLine("Sua média é:" + media);








        }
    }
}
