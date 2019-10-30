using System.Collections.Generic;

namespace InvertBinaryTree
{
    public class Program
    {
        internal class BinaryTree
        {
            internal int value;
            internal BinaryTree leftChild;
            internal BinaryTree rightChild;

            internal BinaryTree(int value)
            {
                this.value = value;
            }
        }

        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.leftChild = new BinaryTree(2);
            tree.rightChild = new BinaryTree(3);
            tree.leftChild.leftChild = new BinaryTree(4);
            tree.leftChild.rightChild = new BinaryTree(5);
            tree.rightChild.leftChild = new BinaryTree(6);

            Program p = new Program();
            p.InvertBTree(tree);
        }

        internal void InvertBTree(BinaryTree tree)
        {
            List<BinaryTree> queue = new List<BinaryTree>();
            queue.Add(tree);
            int index = 0;
            while (index < queue.Count)
            {
                BinaryTree current = queue[index];

                if (current.leftChild != null)
                    queue.Add(current.leftChild);
                if (current.rightChild != null)
                    queue.Add(current.rightChild);

                index += 1;
                SwapLeftAndRight(current);
            }
        }

        internal void SwapLeftAndRight(BinaryTree tree)
        {
            BinaryTree left = tree.leftChild;
            tree.leftChild = tree.rightChild;
            tree.rightChild = left;
        }
    }
}
