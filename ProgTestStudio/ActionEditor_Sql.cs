using ProgTestStudio.Model;
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
    public partial class ActionEditor_Sql : Form
    {
        public ActionEditor_Sql()
        {
            InitializeComponent();
        }

        public void PopulateForm(SqlAction model)
        {
            TxtBoxConnection.Text = model.ConectionString;
            GridParameters.DataSource = model.Args;
            TxtBoxName.Text = model.Name;
            numericUpDown1.Value = model.Position;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete?", "CONFIRM DELETE ACTION", MessageBoxButtons.YesNo);

            if (result.Equals(DialogResult.Yes))
            {
                //Call method to delete action
            }
            else
            {
                Close();
            }
        }
    }
}
