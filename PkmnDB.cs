using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

[DataObject(true)]
public static class PkmnDB
{
    public static List<Pokemon> GetPokemonFromDB() //returns me a strongly typed list of Pokemon
    {
        List<Pokemon> GetPkmn = new List<Pokemon>();
        string sql = "SELECT PokemonID, PokemonName "
            + "FROM Pokemon2 ORDER BY PokemonID";
        using (SqlConnection con = new SqlConnection(GetConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();                
                Pokemon p;
                while (dr.Read())
                {
                    p = new Pokemon();
                    p.PokemonID = Convert.ToInt32(dr["PokemonID"]);
                    p.PokemonName = dr["PokemonName"].ToString();
                    GetPkmn.Add(p);
                }
                dr.Close();
            }
        }
        return GetPkmn;
    }  

    private static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings
            ["PKMNConnectionString"].ConnectionString;
    }
}