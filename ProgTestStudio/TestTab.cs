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

        public TestTab() : base("*New Test")
        {
            InitializeComponents();
        }

        public void InitializeComponents()
        {
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tabPage1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(753, 520);
            this.TabIndex = 0;
            this.Text = "tabPage1";
            this.UseVisualStyleBackColor = true;

            actionFlowControl = new ActionFlowControl();
            actionFlowControl.Dock = DockStyle.Fill;

            this.Controls.Add(actionFlowControl);
        }
    }
}
