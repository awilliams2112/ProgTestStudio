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
    public partial class Form1 : Form
    {
        public Form1()
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

            this.flowLayoutPanel1.Controls.Clear();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is ActionTreeNode)
                DoDragDrop(e.Item, DragDropEffects.Move);
            else
                return;
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move; 
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            ActionTreeNode actionTreeNode = (ActionTreeNode)e.Data.GetData(typeof(ActionTreeNode));
            
            if(this.flowLayoutPanel1.Controls.Count > 0 &&
               this.flowLayoutPanel1.Controls[this.flowLayoutPanel1.Controls.Count - 1] is UIAction)
            {
                this.flowLayoutPanel1.Controls.Add(new ArrowControl
                {
                    Size = new Size(152, 145)
                });
            }

            var uiAction = new UIAction
            {
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Location = new System.Drawing.Point(5, 5),
                Margin = new System.Windows.Forms.Padding(5),
                Name = "uiAction1",
                TabIndex = 0,
                DisplayName = actionTreeNode.Name,
                Size = new Size(306, 145),
            };

            uiAction.DoubleClick += (object sender1, EventArgs e1) =>
            {
                AddTask task = new AddTask();
                task.ShowDialog();
            };

            this.flowLayoutPanel1.Controls.Add(uiAction);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void uiAction1_DoubleClick(object sender, EventArgs e)
        {

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
