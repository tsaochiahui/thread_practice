namespace Hello_World
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSay = new System.Windows.Forms.Button();
            this.labHelloWorld = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.btnTime = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSay
            // 
            this.btnSay.Location = new System.Drawing.Point(219, 29);
            this.btnSay.Margin = new System.Windows.Forms.Padding(2);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(91, 34);
            this.btnSay.TabIndex = 0;
            this.btnSay.Text = "Say Hello World";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // labHelloWorld
            // 
            this.labHelloWorld.AutoSize = true;
            this.labHelloWorld.Location = new System.Drawing.Point(43, 40);
            this.labHelloWorld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labHelloWorld.Name = "labHelloWorld";
            this.labHelloWorld.Size = new System.Drawing.Size(33, 12);
            this.labHelloWorld.TabIndex = 1;
            this.labHelloWorld.Text = "label1";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(219, 86);
            this.btnCount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(91, 34);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(43, 97);
            this.labCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(11, 12);
            this.labCount.TabIndex = 3;
            this.labCount.Text = "0";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(219, 147);
            this.btnTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(91, 34);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "Current Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(43, 157);
            this.labTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(11, 12);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "多執行續";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "我會壞掉喔";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.labHelloWorld);
            this.Controls.Add(this.btnSay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Label labHelloWorld;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

