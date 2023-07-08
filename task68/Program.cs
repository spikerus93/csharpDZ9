// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n. 
// Пример, m = 2, n = 3 -> A(m,n) = 29

// 

Console.WriteLine("Ввведите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackkerman(int m, int n)
{
    if (m < 0 || n < 0)
        return -1;
    if (m == 0)
        return n + 1;
        else
    if (m > 0 && n == 0)
        return Ackkerman(m - 1, 1);
        else
        return Ackkerman(m - 1, Ackkerman(m, n - 1));
}
Console.Write(Ackkerman(m, n));