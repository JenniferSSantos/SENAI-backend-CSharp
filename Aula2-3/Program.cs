using System;

namespace Aula2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deixamos declaradas como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            //como já atribuimos anteriormente, mudamos o estado da variavel para verdadeira caso entre nessa
            if(idade > 17 ){
                entrada = true;

            }

            if ( entrada == true){
                retorno = "Entrada permitida!!";
            }else
            retorno = "Entrada não permitida :(";

            Console.WriteLine(retorno);




        }
    }
}
