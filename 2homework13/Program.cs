
int num = int.Parse(Console.ReadLine());
if (num / 100 == 0)
{
    Console.Write("третьей цифры нет");
}
else
{
    while (num != 0)
    {   
        if (num / 100 < 10)
        {
        Console.WriteLine(num % 10);
        break;
        }
        num = num / 10;
    }
}

