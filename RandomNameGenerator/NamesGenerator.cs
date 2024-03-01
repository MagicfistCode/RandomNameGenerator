using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNameGenerator
{
    public class NamesGenerator
    {
        public static string[] firstNames = {"Finn", "Jake", "Marceline", "Bonnibel" };
        public static string[] lastNames = { "Mertens", "Dog", "Abadeer", "Bubblegum" };
        public static string GenerateName()
        {
            var rand = new Random();
            string randomFirstName = firstNames[rand.Next(firstNames.Length)];
            string randomLastName = lastNames[rand.Next(firstNames.Length)];


            return $"{randomFirstName} {randomLastName}";
        }
    }
}
