using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var brokenTree = new char[4, 9] {
                {'_', '*', '_', '_', '_', '_', '_', '_', '_'},
                {'*', '_', '_', '_', '*', '_', '*', '_', '_'},
                {'_', '*', '_', '_', '*', '*', '*', '_', '*'},
                {'*', '*', '_', '*', '*', '*', '*', '_', '*'}
            };

            TreePrinter.PrintTree(brokenTree);

            var treeFixer = new TreeFixer(brokenTree, '*', '_');

            TreePrinter.PrintTree(treeFixer.FixTree());

            Console.Read();
        }
    }
}
