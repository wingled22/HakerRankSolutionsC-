namespace consoleApp1.algo
{

    //EvenOddQueries e = new EvenOddQueries();
    //Console.WriteLine(String.Join("\n", e.solve(new List<int> { 3, 2, 7, }, new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 } })));
    //Console.WriteLine(String.Join("\n", e.solve(new List<int> { 5, 3, 2,7,9,1,4,6  }, new List<List<int>> { new List<int> { 6, 8 }, new List<int> { 1, 3 } })));
    public class EvenOddQueries
    {


        public List<string> solve(List<int> arr , List<List<int>> queries){
            List<string> res = new List<string>();

            foreach (var q in queries)
            {
                int a = q.ElementAt(0), b = q.ElementAt(1), t = arr.Count;
                Console.WriteLine("{0} {1} {2}", a,b,t);
                if(a != b && a < t && arr[a] == 0)
                    res.Add("Odd");
                else if(arr[a-1]%2 == 0)
                    res.Add("Even");
                else
                    res.Add("Odd");
            }

            return res;
        }
    }
}