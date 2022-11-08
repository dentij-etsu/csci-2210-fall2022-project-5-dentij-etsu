///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 5
// Description: Show a functional knowledge of tree structures
//
///////////////////////////////////////////////////////////////////////////////
namespace Project5;

public static class MauiProgram
{
    /// <summary>
    /// No clue what this is. VS generated it for GUI management purposes
    /// </summary>
    /// <returns> A created MauiApp object </returns>
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		return builder.Build();
	}
}
public class TreeNode<T>
{
    public T Data { get; set; }
    public List<TreeNode<T>> Children { get; private set; }
    public TreeNode<T> LeftChild { get; private set; }
    public TreeNode<T> RightChild { get; private set; }
    public bool HasRightChild = false;
    public bool HasLeftChild = false;

    public TreeNode(T data)
    {
        Data = data;
        //Children = new TreeNode<T>();
    }

    /// <summary>
    /// Sets a node object in the tree. This is a binary tree implementation
    /// and this sets the "Right" child for the node
    /// </summary>
    /// <param name="node"> Node object to be set </param>
    public void SetRightChild(TreeNode<T> node)
    {
        HasRightChild = true;
        RightChild = node;
    }

    /// <summary>
    /// Sets a node object in the tree. This is a binary tree implementation
    /// and this sets the "Left" child for the node
    /// </summary>
    /// <param name="node"> Node object to be set </param>
    public void SetLeftChild(TreeNode<T> node)
    {
        HasLeftChild = true;
        LeftChild = node;
    }
}

public class Tree<T>
{
    public TreeNode<T> Root { get; set; }

    /// <summary>
    /// Constructor for Tree class
    /// </summary>
    /// <param name="data"> Starting data to be the root of the tree </param>
    public Tree(T data)
    {
        this.Root = new TreeNode<T>(data);
    }
}
