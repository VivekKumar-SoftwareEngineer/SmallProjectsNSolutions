using System.Collections.Generic;

namespace InvertBinaryTree
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
    internal class Invert
    {
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
