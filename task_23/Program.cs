Console.WriteLine("Введите число ");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = 1;
while (number2 <= number1)
{
    Console.WriteLine(Math.Pow(number2, 3) + " ");
    number2++;
}
Console.WriteLine(" ");