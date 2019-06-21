using ProgTestStudio.Controller;
using ProgTestStudio.Model;
using System;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class ActionEditor_Custom : Form
    {
        private CustomAction _model;

        public ActionEditor_Custom()
        {
            InitializeComponent();
        }

        public ActionBase Model
        {
            get
            {
                return _model;
            }
        }

        public ActionEditor_Custom PopulateForm(CustomAction model)
        {
            _model = model;

            TxtBoxName.Text = _model.Name;

            return this;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

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
