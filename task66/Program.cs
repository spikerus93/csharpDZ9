// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int firstNumber, int secondNumber)
{
    if(firstNumber > secondNumber) return 0;
    return SumOfNumbers(firstNumber, secondNumber-1) + (secondNumber);
}

Console.Write(SumOfNumbers(M,N));