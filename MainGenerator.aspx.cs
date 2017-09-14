using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace PokemonRandomName
{
    public partial class MainGenerator : System.Web.UI.Page
    {
        List<Pokemon> retrievedPokemon = null;
        List<int> pkmnIdNumbers = null;
        List<string> pkmnNames = null;

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            GrabPokemonInfo2();            
        }

        public void GrabPokemonInfo2()
        {
            if (pkmnIdNumbers == null)
            {
                CallDBOnce();
            }
            
            Random r = new Random();
            int startNumID = pkmnIdNumbers[0]; //pkmn from 1-9, indexes from 0-8
            int countNumID = pkmnIdNumbers.Count;
            int randomPick = r.Next((startNumID - 1), (countNumID)); //indexes need to go from [first value] to [final value +1] but we need the -1 to account for index 0

            if (pkmnIdNumbers != null)
            {
                pkmnIdNumbers.RemoveAt(randomPick);
            }
            else 
            {
                foreach (Pokemon p in retrievedPokemon)
                {
                    pkmnIdNumbers.Add(p.PokemonID);
                }
            }

            List<int> pickedNumbers = new List<int>();
            pickedNumbers.Add(randomPick);

            string chosenPokemon = pkmnNames[randomPick];
            lblPkmn.Text = chosenPokemon;
        }

        public void CallDBOnce ()
        {
            retrievedPokemon = PkmnDB.GetPokemonFromDB();
            pkmnIdNumbers = new List<int>();
            pkmnNames = new List<string>();
            foreach (Pokemon p in retrievedPokemon)  //each button click is refilling the list
            {
                pkmnIdNumbers.Add(p.PokemonID);
                pkmnNames.Add(p.PokemonName);
            }
        }
    }
}
