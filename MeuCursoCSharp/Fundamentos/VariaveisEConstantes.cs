using System;
using System.Collections.Generic;
using System.Text;

namespace MeuCursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferência

            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);


            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de Gols é " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é " + salario);
            
            int menorValorInt = int.MinValue; //Mais usado dos inteiros
            Console.WriteLine("Menor valor do inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A população brasileira é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado no mundo dos reais
            Console.WriteLine("Valor do mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
