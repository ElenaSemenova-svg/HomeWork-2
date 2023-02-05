// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetNumber()
{
    Random rdn = new Random();
    int result = rdn.Next(100, 1000);//диапазон
    Console.WriteLine($"Случайное число {result}");
    return result;//функция возвращает значение
}

int SecondDigit(int number)
{
int result = number %100;
int numberSecond = result/10;
return numberSecond;
}


int number = GetNumber();
int seconddigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {seconddigit}");
