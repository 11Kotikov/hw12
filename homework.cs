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
    for (int k = 0; k < newArray.Length; k++)
    {
        System.Console.Write(newArray[k]+", ");        
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
//не решено:
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

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double FindXDot(double b1, double k1, double b2, double k2) //не считает. если в аргументы пишу int
// {
//     double x = ((b2 - b1) / (k1 - k2));
//     return x;
// }
// double FindYDot(double x, int b1, int k1) // а тут считает)))
// {
//     double y = ((k1 * x) + b1); // тут можно сделать проверку, добавив аргументов, если х - уже известен
//     return y;
// }

// void CheckingTheIntersected (double x, double y, int b1, int k1, int b2, int k2)
// {
// if (k1*x+b1==k2*x+b2)
// {
//     System.Console.WriteLine($"Your straight lines intersected at the point x:{x} and y:{y}");
// }
// else System.Console.WriteLine("Ooooops, your lines will never cross again...i'm really sorry, dude...wanna beer?");
// }

// System.Console.WriteLine("Input coordinate b1: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input coordinate k1: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input coordinate b2: ");
// int n3 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input coordinate k2: ");
// int n4 = Convert.ToInt32(Console.ReadLine());
// double x = FindXDot(n1, n2, n3, n4);
// double y = FindYDot(x, n1, n2);
// CheckingTheIntersected(x, y, n1, n2, n3, n4);