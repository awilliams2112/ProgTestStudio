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
    public partial class Sample 
    {
        public Sample()
        {
            
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

        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
}
