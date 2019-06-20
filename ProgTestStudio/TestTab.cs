using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public class TestTab : TabPage
    {
        ActionFlowControl actionFlowControl;
        string testName;

        public TestTab() : base("*New Test")
        {
            testName = this.Text;
            InitializeComponents();
        }

        public void InitializeComponents()
        {

            this.Location = new System.Drawing.Point(4, 22);
            this.Name = testName;
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(753, 520);
            this.TabIndex = 0;
            this.UseVisualStyleBackColor = true;

            actionFlowControl = new ActionFlowControl();
            actionFlowControl.Dock = DockStyle.Fill;

            this.Controls.Add(actionFlowControl);
        }
    }
}
