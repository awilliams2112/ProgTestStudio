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
            this.GrpBoxMethod = new System.Windows.Forms.GroupBox();
            this.RBtnPut = new System.Windows.Forms.RadioButton();
            this.RBtnPost = new System.Windows.Forms.RadioButton();
            this.RBtnGet = new System.Windows.Forms.RadioButton();
            this.TxtBoxUrl = new ProgTestStudio.HintTextBox();
            this.GridHeaders = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RichPayload = new System.Windows.Forms.RichTextBox();
            this.LblPayload = new System.Windows.Forms.Label();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
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
            this.GrpBoxMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaders)).BeginInit();
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
            this.BtnOk.Location = new System.Drawing.Point(915, 517);
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
            this.BtnCancel.Location = new System.Drawing.Point(46, 517);
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
            this.GrpBoxDetails.Controls.Add(this.GrpBoxMethod);
            this.GrpBoxDetails.Controls.Add(this.TxtBoxUrl);
            this.GrpBoxDetails.Controls.Add(this.GridHeaders);
            this.GrpBoxDetails.Controls.Add(this.RichPayload);
            this.GrpBoxDetails.Controls.Add(this.LblPayload);
            this.GrpBoxDetails.Controls.Add(this.LblHeaders);
            this.GrpBoxDetails.Controls.Add(this.LblUrl);
            this.GrpBoxDetails.Location = new System.Drawing.Point(13, 162);
            this.GrpBoxDetails.Name = "GrpBoxDetails";
            this.GrpBoxDetails.Size = new System.Drawing.Size(1040, 339);
            this.GrpBoxDetails.TabIndex = 1;
            this.GrpBoxDetails.TabStop = false;
            this.GrpBoxDetails.Text = "Action Details";
            // 
            // GrpBoxMethod
            // 
            this.GrpBoxMethod.Controls.Add(this.RBtnPut);
            this.GrpBoxMethod.Controls.Add(this.RBtnPost);
            this.GrpBoxMethod.Controls.Add(this.RBtnGet);
            this.GrpBoxMethod.Location = new System.Drawing.Point(889, 23);
            this.GrpBoxMethod.Name = "GrpBoxMethod";
            this.GrpBoxMethod.Size = new System.Drawing.Size(124, 101);
            this.GrpBoxMethod.TabIndex = 10;
            this.GrpBoxMethod.TabStop = false;
            this.GrpBoxMethod.Text = "Method";
            // 
            // RBtnPut
            // 
            this.RBtnPut.AutoSize = true;
            this.RBtnPut.Location = new System.Drawing.Point(8, 74);
            this.RBtnPut.Name = "RBtnPut";
            this.RBtnPut.Size = new System.Drawing.Size(57, 21);
            this.RBtnPut.TabIndex = 2;
            this.RBtnPut.TabStop = true;
            this.RBtnPut.Text = "PUT";
            this.RBtnPut.UseVisualStyleBackColor = true;
            // 
            // RBtnPost
            // 
            this.RBtnPost.AutoSize = true;
            this.RBtnPost.Location = new System.Drawing.Point(7, 47);
            this.RBtnPost.Name = "RBtnPost";
            this.RBtnPost.Size = new System.Drawing.Size(67, 21);
            this.RBtnPost.TabIndex = 1;
            this.RBtnPost.TabStop = true;
            this.RBtnPost.Text = "POST";
            this.RBtnPost.UseVisualStyleBackColor = true;
            // 
            // RBtnGet
            // 
            this.RBtnGet.AutoSize = true;
            this.RBtnGet.Location = new System.Drawing.Point(7, 20);
            this.RBtnGet.Name = "RBtnGet";
            this.RBtnGet.Size = new System.Drawing.Size(58, 21);
            this.RBtnGet.TabIndex = 0;
            this.RBtnGet.TabStop = true;
            this.RBtnGet.Text = "GET";
            this.RBtnGet.UseVisualStyleBackColor = true;
            // 
            // TxtBoxUrl
            // 
            this.TxtBoxUrl.Hint = "https://stormwind.local10/Test";
            this.TxtBoxUrl.Location = new System.Drawing.Point(135, 70);
            this.TxtBoxUrl.Name = "TxtBoxUrl";
            this.TxtBoxUrl.Size = new System.Drawing.Size(721, 22);
            this.TxtBoxUrl.TabIndex = 9;
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
            this.GridHeaders.Location = new System.Drawing.Point(135, 134);
            this.GridHeaders.Name = "GridHeaders";
            this.GridHeaders.RowTemplate.Height = 24;
            this.GridHeaders.Size = new System.Drawing.Size(721, 74);
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
            // RichPayload
            // 
            this.RichPayload.Location = new System.Drawing.Point(135, 251);
            this.RichPayload.Name = "RichPayload";
            this.RichPayload.Size = new System.Drawing.Size(721, 66);
            this.RichPayload.TabIndex = 7;
            this.RichPayload.Text = "";
            // 
            // LblPayload
            // 
            this.LblPayload.AutoSize = true;
            this.LblPayload.Location = new System.Drawing.Point(40, 261);
            this.LblPayload.Name = "LblPayload";
            this.LblPayload.Size = new System.Drawing.Size(63, 17);
            this.LblPayload.TabIndex = 5;
            this.LblPayload.Text = "Payload:";
            // 
            // LblHeaders
            // 
            this.LblHeaders.AutoSize = true;
            this.LblHeaders.Location = new System.Drawing.Point(41, 161);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(66, 17);
            this.LblHeaders.TabIndex = 4;
            this.LblHeaders.Text = "Headers:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(73, 70);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(30, 17);
            this.LblUrl.TabIndex = 3;
            this.LblUrl.Text = "Url:";
            // 
            // SplitterDetails
            // 
            this.SplitterDetails.Location = new System.Drawing.Point(13, 12);
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
            this.SplitterDetails.Size = new System.Drawing.Size(1040, 144);
            this.SplitterDetails.SplitterDistance = 516;
            this.SplitterDetails.TabIndex = 2;
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImage = global::ProgTestStudio.Properties.Resources.rest;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Location = new System.Drawing.Point(23, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(100, 120);
            this.PicLogo.TabIndex = 12;
            this.PicLogo.TabStop = false;
            // 
            // NumBoxPosition
            // 
            this.NumBoxPosition.Location = new System.Drawing.Point(269, 97);
            this.NumBoxPosition.Name = "NumBoxPosition";
            this.NumBoxPosition.Size = new System.Drawing.Size(138, 22);
            this.NumBoxPosition.TabIndex = 3;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(269, 59);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(138, 22);
            this.TxtBoxName.TabIndex = 10;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(188, 60);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 17);
            this.LblName.TabIndex = 8;
            this.LblName.Text = "Name:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(150, 26);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(87, 17);
            this.LblType.TabIndex = 6;
            this.LblType.Text = "Action Type:";
            // 
            // LblTypeValue
            // 
            this.LblTypeValue.AutoSize = true;
            this.LblTypeValue.Location = new System.Drawing.Point(266, 26);
            this.LblTypeValue.Name = "LblTypeValue";
            this.LblTypeValue.Size = new System.Drawing.Size(45, 17);
            this.LblTypeValue.TabIndex = 7;
            this.LblTypeValue.Text = "REST";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(175, 98);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(62, 17);
            this.LblPosition.TabIndex = 9;
            this.LblPosition.Text = "Position:";
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
            // ActionEditor
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
            this.Name = "ActionEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Editor";
            this.GrpBoxDetails.ResumeLayout(false);
            this.GrpBoxDetails.PerformLayout();
            this.GrpBoxMethod.ResumeLayout(false);
            this.GrpBoxMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaders)).EndInit();
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
        private System.Windows.Forms.Label LblPayload;
        private System.Windows.Forms.Label LblHeaders;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.NumericUpDown NumBoxPosition;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTypeValue;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.DataGridView GridHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValue;
        private System.Windows.Forms.RichTextBox RichPayload;
        private HintTextBox TxtBoxUrl;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.GroupBox GrpBoxMethod;
        private System.Windows.Forms.RadioButton RBtnPut;
        private System.Windows.Forms.RadioButton RBtnPost;
        private System.Windows.Forms.RadioButton RBtnGet;
    }
}