using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class ActionFlowControl : UserControl
    {
        public ActionFlowControl()
        {
            InitializeComponent();
        }

        #region events

        /// <summary>
        /// Drop drop event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowPanel_DragDrop(object sender, DragEventArgs e)
        {
            ActionTreeNode actionTreeNode = (ActionTreeNode)e.Data.GetData(typeof(ActionTreeNode));

            if (this.FlowPanel.Controls.Count > 0 &&
               this.FlowPanel.Controls[this.FlowPanel.Controls.Count - 1] is ActionControl)
            {
                this.FlowPanel.Controls.Add(new ArrowControl());
            }

            var uiAction = new ActionControl
            {
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                Location = new System.Drawing.Point(5, 5),
                Margin = new System.Windows.Forms.Padding(5),
                Name = "uiAction1",
                TabIndex = 0,
                DisplayName = actionTreeNode.Text.Trim(),
            };

            uiAction.DoubleClick += (object sender1, EventArgs e1) =>
            {
                AddTask task = new AddTask();
                task.ShowDialog();
            };

            this.FlowPanel.Controls.Add(uiAction);
        }

        /// <summary>
        /// Drag enter event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        #endregion


    }
}
