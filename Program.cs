// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.WriteLine("Введите перовое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        System.Console.WriteLine(num1 + " максимальное число");
    }
}
else if (num2 > num3)
{
    System.Console.WriteLine(num2 + " максимальное число");
}
else if (num3 > num2)
{
    System.Console.WriteLine(num3 + " максимальное число");
}
else
{
    System.Console.WriteLine("Все числа равны");