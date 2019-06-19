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
    public partial class UIAction : UserControl
    {
        public UIAction()
        {
            InitializeComponent();
        }

        public string DisplayName { get; internal set; }
    }
}
