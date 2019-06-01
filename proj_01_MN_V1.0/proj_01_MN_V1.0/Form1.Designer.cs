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
            this.InMealAmountBox = new System.Windows.Forms.TextBox();
            this.OutPoorServiceBox = new System.Windows.Forms.TextBox();
            this.OutAverageServiceBox = new System.Windows.Forms.TextBox();
            this.OutExcellentServiceBox = new System.Windows.Forms.TextBox();
            this.MealAmountLabel = new System.Windows.Forms.Label();
            this.PoorServiceLabel = new System.Windows.Forms.Label();
            this.AverageServiceLabel = new System.Windows.Forms.Label();
            this.ExcellentServiceLabel = new System.Windows.Forms.Label();
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
            // InMealAmountBox
            // 
            this.InMealAmountBox.Location = new System.Drawing.Point(131, 51);
            this.InMealAmountBox.Name = "InMealAmountBox";
            this.InMealAmountBox.Size = new System.Drawing.Size(100, 20);
            this.InMealAmountBox.TabIndex = 1;
            this.InMealAmountBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.InMealAmountBox.Leave += new System.EventHandler(this.InMealAmount_Leave);
            // 
            // OutPoorServiceBox
            // 
            this.OutPoorServiceBox.Location = new System.Drawing.Point(131, 117);
            this.OutPoorServiceBox.Name = "OutPoorServiceBox";
            this.OutPoorServiceBox.Size = new System.Drawing.Size(100, 20);
            this.OutPoorServiceBox.TabIndex = 2;
            // 
            // OutAverageServiceBox
            // 
            this.OutAverageServiceBox.Location = new System.Drawing.Point(131, 152);
            this.OutAverageServiceBox.Name = "OutAverageServiceBox";
            this.OutAverageServiceBox.Size = new System.Drawing.Size(100, 20);
            this.OutAverageServiceBox.TabIndex = 3;
            // 
            // OutExcellentServiceBox
            // 
            this.OutExcellentServiceBox.Location = new System.Drawing.Point(131, 190);
            this.OutExcellentServiceBox.Name = "OutExcellentServiceBox";
            this.OutExcellentServiceBox.Size = new System.Drawing.Size(100, 20);
            this.OutExcellentServiceBox.TabIndex = 4;
            // 
            // MealAmountLabel
            // 
            this.MealAmountLabel.AutoSize = true;
            this.MealAmountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealAmountLabel.Location = new System.Drawing.Point(30, 53);
            this.MealAmountLabel.Name = "MealAmountLabel";
            this.MealAmountLabel.Size = new System.Drawing.Size(83, 15);
            this.MealAmountLabel.TabIndex = 5;
            this.MealAmountLabel.Text = "Meal Amount:";
            // 
            // PoorServiceLabel
            // 
            this.PoorServiceLabel.AutoSize = true;
            this.PoorServiceLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoorServiceLabel.Location = new System.Drawing.Point(35, 122);
            this.PoorServiceLabel.Name = "PoorServiceLabel";
            this.PoorServiceLabel.Size = new System.Drawing.Size(78, 15);
            this.PoorServiceLabel.TabIndex = 6;
            this.PoorServiceLabel.Text = "Poor Service:";
            // 
            // AverageServiceLabel
            // 
            this.AverageServiceLabel.AutoSize = true;
            this.AverageServiceLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageServiceLabel.Location = new System.Drawing.Point(18, 157);
            this.AverageServiceLabel.Name = "AverageServiceLabel";
            this.AverageServiceLabel.Size = new System.Drawing.Size(95, 15);
            this.AverageServiceLabel.TabIndex = 7;
            this.AverageServiceLabel.Text = "Average Service:";
            // 
            // ExcellentServiceLabel
            // 
            this.ExcellentServiceLabel.AutoSize = true;
            this.ExcellentServiceLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcellentServiceLabel.Location = new System.Drawing.Point(12, 195);
            this.ExcellentServiceLabel.Name = "ExcellentServiceLabel";
            this.ExcellentServiceLabel.Size = new System.Drawing.Size(101, 15);
            this.ExcellentServiceLabel.TabIndex = 8;
            this.ExcellentServiceLabel.Text = "Excellent Service:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ExcellentServiceLabel);
            this.Controls.Add(this.AverageServiceLabel);
            this.Controls.Add(this.PoorServiceLabel);
            this.Controls.Add(this.MealAmountLabel);
            this.Controls.Add(this.OutExcellentServiceBox);
            this.Controls.Add(this.OutAverageServiceBox);
            this.Controls.Add(this.OutPoorServiceBox);
            this.Controls.Add(this.InMealAmountBox);
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
        private System.Windows.Forms.TextBox InMealAmountBox;
        private System.Windows.Forms.TextBox OutPoorServiceBox;
        private System.Windows.Forms.TextBox OutAverageServiceBox;
        private System.Windows.Forms.TextBox OutExcellentServiceBox;
        private System.Windows.Forms.Label MealAmountLabel;
        private System.Windows.Forms.Label PoorServiceLabel;
        private System.Windows.Forms.Label AverageServiceLabel;
        private System.Windows.Forms.Label ExcellentServiceLabel;
    }
}

