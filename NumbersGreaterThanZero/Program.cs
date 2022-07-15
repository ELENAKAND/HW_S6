/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
 
0, 7, 8, -2, -2 -> 2
 
1, -7, 567, 89, 223-> 3
*/
 
int GetNumber(string message) //Проверка числа, как и раньше
{
    int result = 0;
 
    string errorMessage = ("Вы ввели не число. Введите корректное число.");
        while (true)
        {
            Console.WriteLine(message);
 
            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Число меньше, либо равно 0.");
                    }
                        else
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

int GetNumber1(string message1) // проверка чисел массива
{
int result1 = 0;
 string errorMessage1 = ("Вы ввели не число. Введите корректное число.");
    while (true)
    {
        Console.WriteLine(message1);
        if (int.TryParse(Console.ReadLine(), out result1))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage1);
        }
    }
 return result1;
}
 
            //Ввод числа для проверки
int x = GetNumber("Введите  число элементов");
int[] arr = new int[x];//массив чисел
            //задаем числа:
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetNumber1($"Введите {i}-й элемент");
    }
int count = 0;//счетчик чисел больше 0
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + "\t");
            if (arr[j] > 0)
                count++;
    }
 
Console.WriteLine($"Число элементов больше 0 = { count}");







        

