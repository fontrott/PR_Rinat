using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Начать работу программы? Y - да, N - нет: ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                PrintDiagonal(str);
            }
            else if (answer.ToUpper() == "N")
            {
                break;
            }
            else
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите Y или N.");
            }
        }
    }

    static void PrintDiagonal(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == i)
                {
                    Console.Write(str[j]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}