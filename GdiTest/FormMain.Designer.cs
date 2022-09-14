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
            this.chkOptimizedDoubleBuffer = new System.Windows.Forms.CheckBox();
            this.chkUserPaint = new System.Windows.Forms.CheckBox();
            this.chkAllPaintingInWmPaint = new System.Windows.Forms.CheckBox();
            this.chkOpaque = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkOptimizedDoubleBuffer
            // 
            this.chkOptimizedDoubleBuffer.AutoSize = true;
            this.chkOptimizedDoubleBuffer.Location = new System.Drawing.Point(12, 34);
            this.chkOptimizedDoubleBuffer.Name = "chkOptimizedDoubleBuffer";
            this.chkOptimizedDoubleBuffer.Size = new System.Drawing.Size(152, 16);
            this.chkOptimizedDoubleBuffer.TabIndex = 0;
            this.chkOptimizedDoubleBuffer.Text = "OptimizedDoubleBuffer";
            this.chkOptimizedDoubleBuffer.UseVisualStyleBackColor = true;
            this.chkOptimizedDoubleBuffer.CheckedChanged += new System.EventHandler(this.chkOpaque_CheckedChanged);
            // 
            // chkUserPaint
            // 
            this.chkUserPaint.AutoSize = true;
            this.chkUserPaint.Location = new System.Drawing.Point(12, 12);
            this.chkUserPaint.Name = "chkUserPaint";
            this.chkUserPaint.Size = new System.Drawing.Size(78, 16);
            this.chkUserPaint.TabIndex = 1;
            this.chkUserPaint.Text = "UserPaint";
            this.chkUserPaint.UseVisualStyleBackColor = true;
            this.chkUserPaint.CheckedChanged += new System.EventHandler(this.chkOpaque_CheckedChanged);
            // 
            // chkAllPaintingInWmPaint
            // 
            this.chkAllPaintingInWmPaint.AutoSize = true;
            this.chkAllPaintingInWmPaint.Location = new System.Drawing.Point(12, 56);
            this.chkAllPaintingInWmPaint.Name = "chkAllPaintingInWmPaint";
            this.chkAllPaintingInWmPaint.Size = new System.Drawing.Size(142, 16);
            this.chkAllPaintingInWmPaint.TabIndex = 2;
            this.chkAllPaintingInWmPaint.Text = "AllPaintingInWmPaint";
            this.chkAllPaintingInWmPaint.UseVisualStyleBackColor = true;
            this.chkAllPaintingInWmPaint.CheckedChanged += new System.EventHandler(this.chkOpaque_CheckedChanged);
            // 
            // chkOpaque
            // 
            this.chkOpaque.AutoSize = true;
            this.chkOpaque.Location = new System.Drawing.Point(12, 78);
            this.chkOpaque.Name = "chkOpaque";
            this.chkOpaque.Size = new System.Drawing.Size(68, 16);
            this.chkOpaque.TabIndex = 3;
            this.chkOpaque.Text = "Opaque";
            this.chkOpaque.UseVisualStyleBackColor = true;
            this.chkOpaque.CheckedChanged += new System.EventHandler(this.chkOpaque_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkOpaque);
            this.Controls.Add(this.chkAllPaintingInWmPaint);
            this.Controls.Add(this.chkUserPaint);
            this.Controls.Add(this.chkOptimizedDoubleBuffer);
            this.Name = "FormMain";
            this.Text = "GDI Test";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOptimizedDoubleBuffer;
        private System.Windows.Forms.CheckBox chkUserPaint;
        private System.Windows.Forms.CheckBox chkAllPaintingInWmPaint;
        private System.Windows.Forms.CheckBox chkOpaque;
    }
}

