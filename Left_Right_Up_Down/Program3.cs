using System;

class Task3 {
    static void Main() {
        Node root = new Node(67,
            new Node(765,
                new Node(167,
                    new Node(564, 
                        null,
                        new Node(379)
                    )
                )
            )
        );

        BinaryTree tree = new BinaryTree(root);
        tree.Traverse(tree.Root);
        Console.WriteLine($"Sum = {tree.Sum}");
        Console.WriteLine($"Deepest Level = {tree.DeepestLevel}");
        Console.WriteLine($"Nodes = {tree.NodeCount}");
    }
}
