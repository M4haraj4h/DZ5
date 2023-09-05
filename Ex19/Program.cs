
int a = Convert.ToInt32(Console.ReadLine());

if (a < 10000)
{
    Console.WriteLine("Число не пятизначное");
}
else if (a > 99999)
{
    Console.WriteLine("Число не пятизначное");  
}
else
{
    int a2 = a % 10;
    int a1 = (a % 100) / 10;
    int b1 = a / 10000;
    int b2 = (a / 1000) % 10;

    if(a2 == b1)
    {
        if(a1 == b2)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

