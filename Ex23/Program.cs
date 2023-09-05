int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i<=a)
{   
    Console.WriteLine($"{i} | {Math.Pow(i,3)}");
    i = i + 1;
}
