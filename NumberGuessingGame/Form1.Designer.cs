namespace NumberGuessingGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblMessage = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.White;
            lblMessage.Location = new Point(229, 215);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(244, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Guess a number between 1 and 100";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(229, 157);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(433, 27);
            txtGuess.TabIndex = 1;
            txtGuess.KeyDown += txtGuess_KeyDown; // Ավելացնում ենք KeyDown իրադարձությունը
                                                  // 
                                                  // btnGuess
                                                  // 
            btnGuess.Location = new Point(512, 262);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(150, 39);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(229, 262);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(148, 39);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 457);
            Controls.Add(btnRestart);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblMessage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "Form1";
            Text = "Number Guessing Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
        private TextBox txtGuess;
        private Button btnGuess;
        private Button btnRestart;
    }
}
