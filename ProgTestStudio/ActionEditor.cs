using ProgTestStudio.Controller;
using ProgTestStudio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProgTestStudio
{
    public partial class ActionEditor : Form
    {
        private RestAction _model;

        public ActionEditor()
        {
            InitializeComponent();
            GridHeaders.DataSource = new Dictionary<string, string>();
        }

        public void PopulateForm(RestAction model)
        {
            TxtBoxUrl.Text = model.Url;
            GridHeaders.DataSource = model.Headers;
            RichPayload.Text = model.Payload;
            TxtBoxName.Text = model.Name;
            NumBoxPosition.Value = model.Position;

            _model = model;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            _model.Headers = (Dictionary<string, string>)GridHeaders.DataSource;
            _model.Name = TxtBoxName.Text;
            _model.Payload = RichPayload.Text;

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

            Close();
        }
    }
}
