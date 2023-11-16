namespace ConsoleApp;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var intervals = new int[n][];
        for (var i = 0; i < n; i++)
        {
            var interval = Console.ReadLine().Split().Select(int.Parse).ToArray();
            intervals[i] = interval;
        }
        intervals = intervals.OrderBy(x => x[0]).ToArray();

        var startInterval = intervals[0][0];
        var endInterval = intervals[0][1];

        var result = 0;
        
        foreach (var interval in intervals.Skip(1)) 
        { 
            if (endInterval >= interval[0])
            {
                if (endInterval < interval[1])
                {
                    endInterval = interval[1];
                }   
            }
            else 
            {
                result += endInterval - startInterval+1;
                startInterval = interval[0];
                endInterval = interval[1];
            }
        }
        result += endInterval - startInterval+1;
        Console.WriteLine(result);
    }
}



