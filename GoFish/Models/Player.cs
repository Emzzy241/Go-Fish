using System;
using System.Collections.Generic;
using GoFish.Models;

namespace GoFish.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Id { get; }
        private static List<Player> _players = new List<Player>(){};
        
        

        public Player(string playerName)
        {
            Name = playerName;
            _players.Add(this);
            Id = _players.Count;
        }

        public static List<Player> GetAllPlayers()
        {
            return _players;
        }

        public static void ClearAllPlayers()
        {
            _players.Clear();
        }
        
        
    }
}