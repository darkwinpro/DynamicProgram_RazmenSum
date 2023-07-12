using System;

public class Program
{
    public static void Main()
    {
        int jump = 2;
        
        int steps = Convert.ToInt32(Console.ReadLine());
        steps++;
        ulong[] count = new ulong[steps];
        count[0] = 1;
        for (int i = 1; i < steps; i++)
        {
            int min = jump;
            if (i < jump)
            {
                min = i;
            }

            for (int j = 1; j <= min; j++)
            {
                count[i] += count[i - j];
            }
        }
        Console.WriteLine(count[steps - 1]);
    }
}