using PlayerCounterApp.Domain;

namespace PlayerCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player sachin = new Player("Sachin", 55);
           // Console.WriteLine(sachin.Counter);

            Player virat = new Player("Virat", 38);
          //  Console.WriteLine(virat.Counter);

            Player rohit = new Player("Rohit", 37);
           
            Console.WriteLine(rohit.Counter);
            Console.WriteLine(sachin.Counter);
            Console.WriteLine(virat.Counter);



        }
    }
}
