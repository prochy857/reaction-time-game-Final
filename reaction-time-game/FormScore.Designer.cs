namespace reaction_time_game
{
    partial class FormScore
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
            DGVScores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVScores).BeginInit();
            SuspendLayout();
            // 
            // DGVScores
            // 
            DGVScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVScores.Location = new Point(192, 73);
            DGVScores.Name = "DGVScores";
            DGVScores.Size = new Size(426, 306);
            DGVScores.TabIndex = 0;
            
            // 
            // FormScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGVScores);
            Name = "FormScore";
            Text = "FormScore";
            Load += FormScore_Load;
            ((System.ComponentModel.ISupportInitialize)DGVScores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVScores;
    }
}