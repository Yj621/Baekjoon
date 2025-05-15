namespace Baekjoon_1991
{
    public class Node
    {
        public char data;
        public Node left, right;

        public Node(char data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root;

        public void Add(char parent, char left, char right)
        {
            if(Root == null)
            {
                Root = new Node(parent);
            }
            Node pNode = Find(Root, parent);
            if (pNode == null) return;

            // left자리에 .이 없으면 left가 왼쪽 노드
            if (left != '.')
                pNode.left = new Node(left);
            if (right != '.')
                pNode.right = new Node(right);

        }

        private Node Find(Node node, char data)
        {
            if (node == null) return null;
            if (node.data == data) return node;

            //왼쪽에서 찾고, 못 찾으면 오른쪽에서 다시 탐색
            Node found = Find(node.left, data);
            if (found == null)
                found = Find(node.right, data);

            return found;
        }

        public void PrintPreorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.data);
            PrintPreorder(node.left);
            PrintPreorder(node.right);
        }

        public void PrintInorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintInorder(node.left);
            Console.Write(node.data);
            PrintInorder(node.right);
        }

        public void PrintPostorder(Node node)
        {
            if (node == null)
            {
                return;
            }
            PrintPostorder(node.left);
            PrintPostorder(node.right);
            Console.Write(node.data);
        }

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

                tree.Add(parent, left, right);  
            }

            tree.PrintPreorder(tree.Root);
            Console.WriteLine();

            tree.PrintInorder(tree.Root);
            Console.WriteLine();

            tree.PrintPostorder(tree.Root);
            Console.WriteLine();
        }
    }
}
