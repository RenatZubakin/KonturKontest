namespace ConsoleApp;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var lampsArr = Console.ReadLine().Select(x => int.Parse(x.ToString())).ToList();

        var zeroCount = 0;
        var results = new List<int>();

        for (var i = n - 1; i >= 0; i--)
        {
            var a = lampsArr[i];
            if (lampsArr[i] == 0)
            {
                zeroCount += 1;
            }
            else
            {
                results.Add(zeroCount);
            }
        }

        var units_count = results.Count();
        if (units_count > 0)
        {
            var min = results.Select((count, index) => count + units_count - index - 1).Min();
            Console.WriteLine(min);
        }
        else Console.WriteLine(0);
    }

}



