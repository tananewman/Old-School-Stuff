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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtnSame = new System.Windows.Forms.RadioButton();
            this.RadioBtnExpress = new System.Windows.Forms.RadioButton();
            this.RadioBtnStd = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RadioBtnQuantity = new System.Windows.Forms.RadioButton();
            this.RadioBtnWeight = new System.Windows.Forms.RadioButton();
            this.InputBxQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioBtnYes = new System.Windows.Forms.RadioButton();
            this.RadioBtnNo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red Fern Electronics";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shipping Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBtnSame);
            this.groupBox1.Controls.Add(this.RadioBtnExpress);
            this.groupBox1.Controls.Add(this.RadioBtnStd);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(35, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method";
            // 
            // RadioBtnSame
            // 
            this.RadioBtnSame.AutoSize = true;
            this.RadioBtnSame.Location = new System.Drawing.Point(14, 73);
            this.RadioBtnSame.Name = "RadioBtnSame";
            this.RadioBtnSame.Size = new System.Drawing.Size(74, 17);
            this.RadioBtnSame.TabIndex = 2;
            this.RadioBtnSame.TabStop = true;
            this.RadioBtnSame.Text = "Same Day";
            this.RadioBtnSame.UseVisualStyleBackColor = true;
            // 
            // RadioBtnExpress
            // 
            this.RadioBtnExpress.AutoSize = true;
            this.RadioBtnExpress.Location = new System.Drawing.Point(14, 50);
            this.RadioBtnExpress.Name = "RadioBtnExpress";
            this.RadioBtnExpress.Size = new System.Drawing.Size(62, 17);
            this.RadioBtnExpress.TabIndex = 1;
            this.RadioBtnExpress.TabStop = true;
            this.RadioBtnExpress.Text = "Express";
            this.RadioBtnExpress.UseVisualStyleBackColor = true;
            // 
            // RadioBtnStd
            // 
            this.RadioBtnStd.AutoSize = true;
            this.RadioBtnStd.Location = new System.Drawing.Point(14, 27);
            this.RadioBtnStd.Name = "RadioBtnStd";
            this.RadioBtnStd.Size = new System.Drawing.Size(68, 17);
            this.RadioBtnStd.TabIndex = 0;
            this.RadioBtnStd.TabStop = true;
            this.RadioBtnStd.Text = "Standard";
            this.RadioBtnStd.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(131, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RadioBtnQuantity);
            this.groupBox3.Controls.Add(this.RadioBtnWeight);
            this.groupBox3.Location = new System.Drawing.Point(246, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 90);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category";
            // 
            // RadioBtnQuantity
            // 
            this.RadioBtnQuantity.AutoSize = true;
            this.RadioBtnQuantity.Location = new System.Drawing.Point(19, 27);
            this.RadioBtnQuantity.Name = "RadioBtnQuantity";
            this.RadioBtnQuantity.Size = new System.Drawing.Size(64, 17);
            this.RadioBtnQuantity.TabIndex = 3;
            this.RadioBtnQuantity.TabStop = true;
            this.RadioBtnQuantity.Text = "Quantity";
            this.RadioBtnQuantity.UseVisualStyleBackColor = true;
            // 
            // RadioBtnWeight
            // 
            this.RadioBtnWeight.AutoSize = true;
            this.RadioBtnWeight.Location = new System.Drawing.Point(19, 50);
            this.RadioBtnWeight.Name = "RadioBtnWeight";
            this.RadioBtnWeight.Size = new System.Drawing.Size(59, 17);
            this.RadioBtnWeight.TabIndex = 4;
            this.RadioBtnWeight.TabStop = true;
            this.RadioBtnWeight.Text = "Weight";
            this.RadioBtnWeight.UseVisualStyleBackColor = true;
            // 
            // InputBxQuantity
            // 
            this.InputBxQuantity.Location = new System.Drawing.Point(35, 278);
            this.InputBxQuantity.Name = "InputBxQuantity";
            this.InputBxQuantity.Size = new System.Drawing.Size(137, 20);
            this.InputBxQuantity.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioBtnYes);
            this.groupBox2.Controls.Add(this.RadioBtnNo);
            this.groupBox2.Location = new System.Drawing.Point(246, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 95);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alaska/Hawaii?";
            // 
            // RadioBtnYes
            // 
            this.RadioBtnYes.AutoSize = true;
            this.RadioBtnYes.Location = new System.Drawing.Point(19, 28);
            this.RadioBtnYes.Name = "RadioBtnYes";
            this.RadioBtnYes.Size = new System.Drawing.Size(43, 17);
            this.RadioBtnYes.TabIndex = 5;
            this.RadioBtnYes.TabStop = true;
            this.RadioBtnYes.Text = "Yes";
            this.RadioBtnYes.UseVisualStyleBackColor = true;
            // 
            // RadioBtnNo
            // 
            this.RadioBtnNo.AutoSize = true;
            this.RadioBtnNo.Location = new System.Drawing.Point(19, 51);
            this.RadioBtnNo.Name = "RadioBtnNo";
            this.RadioBtnNo.Size = new System.Drawing.Size(39, 17);
            this.RadioBtnNo.TabIndex = 6;
            this.RadioBtnNo.TabStop = true;
            this.RadioBtnNo.Text = "No";
            this.RadioBtnNo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity/Weight";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(399, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InputBxQuantity);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Red Fern Shipping Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtnSame;
        private System.Windows.Forms.RadioButton RadioBtnExpress;
        private System.Windows.Forms.RadioButton RadioBtnStd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RadioBtnQuantity;
        private System.Windows.Forms.RadioButton RadioBtnWeight;
        private System.Windows.Forms.TextBox InputBxQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadioBtnYes;
        private System.Windows.Forms.RadioButton RadioBtnNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}

