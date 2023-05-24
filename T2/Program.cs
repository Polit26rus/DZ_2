Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


if(num < 100 && num > -100){
Console.WriteLine("Третьей цифры нет");
}
else{
if(num < 0){
num *= -1;
}
int a = 0;
while(num >= 100 || num <= -100){
a = num % 10;
num = num / 10;

}
Console.WriteLine($"Искомое число: {a}");
} 