namespace consoleApp1.algo
{
    public class MiniMaxSum
    {
        /*
            MiniMaxSum mms = new MiniMaxSum();
            List<int> a = new List<int> (){
                {256741038},
                {623958417},
                {467905213},
                {714532089},
                {938071625},
            };
            mms.getMaxSum(a);
        */
        public void getMaxSum(List<int> arr){

            List<ulong> resultList = new List<ulong>();
            var skipIndex = 0;
            var len = arr.Count();
            ulong min, max;

            for (int i = 0; i < len; i++)
            {
                ulong tempSum = 0;
                for (int j = 0; j < len; j++)
                {
                    if(skipIndex != j){
                        tempSum = tempSum + (ulong)arr[j];
                    }

                }

                resultList.Add(tempSum);
                skipIndex++;
            }
            min = resultList.Min();
            max = resultList.Max();
            Console.WriteLine(string.Format("{0} {1}", min, max));
        }
    }
}