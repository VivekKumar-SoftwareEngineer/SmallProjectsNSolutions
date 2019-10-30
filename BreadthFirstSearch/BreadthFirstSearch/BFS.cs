using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstSearch
{
    internal class BFS
    {
        internal void BreadthFirstTraversal(Tree tree)
        {
            if (tree == null)
                return;

            Queue<Tree> queue = new Queue<Tree>();
            queue.Enqueue(tree);

            while (queue.Count() > 0)
            {
                Tree node = queue.Dequeue();
                Console.Write(node.value + " ");
                foreach (Tree child in node.children)
                {
                    if (child != null)
                    {
                        queue.Enqueue(child);
                    }
                }
            }
        }
    }

    internal class Tree
    {
        internal int value;
        internal Tree[] children;

        internal Tree(int value)
        {
            this.value = value;
            children = new Tree[5];
        }
    }
}
