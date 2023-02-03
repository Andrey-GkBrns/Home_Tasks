// Программа для определения чётного и нечётного числа.
Console.Clear();
Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
Console.WriteLine($"Данное число {a} - чётное");
else
Console.WriteLine($"Данное число {a} - нечётное");
