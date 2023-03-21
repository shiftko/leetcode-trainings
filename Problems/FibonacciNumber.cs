namespace Problems;

public static class FibonacciNumber
{
    public static int Fib(int n)
    {
        var x = new List<int> { 0, 1 };

        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        while (n-- > 1)
        {
            x.Add(x[^1] + x[^2]);
        }

        return x[^1];
    }
}