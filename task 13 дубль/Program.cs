// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = N.ToString().Length;
if(count < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    for(int i = 0; N >= 1000; N = N /= 10, i++);
    Console.WriteLine(N%10);
}
//все оказалось проще)) надо было просто время подумать