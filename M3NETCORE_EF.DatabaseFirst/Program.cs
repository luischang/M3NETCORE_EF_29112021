using M3NETCORE_EF.DatabaseFirst.Models;
using System;
using System.Linq;

namespace M3NETCORE_EF.DatabaseFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var data = new QatarDBContext();

            var positions = data.PlayerPosition.ToList();

            foreach (var item in positions)
            {
                Console.WriteLine("The position is: " + item.Description);
            }


        }
    }
}
