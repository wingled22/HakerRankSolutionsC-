using System;
using consoleApp1.algo;

namespace consoleApp1{
    class Program
    {
        
        static void Main(string[] args)
        {
            MiniMaxSum mms = new MiniMaxSum();
            List<int> a = new List<int> (){
                {256741038},
                {623958417},
                {467905213},
                {714532089},
                {938071625},
            };
            mms.getMaxSum(a);
        }

    }
}