/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetSumOfRange(int start, int finish)
{
    if(start == finish)
    {
        return start;
    }
    return start + GetSumOfRange(start + 1, finish);
}
int userNumberStart = GetUserData("Введите число М: ");
int userNumberFinsh = GetUserData("Введите число N: ");
int start = Math.Min(userNumberStart, userNumberFinsh);
int finish = Math.Max(userNumberStart, userNumberFinsh);
int range = GetSumOfRange(start, finish);
Console.Write("Сумма элементов диапазона равна: " + range);
