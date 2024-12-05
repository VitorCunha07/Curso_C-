using System;
using System.Globalization;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu nome, altura e idade (na mesma linha): ");
            string[] infos = Console.ReadLine().Split(' ');

            string sobrenome = infos[0]; 
            float altura = float.Parse(infos[1]);
            int idade = int.Parse(infos[2]);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(idade);



        }
    }
}