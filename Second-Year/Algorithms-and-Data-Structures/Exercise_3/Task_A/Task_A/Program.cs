// Calculate the Big O Notation

class Program
{
    static void Main(string[] args)
    {
        var timer = new System.Diagnostics.Stopwatch();
        // Section 1
        Console.Write("Please input n: ");
        double n = Convert.ToDouble(Console.ReadLine());
        int r = 20;
        int dummy = 0;
        timer.Start();
        for (int i = 0; i < n; i++)
        {
            dummy++;
            for (int j = 0; j < n; j++)
            {
                r = r + dummy;
            }
        }
        timer.Stop();
        Console.WriteLine($"Section 1 execution time: {timer.ElapsedMilliseconds}ms");

        // Section 2
        Console.Write("Please input m: ");
        double m = Convert.ToDouble(Console.ReadLine());
        timer.Restart();
        timer.Start();
        for (int i = 1; i <= m; i++)
        {

        }
        timer.Stop();
        Console.WriteLine($"Section 2, For loop execution time: {timer.ElapsedMilliseconds}ms");
        timer.Restart();
        timer.Start();
        while (m > 0)
        {
            m--;
        }
        timer.Stop();
        Console.WriteLine($"Section 2, While loop execution time: {timer.ElapsedMilliseconds}ms");

        Console.ReadKey();
    }
}