using System;

namespace BetterDecorator
{
    /// <summary>
    /// Classe que implementa o programa "Better Decorator".
    /// </summary>
    class Program
    {


        /// <summary>
        /// Função que recebe e formata uma string adicionando um determinado número de caracteres antes e depois desta.
        /// </summary>
        /// <param name="s">String a ser formatada.</param>
        /// <param name="dec">Caracter a ser introduzido.</param>
        /// <param name="num">Número de vezes que o caracter aparece antes e depois da string.</param>
        /// <returns>String formatada com o caracter definido.</returns>
        private static string Decor( string s , char dec , int num)
        {
            string aux = "";
            for(int i = 0;i < num;i++)
            {
                aux += dec;
            }
            return $"{aux} {s} {aux}";
        }
        
        /// <summary>
        /// Overload da função "Decor" para quando o utilizador não define argumentos.
        /// </summary>
        /// <returns>String indica que o utilizador não especificou os argumentos.</returns>
        private static string Decor() => Decor("User did not specify args!", '=', 3);

        /// <summary>
        /// Função que recebe os parâmetros de entrada e chama a função "Decor" com estes.
        /// </summary>
        /// <param name="args">Parâmetros de entrada do programa.</param>
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
                string s = args[0];
                char dec = args[1][0];
                int num = int.Parse(args[2]);
                Console.WriteLine(Decor(s, dec, num));
            }
        }
    }
}
