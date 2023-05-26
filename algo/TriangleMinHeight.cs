namespace consoleApp1.algo
{
    public class TriangleMinHeight
    {
        public int minH(int trianglebase, int area){
            return (int)Math.Ceiling((double)2*area/trianglebase);
        }
    }
}