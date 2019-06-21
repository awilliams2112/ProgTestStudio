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

            this.treeView1.ImageList.Images.Add("blank", Image.FromFile(Constants.Images.Transparent));
            this.treeView1.ImageList.Images.Add("sql", Image.FromFile(Constants.Images.SqlActionIcon));
            this.treeView1.ImageList.Images.Add("rest", Image.FromFile(Constants.Images.RestActionIcon));
            this.treeView1.ImageList.Images.Add("assert", Image.FromFile(Constants.Images.AssertActionIcon));
            this.treeView1.ImageList.Images.Add("custom", Image.FromFile(Constants.Images.CustomActionIcon));

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
                            ImageKey = "assert"
                        }
                    }),
                new TreeNode("Custom",
                    new ActionTreeNode []
                    {
                        new ActionTreeNode("Send Email            ")
                        {
                            ImageKey = "custom"
                        },
                        new ActionTreeNode("Send Text          ")
                        {
                            ImageKey = "custom"
                        },
                        new ActionTreeNode("Create Application            ")
                        {
                            ImageKey = "custom"
                        },
                        new ActionTreeNode("Create Lease           ")
                        {
                            ImageKey = "custom"
                        },
                        new ActionTreeNode("Update Client         ")
                        {
                            ImageKey = "custom"
                        }
                    })
            });
            
            this.treeView1.ExpandAll();

            this.tabControl1.TabPages.Clear();
            this.tabControl1.TabPages.Add(CreateTab(false));
        }

        #region private methods

        private void OpenProfileFile(string fileName)
        {
            using (var stream = File.OpenText(fileName))
            {
                string content = stream.ReadToEnd();
                
                //read file
            }

            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(CreateTab(true));
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];

        }

        private TestTab CreateTab(bool setdefault)
        {
            TestTab newTab;
            if (setdefault)
            {
                newTab = new TestTab(setdefault);
            }
            else
            {
                newTab = new TestTab();
            }

            newTab.OnCreateCustomAction = (name) =>
            {
                treeView1.Nodes[1].Nodes.Add(new ActionTreeNode(name)
                {
                    ImageKey = "custom"
                });
            };

            return newTab;

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

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
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
            Save();
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

            this.Invoke(new Action(() =>
            {
                richTextBox1.AppendText("Building... \n\n");
                Application.DoEvents();

                Thread.Sleep(1000);

                Application.DoEvents();

            }));

            richTextBox1.AppendText("Running Suite...\n\n");
            Application.DoEvents();
            

            for(int i = 0; i< 3;i++)
            {
                this.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText("Running Test {TestName}... ");
                    Application.DoEvents();

                    Thread.Sleep(500);

                    richTextBox1.AppendText("PASSED\n\n", Color.Green);
                    Thread.Sleep(100);
                    Application.DoEvents();
                    
                }));

                

            }
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

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCode exportCode = new ExportCode(Model.Constants.ExportCodeTypes.Java);

            exportCode.ShowDialog();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportCode exportCode = new ExportCode(Model.Constants.ExportCodeTypes.Python);

            exportCode.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            saveFileDialog1.Filter = "Test Studio Projects |*.tsproj";

            var dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                SaveProfileFile(saveFileDialog1.FileName);
            }
        }

        private void addTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(CreateTab(false));
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(CreateTab(false));
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
