using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class TextEntryForm : Form
    {
        public TextEntryForm()
        {
            InitializeComponent();
        }

        public TextEntryForm(string message)
        {
            InitializeComponent();

            MessageLbl.Text = message;
        }

        public string Entry
        {
            get
            {
                return EntryTextBox.Text;
            }
        }
        
    }
}
