namespace consoleApp1.algo
{
    public class TimeNoSig
    {
        public void tns(string s){
            TimeOnly t = TimeOnly.Parse("07:05:45PM");
            
            Console.WriteLine(t.ToString("HH:mm:ss"));
        }
    }
}