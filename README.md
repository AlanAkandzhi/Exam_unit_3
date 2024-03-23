# Exam_Unit_3 Overview 🎓

## 📝 Tasks and Solutions

### Task: Functions are a popping.

#### Objective 🎯
Create the following functions:

    A function that returns the square of a number
    A function that returns a length in mm assuming it has been given a length in inches.
    A function that returns the root of a number
    A function that returns the cube of a number
    A function that returns the area of a circle given the radius.
    A function that returns a greeting, given a name.

#### Solution 💡

#### Length in Millimeters

Given a length in inches, this function returns the equivalent length in millimeters.

```
public static double InchesToMillimeters(double inches)
{
    return inches * 25.4;
} 
```
#### Square Root of a Number

This function calculates and returns the square root of a given number.

```
public static double Root(double number)
{
    return Math.Sqrt(number);
}
```
#### Cube of a Number

This function returns the cube of the given number.

```
public static double Cube(double number)
{
    return Math.Pow(number, 3);
}
```
#### Area of a Circle

Given the radius of a circle, this function calculates and returns its area.

```
public static double CircleArea(double radius)
{
    return Math.PI * radius * radius;
}
```
#### Greeting

This function returns a greeting message for the given name.

```
public static string Greet(string name)
{
    return $"Hello, {name}!";
}
```

#### Usage

To use these functions, simply call them from your C# application with the appropriate parameters.

```
double square = Square(4);
double length = InchesToMillimeters(10);
double root = Root(16);
double cube = Cube(3);
double area = CircleArea(5);
string greeting = Greet("Christian");
```
### Task: Flatten those numbers.

#### Objective 🎯
In the file arrays.json there is an example of a an array that contains integers and possibly other arrays. If you need more test data you can get as many as you want from this source The task is to write a function that returns a flattened version of any such array structure.

NB! You might be tempted to use string manipulation, that is considered not solving the task. This is a jagged array of integers, not a string.

Example:

[
  435,
  2028,
  [
    [
      3047, 4910, 8146,
      7999, 1433, 7211,
      1197, 6002
    ],
    2821,
    3508
  ]
]
//--> 
[435, 2028, 3047, 4910, 8146, 7999, 1433, 7211, 1197, 6002, 2821, 3508]

#### Solution 💡
### FlattenArray Method

This function recursively traverses an array that may contain nested arrays of integers and flattens it into a single-dimensional array.

```
using System;
using System.Collections.Generic;

public class ArrayFlattener
{
    public static List<int> FlattenArray(object[] array)
    {
        List<int> flattened = new List<int>();
        foreach (var element in array)
        {
            if (element is int)
            {
                flattened.Add((int)element);
            }
            else if (element is object[])
            {
                flattened.AddRange(FlattenArray((object[])element));
            }
        }
        return flattened;
    }
}
```
### Usage

```
object[] jaggedArray = new object[]
{
    435,
    2028,
    new object[]
    {
        new object[] {3047, 4910, 8146, 7999, 1433, 7211, 1197, 6002},
        2821,
        3508
    }
};

List<int> flattenedArray = ArrayFlattener.FlattenArray(jaggedArray);
Console.WriteLine($"Flattened Array: [{string.Join(", ", flattenedArray)}]");
```
### Task: Left and right up and down, away we go.

#### Objective 🎯
In the file nodes.jsonthere is an example of a data structure that has a value of type integer, but also a left and right variable that could be a object of the same type. If you need more test data you can get as much as you want from this source

Calculate the sum of the full structure.
Report the deepest level of the structure.
Report the number of nodes.
```
{
  value: 67, // Level 1
  left: { value: 765, left: null, right: null }, // Level 2
  right: {
    value: 167, // Level 2
    left: {
      value: 564, // Level 3
      left: null,
      right: { value: 379, left: null, right: null } // Level 4
    },
    right: null
  }
}
// --> 
Sum = 1942
Deepest level = 4
Nodes = 5
```

#### Solution 💡

###Solution in C#

Define a class to represent a node in the tree:

### csharp
```
public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value, TreeNode left = null, TreeNode right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}
```
Then, implement methods to calculate the sum of values, the depth of the tree, and the number of nodes:

### csharp
```
public class BinaryTree
{
    public TreeNode Root { get; set; }

    public BinaryTree(TreeNode root)
    {
        Root = root;
    }

    public int CalculateSum(TreeNode node)
    {
        if (node == null) return 0;
        return node.Value + CalculateSum(node.Left) + CalculateSum(node.Right);
    }

    public int FindDepth(TreeNode node)
    {
        if (node == null) return 0;
        return 1 + Math.Max(FindDepth(node.Left), FindDepth(node.Right));
    }

    public int CountNodes(TreeNode node)
    {
        if (node == null) return 0;
        return 1 + CountNodes(node.Left) + CountNodes(node.Right);
    }
}
```
### Usage Example

Given the provided JSON structure, create the tree in C# and use the above methods to find the required information:


```
var root = new TreeNode(67,
    new TreeNode(765),
    new TreeNode(167, 
        new TreeNode(564, 
            null, 
            new TreeNode(379)),
        null));

var tree = new BinaryTree(root);

int sum = tree.CalculateSum(tree.Root);
int depth = tree.FindDepth(tree.Root);
int nodeCount = tree.CountNodes(tree.Root);

Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"Deepest level = {depth}");
Console.WriteLine($"Nodes = {nodeCount}");
```
This code snippet demonstrates how to initialize the tree with the given structure, and then calculates the sum of all node values, the depth of the tree, and the total number of nodes, producing the expected output:
```
Sum = 1942
Deepest level = 4
Nodes = 5
```
### Task: My books they are a mess.

#### Objective 🎯

1.Return only books starting with The
2.Return only books written by authors with a t in their name
3.The number of books written after 1992
4.The number of books written before 2004
5.Return the isbn number of all the books for a given author.
6.List books alphabetically assending or decendig
7.List books chronologically assending or decendig
8.List books grouped by author last name
9.Lits books grouped by author first name

#### Solution 💡
These books are presumably stored in a JSON file, but for the purposes of this example, let's assume that deserialized the JSON into a list of Book objects. Each Book object has properties such as Title, Author, PublicationYear, and ISBN.

First to define a Book class that represent the structure of a book:

```
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, int publicationYear, string isbn)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        ISBN = isbn;
    }
```
Implement the required functions:
```
    public int CountBooksAfter1992()
    {
        return Books.Count(book => book.PublicationYear > 1992);
    }

    public int CountBooksBefore2004()
    {
        return Books.Count(book => book.PublicationYear < 2004);
    }
    public IEnumerable<string> ISBNsByAuthor(string author)
```
