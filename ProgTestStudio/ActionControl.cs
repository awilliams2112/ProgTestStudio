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

        public ActionControl()
        {
            InitializeComponent();
        }

        public ActionControl(Constants.ActionTypes actionType)
        {
            InitializeComponent();

            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Location = new System.Drawing.Point(5, 5);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "uiAction1";
            TabIndex = 0;
            DisplayName = Constants.ActionTypeDefaultDescription(actionType);
            Size = new Size(154, 60);

            string imageLocation = string.Empty;


            switch(actionType)
            {
                case Constants.ActionTypes.Sql:
                    imageLocation = Constants.Images.SqlActionIcon;
                    break;

                case Constants.ActionTypes.Rest:
                    imageLocation = Constants.Images.RestActionIcon;

                    break;

                case Constants.ActionTypes.Assert:
                    imageLocation = "Resources\\iconfinder_language_326663.png";

                    break;
                    
                case Constants.ActionTypes.Custom:
                    imageLocation = "Resources\\iconfinder_language_326663.png";

                    break;

                default:
                    break;
            }

            pictureBox1.ImageLocation = imageLocation;

            DoubleClick += (object sender1, EventArgs e1) =>
            {
                 ActionEditor task = new ActionEditor();
                 //task.PopulateForm();
                 task.ShowDialog();
            };
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

    }
}
