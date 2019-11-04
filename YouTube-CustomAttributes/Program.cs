using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube_CustomAttributes
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var genreSciFi = GenreParser.Parse("Sci-Fi");
            var genreAsString = GenreParser.ToString(genreSciFi);
        }
    }
}
