namespace ProgTestStudio
{
    partial class ActionEditor_Sql
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpBoxDetails = new System.Windows.Forms.GroupBox();
            this.TxtBoxConnection = new ProgTestStudio.HintTextBox();
            this.GridParameters = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.SplitterDetails = new System.Windows.Forms.SplitContainer();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTypeValue = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.RichStatement = new System.Windows.Forms.RichTextBox();
            this.LblStatement = new System.Windows.Forms.Label();
            this.GrpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).BeginInit();
            this.SplitterDetails.Panel1.SuspendLayout();
            this.SplitterDetails.Panel2.SuspendLayout();
            this.SplitterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(915, 514);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 28);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(51, 514);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 28);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GrpBoxDetails
            // 
            this.GrpBoxDetails.Controls.Add(this.RichStatement);
            this.GrpBoxDetails.Controls.Add(this.LblStatement);
            this.GrpBoxDetails.Controls.Add(this.TxtBoxConnection);
            this.GrpBoxDetails.Controls.Add(this.GridParameters);
            this.GrpBoxDetails.Controls.Add(this.LblHeaders);
            this.GrpBoxDetails.Controls.Add(this.LblUrl);
            this.GrpBoxDetails.Location = new System.Drawing.Point(13, 162);
            this.GrpBoxDetails.Name = "GrpBoxDetails";
            this.GrpBoxDetails.Size = new System.Drawing.Size(1040, 339);
            this.GrpBoxDetails.TabIndex = 1;
            this.GrpBoxDetails.TabStop = false;
            this.GrpBoxDetails.Text = "Action Details";
            // 
            // TxtBoxConnection
            // 
            this.TxtBoxConnection.Hint = "\"Data Source = PF2-SQL-qas; User ID=TestUser; Password=yourMom\"";
            this.TxtBoxConnection.Location = new System.Drawing.Point(160, 67);
            this.TxtBoxConnection.Name = "TxtBoxConnection";
            this.TxtBoxConnection.Size = new System.Drawing.Size(769, 22);
            this.TxtBoxConnection.TabIndex = 10;
            // 
            // GridParameters
            // 
            this.GridParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridParameters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridParameters.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKey,
            this.ColValue});
            this.GridParameters.Location = new System.Drawing.Point(160, 134);
            this.GridParameters.Name = "GridParameters";
            this.GridParameters.RowTemplate.Height = 24;
            this.GridParameters.Size = new System.Drawing.Size(769, 74);
            this.GridParameters.TabIndex = 8;
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
            // LblHeaders
            // 
            this.LblHeaders.AutoSize = true;
            this.LblHeaders.Location = new System.Drawing.Point(47, 161);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(85, 17);
            this.LblHeaders.TabIndex = 4;
            this.LblHeaders.Text = "Parameters:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(8, 68);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(124, 17);
            this.LblUrl.TabIndex = 3;
            this.LblUrl.Text = "Connection String:";
            // 
            // SplitterDetails
            // 
            this.SplitterDetails.Location = new System.Drawing.Point(13, 12);
            this.SplitterDetails.Name = "SplitterDetails";
            // 
            // SplitterDetails.Panel1
            // 
            this.SplitterDetails.Panel1.Controls.Add(this.PicLogo);
            this.SplitterDetails.Panel1.Controls.Add(this.numericUpDown1);
            this.SplitterDetails.Panel1.Controls.Add(this.TxtBoxName);
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
            // PicLogo
            // 
            this.PicLogo.BackgroundImage = global::ProgTestStudio.Properties.Resources.sql;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Location = new System.Drawing.Point(21, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(100, 100);
            this.PicLogo.TabIndex = 11;
            this.PicLogo.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(277, 102);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(277, 64);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(138, 22);
            this.TxtBoxName.TabIndex = 10;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(183, 103);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(62, 17);
            this.LblPosition.TabIndex = 9;
            this.LblPosition.Text = "Position:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(196, 65);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name:";
            // 
            // LblTypeValue
            // 
            this.LblTypeValue.AutoSize = true;
            this.LblTypeValue.Location = new System.Drawing.Point(274, 31);
            this.LblTypeValue.Name = "LblTypeValue";
            this.LblTypeValue.Size = new System.Drawing.Size(36, 17);
            this.LblTypeValue.TabIndex = 7;
            this.LblTypeValue.Text = "SQL";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(158, 31);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(87, 17);
            this.LblType.TabIndex = 6;
            this.LblType.Text = "Action Type:";
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
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // RichStatement
            // 
            this.RichStatement.Location = new System.Drawing.Point(161, 251);
            this.RichStatement.Name = "RichStatement";
            this.RichStatement.Size = new System.Drawing.Size(768, 66);
            this.RichStatement.TabIndex = 12;
            this.RichStatement.Text = "";
            // 
            // LblStatement
            // 
            this.LblStatement.AutoSize = true;
            this.LblStatement.Location = new System.Drawing.Point(66, 261);
            this.LblStatement.Name = "LblStatement";
            this.LblStatement.Size = new System.Drawing.Size(76, 17);
            this.LblStatement.TabIndex = 11;
            this.LblStatement.Text = "Statement:";
            // 
            // ActionEditor_Sql
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionEditor_Sql";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Editor";
            this.TopMost = true;
            this.GrpBoxDetails.ResumeLayout(false);
            this.GrpBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParameters)).EndInit();
            this.SplitterDetails.Panel1.ResumeLayout(false);
            this.SplitterDetails.Panel1.PerformLayout();
            this.SplitterDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).EndInit();
            this.SplitterDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox GrpBoxDetails;
        private System.Windows.Forms.SplitContainer SplitterDetails;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblHeaders;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTypeValue;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.DataGridView GridParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private HintTextBox TxtBoxConnection;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.RichTextBox RichStatement;
        private System.Windows.Forms.Label LblStatement;
    }
}