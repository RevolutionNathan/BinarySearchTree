using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeConsole
{
    class AddSearchTree
    {
        Node root = new Node(0);
        
        int intToAdd;
        int searchInt;

        public void PlantRoot()
        {
            Console.Write("Enter the root int");
            string rootValue = Console.ReadLine();
            int rootInt = Int32.Parse(rootValue);
            root.value = rootInt;
        }

        public int GetIntToAdd()
        {
            Console.Write("Enter an int you want to add to the tree");
            string inputToAdd = Console.ReadLine();
            intToAdd = Int32.Parse(inputToAdd);
            return intToAdd;
        }

        public void CreateNode()
        {
            if (root == null)
            {

            }
            Node currentNode = root;
            while (currentNode != null)
            {
                
                if (intToAdd > currentNode.value && (currentNode.right == null))
                {
                    Node right = new Node(intToAdd);
                    currentNode.right = right;
                    AddOrSearch();
                }
                if (intToAdd > currentNode.value && (currentNode.right != null))
                {
                    currentNode = currentNode.right;
                }
                if (intToAdd < currentNode.value && (currentNode.left == null))
                {
                    Node left = new Node(intToAdd);
                    currentNode.left = left;
                    AddOrSearch();
                }
                if (intToAdd < currentNode.value && (currentNode.left != null))
                {
                    currentNode = currentNode.left;
                }
            }
                
        }

        public void AddOrSearch()
        {
            while (1 != 0)
            {
                Console.Write("add or search or stop?");
                string addSearch = Console.ReadLine();
                switch (addSearch)
                {
                    case "add":
                        GetIntToAdd();
                        CreateNode();
                        break;
                    case "search":
                        GetIntToSearchFor();
                        SearchBinaryTree();
                        break;
                    case "stop":
                        Console.Write("Stopping");
                        Console.ReadKey();
                        break;
                    default:
                        AddOrSearch();
                        break;
                }
            }
                
        }
        public int GetIntToSearchFor()
        {
            Console.Write("Enter the int you want to search for");
            string intSought = Console.ReadLine();
            searchInt = Int32.Parse(intSought);
            return searchInt;
        }
        public void SearchBinaryTree()
        {
            Node currentNode = root;
            while (currentNode !=null)
            {
                if (searchInt > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else if (searchInt < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if (currentNode.value == searchInt)
                {
                    Console.Write("Found " + searchInt);
                    AddOrSearch();
                    break;
                }
            }
            Console.Write("Not found");
        }

    }
}
