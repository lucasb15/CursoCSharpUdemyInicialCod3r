using System;


namespace CursoCSharpUdemyInicial.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTrucada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTrucada);

            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado:{0}", idadeInteiro);

            Console.WriteLine("Digite o primeiro número");
            string palavra = Console.ReadLine();
            int primeiroNumero;
            int.TryParse(palavra, out primeiroNumero);
            Console.WriteLine("Resultado 1: {0}", primeiroNumero);

            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int segundoNumero);
            Console.WriteLine("Resultado 2: {0}", segundoNumero);
        }
    }
}