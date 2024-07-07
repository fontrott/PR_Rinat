try
{
    Console.Write("Введите сторону А первого треугольника: ");
    double sideA1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите сторону B первого треугольника: ");
    double sideB1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите сторону C первого треугольника: ");
    double sideC1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите сторону А второго треугольника: ");
    double sideA2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите сторону B второго треугольника: ");
    double sideB2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите сторону C второго треугольника: ");
    double sideC2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    if (sideA1 < 0 || sideB1 < 0 || sideC1 < 0 || sideA2 < 0 || sideB2 < 0 || sideC2 < 0)
    {
        Console.WriteLine("Стороны треугольника не могут быть отрицательными.");
        return;
    }
    double halfPerimeter1 = (sideA1 + sideB1 + sideC1) / 2;
    double halfPerimeter2 = (sideA2 + sideB2 + sideC2) / 2;
    double Area1 = Math.Sqrt(halfPerimeter1 * (halfPerimeter1 - sideA1) * (halfPerimeter1 - sideB1) * (halfPerimeter1 - sideC1));
    double Area2 = Math.Sqrt(halfPerimeter2 * (halfPerimeter2 - sideA2) * (halfPerimeter2 - sideB2) * (halfPerimeter2 - sideC2));
    Console.WriteLine($"Площадь первого треугольника: {Area1}");
    Console.WriteLine($"Площадь второго треугольника: {Area2}");
    switch (Area1 == Area2)
    {
        case true:
            Console.WriteLine("Треугольники равновеликие!");
            break;
        default:
            Console.WriteLine("Треугольники не равновеликие!");
            break;
    }
}
catch (FormatException fe) { Console.WriteLine("Ошибка!" , fe.Message); }
catch (Exception ex) { Console.WriteLine("Ошибка", ex.Message); }