Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Дз: Обробка некоректного формату числа");
Console.WriteLine("Введіть в консоль тільки число:");

try
{
int Numbers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ви ввели число - {Numbers}");
}
catch(FormatException)
{
    Console.WriteLine("Введений вами текст не є числом");
}