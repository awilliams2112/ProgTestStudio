using ProgTestStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.treeView1.ImageList = new ImageList();
            this.treeView1.ImageList.Images.Add("sql", Image.FromFile(Constants.Images.SqlActionIcon));
            this.treeView1.ImageList.Images.Add("rest", Image.FromFile(Constants.Images.RestActionIcon));

            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Base",
                    new ActionTreeNode []
                    {
                        new ActionTreeNode("SQL            ")
                        {
                            ImageKey = "sql"
                        },
                        new ActionTreeNode("Rest           ")
                        {
                            ImageKey = "rest"
                        },
                        new ActionTreeNode("Assert         ")
                        {
                            ImageKey = Constants.Images.AssertActionIcon
                        }
                    }),
            });

            this.treeView1.ExpandAll();

            this.tabControl1.TabPages.Clear();
            this.tabControl1.TabPages.Add(new TestTab());
        }

        #region private methods

        private void OpenProfileFile(string fileName)
        {
            using (var stream = File.OpenText(fileName))
            {
                string content = stream.ReadToEnd();
                
                //read file
            }
        }

        private void SaveProfileFile(string fileName)
        {
            File.WriteAllText(fileName, "sample test");
        }

        #endregion

        #region events

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
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Test Studio Projects |*.tsproj";

            var dialogResult = saveFileDialog1.ShowDialog();
            
            if(dialogResult == DialogResult.OK)
            {
                SaveProfileFile(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Test Studio Projects |*.tsproj";

            var dialogResult = openFileDialog1.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                OpenProfileFile(openFileDialog1.FileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutPage = new AboutForm();
            aboutPage.ShowDialog();
        }

        #endregion

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void selectedTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void RunTests()
        {
            //simulate test

            richTextBox1.Clear();

            richTextBox1.AppendText("Running Test Suite...\n\n");
            Application.DoEvents();
            

            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText("Running Test {TestName}...\n");
                Application.DoEvents();

                Thread.Sleep(500);
            }));

            richTextBox1.AppendText("Test {TestName} Passed\n\n");

            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText("Running Test {TestName}...\n");
                Application.DoEvents();

                Thread.Sleep(500);
            }));
            
            richTextBox1.AppendText("Test {TestName} Passed\n\n");
            
            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText("Running Test {TestName}...\n");
                Thread.Sleep(500);
                Application.DoEvents();
            }));

            richTextBox1.AppendText("Test {TestName} Passed\n\n");

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void powershellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCode exportCode = new ExportCode(Model.Constants.ExportCodeTypes.Powershell);

            exportCode.ShowDialog();
        }

        private void cSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCode exportCode = new ExportCode(Model.Constants.ExportCodeTypes.CSharp);

            exportCode.ShowDialog();
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
