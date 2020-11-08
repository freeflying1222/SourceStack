using System;

namespace Dfg.YZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(new Room().Id); 
        }
    }


    public class Room
    {
        protected /*||*/ internal int Id { get; set; }
    }


}
