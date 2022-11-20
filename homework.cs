using System;
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

int [] InputAndShowNumbersInArray ()
{
    System.Console.WriteLine("How many numbers do you want to input?");
    int elements = Convert.ToInt32 (Console.ReadLine());
    int [] newArray = new int [elements];
    System.Console.WriteLine("What kind of?");

    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.WriteLine($"Your number '{i+1}' will be: ");
        newArray[i] = Convert.ToInt32 (Console.ReadLine());         
    }
System.Console.Write("You have input: ");
    for (int j = 0; j < newArray.Length; j++)
    {
        System.Console.Write(newArray[j]+", ");        
    }
    System.Console.WriteLine("\b\b. ");

    return newArray;
}

void CountingMoreThanZero (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Quantity of the possitive numbers is {count}");
}


int [] array = InputAndShowNumbersInArray();
CountingMoreThanZero (array);

// попытки остановить заполнение массива при нажатии клавишы esc https://learn.microsoft.com/ru-RU/dotnet/api/system.console.readkey?view=netcore-1.0
// не получается достать величину остановленного массива, возможно нужен динамический...
// int[] INIA (int[] collection) //нужен войд
// {
//     Console.WriteLine("Press the Escape (Esc) key to quit from filling array!");
//     int i = 0;
//     do
//     {
//         System.Console.WriteLine($"Number in the index possition '{i}' will be: ");
//         collection[i] = Convert.ToInt32(Console.ReadLine()); // некорректно работает
//         i++;
//     } while (Console.ReadKey().Key != ConsoleKey.Escape);
//     i = collection.Length;
//     return collection;
// }
// void ShowArray (int [] array)
// {
//     System.Console.Write("Your array is [");
// for (int i = 0; i<array.Length; i++)
// {
//     System.Console.Write(array[i]+ ", ");
// }
// System.Console.WriteLine("\b\b]");
// }

