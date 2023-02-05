// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int NumberRequest(string message)
{
    Console.WriteLine(message);
    int number=Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

int GetThirdDigit(int number)
{
    int result = -1;
        
    if (number >= 100)
    {
        {
            while (number > 999)
                {
                    number = number / 10;
                }
           result = number % 10;
        }
    }
    return result;
}

int number1 = NumberRequest("Введите число: ");

if (GetThirdDigit(number1) == -1 )
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра {GetThirdDigit(number1)} в числе {number1}");