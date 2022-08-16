double[] array1 = new double[3];
double[] array2 = new double[3];
double sum = 0;
Console.WriteLine("Введите первую точку ");
for (int i = 0; i < 3; i++)
{
    array1[1] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите вторую точку");
for (int i = 0; i < 3; i++)
{
    array2[i] = Convert.ToDouble(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
{
    sum += Math.Pow(array1[i] - array2[i], 2);
}
Console.WriteLine(Math.Sqrt(sum));