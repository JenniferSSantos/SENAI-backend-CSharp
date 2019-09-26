using System;

namespace Aula6 {
    class Program {
        static void Main (string[] args) {
            // Chamamos a primeira função
            Console.WriteLine (BomDia ());

            // chamamos a função do tipo VOID (sem retorno)
            ImprimeDataHora ();

            //chamos a nossa função que calcula a média
            double[] numeros = { 2, 5, 2, 8, 9, 5 };
            Console.WriteLine (CalculaMedia (numeros));

            //chamamos a função de soma
            Console.WriteLine(CalculaMedia(numeros));
            
        }
        /// <summary>
        /// Função de escreve bom dia para o usuário
        /// </summary>
        /// <returns>Retorna Olá, bom dia!</returns>
        static string BomDia () {
            return "Olá, Bom dia!";

        }
        /// <summary>
        /// função que mostra uma saudação de acordo com o horario atual
        /// </summary>
        /// <param name="Saudacao">um texto qualquer (sobrecarga de metodo)</param>
        /// <returns>saudação de acordo com o horario</returns>
        static string BomDia (string Saudacao) {

            int hora = DateTime.Now.Hour;

            if (hora <= 12 && hora >= 6) {
                Saudacao = "Bom dia";

            } else if (hora > 12 && hora <= 18) {
                Saudacao = "Boa tarde";
            } else {
                Saudacao = "Boa noite";
            }

            return Saudacao;
        }

        /// <summary>
        /// retorna uma número - teste de sobrecarga
        /// </summary>
        /// <param name="numero">um número inteiro qualquer</param>
        /// <returns>número passado como parâmetro</returns>
        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        /// Retorna Data e Hora atuais
        /// </summary>
        static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour);
        }

        /// <summary>
        /// função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">vetor com valores</param>
        /// <returns>média dos valores</returns>
        static double CalculaMedia (double[] valores) {

            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado = resultado + valores[i];
            }
            resultado = resultado / valores.Length;

            return resultado;

        }

            /// <summary>
            /// calcula a soma de um vetor
            /// </summary>
            /// <param name="valores">vetor de doubles</param>
            /// <returns>soma de valores</returns>
        static double Calculasoma (double[] valores) {

            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado = resultado + valores[i];
            }
            resultado = resultado / valores.Length;

            return resultado;

        }

    }
}