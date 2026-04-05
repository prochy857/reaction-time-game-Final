namespace reaction_time_game
{
    partial class FormMenu
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
            buttonNovaHra = new Button();
            buttonScore = new Button();
            buttonHint = new Button();
            SuspendLayout();
            // 
            // buttonNovaHra
            // 
            buttonNovaHra.Anchor = AnchorStyles.None;
            buttonNovaHra.Location = new Point(326, 107);
            buttonNovaHra.Name = "buttonNovaHra";
            buttonNovaHra.Size = new Size(122, 64);
            buttonNovaHra.TabIndex = 0;
            buttonNovaHra.Text = "Nová hra";
            buttonNovaHra.UseVisualStyleBackColor = true;
            buttonNovaHra.Click += buttonNovaHra_Click;
            // 
            // buttonScore
            // 
            buttonScore.Anchor = AnchorStyles.None;
            buttonScore.Location = new Point(326, 177);
            buttonScore.Name = "buttonScore";
            buttonScore.Size = new Size(122, 64);
            buttonScore.TabIndex = 1;
            buttonScore.Text = "Skóre";
            buttonScore.UseVisualStyleBackColor = true;
            buttonScore.Click += buttonScore_Click;
            // 
            // buttonHint
            // 
            buttonHint.Anchor = AnchorStyles.None;
            buttonHint.Location = new Point(326, 247);
            buttonHint.Name = "buttonHint";
            buttonHint.Size = new Size(122, 64);
            buttonHint.TabIndex = 2;
            buttonHint.Text = "Nápověda";
            buttonHint.UseVisualStyleBackColor = true;
            buttonHint.Click += buttonHint_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHint);
            Controls.Add(buttonScore);
            Controls.Add(buttonNovaHra);
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNovaHra;
        private Button buttonScore;
        private Button buttonHint;
    }
}