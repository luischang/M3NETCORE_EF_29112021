using M3NETCORE_EF.CodeFirst.Models;
using System;
using System.Collections.Generic;

namespace M3NETCORE_EF.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var data = new MundialQatarDbContext();
            //Add PlayerPosition
            //var position1 = new PlayerPosition()
            //{
            //    Description = "Portero",
            //    Code = "PT"
            //};
            //data.PlayerPosition.Add(position1);
            //data.SaveChanges();
            //Add Range PlayerPosition
            var position2 = new PlayerPosition()
            {
                Description = "Lateral Izquiero",
                Code = "LI"
            };

            var position3 = new PlayerPosition()
            {
                Description = "Mediocampista Ofensivo",
                Code = "MO"
            };

            var position4 = new PlayerPosition()
            {
                Description = "Delantrero Central",
                Code = "DC"
            };

            var listPosition = new List<PlayerPosition>();
            listPosition.Add(position2);
            listPosition.Add(position3);
            listPosition.Add(position4);

            data.PlayerPosition.AddRange(listPosition);
            data.SaveChanges();







            Console.WriteLine("Hello World!");
        }
    }
}
