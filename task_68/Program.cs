/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


int Akkermann(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (m != 0 && n == 0) 
    {
        return Akkermann(m - 1, 1);
    }
    if (m > 0 && n > 0) 
    {
        return Akkermann(m - 1, Akkermann(m, n - 1));
    }
    return Akkermann(m, n);
}

int m = GetUserData("Введите число m: ");
int n = GetUserData("Введите число n: ");
int result = Akkermann(m, n);
Console.WriteLine("Результат равен: " + result);