namespace Baekjoon_1991
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        void PrintPreorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.data + " ");
            PrintPreorder(node.left);
            PrintPreorder(node.right);
        }

        void PrintInorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintPreorder(node.left);
            Console.Write(node.data + " ");
            PrintPreorder(node.right);
        }

        void PrintPostorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintPreorder(node.left);
            PrintPreorder(node.right);
            Console.Write(node.data + " ");
        }

        public void PrintPreorder() { PrintPreorder(root); }
        public void PrintInorder() { PrintInorder(root); }
        public void PrintPostorder() { PrintPostorder(root); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i< N; i++)
            {
                var parts = Console.ReadLine().Split();
                char parent = parts[0][0];
                char left = parts[1][0];
                char right = parts[2][0];
            }

            tree.PrintPreorder();
            Console.WriteLine();

            tree.PrintInorder();
            Console.WriteLine();

            tree.PrintPostorder();
            Console.WriteLine();
        }
    }
}
