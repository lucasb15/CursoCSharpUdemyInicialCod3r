using System;

namespace CursoCSharpUdemyInicial.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // False
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // True
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // True
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // False
        }
    }
}
