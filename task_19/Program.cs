int[] array = new int[5];
int number = Convert.ToInt32(Console.ReadLine());
int flag = 0;
int leng = array.Length;
while (number > 0)
{
    array[leng - 1] = number % 10;
    number /= 10;
    leng--;
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] != array[array.Length - i - 1])
    {
        flag = 1;
    }
}
if (flag == 1)
{
    Console.WriteLine("Нет, это не палиндром.");
}
else
{
    Console.WriteLine("Да, это палиндром.");
}