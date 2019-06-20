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
            Size = new Size(154, 60);
            
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

        public string Description { get; set; }
    }
}
