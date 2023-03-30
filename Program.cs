// Task 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int OneNumber(int num)
// {
//     int result = num / 10 % 10;
//     return result;
// }
// int randNumber = new Random().Next(100, 1000);
// int newNumber = OneNumber(randNumber);
// Console.WriteLine($" New version of {randNumber} is {newNumber} ");



// Task 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool WeekDay(int num)
// {
//     if(num >= 1 && num <= 5 || num > 7)
//     {
//         return false;
//     }
//     else
//     {
//         return true;
//     }
// }

// Console.Write("Введите день недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(WeekDay(num)); 



//Task 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Digit(int num)
{
    if(num < 100)
    {
        return -1;
    }
    else
    {
        while((num / 1000) > 1)
        {
            num = num / 10;
        }
    int digit3 = num % 10;
    return digit3;    
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (Digit(num) == -1) Console.Write("There is no third number!");
else Console.Write(Digit(num));
