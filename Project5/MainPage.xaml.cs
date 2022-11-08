///////////////////////////////////////////////////////////////////////////////
//
// Author: Jackson Denti, dentij@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 5
// Description: Show a functional knowledge of tree structures
//
///////////////////////////////////////////////////////////////////////////////

namespace Project5;

public partial class MainPage : ContentPage
{
    TreeNode<string> currentNode;
    Tree<string> quizTree = new Tree<string>("Lets figure out what to eat tonight. Are you a Vegetarian?");

    /// <summary>
    /// The driving code for the MainPage.xaml file
    /// </summary>
    public MainPage()
	{
        // I don't know what this is, but VS put it there so I truse it needs to be here
		InitializeComponent();

        // Creates nodes of the tree with string data
        // The node variables are numbered with a zero based index in mind, with the root being 0
        TreeNode<string> node1 = new TreeNode<string>("Okay, but are you like REALLY a Vegetarian?");
        TreeNode<string> node2 = new TreeNode<string>("Okay, we are narrowing it down. Are you alergic to Shellfish?");
        TreeNode<string> node3 = new TreeNode<string>("Okay, that restricts us a bit. Are you a Vegan?");
        TreeNode<string> node4 = new TreeNode<string>("Okat, that opens us up. Do you like fish?");
        TreeNode<string> node5 = new TreeNode<string>("That is okay, I am too. Do you like steak?");
        TreeNode<string> node6 = new TreeNode<string>("Does Red Lobster sound like a nice date idea to you?");
        TreeNode<string> node7 = new TreeNode<string>("I don't know, I guess go eat some grass");
        TreeNode<string> node8 = new TreeNode<string>("Lets go hit up a nice salad bar");
        TreeNode<string> node9 = new TreeNode<string>("Lets go to a nice sushi bar");
        TreeNode<string> node10 = new TreeNode<string>("Lets just get a pizza delivered");
        TreeNode<string> node11 = new TreeNode<string>("Yay, lets go to a steakhouse");
        TreeNode<string> node12 = new TreeNode<string>("Cool, lets go to BBQ place.");
        TreeNode<string> node13 = new TreeNode<string>("Better grab your lobster cracking bib, we are going to red lobster.");
        TreeNode<string> node14 = new TreeNode<string>("Lets go munch down a nice plate of oysters Rockefeller");

        // Adds all the nodes to the tree
        quizTree.Root.SetLeftChild(node1);
        quizTree.Root.SetRightChild(node2);
        quizTree.Root.LeftChild.SetLeftChild(node3);
        quizTree.Root.LeftChild.SetRightChild(node4);
        quizTree.Root.RightChild.SetLeftChild(node5);
        quizTree.Root.RightChild.SetRightChild(node6);
        quizTree.Root.LeftChild.LeftChild.SetLeftChild(node7);
        quizTree.Root.LeftChild.LeftChild.SetRightChild(node8);
        quizTree.Root.LeftChild.RightChild.SetLeftChild(node9);
        quizTree.Root.LeftChild.RightChild.SetRightChild(node10);
        quizTree.Root.RightChild.LeftChild.SetLeftChild(node11);
        quizTree.Root.RightChild.LeftChild.SetRightChild(node12);
        quizTree.Root.RightChild.RightChild.SetLeftChild(node13);
        quizTree.Root.RightChild.RightChild.SetRightChild(node14);

        // The currentNode variable is used to manage where we are in the tree so the text can update correctly
        currentNode = quizTree.Root;
    }

    /// <summary>
    /// If the user clicks on the "No" button, it updates the text and current node to the correct node
    /// </summary>
    /// <param name="sender"> Object Calling method </param>
    /// <param name="e"> Event Args </param>
    private void OnNoClicked(object sender, EventArgs e)
    {
        if (currentNode.HasRightChild) currentNode = currentNode.RightChild;
        label.Text = currentNode.Data;
    }

    /// <summary>
    /// If the user clicks on the "No" button, it updates the text and current node to the correct node
    /// </summary>
    /// <param name="sender"> Object Calling method </param>
    /// <param name="e"> Event Args </param>
    private void OnYesClicked(object sender, EventArgs e)
    {
        if (currentNode.HasLeftChild) currentNode = currentNode.LeftChild;
        label.Text = currentNode.Data;
    }
    /// <summary>
    /// If the user clicks on the "Restart" Button, it sets the current node to the root of the tree
    /// </summary>
    /// <param name="sender"> Object Calling method </param>
    /// <param name="e"> Event Args </param>
    private void OnRestartClicked(object sender, EventArgs e)
    {
        currentNode = quizTree.Root;
        label.Text = currentNode.Data;
    }
}

