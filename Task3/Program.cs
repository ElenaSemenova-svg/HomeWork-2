// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру обозначающую день недели");
int numberDayOfWeek=Convert.ToInt32(Console.ReadLine());

void GetDayOfWeek(int numberDayOfWeek)
{
if (numberDayOfWeek == 6 || numberDayOfWeek == 7)
{
    Console.WriteLine("Это выходной");
}

else if (numberDayOfWeek > 7 || numberDayOfWeek < 1 )
{
   Console.WriteLine("Число не является днем недели"); 
}

else 
{
    Console.WriteLine("Это будний день");
}
}

GetDayOfWeek(numberDayOfWeek);