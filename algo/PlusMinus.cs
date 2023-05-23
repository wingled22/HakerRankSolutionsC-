using System.Numerics;

namespace consoleApp1.algo
{
    public class PlusMinus
    {
        public void PM(List<int> arr){
           int pos = 0, neg = 0, zer = 0;
           int len = arr.Count();
           for (int i = 0; i < arr.Count(); i++)
           {
                if(arr[i] > 0)
                    pos++;
                if(arr[i]<0)
                    neg++;
                if(arr[i] == 0)
                    zer++;
           }

            // Console.WriteLine(pos); 
            // Console.WriteLine(neg);
            // Console.WriteLine(zer);
            // Console.WriteLine("len : "+ len);
            

            Console.WriteLine(((double)pos/len).ToString("N6"));
            Console.WriteLine(((double)neg/len).ToString("N6"));
            Console.WriteLine(((double)zer/len).ToString("N6"));
        }
    }
}