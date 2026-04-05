namespace reaction_time_game
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pnlGame = new Panel();
            timerWait = new System.Windows.Forms.Timer(components);
            timerReaction = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            lblInfo = new Label();
            lblResult = new Label();
            btnRestart = new Button();
            buttonDog = new Button();
            buttonHint = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(313, 50);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Reaction time game";
            // 
            // pnlGame
            // 
            pnlGame.Anchor = AnchorStyles.None;
            pnlGame.BackColor = Color.Red;
            pnlGame.Cursor = Cursors.Hand;
            pnlGame.Location = new Point(250, 120);
            pnlGame.Name = "pnlGame";
            pnlGame.Size = new Size(300, 200);
            pnlGame.TabIndex = 1;
            pnlGame.Click += pnlGame_Click;
            // 
            // timerWait
            // 
            timerWait.Tick += timerWait_Tick;
            // 
            // timerReaction
            // 
            timerReaction.Interval = 1;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.None;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnStart.Location = new Point(313, 338);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(172, 47);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblInfo.ForeColor = SystemColors.ButtonFace;
            lblInfo.Location = new Point(275, 405);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(255, 17);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Pro začátek hry klikněte na na tlačítko start";
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.ForeColor = SystemColors.ButtonFace;
            lblResult.Location = new Point(12, 169);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(78, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "váš výsledek: ";
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.None;
            btnRestart.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnRestart.Location = new Point(12, 408);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(98, 30);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart hry";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // buttonDog
            // 
            buttonDog.BackColor = Color.Black;
            buttonDog.FlatStyle = FlatStyle.Flat;
            buttonDog.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonDog.ForeColor = SystemColors.ButtonFace;
            buttonDog.Location = new Point(1, 3);
            buttonDog.Name = "buttonDog";
            buttonDog.Size = new Size(61, 24);
            buttonDog.TabIndex = 7;
            buttonDog.Text = "POZOR!";
            buttonDog.UseVisualStyleBackColor = false;
            buttonDog.Click += buttonDog_Click;
            // 
            // buttonHint
            // 
            buttonHint.Anchor = AnchorStyles.None;
            buttonHint.Location = new Point(520, 352);
            buttonHint.Name = "buttonHint";
            buttonHint.Size = new Size(75, 23);
            buttonHint.TabIndex = 8;
            buttonHint.Text = "nápověda";
            buttonHint.UseVisualStyleBackColor = true;
            buttonHint.Click += buttonHint_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.valachpes;
            pictureBox1.Location = new Point(12, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_659174028_Cxg0bbYw3Nm9OZKuhdPwxqAgWDeiNTx7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonHint);
            Controls.Add(buttonDog);
            Controls.Add(btnRestart);
            Controls.Add(lblResult);
            Controls.Add(lblInfo);
            Controls.Add(btnStart);
            Controls.Add(pnlGame);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlGame;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Timer timerReaction;
        private Button btnStart;
        private Label lblInfo;
        private Label lblResult;
        private Button btnRestart;
        private Button buttonDog;
        private Button buttonHint;
        private PictureBox pictureBox1;
    }
}
