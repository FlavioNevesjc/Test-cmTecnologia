using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questões de Logica - Teste CM Tecnologia\n\nQuestão 01\n");
            Console.Write("Digite um numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O quadrado do menor numero ("+num2+") é: "+ (Math.Pow(num2, 2)));
                Console.WriteLine("A Raiz Quadradada do maior numero (" + num1 + ") é: " + (Math.Sqrt(num1)));
            }
            else
            {
                Console.WriteLine("O quadrado do menor numero ("+num1+") é: " + (Math.Pow(num1, 2)));
                Console.WriteLine("A Raiz Quadradada do maior numero (" + num2 + ") é: " + (Math.Sqrt(num2)));
            }
          
            Console.WriteLine("\n\n\nQuestão 02\n");

            Console.Write("Digite seu ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(ano))
            {
                Console.WriteLine("O Ano " + ano + " é Bissexto");
            }
            else
            {
                Console.WriteLine("O Ano " + ano + " não é Bissexto");
            }
        }
    }
}
