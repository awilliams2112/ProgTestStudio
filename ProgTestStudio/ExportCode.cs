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
                    exportedCode = File.ReadAllText("SampleExports\\sample.cs");

                    break;

                case ExportCodeTypes.Powershell:
                    exportedCode = File.ReadAllText("SampleExports\\sample.ps1");
                    break;

                default:
                    break;
            }

            ExportCodeTxtBox.Text = exportedCode;
        }
    }
}
