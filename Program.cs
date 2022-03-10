using Strings.Models;
using System;
using System.Text.RegularExpressions;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntroducaoRegex();
            IntroducaoEquals();
        }
        public static void IntroducaoEquals() {
            var gui = new Pessoa() {Id = 1,Nome = "Guilherme" };
            
            var pedro = new Pessoa() {Id = 2, Nome = "Pedro jose" };

            Console.WriteLine(pedro.Equals(2));
            
        }
        public static void IntroducaoRegex() {
            var frase1 = "Me ligue em 1234-4568";
            var frase2 = "Meu numero é 1234-4568 me liga";
            var frase3 = "Me ligue em 1234-4568 esse é meu numero";
            var padrao1 = "[123456789][123456789][123456789][123456789]-[123456789][123456789][123456789][123456789]";
            var padrao2 = "[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]";
            var padrao3 = "[0-9]{4}-[0-9]{4}";
            //var padrao4 = "[0-9]{4,5}-[0-9]{4}";
            //var padrao5 = "[0-9]{4,5}-?[0-9]{4}";
            Console.WriteLine(Regex.Match(frase1, padrao1));
            Console.WriteLine(Regex.Match(frase2, padrao2));
            Console.WriteLine(Regex.Match(frase3, padrao3));

            var url = "paginas?argumentos";
            var _substring = url.Substring(url.IndexOf("?") + 1);
            Console.WriteLine(_substring);

        }



    }
}
