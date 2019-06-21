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
            Id = Guid.NewGuid().ToString();
        }

        public TestTab(bool autoDefault) : base()
        {
            testName = this.Text;
            InitializeComponents();
            Id = Guid.NewGuid().ToString();

            Text = "CCM Test Case";
            actionFlowControl.AddControl(new ActionControl(Model.Constants.ActionTypes.Rest, "POST Email Event"));
            actionFlowControl.AddControl(new ArrowControl());
            actionFlowControl.AddControl(new ActionControl(Model.Constants.ActionTypes.Sql, "Check CCM Db"));
            actionFlowControl.AddControl(new ArrowControl());
            actionFlowControl.AddControl(new ActionControl(Model.Constants.ActionTypes.Assert, "Validate Email Sent"));
        }

        public Action<string> OnDelete;
        public Action<string> OnCreateCustomAction;

        public string Id { get; private set; }

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

            this.MouseClick += TestTab_MouseClick;
            this.Controls.Add(actionFlowControl);

            this.ContextMenu = BuildContextMenu();
        }

        private void TestTab_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
            }
        }

        private ContextMenu BuildContextMenu()
        {
            ContextMenu cm = new ContextMenu();

            cm.MenuItems.Add(new MenuItem("Rename", (object sender, EventArgs e) => 
            {
                TextEntryForm testNameForm = new TextEntryForm("Enter Test Name:");

                if (DialogResult.OK == testNameForm.ShowDialog())
                {
                    Text = testNameForm.Entry;
                }
            }));

            cm.MenuItems.Add(new MenuItem("Create Custom Action", (object sender, EventArgs e) =>
            {
                TextEntryForm testNameForm = new TextEntryForm("Enter Custom Action Name:");

                if (DialogResult.OK == testNameForm.ShowDialog())
                {
                    if (OnCreateCustomAction != null)
                        OnCreateCustomAction(testNameForm.Entry);
                }


            }));

            cm.MenuItems.Add(new MenuItem("Delete", (object sender, EventArgs e) => 
            {
                if (OnDelete != null)
                    OnDelete(Id);
            }));

            return cm;
        }
    }
}
