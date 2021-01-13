using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public enum PokemonType
    {
        Normal = 1,
        Grass,
        Fire,
        Water,
        Electric,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon
    }
    public class Pokemon
    {
        public string SpeciesName { get; set; }
        public string NickName { get; set; }
        public int Level { get; set; }
        public PokemonType Primary { get; set; }
        public PokemonType Secondary { get; set; }
        public string MoveOne { get; set; }
        public string MoveTwo { get; set; }
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }
        public int TeamPosition { get; set; }

        public Pokemon() { }

        public Pokemon(string speciesName, string nickName, int level, PokemonType primary, PokemonType secondary, string moveOne, string moveTwo, string moveThree, string moveFour, int teamPosition)
        {
            //TeamPosition = teamPosition;
            SpeciesName = speciesName;
            NickName = nickName;
            Level = level;
            Primary = primary;
            Secondary = secondary;
            MoveOne = moveOne;
            MoveTwo = moveTwo;
            MoveThree = moveThree;
            MoveFour = moveFour;
            TeamPosition = teamPosition;
        }
    }
}
