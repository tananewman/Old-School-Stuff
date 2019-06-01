namespace WindowsFormsApplication1
{
    partial class PirateWindow
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
            this.NumPiratesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SplitGoldButton = new System.Windows.Forms.Button();
            this.NumOfPiratesInput = new System.Windows.Forms.TextBox();
            this.NumOfGoldInput = new System.Windows.Forms.TextBox();
            this.JacksShareTextBox = new System.Windows.Forms.TextBox();
            this.MatesShareTextBox = new System.Windows.Forms.TextBox();
            this.CrewShareTextBox = new System.Windows.Forms.TextBox();
            this.PiratesBenevTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumPiratesLabel
            // 
            this.NumPiratesLabel.AutoSize = true;
            this.NumPiratesLabel.Location = new System.Drawing.Point(28, 64);
            this.NumPiratesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumPiratesLabel.Name = "NumPiratesLabel";
            this.NumPiratesLabel.Size = new System.Drawing.Size(113, 18);
            this.NumPiratesLabel.TabIndex = 0;
            this.NumPiratesLabel.Text = "Number of Pirates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Gold Coins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jack\'s Share";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mate\'s Share";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crew Members\' Share";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pirates\' Benevolent Fund";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SplitGoldButton
            // 
            this.SplitGoldButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplitGoldButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SplitGoldButton.Location = new System.Drawing.Point(108, 141);
            this.SplitGoldButton.Name = "SplitGoldButton";
            this.SplitGoldButton.Size = new System.Drawing.Size(117, 34);
            this.SplitGoldButton.TabIndex = 6;
            this.SplitGoldButton.Text = "Split the Gold";
            this.SplitGoldButton.UseVisualStyleBackColor = true;
            this.SplitGoldButton.Click += new System.EventHandler(this.SplitGoldButton_Click);
            // 
            // NumOfPiratesInput
            // 
            this.NumOfPiratesInput.Location = new System.Drawing.Point(232, 57);
            this.NumOfPiratesInput.Name = "NumOfPiratesInput";
            this.NumOfPiratesInput.Size = new System.Drawing.Size(100, 25);
            this.NumOfPiratesInput.TabIndex = 7;
            this.NumOfPiratesInput.TextChanged += new System.EventHandler(this.NumOfPiratesInput_TextChanged);
            // 
            // NumOfGoldInput
            // 
            this.NumOfGoldInput.Location = new System.Drawing.Point(232, 99);
            this.NumOfGoldInput.Name = "NumOfGoldInput";
            this.NumOfGoldInput.Size = new System.Drawing.Size(100, 25);
            this.NumOfGoldInput.TabIndex = 8;
            // 
            // JacksShareTextBox
            // 
            this.JacksShareTextBox.Location = new System.Drawing.Point(232, 198);
            this.JacksShareTextBox.Name = "JacksShareTextBox";
            this.JacksShareTextBox.Size = new System.Drawing.Size(100, 25);
            this.JacksShareTextBox.TabIndex = 9;
            // 
            // MatesShareTextBox
            // 
            this.MatesShareTextBox.Location = new System.Drawing.Point(232, 240);
            this.MatesShareTextBox.Name = "MatesShareTextBox";
            this.MatesShareTextBox.Size = new System.Drawing.Size(100, 25);
            this.MatesShareTextBox.TabIndex = 10;
            // 
            // CrewShareTextBox
            // 
            this.CrewShareTextBox.Location = new System.Drawing.Point(232, 291);
            this.CrewShareTextBox.Name = "CrewShareTextBox";
            this.CrewShareTextBox.Size = new System.Drawing.Size(100, 25);
            this.CrewShareTextBox.TabIndex = 11;
            // 
            // PiratesBenevTextBox
            // 
            this.PiratesBenevTextBox.Location = new System.Drawing.Point(232, 341);
            this.PiratesBenevTextBox.Name = "PiratesBenevTextBox";
            this.PiratesBenevTextBox.Size = new System.Drawing.Size(100, 25);
            this.PiratesBenevTextBox.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PirateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(366, 421);
            this.Controls.Add(this.PiratesBenevTextBox);
            this.Controls.Add(this.CrewShareTextBox);
            this.Controls.Add(this.MatesShareTextBox);
            this.Controls.Add(this.JacksShareTextBox);
            this.Controls.Add(this.NumOfGoldInput);
            this.Controls.Add(this.NumOfPiratesInput);
            this.Controls.Add(this.SplitGoldButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumPiratesLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PirateWindow";
            this.Text = "The Pirate Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumPiratesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SplitGoldButton;
        private System.Windows.Forms.TextBox NumOfPiratesInput;
        private System.Windows.Forms.TextBox NumOfGoldInput;
        private System.Windows.Forms.TextBox JacksShareTextBox;
        private System.Windows.Forms.TextBox MatesShareTextBox;
        private System.Windows.Forms.TextBox CrewShareTextBox;
        private System.Windows.Forms.TextBox PiratesBenevTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

