using System;

namespace Aula3 {
    class Program {
        static void Main (string[] args) {
            //Laço contado - for - incremento (+)
            for (int cont = 1; cont <= 100; cont++) {

                //     //verificamos se o número é diferente de par
                if (cont % 2 != 0) {
                    Console.WriteLine (cont);
                }
            }
            //LAÇO CONTADO - FOR - DECREMENTO (-)
            for (int cont = 100; cont >= 0; cont--) {

                //verificamos se o número é diferente de par
                if (cont % 2 != 0) {
                    Console.WriteLine ("FOR 100-0 -" + cont);
                }

                //LAÇO CONDICIONAL - WHILE

                double acumuladora = 0;
                double nota = 0;
                int cont = 0;
                string sair = "";

                while (sair != "Sair") {

                    Console.WriteLine ("Digite a nota de um aluno:   ");
                    nota = double.Parse (Console.ReadLine ());

                    acumuladora += nota;
                    acumuladora += acumuladora;
                    cont++;

                    Console.Write ("Deseja sair da aplicação? sim/não");
                    sair = Console.ReadLine ().ToLower ();

                }
                Console.WriteLine ("Média das notas:   " + (acumuladora / cont));

                do {

                
                
                
                
                
                } while ();
            }

        }
    }