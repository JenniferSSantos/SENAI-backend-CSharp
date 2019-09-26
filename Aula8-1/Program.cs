using System;

namespace Aula8_1 {
    class Program {
        static void Main (string[] args) {
            int numero;

            try {

                //escrevemos um bloco de códigos
                Console.WriteLine ("Digite um número:  ");
                numero = int.Parse (Console.ReadLine ());

            } catch (Exception ex) {

                //mostramos a exceção da regra
                //erro gerado na aplicação
                Console.WriteLine ("Ops :( Deu ruim. Erro:" + ex);
            }
        }
    }
}