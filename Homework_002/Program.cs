//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if ((a > b) && (a > c)) 
{
    Console.WriteLine($"Наибольшее число {a}");
}
if ((b > a) && (b > c)) 
{
    Console.WriteLine($"Наибольшее число {b}");
}
if ((c > a) && (c > b))
{
    Console.WriteLine($"Наибольшее число {c}");
}