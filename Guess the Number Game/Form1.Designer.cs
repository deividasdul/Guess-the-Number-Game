namespace Guess_the_Number_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameTitle = new Label();
            guessBtn = new Button();
            userInputBox = new TextBox();
            enterYourGuess = new Label();
            computerOutputBox = new TextBox();
            label3 = new Label();
            restartBtn = new Button();
            SuspendLayout();
            // 
            // gameTitle
            // 
            gameTitle.AutoSize = true;
            gameTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            gameTitle.Location = new Point(118, 9);
            gameTitle.Name = "gameTitle";
            gameTitle.Size = new Size(557, 65);
            gameTitle.TabIndex = 0;
            gameTitle.Text = "Guess the Number Game";
            // 
            // guessBtn
            // 
            guessBtn.Location = new Point(296, 365);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(146, 73);
            guessBtn.TabIndex = 1;
            guessBtn.Text = "Guess";
            guessBtn.UseVisualStyleBackColor = true;
            guessBtn.Click += button1_Click;
            // 
            // userInputBox
            // 
            userInputBox.Location = new Point(296, 336);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(146, 23);
            userInputBox.TabIndex = 2;
            userInputBox.TextAlign = HorizontalAlignment.Center;
            // 
            // enterYourGuess
            // 
            enterYourGuess.AutoSize = true;
            enterYourGuess.Location = new Point(322, 318);
            enterYourGuess.Name = "enterYourGuess";
            enterYourGuess.Size = new Size(95, 15);
            enterYourGuess.TabIndex = 3;
            enterYourGuess.Text = "Enter Your Guess";
            // 
            // computerOutputBox
            // 
            computerOutputBox.Location = new Point(637, 415);
            computerOutputBox.Name = "computerOutputBox";
            computerOutputBox.PasswordChar = '*';
            computerOutputBox.ReadOnly = true;
            computerOutputBox.Size = new Size(151, 23);
            computerOutputBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 394);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 5;
            label3.Text = "Computer's Secret Number";
            // 
            // restartBtn
            // 
            restartBtn.Location = new Point(12, 365);
            restartBtn.Name = "restartBtn";
            restartBtn.Size = new Size(146, 73);
            restartBtn.TabIndex = 6;
            restartBtn.Text = "Restart";
            restartBtn.UseVisualStyleBackColor = true;
            restartBtn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(restartBtn);
            Controls.Add(label3);
            Controls.Add(computerOutputBox);
            Controls.Add(enterYourGuess);
            Controls.Add(userInputBox);
            Controls.Add(guessBtn);
            Controls.Add(gameTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameTitle;
        private Button guessBtn;
        private TextBox userInputBox;
        private Label enterYourGuess;
        private TextBox computerOutputBox;
        private Label label3;
        private Button restartBtn;
    }
}