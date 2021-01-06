using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;



namespace DataLibrary
{
    public static class DataAccess
    {
        public static List<Person> Read()
        {
            string file = File.ReadAllText("data.json");
            var people = JsonConvert.DeserializeObject<List<Person>>(file);

            return people;
        }
    }
}
