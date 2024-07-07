using System;
using System.IO;

class Program
{
    static void Main()
    {
        bool continueProgram = true;
        try
        {
            while (continueProgram)
            {
                Console.Write("Начать работу программы? (Y/N): ");
                string startResponse = Console.ReadLine();

                if (startResponse.ToUpper() == "Y")
                {
                    Console.Write("Введите путь к файлу (например, C:\\Users\\ВашеИмя\\Desktop\\numbers.txt): ");
                    string filePath = Console.ReadLine();
                    Random random = new Random();

                    // Запросить у пользователя количество чисел и значение t
                    int n = GetPositiveInteger("Введите количество чисел (n): ");
                    double t = GetPositiveDouble("Введите значение t: ");

                    // Записать n случайных вещественных чисел в файл
                    WriteRandomNumbersToFile(filePath, n, random);

                    // Прочитать содержимое файла и вывести его на экран
                    double[] numbers = ReadNumbersFromFile(filePath, n);

                    // Найти произведение элементов с четными номерами, которые превосходят t
                    double product = 1;
                    bool found = false;

                    for (int i = 1; i < numbers.Length; i += 2) // Четные индексы в 0-базированном массиве
                    {
                        if (numbers[i] > t)
                        {
                            product *= numbers[i];
                            found = true;
                        }
                    }

                    if (found)
                    {
                        Console.WriteLine($"Произведение элементов с четными номерами, превосходящих {t}: {product:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"Нет элементов с четными номерами, превосходящих {t}.");
                    }
                }
                else if (startResponse.ToUpper() == "N")
                {
                    continueProgram = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите Y или N.");
                }
            }
        }
        catch (FormatException fe) { Console.WriteLine(fe.Message); }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }

    static int GetPositiveInteger(string message)
    {
        int value;
        do
        {
            Console.Write(message);
            if (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное целое число.");
            }
        } while (value <= 0);
        return value;
    }

    static double GetPositiveDouble(string message)
    {
        double value;
        do
        {
            Console.Write(message);
            if (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите положительное число.");
            }
        } while (value <= 0);
        return value;
    }

    static void WriteRandomNumbersToFile(string filePath, int n, Random random)
    {
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(filePath);
            for (int i = 0; i < n; i++)
            {
                double number = random.NextDouble() * (10.43 - (-10.78)) + (-10.78);
                writer.WriteLine(number);
            }
        }
        finally
        {
            if (writer != null)
            {
                writer.Close();
            }
        }

        Console.WriteLine($"Записано {n} случайных чисел в файл {filePath}.");
    }

    static double[] ReadNumbersFromFile(string filePath, int n)
    {
        double[] numbers = new double[n];

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл {filePath} не найден.");
            return numbers;
        }

        StreamReader reader = null;
        try
        {
            reader = new StreamReader(filePath);
            for (int i = 0; i < n; i++)
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    numbers[i] = double.Parse(line);
                    Console.WriteLine($"Число {i + 1}: {numbers[i]:F2}");
                }
                else
                {
                    Console.WriteLine($"Недостаточно данных в файле {filePath}.");
                    break;
                }
            }
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
        }

        return numbers;
    }
}
