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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SideATxtBox = new System.Windows.Forms.TextBox();
            this.SideBTxtBox = new System.Windows.Forms.TextBox();
            this.HypotenuseTxtBox = new System.Windows.Forms.TextBox();
            this.AreaTxtBox = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Side A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Side B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SideATxtBox
            // 
            this.SideATxtBox.Location = new System.Drawing.Point(148, 46);
            this.SideATxtBox.Name = "SideATxtBox";
            this.SideATxtBox.Size = new System.Drawing.Size(100, 20);
            this.SideATxtBox.TabIndex = 4;
            // 
            // SideBTxtBox
            // 
            this.SideBTxtBox.Location = new System.Drawing.Point(148, 90);
            this.SideBTxtBox.Name = "SideBTxtBox";
            this.SideBTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SideBTxtBox.TabIndex = 5;
            // 
            // HypotenuseTxtBox
            // 
            this.HypotenuseTxtBox.Location = new System.Drawing.Point(148, 209);
            this.HypotenuseTxtBox.Name = "HypotenuseTxtBox";
            this.HypotenuseTxtBox.Size = new System.Drawing.Size(100, 20);
            this.HypotenuseTxtBox.TabIndex = 6;
            this.HypotenuseTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AreaTxtBox
            // 
            this.AreaTxtBox.Location = new System.Drawing.Point(148, 254);
            this.AreaTxtBox.Name = "AreaTxtBox";
            this.AreaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTxtBox.TabIndex = 7;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(34, 261);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(29, 13);
            this.Area.TabIndex = 8;
            this.Area.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 314);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.AreaTxtBox);
            this.Controls.Add(this.HypotenuseTxtBox);
            this.Controls.Add(this.SideBTxtBox);
            this.Controls.Add(this.SideATxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Right Triangle Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SideATxtBox;
        private System.Windows.Forms.TextBox SideBTxtBox;
        private System.Windows.Forms.TextBox HypotenuseTxtBox;
        private System.Windows.Forms.TextBox AreaTxtBox;
        private System.Windows.Forms.Label Area;
    }
}

