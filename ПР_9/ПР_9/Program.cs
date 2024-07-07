using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Начать работу программы? Y - да, N - нет: ");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    Console.WriteLine("Выберите способ ввода массива:");
                    Console.WriteLine("1. Ввести массив вручную");
                    Console.WriteLine("2. Сгенерировать случайный массив");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0)
                    {
                        Console.WriteLine("Выбор не может быть отрицательным!");
                        return;
                    }
                    int[] array;
                    int A;

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введите количество элементов в массиве: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            if (n < 0)
                            {
                                Console.WriteLine("Количество элементов не может быть отрицательным!");
                                return;
                            }
                            array = new int[n];
                            Console.WriteLine("Введите элементы массива:");
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("Введите элемент " + (i + 1) + ": ");
                                array[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        case 2:
                            Console.Write("Введите количество элементов в массиве: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            array = new int[n];
                            Random random = new Random();
                            for (int i = 0; i < n; i++)
                            {
                                array[i] = random.Next(-100, 101);
                                Console.WriteLine("Элемент " + (i + 1) + ": " + array[i]);
                            }
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Выход из программы.");
                            return;
                    }
                    Console.Write("Введите натуральное число А: ");
                    A = Convert.ToInt32(Console.ReadLine());

                    int count = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > 0 && array[i] <= A)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine("Количество положительных элементов, не превосходящих " + A + ": " + count);
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
            catch (FormatException fe) { Console.WriteLine(fe.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}