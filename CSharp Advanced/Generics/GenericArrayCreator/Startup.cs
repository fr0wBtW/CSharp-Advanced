using System;

namespace GenericArrayCreator
{
    class Startup
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator<string>.Create(5, "Pesho");
            int[] integers = ArrayCreator<int>.Create(10, 33);
        }
    }
}
