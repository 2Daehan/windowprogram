﻿namespace winProExam
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WKULink = new System.Windows.Forms.LinkLabel();
            this.WKUniversity = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.Label();
            this.courseRegistration = new System.Windows.Forms.Label();
            this.searchingStudentID = new System.Windows.Forms.Label();
            this.searchingStudentIDTextbox = new System.Windows.Forms.TextBox();
            this.openClassList = new System.Windows.Forms.Label();
            this.courserRegistrationList = new System.Windows.Forms.Label();
            this.openClassListBox = new System.Windows.Forms.ListBox();
            this.courseRegistrationListBox = new System.Windows.Forms.ListBox();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.decisionButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wkuImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wkuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1373, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // WKULink
            // 
            this.WKULink.AutoSize = true;
            this.WKULink.Location = new System.Drawing.Point(5, 654);
            this.WKULink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WKULink.Name = "WKULink";
            this.WKULink.Size = new System.Drawing.Size(104, 15);
            this.WKULink.TabIndex = 1;
            this.WKULink.TabStop = true;
            this.WKULink.Text = "www.wku.ac.kr";
            // 
            // WKUniversity
            // 
            this.WKUniversity.AutoSize = true;
            this.WKUniversity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WKUniversity.ForeColor = System.Drawing.Color.White;
            this.WKUniversity.Location = new System.Drawing.Point(8, 631);
            this.WKUniversity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WKUniversity.Name = "WKUniversity";
            this.WKUniversity.Size = new System.Drawing.Size(87, 15);
            this.WKUniversity.TabIndex = 2;
            this.WKUniversity.Text = "원광대학교";
            this.WKUniversity.Click += new System.EventHandler(this.WKUniversity_Click);
            // 
            // studentID
            // 
            this.studentID.AutoSize = true;
            this.studentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentID.ForeColor = System.Drawing.Color.White;
            this.studentID.Location = new System.Drawing.Point(2, 10);
            this.studentID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(65, 36);
            this.studentID.TabIndex = 5;
            this.studentID.Text = "학번";
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentName.ForeColor = System.Drawing.Color.White;
            this.studentName.Location = new System.Drawing.Point(2, 175);
            this.studentName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(65, 36);
            this.studentName.TabIndex = 6;
            this.studentName.Text = "이름";
            // 
            // courseRegistration
            // 
            this.courseRegistration.AutoSize = true;
            this.courseRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.courseRegistration.Location = new System.Drawing.Point(278, 41);
            this.courseRegistration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.courseRegistration.Name = "courseRegistration";
            this.courseRegistration.Size = new System.Drawing.Size(115, 36);
            this.courseRegistration.TabIndex = 7;
            this.courseRegistration.Text = "수강신청";
            // 
            // searchingStudentID
            // 
            this.searchingStudentID.AutoSize = true;
            this.searchingStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchingStudentID.Location = new System.Drawing.Point(281, 109);
            this.searchingStudentID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchingStudentID.Name = "searchingStudentID";
            this.searchingStudentID.Size = new System.Drawing.Size(132, 25);
            this.searchingStudentID.TabIndex = 8;
            this.searchingStudentID.Text = "검색(학수번호) : ";
            // 
            // searchingStudentIDTextbox
            // 
            this.searchingStudentIDTextbox.Location = new System.Drawing.Point(403, 109);
            this.searchingStudentIDTextbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.searchingStudentIDTextbox.Name = "searchingStudentIDTextbox";
            this.searchingStudentIDTextbox.Size = new System.Drawing.Size(94, 25);
            this.searchingStudentIDTextbox.TabIndex = 9;
            this.searchingStudentIDTextbox.Text = "학수번호 입력";
            // 
            // openClassList
            // 
            this.openClassList.AutoSize = true;
            this.openClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.openClassList.Location = new System.Drawing.Point(281, 148);
            this.openClassList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.openClassList.Name = "openClassList";
            this.openClassList.Size = new System.Drawing.Size(90, 18);
            this.openClassList.TabIndex = 10;
            this.openClassList.Text = "개설강좌 목록";
            // 
            // courserRegistrationList
            // 
            this.courserRegistrationList.AutoSize = true;
            this.courserRegistrationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.courserRegistrationList.Location = new System.Drawing.Point(281, 420);
            this.courserRegistrationList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.courserRegistrationList.Name = "courserRegistrationList";
            this.courserRegistrationList.Size = new System.Drawing.Size(90, 18);
            this.courserRegistrationList.TabIndex = 11;
            this.courserRegistrationList.Text = "수강신청 목록";
            // 
            // openClassListBox
            // 
            this.openClassListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.openClassListBox.FormattingEnabled = true;
            this.openClassListBox.ItemHeight = 18;
            this.openClassListBox.Items.AddRange(new object[] {
            "윈도우프로그래밍",
            "창의실무프로젝트",
            "알고리즘",
            "컴퓨터조직",
            "오픈소스SW응용",
            "프로그래밍언어론",
            "종교와 원불교",
            "창의적발상기법",
            "객체지향프로그래밍",
            "하나둘셋",
            "둘둘셋"});
            this.openClassListBox.Location = new System.Drawing.Point(283, 166);
            this.openClassListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.openClassListBox.Name = "openClassListBox";
            this.openClassListBox.Size = new System.Drawing.Size(479, 148);
            this.openClassListBox.TabIndex = 12;
            // 
            // courseRegistrationListBox
            // 
            this.courseRegistrationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.courseRegistrationListBox.FormattingEnabled = true;
            this.courseRegistrationListBox.ItemHeight = 18;
            this.courseRegistrationListBox.Location = new System.Drawing.Point(283, 439);
            this.courseRegistrationListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.courseRegistrationListBox.Name = "courseRegistrationListBox";
            this.courseRegistrationListBox.Size = new System.Drawing.Size(477, 238);
            this.courseRegistrationListBox.TabIndex = 13;
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.upButton.Location = new System.Drawing.Point(579, 362);
            this.upButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(86, 29);
            this.upButton.TabIndex = 14;
            this.upButton.Text = "⇈";
            this.upButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.downButton.Location = new System.Drawing.Point(283, 362);
            this.downButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(86, 29);
            this.downButton.TabIndex = 15;
            this.downButton.Text = "⇊";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // decisionButton
            // 
            this.decisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.decisionButton.Location = new System.Drawing.Point(1129, 565);
            this.decisionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(210, 124);
            this.decisionButton.TabIndex = 16;
            this.decisionButton.Text = "이 시간표 사용하기!";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resetButton.Location = new System.Drawing.Point(789, 439);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 29);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "전부 지우기";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_subject,
            this.Column_professor,
            this.Column_class,
            this.Column_days});
            this.dataGridView1.Location = new System.Drawing.Point(771, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(461, 162);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column_subject
            // 
            this.Column_subject.HeaderText = "과목명";
            this.Column_subject.MinimumWidth = 6;
            this.Column_subject.Name = "Column_subject";
            this.Column_subject.Width = 125;
            // 
            // Column_professor
            // 
            this.Column_professor.HeaderText = "교수명";
            this.Column_professor.MinimumWidth = 6;
            this.Column_professor.Name = "Column_professor";
            this.Column_professor.Width = 125;
            // 
            // Column_class
            // 
            this.Column_class.HeaderText = "분반";
            this.Column_class.MinimumWidth = 6;
            this.Column_class.Name = "Column_class";
            this.Column_class.Width = 125;
            // 
            // Column_days
            // 
            this.Column_days.HeaderText = "시간";
            this.Column_days.MinimumWidth = 6;
            this.Column_days.Name = "Column_days";
            this.Column_days.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(517, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "검색(교수명) : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(648, 109);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "학수번호 입력";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.studentID);
            this.panel1.Controls.Add(this.wkuImage);
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Controls.Add(this.WKUniversity);
            this.panel1.Controls.Add(this.WKULink);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 679);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // wkuImage
            // 
            this.wkuImage.Image = global::프로젝트.Properties.Resources.스크린샷_2023_11_13_193609;
            this.wkuImage.Location = new System.Drawing.Point(35, 389);
            this.wkuImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wkuImage.Name = "wkuImage";
            this.wkuImage.Size = new System.Drawing.Size(137, 160);
            this.wkuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wkuImage.TabIndex = 17;
            this.wkuImage.TabStop = false;
            this.wkuImage.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 760);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.decisionButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.courseRegistrationListBox);
            this.Controls.Add(this.openClassListBox);
            this.Controls.Add(this.courserRegistrationList);
            this.Controls.Add(this.openClassList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchingStudentIDTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchingStudentID);
            this.Controls.Add(this.courseRegistration);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form3";
            this.Text = "수강신청 프로그램";
            this.Load += new System.EventHandler(this.courseRegistrationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wkuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.LinkLabel WKULink;
        private System.Windows.Forms.Label WKUniversity;
        private System.Windows.Forms.Label studentID;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label courseRegistration;
        private System.Windows.Forms.Label searchingStudentID;
        private System.Windows.Forms.TextBox searchingStudentIDTextbox;
        private System.Windows.Forms.Label openClassList;
        private System.Windows.Forms.Label courserRegistrationList;
        private System.Windows.Forms.ListBox openClassListBox;
        private System.Windows.Forms.ListBox courseRegistrationListBox;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button decisionButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox wkuImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
