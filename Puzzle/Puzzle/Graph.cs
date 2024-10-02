using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    public class Graph
    {
        private static List<int> LstSo = new List<int>();
        public int F { get; set; }
        public static List<int> GetLstSo()
        {
            return LstSo;
        }
    }
}
