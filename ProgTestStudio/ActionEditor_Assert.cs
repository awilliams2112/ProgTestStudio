using ProgTestStudio.Controller;
using ProgTestStudio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class ActionEditor_Assert : Form
    {
        private AssertAction _model;

        public ActionEditor_Assert()
        {
            InitializeComponent();
            GridAssertions.DataSource = new Dictionary<string, string>();
        }

        public ActionBase Model
        {
            get
            {
                return _model;
            }
        }

        public void PopulateForm(AssertAction model)
        {
            _model = model;

            TxtBoxName.Text = _model.Name;
        }



        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _model.Assertions = GridAssertions.DataSource.ToString();
            _model.Name = TxtBoxName.Text;

            if (_model.Position != NumBoxPosition.Value)
                BusinessLogic.Instance.ReconcilePosition(_model.Position, decimal.ToInt32(NumBoxPosition.Value));

            //BusinessLogic.Instance.Data[_model.Position] = _model;
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

            Close();
        }
    }
}
