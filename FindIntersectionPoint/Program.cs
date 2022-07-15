/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
 
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; 5,5)*/
 
            
            // проверка чисел аргументов функции:
double GetNumber(string message)
{
    double result = 0;
    string errorMessage = ("Вы ввели не число. Введите корректное число.");
    while (true)
    {
    Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
 return result;
}
 //Ввод аргументов для проверки
double k1 = GetNumber("Введите множитель первой функции");
double k2 = GetNumber("Введите множитель второй функции");
double b1 = GetNumber("Введите слагаемое первой функции");
double b2 = GetNumber("Введите слагаемое второй функции");

//вычисление координат точки пересечения        
void Point(double a1, double a2, double c1, double c2)
{
    if(a1 != a2)
    {
        double x = (c2 - c1) / (a1 - a2);
        double y = a1 * x + c1;
        Console.WriteLine($"Точка пересечения прямых имеет координаты x = {x} ; y = {y}");
    }
    else
    {
        Console.WriteLine("Прямые параллельны и не пересекаются");
    }
               
}
Point(k1, k2, b1, b2); //Обращение к функции 
