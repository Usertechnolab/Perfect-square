for (int number = 1; number <= 1000; number++)
{
    double sqrtResult = Math.Sqrt(number);
    if (sqrtResult == (int)sqrtResult)
    {
        Console.WriteLine(number);
    }
}