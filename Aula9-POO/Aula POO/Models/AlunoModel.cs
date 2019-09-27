using System;

namespace Aula_POO.Models {
    public class AlunoModel {
        public string nome { get; set; }

        public string curso { get; set; }

        public string RA { get; set; }

        public int idade { get; set; }

        /// <summary>
        /// Shhhhhhhhhh
        /// </summary>
        public void Estudar () {
            Console.WriteLine ("Estou estudando");

        }


        /// <summary>
        /// pede para comer
        /// </summary>
        public void Pedir_Intervalo (){
            Console.WriteLine("Quero comer!!!!");
        }

        /// <summary>
        /// socorro ARIEL
        /// </summary>
        public void Ajuda(){
            Console.WriteLine("Ariel, não entendi nada. Me dá um HELP!!!");
        }

    }
}