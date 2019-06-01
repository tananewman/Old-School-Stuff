namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiameterOfWheelLabel = new System.Windows.Forms.Label();
            this.TurnsPerMileLabel = new System.Windows.Forms.Label();
            this.DiamOfWheelInputBox = new System.Windows.Forms.TextBox();
            this.TurnsPerMileOutputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // DiameterOfWheelLabel
            // 
            this.DiameterOfWheelLabel.AutoSize = true;
            this.DiameterOfWheelLabel.Location = new System.Drawing.Point(15, 79);
            this.DiameterOfWheelLabel.Name = "DiameterOfWheelLabel";
            this.DiameterOfWheelLabel.Size = new System.Drawing.Size(95, 13);
            this.DiameterOfWheelLabel.TabIndex = 1;
            this.DiameterOfWheelLabel.Text = "Diameter of Wheel";
            this.DiameterOfWheelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TurnsPerMileLabel
            // 
            this.TurnsPerMileLabel.AutoSize = true;
            this.TurnsPerMileLabel.Location = new System.Drawing.Point(15, 136);
            this.TurnsPerMileLabel.Name = "TurnsPerMileLabel";
            this.TurnsPerMileLabel.Size = new System.Drawing.Size(74, 13);
            this.TurnsPerMileLabel.TabIndex = 2;
            this.TurnsPerMileLabel.Text = "Turns per Mile";
            // 
            // DiamOfWheelInputBox
            // 
            this.DiamOfWheelInputBox.Location = new System.Drawing.Point(128, 79);
            this.DiamOfWheelInputBox.Name = "DiamOfWheelInputBox";
            this.DiamOfWheelInputBox.Size = new System.Drawing.Size(100, 20);
            this.DiamOfWheelInputBox.TabIndex = 3;
            this.DiamOfWheelInputBox.TextChanged += new System.EventHandler(this.DiamOfWheelInputBox_TextChanged);
            this.DiamOfWheelInputBox.Leave += new System.EventHandler(this.DiamOfWheelInputBox_Leave);
            // 
            // TurnsPerMileOutputBox
            // 
            this.TurnsPerMileOutputBox.Location = new System.Drawing.Point(128, 129);
            this.TurnsPerMileOutputBox.Name = "TurnsPerMileOutputBox";
            this.TurnsPerMileOutputBox.Size = new System.Drawing.Size(100, 20);
            this.TurnsPerMileOutputBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TurnsPerMileOutputBox);
            this.Controls.Add(this.DiamOfWheelInputBox);
            this.Controls.Add(this.TurnsPerMileLabel);
            this.Controls.Add(this.DiameterOfWheelLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label DiameterOfWheelLabel;
        private System.Windows.Forms.Label TurnsPerMileLabel;
        private System.Windows.Forms.TextBox DiamOfWheelInputBox;
        private System.Windows.Forms.TextBox TurnsPerMileOutputBox;
        private System.Windows.Forms.Button button1;
    }
}

