// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

double d = Math.Log10(num);
double c = Math.Ceiling(d);
int razryad = Convert.ToInt32(c);

int stepen = 10;
for (int stat1 = 0; stat1<razryad-3; stat1++)
    {
        stepen = stepen * 10;
    }

int stepen2 = 10;
for (int stat2 = 0; stat2<razryad-4; stat2++)
    {
        stepen2 = stepen2 * 10;
    }

if (num == 100)
{
    System.Console.WriteLine("Третья цифра: 0");
}
else if (razryad == 3)
    {
        int num1 = num%stepen;
        System.Console.WriteLine($"Третья цифра: {num1}");
    }
else if (razryad > 3)
    {
        int num1 = num%stepen;
        int num2 = num1/stepen2;
        System.Console.WriteLine($"Третья цифра: {num2}");
    }
else
    System.Console.WriteLine("Третьей цифры нет!");