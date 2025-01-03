﻿using System;

namespace CursoCSharpUdemyInicial.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom compotamento (S/N): ");
            entrada = Console.ReadLine();
            
            /*
            if (entrada == "s" || entrada == "S")
            {
                bomComportamento = true;
            }
            */

            // bomComportamento = entrada == "s" || entrada == "S";
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
