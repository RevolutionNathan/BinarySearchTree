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


        public void CreateNode(Node newNode)
        {
            Node currentNode = root;
            while (currentNode.value != newNode.value)
            {
                if (newNode.value > currentNode.value && (currentNode.right == null))
                {
                   currentNode.right = newNode;
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
          
        }
        



    }


}
