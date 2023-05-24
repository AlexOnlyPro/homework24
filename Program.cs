// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности 
// и на выходе показывает третью цифру слева этого числа или говорит,
//  что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = 0;
if (num >= 100)
{
    while (num >= 999)
    {
        num = num /10;
    }
    result = num % 10;
    System.Console.WriteLine(result);
}
else
System.Console.WriteLine("Нет");