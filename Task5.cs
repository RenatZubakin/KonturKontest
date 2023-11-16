namespace ConsoleApp;

class Program
{
    static void Main()
    {
       var  n = int.Parse(Console.ReadLine());
       var route1 = Console.ReadLine().Split().Select(int.Parse).ToList();
       var m = int.Parse(Console.ReadLine());
       var route2 = Console.ReadLine().Split().Select(int.Parse).ToList();

        var routsMatrix = new int[n, m];
        var maxI = 0;
        var maxLength = 0;
        for (var i = 0; i < n; i++)
            for ( var j = 0; j < m; j++)
            {
                if (route1[i] == route2[j])
                {
                    routsMatrix[i,j]= (i==0||j==0)? 1 : routsMatrix[i-1,j-1]+1;
                    if (routsMatrix[i, j] > maxLength) { 
                        maxLength = routsMatrix[i,j];
                        maxI = i;
                    }
                }
            }
        if(maxLength==0) 
        {
            Console.WriteLine(0);
        }
        else 
        { 
            var maxRoute = route1.Skip(maxI-maxLength+1).Take(maxLength);
            Console.WriteLine(maxLength);
            Console.WriteLine( String.Join(" ",maxRoute));
        }

    }
}



