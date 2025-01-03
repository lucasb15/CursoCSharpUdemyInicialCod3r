using System;

namespace CursoCSharpUdemyInicial.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preõ Desconto
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", totalComDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso + altura * altura;
            Console.WriteLine($"IMC é {imc}.");

            // Numero Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
