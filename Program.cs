using System;

namespace jurossimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("        Juros simples        ");
            Console.WriteLine("-----------------------------");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Insira um capital (R$): ");
            string capital = Console.ReadLine();
            Console.Write("Insira uma taxa de juros (%): ");
            string taxa = Console.ReadLine();
            Console.Write("Insira um tempo (meses): ");
            string tempo = Console.ReadLine();
            Console.WriteLine();

            Decimal c = Convert.ToDecimal(capital);
            Decimal i = Convert.ToDecimal(taxa);
            int t = Convert.ToInt32(tempo);
            Decimal j = c * (i / 100) *t;
            Decimal m = c + j;

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"O valor do juros é {j:N2} R$");
            Console.WriteLine($"O valor do montante é {m:N2} R$");
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine("Toque em uma tecla para encerrar o programa");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
