namespace consoleApp1.algo
{
    public class Median
    {
        public int median(){
            List<int> a = new List<int>(){
                0, 1, 2, 4, 5, 6,3
            };
            a.Sort();

            var len = a.Count();
            var arrMiddle = (int)len/2;
            if (len % 2 == 0)
                return  Convert.ToInt32((a[arrMiddle-1]+a[arrMiddle])/2.0);
            else 
                return a[arrMiddle];

        }
    }
}