// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

Console.WriteLine("Задайте натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

int sumNaturalNumbers (int m, int n)
{
  if (m==n)
  {
    return m;
  }
  else
  {
    return m+sumNaturalNumbers((m+1), n);
  }
}

Console.WriteLine($"Сумма натуральных чисел в заданном промежутке: {sumNaturalNumbers(m, n)}");
