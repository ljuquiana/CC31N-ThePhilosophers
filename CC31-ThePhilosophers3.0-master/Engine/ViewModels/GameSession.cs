using Engine.Model;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Secret";
            CurrentPlayer.CharacterClass = "Dyrad";
            CurrentPlayer.Hitpoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.Experiencepts = 0;
            CurrentPlayer.level = 1;

            CurrentLocation = new Location();
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = 0;
            CurrentLocation.Name = "Home";
            CurrentLocation.Description = "This is your home";


            CurrentWorld = new World();
        }



        public void MoveNorth()
        {
        }
        public void MoveEast()
        {
        }
        public void MoveSouth()
        {
        }
        public void MoveWest()
        {
        }
    }
}