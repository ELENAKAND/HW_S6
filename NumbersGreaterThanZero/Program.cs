/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
 
0, 7, 8, -2, -2 -> 2
 
1, -7, 567, 89, 223-> 3
*/
 
 /*int GetNumber(string message)//Проверка числа, как и раньше
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
            // проверка чисел массива:
            int GetNumber1(string message1)
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
*/








                            //СЕМИНАР

/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int [] GetArray(int dimension)
{
    int [] arr = new int[dimension];
    Random randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1,10);
    }

return arr;
}
void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int [] ArrayReverse(int [] arr)
{
    int [] resultArray = new int[arr.Length];
    int count = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            resultArray[count] = arr[i];
            count++;
        }

return resultArray;
}
Console.WriteLine("Начальный массив: ");

int[] primaryArr = GetArray(6);
PrintArray(primaryArr);
Console.WriteLine();
Console.WriteLine("Конечный массив: ");
int[] resultArray = ArrayReverse(primaryArr);
PrintArray(resultArray);
Console.WriteLine();
Console.WriteLine("Начальный массив через Reverse(): ");
PrintArray(primaryArr.Reverse().ToArray());

        

