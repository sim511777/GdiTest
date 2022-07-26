namespace GdiTest {
    partial class FormMain {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.lbxTest = new System.Windows.Forms.ListBox();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.tbxDrawString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pbx = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxTest
            // 
            this.lbxTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxTest.FormattingEnabled = true;
            this.lbxTest.ItemHeight = 12;
            this.lbxTest.Items.AddRange(new object[] {
            "Line",
            "PolyLine",
            "Ellipse",
            "FillEllipse",
            "Rectangle",
            "FillRectangle",
            "DrawString"});
            this.lbxTest.Location = new System.Drawing.Point(0, 0);
            this.lbxTest.Name = "lbxTest";
            this.lbxTest.Size = new System.Drawing.Size(198, 333);
            this.lbxTest.TabIndex = 0;
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxLog.Location = new System.Drawing.Point(0, 439);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxLog.Size = new System.Drawing.Size(858, 158);
            this.tbxLog.TabIndex = 1;
            this.tbxLog.WordWrap = false;
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTest.Location = new System.Drawing.Point(0, 413);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(198, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // tbxDrawString
            // 
            this.tbxDrawString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxDrawString.Location = new System.Drawing.Point(0, 12);
            this.tbxDrawString.Multiline = true;
            this.tbxDrawString.Name = "tbxDrawString";
            this.tbxDrawString.Size = new System.Drawing.Size(198, 68);
            this.tbxDrawString.TabIndex = 3;
            this.tbxDrawString.Text = "Hello World!";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "DrawString";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxTest);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(660, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 436);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxDrawString);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 80);
            this.panel2.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 436);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(858, 3);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // pbx
            // 
            this.pbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbx.Location = new System.Drawing.Point(0, 0);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(660, 436);
            this.pbx.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 597);
            this.Controls.Add(this.pbx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbxLog);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTest;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox tbxDrawString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pbx;
    }
}

