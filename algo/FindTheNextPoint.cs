namespace consoleApp1.algo
{
    public class FindTheNextPoint
    {
        /*
            FindTheNextPoint p = new FindTheNextPoint();
            List<int> res = p.nextPoint(0,0,1,1);
            Console.WriteLine( String.Join(" ", res) );
            Console.WriteLine( String.Join(" ", p.nextPoint(1,1,2,2)) );
        
        */
        public List<int> nextPoint(int px, int py, int qx, int qy){


            int diffx = qx - px,
                diffy = qy - py;

            return new List<int>{
                qx+diffx,
                qy+diffy
            };

        }
    }
}