using M3NETCORE_EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //var position2 = new PlayerPosition()
            //{
            //    Description = "Lateral Izquiero",
            //    Code = "LI"
            //};

            //var position3 = new PlayerPosition()
            //{
            //    Description = "Mediocampista Ofensivo",
            //    Code = "MO"
            //};

            //var position4 = new PlayerPosition()
            //{
            //    Description = "Delantrero Central",
            //    Code = "DC"
            //};

            //var listPosition = new List<PlayerPosition>();
            //listPosition.Add(position2);
            //listPosition.Add(position3);
            //listPosition.Add(position4);

            //data.PlayerPosition.AddRange(listPosition);
            //data.SaveChanges();


            //var player1 = new Player()
            //{
            //    FullName = "Cristiano Ronaldo",
            //    Age = 34,
            //    PlayerPositionId = 4,
            //    Dorsal = 7                
            //};
            //var player2 = new Player()
            //{
            //    FullName = "Lionel Messi",
            //    Age = 33,
            //    PlayerPositionId = 3,
            //    Dorsal = 10
            //};
            //var player3 = new Player()
            //{
            //    FullName = "Neymar",
            //    Age = 29,
            //    PlayerPositionId = 4,
            //    Dorsal = 8
            //};
            //var playerList = new List<Player>();
            //playerList.Add(player1);
            //playerList.Add(player2);
            //playerList.Add(player3);

            //data.Player.AddRange(playerList);
            //data.SaveChanges();


            //Query by LINQ
            //var players = (from p in data.Player
            //               select p).ToList();

            //foreach (var item in players)
            //{
            //    Console.WriteLine("FullName: " + item.FullName);
            //}

            //var playerPosition = (from pl in data.Player
            //                      join pp in data.PlayerPosition on
            //                      pl.PlayerPositionId equals pp.Id
            //                      select new { PlayerName = pl.FullName, Position = pp.Description }).ToList();

            //foreach (var item in playerPosition)
            //{
            //    Console.WriteLine("Player: " + item.PlayerName + " | Position: " + item.Position);

            //}

            //var player = (from pl in data.Player
            //              where pl.Dorsal == 10
            //              select pl).FirstOrDefault();

            //Console.WriteLine("The player is: " + player.FullName);

            //Query lambda expressions

            //var players = data.Player.ToList();
            //var players = data.Player.Where(x => x.Age >= 30).ToList();
            //var players = data.Player.Where(x => x.Age >= 30).FirstOrDefault();

            //var players = data.Player
            //                .Include(z => z.PlayerPosition)
            //                .Where(x => x.Age >= 30)
            //                .ToList();

            //foreach (var item in players)
            //{
            //    Console.WriteLine("The player is: " + item.FullName 
            //                    + " | The code position is: " + item.PlayerPosition.Code);
            //}


            //Delete
            //var player = data.Player.Where(x => x.Age >= 30).FirstOrDefault();
            //data.Player.Remove(player);
            //data.SaveChanges();
            //Delete by Range
            //var players = data.Player.Where(x => x.Age >= 30).ToList();
            //data.Player.RemoveRange(players);
            //data.SaveChanges();

            //Update

            var player = data.Player.Where(x => x.Dorsal == 8).FirstOrDefault();

            player.Age = 27;

            data.SaveChanges();



            Console.WriteLine("Hello World!");
        }
    }
}
