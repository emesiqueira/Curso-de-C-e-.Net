using System;
using System.Collections.Generic;

using MeuCursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamento", Comentarios.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}