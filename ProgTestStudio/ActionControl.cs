using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgTestStudio.Model;

namespace ProgTestStudio
{
    public partial class ActionControl : UserControl
    {
        TestAction testAction;
        Constants.ActionTypes _actionType;

        public ActionControl()
        {
            InitializeComponent();
        }

        public ActionControl(Constants.ActionTypes actionType)
        {
            _actionType = actionType;

            InitializeComponent();

            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Location = new System.Drawing.Point(5, 5);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "uiAction1";
            TabIndex = 0;
            DisplayName = Constants.ActionTypeDefaultDescription(actionType);
            Size = new Size(154, 60);

            string imageLocation = string.Empty;

            switch (actionType)
            {
                case Constants.ActionTypes.Sql:
                    imageLocation = Constants.Images.SqlActionIcon;
                    break;

                case Constants.ActionTypes.Rest:
                    imageLocation = Constants.Images.RestActionIcon;

                    break;

                case Constants.ActionTypes.Assert:

                    imageLocation = Constants.Images.AssertActionIcon;
                    
                    break;

                default:

                    imageLocation = Constants.Images.CustomActionIcon;

                    break;
            }
            pictureBox1.ImageLocation = imageLocation;

            //DoubleClick += (object sender1, EventArgs e1) =>
            //{
                 
            //};
        }

        public string DisplayName
        {
            get
            {
                return nameLbl.Text;
            }
            set
            {
                nameLbl.Text = value;
            }
        }

        private void ActionControl_DoubleClick(object sender, EventArgs e)
        {
            showEditorDialog();
        }

        private void nameLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showEditorDialog();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showEditorDialog();
        }

        private void showEditorDialog()
        {
            switch (_actionType)
            {
                case Constants.ActionTypes.Sql:

                    new ActionEditor_Sql()
                        .PopulateForm(new SqlAction())
                        .ShowDialog();

                    break;

                case Constants.ActionTypes.Rest:

                    new ActionEditor()
                        .PopulateForm(new RestAction())
                        .ShowDialog();

                    break;

                case Constants.ActionTypes.Assert:

                    new ActionEditor_Sql()
                        .PopulateForm(new SqlAction())
                        .ShowDialog();

                    break;

                case Constants.ActionTypes.Custom:

                    new ActionEditor_Custom()
                        .PopulateForm(new CustomAction())
                        .ShowDialog();

                    break;

                default:
                    break;
            }
        }

    }
}
