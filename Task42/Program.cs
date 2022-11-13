// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//BinaryDigit(num);
Console.WriteLine($"{BinaryDigit(num)}  0  ");

int BinaryDigit(int number)
{
    
   int digit = number / 2;
    
    if (digit>0)
    {
        Console.Write($"{number%2}  ");
        return BinaryDigit(digit);
    }
    else return 1;
}

//chnya