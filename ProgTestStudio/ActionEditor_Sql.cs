using ProgTestStudio.Controller;
using ProgTestStudio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class ActionEditor_Sql : Form
    {
        private SqlAction _model;

        public ActionEditor_Sql()
        {
            InitializeComponent();
        }

        public void PopulateForm(SqlAction model)
        {
            TxtBoxConnection.Text = model.ConectionString;
            RichStatement.Text = model.Statement;
            GridParameters.DataSource = model.Args;
            TxtBoxName.Text = model.Name;
            NumBoxPosition.Value = model.Position;

            _model = model;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _model.ConectionString = TxtBoxConnection.Text;
            _model.Name = TxtBoxName.Text;
            _model.Statement = RichStatement.Text;
            _model.Args = (Dictionary<string, string>)GridParameters.DataSource;

            if (_model.Position != NumBoxPosition.Value)
                BusinessLogic.Instance.ReconcilePosition(_model.Position, decimal.ToInt32(NumBoxPosition.Value));

            BusinessLogic.Instance.Data[_model.Position] = _model;
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
                BusinessLogic.Instance.Data.Remove(_model);
            }
            else
            {
                Close();
            }
        }
    }
}
