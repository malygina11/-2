Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int number2 = number/10;
Console.WriteLine($"Ответ: {number2%10}");