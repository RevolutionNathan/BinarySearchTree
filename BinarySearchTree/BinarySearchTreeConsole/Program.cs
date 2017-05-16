using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AddSearchTree searchAddTree = new AddSearchTree();

            searchAddTree.PlantRoot();
            searchAddTree.AddOrSearch();
        }
    }
}
