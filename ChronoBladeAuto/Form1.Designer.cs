namespace ChronoBladeAuto
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Whereis = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Adventure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "StartGame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Whereis
            // 
            this.lbl_Whereis.AutoSize = true;
            this.lbl_Whereis.Location = new System.Drawing.Point(10, 9);
            this.lbl_Whereis.Name = "lbl_Whereis";
            this.lbl_Whereis.Size = new System.Drawing.Size(54, 12);
            this.lbl_Whereis.TabIndex = 2;
            this.lbl_Whereis.Text = "Where is";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Adventure
            // 
            this.btn_Adventure.Location = new System.Drawing.Point(107, 71);
            this.btn_Adventure.Name = "btn_Adventure";
            this.btn_Adventure.Size = new System.Drawing.Size(75, 23);
            this.btn_Adventure.TabIndex = 4;
            this.btn_Adventure.Text = "모험";
            this.btn_Adventure.UseVisualStyleBackColor = true;
            this.btn_Adventure.Click += new System.EventHandler(this.btn_Adventure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 315);
            this.Controls.Add(this.btn_Adventure);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_Whereis);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Whereis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Adventure;
    }
}

