using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrinaryTree
{
    public class Node
    {
        public Node(int value) { Data = value; }

        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Middle { get; set; }
        public Node Right { get; set; }
    }
    public class Trinary
    {
        public Node root;

        public Trinary()
        {
            root = null;
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return;
            }

            Node current = root;
            Node previous = null;

            while (current != null)
            {
                previous = current;

                if (value < current.Data)
                {
                    current = current.Left;
                }
                else if (value > current.Data)
                {
                    current = current.Right;
                }
                else
                    current = current.Middle;
            }

            if (value < previous.Data) previous.Left = newNode;
            else if (value > previous.Data) previous.Right = newNode;
            else previous.Middle = newNode;
        }

       
        public bool Delete(Node root, int value)
        {
            if (root == null) return false;
            Node current = root;
            Node Parent = null;

            while (current != null)         //Move to the node to be deleted
            {
                if (value > current.Data)
                {
                    Parent = current;
                    current = current.Right;
                }
                else if (value < current.Data)
                {
                    Parent = current;
                    current = current.Left;
                }
                else break;
            }


            if (current == null) return false;

            //Check if the val to be deleted occurs more 
            //than once , then delete the bottom most occurence of it
            if (current.Middle != null)
            {                                       //and return
                while (current.Middle != null)
                {
                    Parent = current;
                    current = current.Middle;
                }
                Parent.Middle = null;
                return true;
            }

            // If the node to be deleted has no child node.
            if (current.Left == null && current.Right == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else if (Parent.Left == current) 
                    Parent.Left = null;
                else 
                    Parent.Right = null;

                return true;
            }

            //If the node to be deleted has only one child
            if (current.Left == null)
            {
                if (current == root)
                {
                    root = current.Right;
                }
                else if (Parent.Left == current) 
                    Parent.Left = current.Right;
                else Parent.Right = current.Right;
            }
            else if (current.Right == null)
            {
                if (current == root)
                {
                    root = current.Left;
                }
                else if (Parent.Left == current) Parent.Left = current.Left;
                else Parent.Right = current.Left;
            }
            else  // If it has both left and right children.
            {
                Node ParentSuccessor = null;
                Node CurrentSuccessor = FindSuccessor(current.Right, ref ParentSuccessor);

                if (ParentSuccessor == null)
                {
                    current.Data = CurrentSuccessor.Data;
                    current.Right = CurrentSuccessor.Right;
                }
                else
                {
                    current.Data = CurrentSuccessor.Data;
                    ParentSuccessor.Left = CurrentSuccessor.Right;
                }
            }

            Display(root);

            return true;

        }

        Node FindSuccessor(Node Node, ref Node Parent)
        {
            if (Node == null)
            {
                Parent = null;
                return null;
            }

            Parent = null;

            while (Node.Left != null)
            {
                Parent = Node;
                Node = Node.Left;
            }

            return Node;
        }

        public void Display(Node node)
        {

            if (node != null)
            {
                Display(node.Left);
            }

            if (node != null)
            {
                Debug.WriteLine(node.Data);
            }

            if (node != null && node.Middle != null)
            {
                Display(node.Middle);
            }


            if (node != null && node.Right != null)
            {
                Display(node.Right);
            }

        }

    }

}

