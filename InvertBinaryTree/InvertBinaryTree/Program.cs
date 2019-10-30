
namespace InvertBinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.leftChild = new BinaryTree(2);
            tree.rightChild = new BinaryTree(3);
            tree.leftChild.leftChild = new BinaryTree(4);
            tree.leftChild.rightChild = new BinaryTree(5);
            tree.rightChild.leftChild = new BinaryTree(6);

            Invert invert = new Invert();
            invert.InvertBTree(tree);
        }
    }
}
