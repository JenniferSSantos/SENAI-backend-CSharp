using System;

namespace ExAula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string []nome =  new string[10];
            double []preco = new double[10];
            double []media = new double[10];
            int i = 0;
            
            string sair = "" ;

            while( sair != "0"){

                Console.WriteLine(@"Menu: 
                1- Cadastrar produto
                2- Listar produtos
                3- Fazer soma
                0- Para sair");

                    sair = Console.ReadLine();

                switch(sair){
                    
                    case"1":
                    
                    while (sair != "n" )
                    {
                        
                   
                        Console.Write("Digite um produto:    ");
                        nome[i] = Console.ReadLine();

                        Console.Write("Digite o valor do produto:   ");
                        preco[i] =Console.ReadLine();

                        if(nome[i] =  "" && preco[i] = null){

                            Console.WriteLine("Cadastro inválido! ");

                        }
                        else{
                            
                            Console.WriteLine("Cadastro realizado com sucesso!  ");

                        } 

                        Console.WriteLine("Deseja finalizar?  S/N ");                          
                        


                    }
                    
                    break;
                }


                
                
                 
                
            } 


            
        }
    }
}
