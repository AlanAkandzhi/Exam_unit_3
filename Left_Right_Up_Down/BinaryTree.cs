using System;

public class BinaryTree {
    public Node Root { get; private set; }
    public int Sum { get; private set; }
    public int DeepestLevel { get; private set; }
    public int NodeCount { get; private set; }

    public BinaryTree(Node root) {
        Root = root;
    }

    public void Traverse(Node? node, int level = 1) {
        if (node == null) return;
        Sum += node.Value;
        NodeCount++;
        if (level > DeepestLevel) DeepestLevel = level;
        Traverse(node.Left, level + 1);
        Traverse(node.Right, level + 1);
    }
}
