/* Программа для сравнения трёх чисел - большего из них по отношению к каждому 
или равного между всеми. */
Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.WriteLine($"Первое число - больше второго {a} > {b}");
if (a == b)
Console.WriteLine($"В этом случае, первое и второе равны {a} = {b}");
if (b > a)
Console.WriteLine($"В этом случае, второе число больше первого {b} > {a}");
if (b > c)
Console.WriteLine($"Здесь второе - больше третьего {b} > {c}");
if (b == c)
Console.WriteLine($"Здесь второе и третье - равны  {b} = {c}");
if (c > b)
Console.WriteLine($"При этом сравнении - третье больше второго {c} > {b}");
if (a > c)
Console.WriteLine($"Тут видим, что первое - больше третьего {a} > {c}");
if (a == c)
Console.WriteLine($"Тут видим, что первое и третье равны {a} = {c}");
if (c > a)
Console.WriteLine($"Очевидно, что третье число больше первого {c} > {a}");
/*
else
Console.WriteLine($"А так - все числа равны: {a} = {b} = {c}");
Тут я бы хотел, чтобы при вводе трёх одинаковых чисел - программа показала сразу
 три числа в одну строку. Но не хватает навыков, чтобы это осуществить.*/
