using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay23
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class Program
    {
        static Queue<Node> nodeQ = new Queue<Node>();
        static void levelOrder(Node root)
        {
            nodeQ.Enqueue(root);
            while (nodeQ.Count > 0)
            {
                var n = nodeQ.Dequeue();
                Console.Write(n.data + " ");
                if (n.left != null)
                    nodeQ.Enqueue(n.left);
                if (n.right != null)
                    nodeQ.Enqueue(n.right);
            }
        }
        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }



        static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
    }
}
