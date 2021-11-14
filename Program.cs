using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя.");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Выберите ваш символ.Пример ! @ # $ % ^ & * )... ");
            string symbol = Console.ReadLine();
            int symbolChek= Convert.ToInt32(symbol.Length);
            int symbolMax = 1;
            if (symbolChek > symbolMax)
            {
                while(symbolChek != symbolMax)
                {
                    Console.WriteLine("Введите один символ!!!!!!");
                    symbol = Console.ReadLine();
                    symbolChek = Convert.ToInt32(symbol.Length);
                }
            }

            int totalSymbalLine = Convert.ToInt32((nameInput.Length)) + 1;
            for (int symbolLineTop = 0; symbolLineTop < totalSymbalLine; symbolLineTop += 1)
            {
                Console.Write(symbol);

            }
            Console.WriteLine(symbol);
            
            Console.WriteLine($"{symbol}{nameInput}{symbol}");

            for (int symbolLineBottom = 0; symbolLineBottom < totalSymbalLine; symbolLineBottom += 1)
            {
                Console.Write(symbol);
            }
            Console.WriteLine(symbol);
        }
    }
}
