﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace MeuCursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
              CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R$ {salario}");

        }

    }
}
