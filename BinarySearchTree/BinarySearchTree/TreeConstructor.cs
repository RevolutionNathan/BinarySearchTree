using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeConstructor
    {

        Node root = new Node(0);
        Node newNode = new Node(0);
        int intToAdd;
        int searchInt;

        public int GetIntToAdd()
        {
            Console.Write("Enter an int you want to add to the tree");
            string inputToAdd = Console.ReadLine();
            int intToAdd = Int32.Parse(inputToAdd);
            return intToAdd;
        }

        public void CreateNode()
        {
            newNode.value = intToAdd;
            Node currentNode = root;
            while (currentNode.value != newNode.value)
            {
                if (newNode.value > currentNode.value && (currentNode.right == null))
                {
                    Node right = new Node(newNode.value);
                }
                if (newNode.value > currentNode.value && (currentNode.right != null))
                {
                    currentNode = currentNode.right;
                }
                if (newNode.value < currentNode.value && (currentNode.left == null))
                {
                    Node left = new Node(newNode.value);
                }
                if (newNode.value < currentNode.value && (currentNode.left != null))
                {
                    currentNode = root.left;
                }
            }
            AddOrSearch();
        }
        
        public void AddOrSearch()
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
        public int GetIntToSearchFor()
        {
            Console.Write("Enter the int you want to search for");
            string intSought = Console.ReadLine();
            int searchInt = Int32.Parse(intSought);
            return searchInt;
        }
        public void SearchBinaryTree()
        {
            Node currentNode = root;
            while (searchInt < currentNode.right.value && searchInt > currentNode.left.value)
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
                    break;
                }
                else if (currentNode.value != searchInt && (currentNode.left == null || currentNode.right == null))
                {
                    Console.Write(searchInt + " not found");
                    break;
                }
            }

            Console.Write("Found " + searchInt + "between " + currentNode.left.value + "and " + currentNode.right.value);
            AddOrSearch();
        }
        



    }


}
