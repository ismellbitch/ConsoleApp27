internal class Program
{
    private static void Main(string[] args)
    {
        int n = 0;
        for (int i = 0; i <=12; i++)
        {
            for(int j = 0; j <= 59; j++)
            {
                if (i == j * 5 && i > 0) { Console.WriteLine($"Часовая и минутная стрелка совпадают на времени {i}:{j}"); n++; break; }
            }
            if (n == 1) break;
        }

        n = 0;
        for (int i = 0; i <= 12; i++)
        {
            for (int j = 0; j <= 59; j++)
            {
                if (i * 20 == j && i > 0) { Console.WriteLine($"Часовая и минутная стрелка перпендикулярны на времени {i}:{j}"); n++; break; }
            }
            if (n == 1) break;
        }
    }
}