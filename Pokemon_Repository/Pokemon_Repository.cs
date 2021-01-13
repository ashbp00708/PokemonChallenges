using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>(6);
        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            if (_pokemonTeam.Count < 6)
            {
                _pokemonTeam.Add(pokemon);
            }
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(List<Pokemon>, int teamPosition)
        {

        }

        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updatedPokemon)
        {
            Pokemon oldPokemon = GetPokemonByTeamPosition(teamPosition);
            if (oldPokemon.TeamPosition => 6)
            {
                Pokemon pokemon = _pokemonTeam[teamPosition - 1];
                pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
                pokemon.PokemonNickName = updates.PokemonNickName;
                pokemon.Level = updates.Level;
                pokemon.PokemonType = updates.PokemonType;
                pokemon.SecondaryType = updates.SecondaryType;
                pokemon.MoveOne = updates.MoveOne;
                pokemon.MoveTwo = updates.MoveTwo;
                pokemon.MoveThree = updates.MoveThree;
                pokemon.MoveFour = updates.MoveFour;
            }
        }

        public void UpdatePokemonByNickName(string oldName, Pokemon newPokemon)
        {
            Pokemon oldPokemon = GetPokemonByName(oldName);
            if (oldPokemon != null)
            {
                oldPokemon.SpeciesName = newPokemon.SpeciesName;
                oldPokemon.NickName = newPokemon.NickName;
                oldPokemon.Level = newPokemon.Level;
                oldPokemon.Primary = newPokemon.Primary;
                oldPokemon.Secondary = newPokemon.Secondary;
                oldPokemon.MoveOne = newPokemon.MoveOne;
                oldPokemon.MoveTwo = newPokemon.MoveTwo;
                oldPokemon.MoveThree = newPokemon.MoveThree;
                oldPokemon.MoveFour = newPokemon.MoveFour;
                oldPokemon.TeamPosition = newPokemon.TeamPosition;
            }


        }
        public Pokemon GetPokemonByName(string name)
        {
            foreach (Pokemon pokemon in _pokemonTeam)
            {
                if (pokemon.NickName == name)
                {
                    return pokemon;
                }
            }
            return null;
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
