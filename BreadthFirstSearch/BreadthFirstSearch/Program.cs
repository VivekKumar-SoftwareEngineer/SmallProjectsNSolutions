
namespace BreadthFirstSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree root = new Tree(10);
            Tree lev1c1 = new Tree(2);
            Tree lev2c1 = new Tree(42);
            Tree lev2c2 = new Tree(5);
            Tree lev3c3 = new Tree(1);
            Tree lev4c1 = new Tree(23);

            root.children[0] = lev1c1;
            lev1c1.children[0] = lev2c1;
            lev1c1.children[1] = lev2c2;
            lev2c2.children[1] = lev3c3;
            lev3c3.children[0] = lev4c1;

            BFS bfs = new BFS();
            bfs.BreadthFirstTraversal(root);
        }
    }
}
