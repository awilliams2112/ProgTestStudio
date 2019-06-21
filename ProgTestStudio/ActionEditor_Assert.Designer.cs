namespace ProgTestStudio
{
    partial class ActionEditor_Assert
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
            this.GridAssertions = new System.Windows.Forms.DataGridView();
            this.ColVal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.SplitterDetails = new System.Windows.Forms.SplitContainer();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.NumBoxPosition = new System.Windows.Forms.NumericUpDown();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblTypeValue = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GrpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAssertions)).BeginInit();
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
            this.BtnOk.Location = new System.Drawing.Point(686, 420);
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
            this.BtnCancel.Location = new System.Drawing.Point(34, 420);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GrpBoxDetails
            // 
            this.GrpBoxDetails.Controls.Add(this.GridAssertions);
            this.GrpBoxDetails.Controls.Add(this.LblHeaders);
            this.GrpBoxDetails.Location = new System.Drawing.Point(10, 132);
            this.GrpBoxDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxDetails.Name = "GrpBoxDetails";
            this.GrpBoxDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxDetails.Size = new System.Drawing.Size(780, 275);
            this.GrpBoxDetails.TabIndex = 1;
            this.GrpBoxDetails.TabStop = false;
            this.GrpBoxDetails.Text = "Action Details";
            // 
            // GridAssertions
            // 
            this.GridAssertions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAssertions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridAssertions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridAssertions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAssertions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColVal1,
            this.ColVal2,
            this.Type});
            this.GridAssertions.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridAssertions.Location = new System.Drawing.Point(101, 109);
            this.GridAssertions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridAssertions.Name = "GridAssertions";
            this.GridAssertions.RowTemplate.Height = 24;
            this.GridAssertions.Size = new System.Drawing.Size(541, 60);
            this.GridAssertions.TabIndex = 8;
            // 
            // ColVal1
            // 
            this.ColVal1.HeaderText = "Value 1";
            this.ColVal1.Name = "ColVal1";
            // 
            // ColVal2
            // 
            this.ColVal2.HeaderText = "Value 2";
            this.ColVal2.Name = "ColVal2";
            // 
            // Type
            // 
            this.Type.HeaderText = "Assertion Type";
            this.Type.Name = "Type";
            // 
            // LblHeaders
            // 
            this.LblHeaders.AutoSize = true;
            this.LblHeaders.Location = new System.Drawing.Point(31, 131);
            this.LblHeaders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(58, 13);
            this.LblHeaders.TabIndex = 4;
            this.LblHeaders.Text = "Assertions:";
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
            this.SplitterDetails.Panel1.Controls.Add(this.LblName);
            this.SplitterDetails.Panel1.Controls.Add(this.LblType);
            this.SplitterDetails.Panel1.Controls.Add(this.LblTypeValue);
            this.SplitterDetails.Panel1.Controls.Add(this.LblPosition);
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
            this.PicLogo.BackgroundImage = global::ProgTestStudio.Properties.Resources.iconfinder_check_box_outline_326561;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Location = new System.Drawing.Point(17, 16);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 80);
            this.PicLogo.TabIndex = 12;
            this.PicLogo.TabStop = false;
            // 
            // NumBoxPosition
            // 
            this.NumBoxPosition.Location = new System.Drawing.Point(202, 79);
            this.NumBoxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumBoxPosition.Name = "NumBoxPosition";
            this.NumBoxPosition.Size = new System.Drawing.Size(183, 20);
            this.NumBoxPosition.TabIndex = 3;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(202, 48);
            this.TxtBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(183, 20);
            this.TxtBoxName.TabIndex = 10;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(141, 49);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(112, 21);
            this.LblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(67, 13);
            this.LblType.TabIndex = 6;
            this.LblType.Text = "Action Type:";
            // 
            // LblTypeValue
            // 
            this.LblTypeValue.AutoSize = true;
            this.LblTypeValue.Location = new System.Drawing.Point(200, 21);
            this.LblTypeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTypeValue.Name = "LblTypeValue";
            this.LblTypeValue.Size = new System.Drawing.Size(50, 13);
            this.LblTypeValue.TabIndex = 7;
            this.LblTypeValue.Text = "ASSERT";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(131, 80);
            this.LblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(47, 13);
            this.LblPosition.TabIndex = 9;
            this.LblPosition.Text = "Position:";
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
            // ActionEditor_Assert
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
            this.Name = "ActionEditor_Assert";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Editor";
            this.GrpBoxDetails.ResumeLayout(false);
            this.GrpBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAssertions)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NumBoxPosition;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTypeValue;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.DataGridView GridAssertions;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}