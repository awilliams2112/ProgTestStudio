namespace ProgTestStudio
{
    partial class ActionEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpBoxDetails = new System.Windows.Forms.GroupBox();
            this.SplitterDetails = new System.Windows.Forms.SplitContainer();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblUrl = new System.Windows.Forms.Label();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.LblPayload = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblTypeValue = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TxtBoxUrl = new Calculator.HintTextBox();
            this.RichPayload = new System.Windows.Forms.RichTextBox();
            this.GridHeaders = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).BeginInit();
            this.SplitterDetails.Panel1.SuspendLayout();
            this.SplitterDetails.Panel2.SuspendLayout();
            this.SplitterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaders)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(915, 508);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 28);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(51, 508);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.OK_Click);
            // 
            // GrpBoxDetails
            // 
            this.GrpBoxDetails.Controls.Add(this.GridHeaders);
            this.GrpBoxDetails.Controls.Add(this.RichPayload);
            this.GrpBoxDetails.Controls.Add(this.TxtBoxUrl);
            this.GrpBoxDetails.Controls.Add(this.LblPayload);
            this.GrpBoxDetails.Controls.Add(this.LblHeaders);
            this.GrpBoxDetails.Controls.Add(this.LblUrl);
            this.GrpBoxDetails.Location = new System.Drawing.Point(13, 162);
            this.GrpBoxDetails.Name = "GrpBoxDetails";
            this.GrpBoxDetails.Size = new System.Drawing.Size(1040, 323);
            this.GrpBoxDetails.TabIndex = 1;
            this.GrpBoxDetails.TabStop = false;
            this.GrpBoxDetails.Text = "Action Details";
            // 
            // SplitterDetails
            // 
            this.SplitterDetails.Location = new System.Drawing.Point(13, 12);
            this.SplitterDetails.Name = "SplitterDetails";
            // 
            // SplitterDetails.Panel1
            // 
            this.SplitterDetails.Panel1.Controls.Add(this.numericUpDown1);
            this.SplitterDetails.Panel1.Controls.Add(this.textBox1);
            this.SplitterDetails.Panel1.Controls.Add(this.LblPosition);
            this.SplitterDetails.Panel1.Controls.Add(this.LblName);
            this.SplitterDetails.Panel1.Controls.Add(this.LblTypeValue);
            this.SplitterDetails.Panel1.Controls.Add(this.LblType);
            // 
            // SplitterDetails.Panel2
            // 
            this.SplitterDetails.Panel2.Controls.Add(this.BtnDelete);
            this.SplitterDetails.Size = new System.Drawing.Size(1040, 144);
            this.SplitterDetails.SplitterDistance = 516;
            this.SplitterDetails.TabIndex = 2;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(382, 24);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 28);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(98, 70);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(30, 17);
            this.LblUrl.TabIndex = 3;
            this.LblUrl.Text = "Url:";
            // 
            // LblHeaders
            // 
            this.LblHeaders.AutoSize = true;
            this.LblHeaders.Location = new System.Drawing.Point(66, 161);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(66, 17);
            this.LblHeaders.TabIndex = 4;
            this.LblHeaders.Text = "Headers:";
            // 
            // LblPayload
            // 
            this.LblPayload.AutoSize = true;
            this.LblPayload.Location = new System.Drawing.Point(65, 261);
            this.LblPayload.Name = "LblPayload";
            this.LblPayload.Size = new System.Drawing.Size(63, 17);
            this.LblPayload.TabIndex = 5;
            this.LblPayload.Text = "Payload:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(41, 24);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(87, 17);
            this.LblType.TabIndex = 6;
            this.LblType.Text = "Action Type:";
            // 
            // LblTypeValue
            // 
            this.LblTypeValue.AutoSize = true;
            this.LblTypeValue.Location = new System.Drawing.Point(157, 24);
            this.LblTypeValue.Name = "LblTypeValue";
            this.LblTypeValue.Size = new System.Drawing.Size(45, 17);
            this.LblTypeValue.TabIndex = 7;
            this.LblTypeValue.Text = "REST";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(79, 58);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name:";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(66, 96);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(62, 17);
            this.LblPosition.TabIndex = 9;
            this.LblPosition.Text = "Position:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(160, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // TxtBoxUrl
            // 
            this.TxtBoxUrl.Hint = "https://stormwind.local/CCM";
            this.TxtBoxUrl.Location = new System.Drawing.Point(160, 67);
            this.TxtBoxUrl.Name = "TxtBoxUrl";
            this.TxtBoxUrl.Size = new System.Drawing.Size(769, 22);
            this.TxtBoxUrl.TabIndex = 6;
            // 
            // RichPayload
            // 
            this.RichPayload.Location = new System.Drawing.Point(160, 251);
            this.RichPayload.Name = "RichPayload";
            this.RichPayload.Size = new System.Drawing.Size(769, 38);
            this.RichPayload.TabIndex = 7;
            this.RichPayload.Text = "";
            // 
            // GridHeaders
            // 
            this.GridHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridHeaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridHeaders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKey,
            this.ColValue});
            this.GridHeaders.Location = new System.Drawing.Point(160, 134);
            this.GridHeaders.Name = "GridHeaders";
            this.GridHeaders.RowTemplate.Height = 24;
            this.GridHeaders.Size = new System.Drawing.Size(769, 74);
            this.GridHeaders.TabIndex = 8;
            // 
            // ColKey
            // 
            this.ColKey.HeaderText = "Key";
            this.ColKey.Name = "ColKey";
            // 
            // ColValue
            // 
            this.ColValue.HeaderText = "Value";
            this.ColValue.Name = "ColValue";
            // 
            // AddTask
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1065, 558);
            this.Controls.Add(this.SplitterDetails);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.GrpBoxDetails);
            this.Controls.Add(this.BtnOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Editor";
            this.TopMost = true;
            this.GrpBoxDetails.ResumeLayout(false);
            this.GrpBoxDetails.PerformLayout();
            this.SplitterDetails.Panel1.ResumeLayout(false);
            this.SplitterDetails.Panel1.PerformLayout();
            this.SplitterDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).EndInit();
            this.SplitterDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GrpBoxDetails;
        private System.Windows.Forms.SplitContainer SplitterDetails;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblPayload;
        private System.Windows.Forms.Label LblHeaders;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTypeValue;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.DataGridView GridHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.RichTextBox RichPayload;
        private Calculator.HintTextBox TxtBoxUrl;
    }
}