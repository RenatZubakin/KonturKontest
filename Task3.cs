    namespace ConsoleApp;

    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            List<int[]> palletsList = new List<int[]>();
            for (int i = 0;i<n; i++)
            {
                var pallet = Console.ReadLine().Split().Skip(1).Select(int.Parse).ToArray();
                var len = pallet.Length;
                if (IsSorted(pallet) || len == 1) 
                {
                    if (pallet[0] > pallet[len - 1])
                    {
                        pallet = pallet.Reverse().ToArray();
                    }
                    palletsList.Add(pallet);
                }
            }

            if (palletsList.Count != n)
            {
                Console.WriteLine(-1);
                return;
            }
            else 
            { 
                var result = new List<int[]>();
                var lastValue = -1;
                palletsList = palletsList.OrderBy(pallet => pallet[0]).ToList();
                foreach(var pallet in palletsList)
                {
                    if (pallet[0] > lastValue)
                    {
                        result.Add(pallet);
                        lastValue = pallet[pallet.Length-1];
                    }
                    else 
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                }
                Console.WriteLine(String.Join(" ",result.SelectMany(arr=>arr)));
            }
      
        }

        static bool IsSorted(int[] pallet) 
        {
            HashSet<bool> result = new HashSet<bool>();
            for (int i = 1; i < pallet.Length; i++)
            {
                if (pallet[i] < pallet[i - 1]) 
                {
                    result.Add(true);
                }
                else if (pallet[i]> pallet[i - 1])
                {
                    result.Add(false);
                }
                else 
                {
                    return false;
                }
            }
            return result.Count==1;
        }

    }



