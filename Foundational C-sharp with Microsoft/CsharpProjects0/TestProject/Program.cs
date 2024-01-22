Random num = new Random();
int num1 = num.Next(1, 7);
int num2 = num.Next(1, 7);
int num3 = num.Next(1, 7);
int sum = num1 + num2 + num3;

Console.WriteLine($"Sum: {num1} + {num2} + {num3} = {sum}");
if ((num1 == num2) || (num1 == num3) || (num2 == num3))
{
    if ((num1 == num2) && (num2== num3))
    {
        Console.WriteLine("+6 bonus points, triples");
        sum += 6;
    }
    else
    {
        Console.WriteLine("+2 bonus points, doubles");
        sum += 2;
    }
}
if (sum >= 15)
{
    Console.WriteLine("YOU WON");
}
else
{
    Console.WriteLine("Sorry, try again");
}