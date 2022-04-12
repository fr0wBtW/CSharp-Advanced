using System;

namespace GenericScale
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var scale1 = new EqualityScale<string>("Pesho", "Pesho");

            Console.WriteLine(scale1.AreEqual());

            //    var scale2 = new EqualityScale<int>(7, 7);
            //   Console.WriteLine(scale2.AreEqual());
        }
    }
}
