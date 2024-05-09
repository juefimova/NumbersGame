namespace _69003_Yuliya_Yafimava_T5
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTip = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(15, 73);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(351, 28);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "0";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Guess";
            // 
            // lbTip
            // 
            this.lbTip.BackColor = System.Drawing.Color.LightPink;
            this.lbTip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTip.Location = new System.Drawing.Point(12, 259);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(358, 32);
            this.lbTip.TabIndex = 2;
            this.lbTip.Text = "Let\'s see..";
            this.lbTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(127, 193);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(132, 22);
            this.tbGuess.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(373, 427);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTime);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Timer timer1;
    }
}