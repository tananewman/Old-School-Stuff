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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hypotenuse = new System.Windows.Forms.Label();
            this.SideAInputBox = new System.Windows.Forms.TextBox();
            this.SideBInputBox = new System.Windows.Forms.TextBox();
            this.HypotenuseOutputBox = new System.Windows.Forms.TextBox();
            this.HypotenuseButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem3,
            this.aboutToolStripMenuItem1});
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // exitToolStripMenuItem3
            // 
            this.exitToolStripMenuItem3.Name = "exitToolStripMenuItem3";
            this.exitToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem3.Text = "Exit";
            this.exitToolStripMenuItem3.Click += new System.EventHandler(this.exitToolStripMenuItem3_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Side A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Side B";
            // 
            // Hypotenuse
            // 
            this.Hypotenuse.AutoSize = true;
            this.Hypotenuse.Location = new System.Drawing.Point(32, 192);
            this.Hypotenuse.Name = "Hypotenuse";
            this.Hypotenuse.Size = new System.Drawing.Size(64, 13);
            this.Hypotenuse.TabIndex = 4;
            this.Hypotenuse.Text = "Hypotenuse";
            this.Hypotenuse.Click += new System.EventHandler(this.label3_Click);
            // 
            // SideAInputBox
            // 
            this.SideAInputBox.Location = new System.Drawing.Point(136, 44);
            this.SideAInputBox.Name = "SideAInputBox";
            this.SideAInputBox.Size = new System.Drawing.Size(100, 20);
            this.SideAInputBox.TabIndex = 5;
            this.SideAInputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SideBInputBox
            // 
            this.SideBInputBox.Location = new System.Drawing.Point(136, 88);
            this.SideBInputBox.Name = "SideBInputBox";
            this.SideBInputBox.Size = new System.Drawing.Size(100, 20);
            this.SideBInputBox.TabIndex = 6;
            // 
            // HypotenuseOutputBox
            // 
            this.HypotenuseOutputBox.Location = new System.Drawing.Point(136, 192);
            this.HypotenuseOutputBox.Name = "HypotenuseOutputBox";
            this.HypotenuseOutputBox.Size = new System.Drawing.Size(100, 20);
            this.HypotenuseOutputBox.TabIndex = 7;
            // 
            // HypotenuseButton
            // 
            this.HypotenuseButton.Location = new System.Drawing.Point(136, 134);
            this.HypotenuseButton.Name = "HypotenuseButton";
            this.HypotenuseButton.Size = new System.Drawing.Size(75, 23);
            this.HypotenuseButton.TabIndex = 8;
            this.HypotenuseButton.Text = "Calculate";
            this.HypotenuseButton.UseVisualStyleBackColor = true;
            this.HypotenuseButton.Click += new System.EventHandler(this.HypotenuseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.HypotenuseButton);
            this.Controls.Add(this.HypotenuseOutputBox);
            this.Controls.Add(this.SideBInputBox);
            this.Controls.Add(this.SideAInputBox);
            this.Controls.Add(this.Hypotenuse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Hypotenuse;
        private System.Windows.Forms.TextBox SideAInputBox;
        private System.Windows.Forms.TextBox SideBInputBox;
        private System.Windows.Forms.TextBox HypotenuseOutputBox;
        private System.Windows.Forms.Button HypotenuseButton;
    }
}

