namespace ConsoleApp;

class Program
{
    static void Main()
    {
        var shapes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(bendsCounter(shapes[0]) + bendsCounter(shapes[1]));
    }
    static int bendsCounter(int num) 
    {
        var count = 0;
        while (num % 2 ==0) {
            num /= 2;
            count++;
        }
        return count;
    }
}



