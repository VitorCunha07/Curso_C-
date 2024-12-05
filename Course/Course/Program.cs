using System;
using System.Globalization;

namespace Course 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeMaria = 32;
            double saldo = 150.47;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e {2} reais de saldo", nome, idadeMaria, saldo );

            Console.WriteLine($"{nome} tem {idadeMaria} anos e {saldo} reais de saldo");

            Console.WriteLine(nome + " tem " + idadeMaria + " anos e " + saldo + " reais de saldo ");


            Console.WriteLine("----------------------------------------");

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0 ;
            double preco2 = 650.50 ;
            double medida = 53.234567;

            
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é ${1}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é ${1}", produto2, preco2);

            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}",idade, codigo, genero);

            Console.WriteLine("Medida com 8 casas decimais: " + medida);
            Console.WriteLine("Arredondando (Três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------------------------");

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 3;
            Console.WriteLine(a);

            Console.WriteLine("----------------------------------------");

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("----------------------------------------");

            int b = 10;
            Console.WriteLine(b);

            b++;
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            Console.WriteLine("----------------------------------------");



            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string sp = Console.ReadLine();
            string[] v = sp.Split(' ');
            string aV = v[0];
            string bV = v[1];
            string cV = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(aV);
            Console.WriteLine(bV);
            Console.WriteLine(cV);

        }
    }
}