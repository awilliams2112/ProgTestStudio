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
        Constants.ActionTypes _actionType;

        public ActionControl()
        {
            InitializeComponent();
        }

        public ActionControl(Constants.ActionTypes actionType, string display = null)
        {
            _actionType = actionType;

            InitializeComponent();

            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Location = new System.Drawing.Point(5, 5);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "uiAction1";
            TabIndex = 0;

            if (actionType == Constants.ActionTypes.Custom)
                DisplayName = display.Trim();
            else
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

                    var act_sql = new ActionEditor_Sql();
                    act_sql.Name = DisplayName;
                    act_sql.PopulateForm(new SqlAction()
                    {
                        Name = DisplayName
                    });
                        
                    if (DialogResult.OK == act_sql.ShowDialog())
                        DisplayName = act_sql.Model.Name;

                    break;

                case Constants.ActionTypes.Rest:

                    var act_rest = new ActionEditor();
                    act_rest.Name = DisplayName;
                    act_rest.PopulateForm(new RestAction()
                    {
                        Name = DisplayName
                    });

                    if (DialogResult.OK == act_rest.ShowDialog())
                        DisplayName = act_rest.Model.Name;

                    break;

                case Constants.ActionTypes.Assert:

                    var act_assert = new ActionEditor_Assert();
                    act_assert.Name = DisplayName;
                    act_assert.PopulateForm(new AssertAction()
                    {
                        Name = DisplayName
                    });

                    if (DialogResult.OK == act_assert.ShowDialog())
                        DisplayName = act_assert.Model.Name;

                    break;

                case Constants.ActionTypes.Custom:

                    var act_custom = new ActionEditor_Custom();
                    act_custom.Name = DisplayName;
                    act_custom.PopulateForm(new CustomAction()
                    {
                        Name = DisplayName
                    });

                    if (DialogResult.OK == act_custom.ShowDialog())
                        DisplayName = act_custom.Model.Name;

                    break;

                default:
                    break;
            }
        }

    }
}
