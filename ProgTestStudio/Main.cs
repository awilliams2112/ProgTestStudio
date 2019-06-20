using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Base",
                    new ActionTreeNode []
                    {
                        new ActionTreeNode("SQL            "),
                        new ActionTreeNode("Rest           "),
                        new ActionTreeNode("Saop           "),
                        new ActionTreeNode("Assert         ")
                    }),
            });

            this.tabControl1.TabPages.Clear();
            this.flowLayoutPanel1.Controls.Clear();
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is ActionTreeNode)
                DoDragDrop(e.Item, DragDropEffects.Move);
            else
                return;
        }
        
        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(new TestTab());
        }
    }

    public class ActionCategoryNode : TreeNode
    {
        public ActionCategoryNode(string displayName) : base(displayName)
        {

        }

        public ActionCategoryNode(string displayName, ActionTreeNode [] childrenNodes ) : base(displayName, childrenNodes)
        {

        }
    }

    public class ActionTreeNode: TreeNode
    {
        public ActionTreeNode(string displayName) : base(displayName)
        {

        }
    }
}
