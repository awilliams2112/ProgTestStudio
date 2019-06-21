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
            this.RichStatement = new System.Windows.Forms.RichTextBox();
            this.LblStatement = new System.Windows.Forms.Label();
            this.TxtBoxConnection = new ProgTestStudio.HintTextBox();
            this.GridParameters = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.SplitterDetails = new System.Windows.Forms.SplitContainer();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.NumBoxPosition = new System.Windows.Forms.NumericUpDown();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTypeValue = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GrpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).BeginInit();
            this.SplitterDetails.Panel1.SuspendLayout();
            this.SplitterDetails.Panel2.SuspendLayout();
            this.SplitterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBoxPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(686, 418);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(38, 418);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
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
            this.GrpBoxDetails.Location = new System.Drawing.Point(10, 132);
            this.GrpBoxDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxDetails.Name = "GrpBoxDetails";
            this.GrpBoxDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxDetails.Size = new System.Drawing.Size(780, 275);
            this.GrpBoxDetails.TabIndex = 1;
            this.GrpBoxDetails.TabStop = false;
            this.GrpBoxDetails.Text = "Action Details";
            // 
            // RichStatement
            // 
            this.RichStatement.Location = new System.Drawing.Point(121, 204);
            this.RichStatement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RichStatement.Name = "RichStatement";
            this.RichStatement.Size = new System.Drawing.Size(577, 54);
            this.RichStatement.TabIndex = 12;
            this.RichStatement.Text = "";
            // 
            // LblStatement
            // 
            this.LblStatement.AutoSize = true;
            this.LblStatement.Location = new System.Drawing.Point(50, 212);
            this.LblStatement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatement.Name = "LblStatement";
            this.LblStatement.Size = new System.Drawing.Size(58, 13);
            this.LblStatement.TabIndex = 11;
            this.LblStatement.Text = "Statement:";
            // 
            // TxtBoxConnection
            // 
            this.TxtBoxConnection.Hint = "\"Data Source = PF2-SQL-qas; User ID=TestUser; Password=yourMom\"";
            this.TxtBoxConnection.Location = new System.Drawing.Point(120, 54);
            this.TxtBoxConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxConnection.Name = "TxtBoxConnection";
            this.TxtBoxConnection.Size = new System.Drawing.Size(578, 20);
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
            this.GridParameters.Location = new System.Drawing.Point(120, 109);
            this.GridParameters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridParameters.Name = "GridParameters";
            this.GridParameters.RowTemplate.Height = 24;
            this.GridParameters.Size = new System.Drawing.Size(577, 60);
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
            this.LblHeaders.Location = new System.Drawing.Point(35, 131);
            this.LblHeaders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(63, 13);
            this.LblHeaders.TabIndex = 4;
            this.LblHeaders.Text = "Parameters:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(6, 55);
            this.LblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(94, 13);
            this.LblUrl.TabIndex = 3;
            this.LblUrl.Text = "Connection String:";
            // 
            // SplitterDetails
            // 
            this.SplitterDetails.Location = new System.Drawing.Point(10, 10);
            this.SplitterDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SplitterDetails.Name = "SplitterDetails";
            // 
            // SplitterDetails.Panel1
            // 
            this.SplitterDetails.Panel1.Controls.Add(this.PicLogo);
            this.SplitterDetails.Panel1.Controls.Add(this.NumBoxPosition);
            this.SplitterDetails.Panel1.Controls.Add(this.TxtBoxName);
            this.SplitterDetails.Panel1.Controls.Add(this.LblPosition);
            this.SplitterDetails.Panel1.Controls.Add(this.LblName);
            this.SplitterDetails.Panel1.Controls.Add(this.LblTypeValue);
            this.SplitterDetails.Panel1.Controls.Add(this.LblType);
            // 
            // SplitterDetails.Panel2
            // 
            this.SplitterDetails.Panel2.Controls.Add(this.BtnDelete);
            this.SplitterDetails.Size = new System.Drawing.Size(780, 117);
            this.SplitterDetails.SplitterDistance = 387;
            this.SplitterDetails.SplitterWidth = 3;
            this.SplitterDetails.TabIndex = 2;
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImage = global::ProgTestStudio.Properties.Resources.iconfinder_database_1608662;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Location = new System.Drawing.Point(16, 16);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 81);
            this.PicLogo.TabIndex = 11;
            this.PicLogo.TabStop = false;
            // 
            // NumBoxPosition
            // 
            this.NumBoxPosition.Location = new System.Drawing.Point(208, 83);
            this.NumBoxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumBoxPosition.Name = "NumBoxPosition";
            this.NumBoxPosition.Size = new System.Drawing.Size(177, 20);
            this.NumBoxPosition.TabIndex = 3;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(208, 52);
            this.TxtBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(177, 20);
            this.TxtBoxName.TabIndex = 10;
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(137, 84);
            this.LblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(47, 13);
            this.LblPosition.TabIndex = 9;
            this.LblPosition.Text = "Position:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(147, 53);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name:";
            // 
            // LblTypeValue
            // 
            this.LblTypeValue.AutoSize = true;
            this.LblTypeValue.Location = new System.Drawing.Point(206, 25);
            this.LblTypeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTypeValue.Name = "LblTypeValue";
            this.LblTypeValue.Size = new System.Drawing.Size(28, 13);
            this.LblTypeValue.TabIndex = 7;
            this.LblTypeValue.Text = "SQL";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(118, 25);
            this.LblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(67, 13);
            this.LblType.TabIndex = 6;
            this.LblType.Text = "Action Type:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(286, 20);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ActionEditor_Sql
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.SplitterDetails);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.GrpBoxDetails);
            this.Controls.Add(this.BtnOk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionEditor_Sql";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Editor";
            this.GrpBoxDetails.ResumeLayout(false);
            this.GrpBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridParameters)).EndInit();
            this.SplitterDetails.Panel1.ResumeLayout(false);
            this.SplitterDetails.Panel1.PerformLayout();
            this.SplitterDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).EndInit();
            this.SplitterDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBoxPosition)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NumBoxPosition;
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