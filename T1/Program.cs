Random rand = new Random();
int a = rand.Next(100,1000);
Console.WriteLine("Случайное число: {0}" , a);
a = a / 10;

Console.WriteLine($"Искомое число: {a % 10}");