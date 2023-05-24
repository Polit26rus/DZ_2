Console.Write("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 7 || num < 1) {
while(num > 7 || num < 1)
{
Console.Write("Ошибка,введите цифру дня недели: ");
num = Convert.ToInt32(Console.ReadLine());
}
}

if(num <= 7 && num > 5){
Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
