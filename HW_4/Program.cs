// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.Write("Введите целое или вещественное число: ");
double num1 = Convert.ToInt32(Console.ReadLine());

double d = Math.Log10(num1);
double c = Math.Floor(d);
double razryad = Convert.ToInt32(c);

int stepen = 10;
for (int stat1 = 0; stat1<razryad-3; stat1++)
    {
        stepen = stepen * 10;
    }

int stepen2 = 10;
for (int stat2 = 0; stat2<razryad-2; stat2++)
    {
        stepen2 = stepen2 * 10;
    }

System.Console.WriteLine(stepen);
System.Console.WriteLine(stepen2);
System.Console.WriteLine(razryad);

double x1 = num1/stepen2;
double x2 = num1%stepen;
System.Console.WriteLine($"{x1}{x2}");