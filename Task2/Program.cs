// Программа для сравнения двух чисел - большего из них или равного друг другу.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите другое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.WriteLine($"Данное число {a} > {b}");
else if (a < b)
Console.WriteLine($"В этом случае {b} > {a}");
else
Console.WriteLine($"А эти числа равны: {a} = {b}");
