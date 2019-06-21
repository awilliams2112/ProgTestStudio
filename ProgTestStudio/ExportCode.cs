using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProgTestStudio.Model.Constants;

namespace ProgTestStudio
{
    public partial class ExportCode : Form
    {
        public ExportCode()
        {
            InitializeComponent();
        }

        public ExportCode(ExportCodeTypes exportCodeType)
        {
            InitializeComponent();

            string exportedCode = string.Empty;

            switch (exportCodeType)
            {
                case ExportCodeTypes.CSharp:
                    Text = "Export to CSharp";
                    exportedCode = File.ReadAllText("SampleExports\\sample.cs");

                    break;

                case ExportCodeTypes.Powershell:
                    Text = "Export to Powershell";
                    exportedCode = File.ReadAllText("SampleExports\\sample.ps1");
                    break;

                case ExportCodeTypes.Java:
                    Text = "Export to Java";
                    exportedCode = File.ReadAllText("SampleExports\\sample.java");
                    break;

                case ExportCodeTypes.Python:
                    Text = "Export to Python";
                    exportedCode = File.ReadAllText("SampleExports\\sample.py");
                    break;

                default:
                    Text = "Export to Python";

                    break;
            }

            ExportCodeTxtBox.Text = exportedCode;
        }
    }
}
