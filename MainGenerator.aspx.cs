using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PokemonRandomName
{
    public partial class MainGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            //Functioning Code 1.0
            Random r = new Random();
            int countDDLEntries = ddlPokemon.Items.Count;
            int randomPick = r.Next(0, (countDDLEntries - 1));
            ddlPokemon.SelectedIndex = randomPick;  //specify what I'm talking to, specify selected index that we're using
            //string pkmn = ddlPokemon.Text[randomPick].ToString();
            string pkmn = ddlPokemon.SelectedItem.ToString();
            lblPkmn.Text = pkmn;
        }

        //protected void NextLevelRandom2()
        //{
        //    Random r = new Random();
        //    List<int> storedInt = new List<int>(ddlPokemon.Items.Count);


        //    int countDDLEntries = ddlPokemon.Items.Count;
        //    int randomPick = r.Next(0, (countDDLEntries - 1));

        //    ddlPokemon.SelectedIndex = randomPick;
        //    string pkmn = ddlPokemon.SelectedItem.ToString();
        //    lblPkmn.Text = pkmn;
        //}
    }
}