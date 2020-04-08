using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Data.CSV
{
    public static class CsvIO 
    {
        public static List<string> ReadCSVString(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}
