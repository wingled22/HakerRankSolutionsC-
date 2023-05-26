namespace consoleApp1.algo
{
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