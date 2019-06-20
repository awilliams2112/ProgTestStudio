using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    /// <summary>
    /// HintTextBox Class - to create a textbox control with a "hint" property.
    /// Uses InteropServices and PInvoke.
    /// </summary>
    class HintTextBox : TextBox
    {
        //Configure dll
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr windowHandle, int message, IntPtr windowPtr, string label);

        //Data Members:
        private string hint;

        //Class Properties:
        [Localizable(true)]
        public string Hint
        {
            get
            {
                return hint;
            }
            set
            {
                hint = value;
                UpdateHint();
            }
        } // end method 

        private void UpdateHint()
        {
            if (IsHandleCreated && hint != null)
            {
                SendMessage(Handle, 0x1501, (IntPtr)1, hint);
            }
        } // end method UpdateHint()

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateHint();
        } // end method OnHandleCreated()
    } // end class HintTextBox
} // end namespace Calculator
