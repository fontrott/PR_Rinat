using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Хотите продолжить? Y - да, N - нет: ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() == "Y")
            {
                try
                {
                    Console.Write("Введите положительное целое число п: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Число должно быть положительным!");
                        Console.Write("Введите положительное целое число п: ");
                        p = Convert.ToInt32(Console.ReadLine());
                    }
                    while (p < 0);
                    int fibonacci = Fibonacci(p);
                    Console.WriteLine("п-ое число Фибоначчи: " + fibonacci);
                }
                catch (FormatException fe) { Console.WriteLine(fe.Message); }
                catch (OverflowException ofe) { Console.WriteLine(ofe.Message); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
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
    static int Fibonacci(int p)
    {
        double phi = (1 + Math.Sqrt(5)) / 2;
        double psi = (1 - Math.Sqrt(5)) / 2;
        return (int)((Math.Pow(phi, p) - Math.Pow(psi, p)) / Math.Sqrt(5));
    }
}