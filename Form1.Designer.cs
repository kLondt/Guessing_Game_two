namespace Guessing_Game_two
{
    partial class Form1
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
            this.LblYourGuess = new System.Windows.Forms.Label();
            this.BtnGenerateHint = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtUinput = new System.Windows.Forms.TextBox();
            this.LstOut = new System.Windows.Forms.ListBox();
            this.LblHint = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LstOutS = new System.Windows.Forms.ListBox();
            this.LblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblYourGuess
            // 
            this.LblYourGuess.AutoSize = true;
            this.LblYourGuess.Location = new System.Drawing.Point(23, 59);
            this.LblYourGuess.Name = "LblYourGuess";
            this.LblYourGuess.Size = new System.Drawing.Size(83, 16);
            this.LblYourGuess.TabIndex = 1;
            this.LblYourGuess.Text = "Your Guess :";
            // 
            // BtnGenerateHint
            // 
            this.BtnGenerateHint.Location = new System.Drawing.Point(410, 125);
            this.BtnGenerateHint.Name = "BtnGenerateHint";
            this.BtnGenerateHint.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerateHint.TabIndex = 2;
            this.BtnGenerateHint.Text = "Hint";
            this.BtnGenerateHint.UseVisualStyleBackColor = true;
            this.BtnGenerateHint.Click += new System.EventHandler(this.BtnGenerateHint_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(666, 239);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(666, 370);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtUinput
            // 
            this.TxtUinput.Location = new System.Drawing.Point(124, 59);
            this.TxtUinput.Name = "TxtUinput";
            this.TxtUinput.Size = new System.Drawing.Size(100, 22);
            this.TxtUinput.TabIndex = 5;
            this.TxtUinput.TextChanged += new System.EventHandler(this.TxtUinput_TextChanged);
            // 
            // LstOut
            // 
            this.LstOut.FormattingEnabled = true;
            this.LstOut.ItemHeight = 16;
            this.LstOut.Location = new System.Drawing.Point(601, 42);
            this.LstOut.Name = "LstOut";
            this.LstOut.Size = new System.Drawing.Size(152, 180);
            this.LstOut.TabIndex = 6;
            this.LstOut.SelectedIndexChanged += new System.EventHandler(this.LstOut_SelectedIndexChanged);
            // 
            // LblHint
            // 
            this.LblHint.AutoSize = true;
            this.LblHint.Location = new System.Drawing.Point(407, 42);
            this.LblHint.Name = "LblHint";
            this.LblHint.Size = new System.Drawing.Size(0, 16);
            this.LblHint.TabIndex = 9;
            this.LblHint.Click += new System.EventHandler(this.LblHint_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(133, 125);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 10;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LstOutS
            // 
            this.LstOutS.FormattingEnabled = true;
            this.LstOutS.ItemHeight = 16;
            this.LstOutS.Location = new System.Drawing.Point(89, 335);
            this.LstOutS.Name = "LstOutS";
            this.LstOutS.Size = new System.Drawing.Size(88, 36);
            this.LstOutS.TabIndex = 11;
            this.LstOutS.SelectedIndexChanged += new System.EventHandler(this.LstOutS_SelectedIndexChanged);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(86, 290);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(41, 16);
            this.LblScore.TabIndex = 13;
            this.LblScore.Text = "score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LstOutS);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.LblHint);
            this.Controls.Add(this.LstOut);
            this.Controls.Add(this.TxtUinput);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnGenerateHint);
            this.Controls.Add(this.LblYourGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblYourGuess;
        private System.Windows.Forms.Button BtnGenerateHint;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtUinput;
        private System.Windows.Forms.ListBox LstOut;
        private System.Windows.Forms.Label LblHint;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ListBox LstOutS;
        private System.Windows.Forms.Label LblScore;
    }
}

