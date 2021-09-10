using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_tree
{
    public class TreePrinter
    {
        public static void PrintTree(char[,] tree)
        {
            for (int i = 0; i < tree.GetLength(0); i++)
            {
                for (int j = 0; j < tree.GetLength(1); j++)
                {
                    Console.Write(tree[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
