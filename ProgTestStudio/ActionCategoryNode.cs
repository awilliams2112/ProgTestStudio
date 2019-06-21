using System.Windows.Forms;

namespace ProgTestStudio
{
    public class ActionCategoryNode : TreeNode
    {
        public ActionCategoryNode(string displayName) : base(displayName)
        {

        }

        public ActionCategoryNode(string displayName, ActionTreeNode [] childrenNodes ) : base(displayName, childrenNodes)
        {

        }
    }
}
