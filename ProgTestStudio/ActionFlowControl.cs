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

            var actionControl = new ActionControl(actionTreeNode.Text);

            this.FlowPanel.Controls.Add(actionControl);
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
