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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpBoxDetails = new System.Windows.Forms.GroupBox();
            this.GrpBoxMethod = new System.Windows.Forms.GroupBox();
            this.RBtnPut = new System.Windows.Forms.RadioButton();
            this.RBtnPost = new System.Windows.Forms.RadioButton();
            this.RBtnGet = new System.Windows.Forms.RadioButton();
            this.GridHeaders = new System.Windows.Forms.DataGridView();
            this.ColKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RichPayload = new System.Windows.Forms.RichTextBox();
            this.LblPayload = new System.Windows.Forms.Label();
            this.LblHeaders = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.SplitterDetails = new System.Windows.Forms.SplitContainer();
            this.NumBoxPosition = new System.Windows.Forms.NumericUpDown();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblTypeValue = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.TxtBoxUrl = new ProgTestStudio.HintTextBox();
            this.GrpBoxDetails.SuspendLayout();
            this.GrpBoxMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitterDetails)).BeginInit();
            this.SplitterDetails.Panel1.SuspendLayout();
            this.SplitterDetails.Panel2.SuspendLayout();
            this.SplitterDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBoxPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
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
            this.GrpBoxDetails.Controls.Add(this.GrpBoxMethod);
            this.GrpBoxDetails.Controls.Add(this.TxtBoxUrl);
            this.GrpBoxDetails.Controls.Add(this.GridHeaders);
            this.GrpBoxDetails.Controls.Add(this.RichPayload);
            this.GrpBoxDetails.Controls.Add(this.LblPayload);
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
            // GrpBoxMethod
            // 
            this.GrpBoxMethod.Controls.Add(this.RBtnPut);
            this.GrpBoxMethod.Controls.Add(this.RBtnPost);
            this.GrpBoxMethod.Controls.Add(this.RBtnGet);
            this.GrpBoxMethod.Location = new System.Drawing.Point(667, 19);
            this.GrpBoxMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxMethod.Name = "GrpBoxMethod";
            this.GrpBoxMethod.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrpBoxMethod.Size = new System.Drawing.Size(93, 82);
            this.GrpBoxMethod.TabIndex = 10;
            this.GrpBoxMethod.TabStop = false;
            this.GrpBoxMethod.Text = "Method";
            // 
            // RBtnPut
            // 
            this.RBtnPut.AutoSize = true;
            this.RBtnPut.Location = new System.Drawing.Point(6, 60);
            this.RBtnPut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBtnPut.Name = "RBtnPut";
            this.RBtnPut.Size = new System.Drawing.Size(47, 17);
            this.RBtnPut.TabIndex = 2;
            this.RBtnPut.TabStop = true;
            this.RBtnPut.Text = "PUT";
            this.RBtnPut.UseVisualStyleBackColor = true;
            // 
            // RBtnPost
            // 
            this.RBtnPost.AutoSize = true;
            this.RBtnPost.Location = new System.Drawing.Point(5, 38);
            this.RBtnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBtnPost.Name = "RBtnPost";
            this.RBtnPost.Size = new System.Drawing.Size(54, 17);
            this.RBtnPost.TabIndex = 1;
            this.RBtnPost.TabStop = true;
            this.RBtnPost.Text = "POST";
            this.RBtnPost.UseVisualStyleBackColor = true;
            // 
            // RBtnGet
            // 
            this.RBtnGet.AutoSize = true;
            this.RBtnGet.Location = new System.Drawing.Point(5, 16);
            this.RBtnGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBtnGet.Name = "RBtnGet";
            this.RBtnGet.Size = new System.Drawing.Size(47, 17);
            this.RBtnGet.TabIndex = 0;
            this.RBtnGet.TabStop = true;
            this.RBtnGet.Text = "GET";
            this.RBtnGet.UseVisualStyleBackColor = true;
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
            this.GridHeaders.Location = new System.Drawing.Point(101, 109);
            this.GridHeaders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridHeaders.Name = "GridHeaders";
            this.GridHeaders.RowTemplate.Height = 24;
            this.GridHeaders.Size = new System.Drawing.Size(541, 60);
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
            this.RichPayload.Location = new System.Drawing.Point(101, 204);
            this.RichPayload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RichPayload.Name = "RichPayload";
            this.RichPayload.Size = new System.Drawing.Size(542, 54);
            this.RichPayload.TabIndex = 7;
            this.RichPayload.Text = "";
            // 
            // LblPayload
            // 
            this.LblPayload.AutoSize = true;
            this.LblPayload.Location = new System.Drawing.Point(30, 212);
            this.LblPayload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPayload.Name = "LblPayload";
            this.LblPayload.Size = new System.Drawing.Size(48, 13);
            this.LblPayload.TabIndex = 5;
            this.LblPayload.Text = "Payload:";
            // 
            // LblHeaders
            // 
            this.LblHeaders.AutoSize = true;
            this.LblHeaders.Location = new System.Drawing.Point(31, 131);
            this.LblHeaders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHeaders.Name = "LblHeaders";
            this.LblHeaders.Size = new System.Drawing.Size(50, 13);
            this.LblHeaders.TabIndex = 4;
            this.LblHeaders.Text = "Headers:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(55, 57);
            this.LblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(23, 13);
            this.LblUrl.TabIndex = 3;
            this.LblUrl.Text = "Url:";
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
            this.SplitterDetails.SplitterDistance = 441;
            this.SplitterDetails.SplitterWidth = 3;
            this.SplitterDetails.TabIndex = 2;
            // 
            // NumBoxPosition
            // 
            this.NumBoxPosition.Location = new System.Drawing.Point(202, 79);
            this.NumBoxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumBoxPosition.Name = "NumBoxPosition";
            this.NumBoxPosition.Size = new System.Drawing.Size(237, 20);
            this.NumBoxPosition.TabIndex = 3;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(202, 48);
            this.TxtBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(237, 20);
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
            this.LblTypeValue.Size = new System.Drawing.Size(36, 13);
            this.LblTypeValue.TabIndex = 7;
            this.LblTypeValue.Text = "REST";
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
            this.BtnDelete.Location = new System.Drawing.Point(241, 16);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImage = global::ProgTestStudio.Properties.Resources.iconfinder_language_326663__1_;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Location = new System.Drawing.Point(17, 16);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 98);
            this.PicLogo.TabIndex = 12;
            this.PicLogo.TabStop = false;
            // 
            // TxtBoxUrl
            // 
            this.TxtBoxUrl.Hint = "https://stormwind.local10/Test";
            this.TxtBoxUrl.Location = new System.Drawing.Point(101, 57);
            this.TxtBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBoxUrl.Name = "TxtBoxUrl";
            this.TxtBoxUrl.Size = new System.Drawing.Size(542, 20);
            this.TxtBoxUrl.TabIndex = 9;
            // 
            // ActionEditor
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
            ((System.ComponentModel.ISupportInitialize)(this.NumBoxPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
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