class TreeNode
{
    public int Data; // Düğümde tutulan veri
    public TreeNode Left; // Sol çocuk
    public TreeNode Right; // Sağ çocuk

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}
class BinaryTree
{
    public TreeNode Root;

    public BinaryTree()
    {
        Root = null;
    }

    // Pre-order (Kök, Sol, Sağ)
    public void PreOrder(TreeNode node)
    {
        if (node == null) return;

        // Kök düğümü işle
        Console.Write(node.Data + " ");

        // Sol alt ağacı işle
        PreOrder(node.Left);

        // Sağ alt ağacı işle
        PreOrder(node.Right);
    }

    // In-order (Sol, Kök, Sağ)
    public void InOrder(TreeNode node)
    {
        if (node == null) return;

        // Sol alt ağacı işle
        InOrder(node.Left);

        // Kök düğümü işle
        Console.Write(node.Data + " ");

        // Sağ alt ağacı işle
        InOrder(node.Right);
    }

    // Post-order (Sol, Sağ, Kök)
    public void PostOrder(TreeNode node)
    {
        if (node == null) return;

        // Sol alt ağacı işle
        PostOrder(node.Left);

        // Sağ alt ağacı işle
        PostOrder(node.Right);

        // Kök düğümü işle
        Console.Write(node.Data + " ");
    }

}
class Program
{
    static void Main(string[] args)
    {
        // Ağaç oluşturma
        BinaryTree tree = new BinaryTree();
        tree.Root = new TreeNode(1);
        tree.Root.Left = new TreeNode(2);
        tree.Root.Right = new TreeNode(3);
        tree.Root.Left.Left = new TreeNode(4);
        tree.Root.Left.Right = new TreeNode(5);
        tree.Root.Right.Left = new TreeNode(6);
        tree.Root.Right.Right = new TreeNode(7);

        // Pre-order Dolaşma
        Console.WriteLine("Pre-order traversal:");
        tree.PreOrder(tree.Root); // 1 2 4 5 3 6 7
        Console.WriteLine();

        // In-order Dolaşma
        Console.WriteLine("In-order traversal:");
        tree.InOrder(tree.Root); // 4 2 5 1 6 3 7
        Console.WriteLine();

        // Post-order Dolaşma
        Console.WriteLine("Post-order traversal:");
        tree.PostOrder(tree.Root); // 4 5 2 6 7 3 1
        Console.WriteLine();
    }
}

