using System;

namespace ExAula6_2CNPJ {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite seu CNPJ:");
            string cnpj = Console.ReadLine ();

            Console.WriteLine (validaCnpj (cnpj));
        }

        static bool validaCnpj (string cnpjUsuario) {

            bool resultado = false;
            int[] c1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cnpjCalculo = "";
            int resto = 0;
            int calculo = 0;

            string digito_c1 = "";
            string digito_c2 = "";

            cnpjCalculo = cnpjUsuario.Substring (0, 11);

            for (int i = 0; i <= 12; i++) {
                calculo += int.Parse (cnpjCalculo[i].ToString ()) * c1[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 11) {
                digito_c1 = "0";
            } else {
                digito_c1 = calculo.ToString ();
            }

            if (digito_c1 == cnpjUsuario[12].ToString ()) {
                resultado = true;
            }

            int[] c2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            resto = 0;

            cnpjCalculo = cnpjCalculo + calculo.ToString ();
            calculo = 0;

            for (int i = 0; i <= 11; i++) {
                calculo += int.Parse (cnpjCalculo[i].ToString ()) * c2[i];
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if (calculo > 11) {
                digito_c2 = "0";
            } else {
                digito_c2 = calculo.ToString ();
            }

            if (digito_c2 == cnpjUsuario[10].ToString ()) {
                resultado = true;
            }

            return resultado;
        }
    }

}