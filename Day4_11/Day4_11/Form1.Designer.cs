namespace Day4_11
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comFont = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoSoccor = new System.Windows.Forms.RadioButton();
            this.radBaseBall = new System.Windows.Forms.RadioButton();
            this.radBasketBall = new System.Windows.Forms.RadioButton();
            this.radTkd = new System.Windows.Forms.RadioButton();
            this.lblSports = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.comFont);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comFont
            // 
            this.comFont.FormattingEnabled = true;
            this.comFont.Location = new System.Drawing.Point(94, 34);
            this.comFont.Name = "comFont";
            this.comFont.Size = new System.Drawing.Size(270, 20);
            this.comFont.TabIndex = 0;
            this.comFont.SelectedIndexChanged += new System.EventHandler(this.comFont_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(396, 34);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(60, 16);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "볼드체";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(500, 34);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(72, 16);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "이탤릭체";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(97, 70);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(474, 21);
            this.txtMessage.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSports);
            this.groupBox2.Controls.Add(this.radTkd);
            this.groupBox2.Controls.Add(this.radBasketBall);
            this.groupBox2.Controls.Add(this.radBaseBall);
            this.groupBox2.Controls.Add(this.rdoSoccor);
            this.groupBox2.Location = new System.Drawing.Point(18, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rdoSoccor
            // 
            this.rdoSoccor.AutoSize = true;
            this.rdoSoccor.Location = new System.Drawing.Point(45, 42);
            this.rdoSoccor.Name = "rdoSoccor";
            this.rdoSoccor.Size = new System.Drawing.Size(47, 16);
            this.rdoSoccor.TabIndex = 0;
            this.rdoSoccor.TabStop = true;
            this.rdoSoccor.Text = "축구";
            this.rdoSoccor.UseVisualStyleBackColor = true;
            this.rdoSoccor.CheckedChanged += new System.EventHandler(this.rdoSoccor_CheckedChanged);
            // 
            // radBaseBall
            // 
            this.radBaseBall.AutoSize = true;
            this.radBaseBall.Location = new System.Drawing.Point(132, 42);
            this.radBaseBall.Name = "radBaseBall";
            this.radBaseBall.Size = new System.Drawing.Size(47, 16);
            this.radBaseBall.TabIndex = 1;
            this.radBaseBall.TabStop = true;
            this.radBaseBall.Text = "야구";
            this.radBaseBall.UseVisualStyleBackColor = true;
            this.radBaseBall.CheckedChanged += new System.EventHandler(this.radBaseBall_CheckedChanged);
            // 
            // radBasketBall
            // 
            this.radBasketBall.AutoSize = true;
            this.radBasketBall.Location = new System.Drawing.Point(220, 42);
            this.radBasketBall.Name = "radBasketBall";
            this.radBasketBall.Size = new System.Drawing.Size(47, 16);
            this.radBasketBall.TabIndex = 2;
            this.radBasketBall.TabStop = true;
            this.radBasketBall.Text = "농구";
            this.radBasketBall.UseVisualStyleBackColor = true;
            this.radBasketBall.CheckedChanged += new System.EventHandler(this.radBasketBall_CheckedChanged);
            // 
            // radTkd
            // 
            this.radTkd.AutoSize = true;
            this.radTkd.Location = new System.Drawing.Point(319, 42);
            this.radTkd.Name = "radTkd";
            this.radTkd.Size = new System.Drawing.Size(59, 16);
            this.radTkd.TabIndex = 3;
            this.radTkd.TabStop = true;
            this.radTkd.Text = "태권도";
            this.radTkd.UseVisualStyleBackColor = true;
            this.radTkd.CheckedChanged += new System.EventHandler(this.radTkd_CheckedChanged);
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(52, 74);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(38, 12);
            this.lblSports.TabIndex = 4;
            this.lblSports.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox comFont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.RadioButton radTkd;
        private System.Windows.Forms.RadioButton radBasketBall;
        private System.Windows.Forms.RadioButton radBaseBall;
        private System.Windows.Forms.RadioButton rdoSoccor;
    }
}

