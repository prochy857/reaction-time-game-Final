namespace reaction_time_game
{
    partial class FormHint
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
            checkBoxQ1 = new CheckBox();
            checkBoxQ2 = new CheckBox();
            checkBoxQ3 = new CheckBox();
            checkBoxQ4 = new CheckBox();
            checkBoxQ5 = new CheckBox();
            buttonSend = new Button();
            labelGood = new Label();
            labelMid = new Label();
            labelBad = new Label();
            SuspendLayout();
            // 
            // checkBoxQ1
            // 
            checkBoxQ1.AutoSize = true;
            checkBoxQ1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBoxQ1.Location = new Point(159, 54);
            checkBoxQ1.Name = "checkBoxQ1";
            checkBoxQ1.Size = new Size(229, 34);
            checkBoxQ1.TabIndex = 0;
            checkBoxQ1.Text = "Víš jak se ovládá hra?";
            checkBoxQ1.UseVisualStyleBackColor = true;
            // 
            // checkBoxQ2
            // 
            checkBoxQ2.AutoSize = true;
            checkBoxQ2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBoxQ2.Location = new Point(159, 88);
            checkBoxQ2.Name = "checkBoxQ2";
            checkBoxQ2.Size = new Size(293, 34);
            checkBoxQ2.TabIndex = 1;
            checkBoxQ2.Text = "rozumíš tomu co máš dělat?";
            checkBoxQ2.UseVisualStyleBackColor = true;
            // 
            // checkBoxQ3
            // 
            checkBoxQ3.AutoSize = true;
            checkBoxQ3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBoxQ3.Location = new Point(159, 126);
            checkBoxQ3.Name = "checkBoxQ3";
            checkBoxQ3.Size = new Size(198, 34);
            checkBoxQ3.TabIndex = 2;
            checkBoxQ3.Text = "víš kde co najdeš?";
            checkBoxQ3.UseVisualStyleBackColor = true;
            // 
            // checkBoxQ4
            // 
            checkBoxQ4.AutoSize = true;
            checkBoxQ4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBoxQ4.Location = new Point(159, 163);
            checkBoxQ4.Name = "checkBoxQ4";
            checkBoxQ4.Size = new Size(497, 34);
            checkBoxQ4.TabIndex = 3;
            checkBoxQ4.Text = "víš jak se dá vymazat aktuální skóre a začít znovu?\r\n";
            checkBoxQ4.UseVisualStyleBackColor = true;
            // 
            // checkBoxQ5
            // 
            checkBoxQ5.AutoSize = true;
            checkBoxQ5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBoxQ5.Location = new Point(159, 200);
            checkBoxQ5.Name = "checkBoxQ5";
            checkBoxQ5.Size = new Size(262, 34);
            checkBoxQ5.TabIndex = 4;
            checkBoxQ5.Text = "víš jak se dá hra ukončit?";
            checkBoxQ5.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(159, 261);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 5;
            buttonSend.Text = "Odeslat";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelGood
            // 
            labelGood.AutoSize = true;
            labelGood.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelGood.Location = new Point(159, 311);
            labelGood.Name = "labelGood";
            labelGood.Size = new Size(343, 25);
            labelGood.TabIndex = 6;
            labelGood.Text = "no vidíš to, ani nepotřebuješ nápovědu.";
            labelGood.Visible = false;
            // 
            // labelMid
            // 
            labelMid.AutoSize = true;
            labelMid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMid.Location = new Point(159, 350);
            labelMid.Name = "labelMid";
            labelMid.Size = new Size(505, 25);
            labelMid.TabIndex = 7;
            labelMid.Text = "Netuším čemu nerozumíš na tak jednoduché hře ale dobře";
            labelMid.Visible = false;
            // 
            // labelBad
            // 
            labelBad.AutoSize = true;
            labelBad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelBad.Location = new Point(159, 390);
            labelBad.Name = "labelBad";
            labelBad.Size = new Size(352, 25);
            labelBad.TabIndex = 8;
            labelBad.Text = "Jak je možné že máš přístup na internet..";
            labelBad.Visible = false;
            // 
            // FormHint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBad);
            Controls.Add(labelMid);
            Controls.Add(labelGood);
            Controls.Add(buttonSend);
            Controls.Add(checkBoxQ5);
            Controls.Add(checkBoxQ4);
            Controls.Add(checkBoxQ3);
            Controls.Add(checkBoxQ2);
            Controls.Add(checkBoxQ1);
            Name = "FormHint";
            Text = "FormHint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxQ1;
        private CheckBox checkBoxQ2;
        private CheckBox checkBoxQ3;
        private CheckBox checkBoxQ4;
        private CheckBox checkBoxQ5;
        private Button buttonSend;
        private Label labelGood;
        private Label labelMid;
        private Label labelBad;
    }
}