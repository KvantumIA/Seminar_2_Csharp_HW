// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

double d = Math.Log10(num);
double c = Math.Floor(d);
int razryad = Convert.ToInt32(c);

int stepen = 10;
for (int stat1 = 0; stat1<razryad-2; stat1++)
    {
        stepen = stepen * 10;
    }

int stepen2 = 10;
for (int stat2 = 0; stat2<razryad-3; stat2++)
    {
        stepen2 = stepen2 * 10;
    }

System.Console.WriteLine(stepen);
System.Console.WriteLine(stepen2);
System.Console.WriteLine(razryad);

if (razryad > 3)
    {
        int num1 = num%stepen;
        int num2 = num1/stepen2;
        System.Console.WriteLine(num2);
    }
else
    System.Console.WriteLine("Третьей цифры нет!");