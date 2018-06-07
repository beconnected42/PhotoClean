namespace WindowsFormsApplication1
{
    partial class 파일정리프로그램
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_newPath = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn_Move = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_Copy = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFileList = new System.Windows.Forms.Label();
            this.boxPhoto = new System.Windows.Forms.ListBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(23, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_newPath);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Run);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Panel2.Controls.Add(this.lblFileList);
            this.splitContainer1.Panel2.Controls.Add(this.boxPhoto);
            this.splitContainer1.Size = new System.Drawing.Size(318, 401);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "   파일의 경로를 넣으세요";
            // 
            // btn_newPath
            // 
            this.btn_newPath.BackColor = System.Drawing.Color.MistyRose;
            this.btn_newPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newPath.Font = new System.Drawing.Font("HY나무M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_newPath.Location = new System.Drawing.Point(230, 49);
            this.btn_newPath.Name = "btn_newPath";
            this.btn_newPath.Size = new System.Drawing.Size(75, 23);
            this.btn_newPath.TabIndex = 18;
            this.btn_newPath.Text = "정리폴더";
            this.btn_newPath.UseVisualStyleBackColor = false;
            this.btn_newPath.Click += new System.EventHandler(this.btn_newPath_Click_1);
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Run.Font = new System.Drawing.Font("HY나무M", 9F);
            this.btn_Run.Location = new System.Drawing.Point(153, 91);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(152, 31);
            this.btn_Run.TabIndex = 16;
            this.btn_Run.Text = "복사 or 이동";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbtn_Move);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.rbtn_Copy);
            this.panel3.Location = new System.Drawing.Point(8, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 31);
            this.panel3.TabIndex = 15;
            // 
            // rbtn_Move
            // 
            this.rbtn_Move.AutoSize = true;
            this.rbtn_Move.BackColor = System.Drawing.Color.SeaShell;
            this.rbtn_Move.Location = new System.Drawing.Point(77, 6);
            this.rbtn_Move.Name = "rbtn_Move";
            this.rbtn_Move.Size = new System.Drawing.Size(47, 16);
            this.rbtn_Move.TabIndex = 14;
            this.rbtn_Move.TabStop = true;
            this.rbtn_Move.Text = "이동";
            this.rbtn_Move.UseVisualStyleBackColor = false;
            this.rbtn_Move.CheckedChanged += new System.EventHandler(this.rbtn_Move_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-136, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 39);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbtn_Copy
            // 
            this.rbtn_Copy.AutoSize = true;
            this.rbtn_Copy.Location = new System.Drawing.Point(17, 6);
            this.rbtn_Copy.Name = "rbtn_Copy";
            this.rbtn_Copy.Size = new System.Drawing.Size(47, 16);
            this.rbtn_Copy.TabIndex = 0;
            this.rbtn_Copy.TabStop = true;
            this.rbtn_Copy.Text = "복사";
            this.rbtn_Copy.UseVisualStyleBackColor = true;
            this.rbtn_Copy.CheckedChanged += new System.EventHandler(this.rbtn_Copy_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Time2;
            this.pictureBox1.Location = new System.Drawing.Point(102, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblFileList
            // 
            this.lblFileList.AutoSize = true;
            this.lblFileList.Location = new System.Drawing.Point(5, 10);
            this.lblFileList.Name = "lblFileList";
            this.lblFileList.Size = new System.Drawing.Size(112, 12);
            this.lblFileList.TabIndex = 5;
            this.lblFileList.Text = "File List (Count： )";
            // 
            // boxPhoto
            // 
            this.boxPhoto.FormattingEnabled = true;
            this.boxPhoto.HorizontalScrollbar = true;
            this.boxPhoto.ItemHeight = 12;
            this.boxPhoto.Location = new System.Drawing.Point(4, 28);
            this.boxPhoto.Name = "boxPhoto";
            this.boxPhoto.ScrollAlwaysVisible = true;
            this.boxPhoto.Size = new System.Drawing.Size(309, 208);
            this.boxPhoto.TabIndex = 2;
            this.boxPhoto.SelectedIndexChanged += new System.EventHandler(this.boxPhoto_SelectedIndexChanged);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(376, 112);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(302, 214);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBox.TabIndex = 7;
            this.imgBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(489, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "사진보기";
            // 
            // 파일정리프로그램
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "파일정리프로그램";
            this.Text = "파일정리프로그램";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_newPath;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtn_Move;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_Copy;
        //private System.Windows.Forms.TextBox tb_FindFileNameList;
        private System.Windows.Forms.ListBox boxPhoto;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label lblFileList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

