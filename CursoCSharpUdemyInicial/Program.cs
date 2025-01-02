using System;
using System.Collections.Generic;

using CursoCSharpUdemyInicial.Fundamentos;

namespace CursoCSharpUdemyInicial
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}