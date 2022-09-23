Console.WriteLine("Введите номер задачи");
int exNum = int.Parse(Console.ReadLine());
if (exNum == 41)
{
    Console.WriteLine("Сколько чисел вы хотите ввести?");
    int m = int.Parse(Console.ReadLine());
    int k = 0;
    for (int i = 0; i < m; i++)
    {   try
        {
            Console.WriteLine($"Введите {i+1}-е число");
            double num = double.Parse(Console.ReadLine());
            if (num > 0) k += 1;
        }
        catch
        {
            i -= 1;
            Console.WriteLine("Вы вводите какую-то дичь");
        }
        

    }
    Console.WriteLine($"{k} из {m} чисел больше нуля");

} 
else if (exNum == 43)
{
    Console.WriteLine("Найдем координаты точки пересечения прямых. Введите значение k1");
    double k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение b1");
    double b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double k2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double b2 = double.Parse(Console.ReadLine());

    double[] crossCoords(double k1_, double k2_, double b1_, double b2_)
    {   
        double resultX = (b2_ - b1_) / (k1_ - k2_);
        double resultY = k1_ * resultX + b1_;
        double[] coords = {resultX, resultY};
        return coords;
    }
    if (k1 == k2) Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} параллельны");
    else
    {
        Console.WriteLine($"Координаты точки пересечения прямой y = {k1}x + {b1} и прямой y = {k2}x + {b2}:");
        Console.WriteLine($"({crossCoords(k1, k2, b1, b2)[0]}, {crossCoords(k1, k2, b1, b2)[1]})");
    }

}