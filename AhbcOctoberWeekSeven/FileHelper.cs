using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AhbcOctoberWeekSeven
{
   public static class FileHelper
    {
        public static void WriteToFile(string path, string text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(text);
            writer.Flush();
            writer.Close();
        }
        public static void AppendToFile(string path, string text)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(text);
            writer.Flush();
            writer.Close();
        }

        public static void AddPokemonToFile(string path,Pokemon pokemon)
        {
            StreamWriter writer = new StreamWriter(path, true);
            StringBuilder builder = new StringBuilder();
            builder.Append(pokemon.Name);
            builder.Append("|");
            builder.Append(pokemon.Type);
            builder.Append("|");
            builder.Append(pokemon.Attack);
            writer.WriteLine(builder.ToString());
            writer.Flush();
            writer.Close();
        }

        public static string ReadFirstLine(string path)
        {
            StreamReader reader = new StreamReader(path);
            string returnValue = reader.ReadLine();
            if (string.IsNullOrEmpty(returnValue))
            {
                return "no value";
            }
            else
            {
                return returnValue;
            }            
        }

        public static string ReadEnterFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            string returnValue = reader.ReadToEnd();
            return returnValue;
        }

        public static List<Pokemon> BuildPokemonList(string path)
        {
            List<Pokemon> pokemonList = new List<Pokemon>();
            using( StreamReader reader = new StreamReader(path))
            {
                string lineText;
                while((lineText = reader.ReadLine()) !=null)
                {
                    //if (string.IsNullOrEmpty(lineText.Trim()))
                    //{
                    //    continue;
                    //}
                    string[] items = lineText.Split('|');
                    if(items.Length != 3)
                    {
                        continue;
                    }

                    Pokemon pokemon = new Pokemon();
                    pokemon.Name = items[0];
                    pokemon.Type = items[1];
                    pokemon.Attack = items[2];
                    pokemonList.Add(pokemon);
                }

            }


            return pokemonList;
        }
    }
}
