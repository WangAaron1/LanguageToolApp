using Sunny.UI;
using System.Windows.Forms;

public static class FrameHelper
{
    public static TreeNode CreateNewNode(this UINavMenu menu, string name, int symbol, int symbolSize, int index, UIPage page)
    {
        TreeNode node = menu.CreateNode(page);
        menu.SetNodeSymbol(node, symbol, symbolSize);
        menu.SetNodePageIndex(node, index);
        node.Text = name;

        return node;
    }

    public static TreeNode CreateNewNode(this UINavMenu menu, string name, int symbol, int symbolSize, int index)
    {
        TreeNode node = menu.CreateNode(name, symbol, symbolSize, index);
        return node;
    }

    public static TreeNode CreateNewChildNode(this UINavMenu menu, TreeNode parent, string name, int symbol, int symbolSize, int index, UIPage page)
    {
        TreeNode node = menu.CreateChildNode(parent, page);
        menu.SetNodeSymbol(node, symbol, symbolSize);
        menu.SetNodePageIndex(node, index);
        node.Text = name;

        return node;
    }
}