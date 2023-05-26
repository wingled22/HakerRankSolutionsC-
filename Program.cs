using System;
using consoleApp1.algo;

namespace consoleApp1{
    class Program
    {
        
        static void Main(string[] args)
        {
            EvenOddQueries e = new EvenOddQueries();
            

            //Console.WriteLine(String.Join("\n", e.solve(new List<int> { 3, 2, 7, }, new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 2, 3 } })));
            Console.WriteLine(String.Join("\n", e.solve(new List<int> { 5, 3, 2,7,9,1,4,6  }, new List<List<int>> { new List<int> { 6, 8 }, new List<int> { 1, 3 } })));
        }   

    }
}