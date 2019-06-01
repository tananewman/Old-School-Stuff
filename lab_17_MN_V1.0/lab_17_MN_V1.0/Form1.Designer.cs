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
            this.StdRadioBtn = new System.Windows.Forms.RadioButton();
            this.ExpressRadioBtn = new System.Windows.Forms.RadioButton();
            this.SameRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StdRadioBtn
            // 
            this.StdRadioBtn.AutoSize = true;
            this.StdRadioBtn.Location = new System.Drawing.Point(8, 19);
            this.StdRadioBtn.Name = "StdRadioBtn";
            this.StdRadioBtn.Size = new System.Drawing.Size(68, 17);
            this.StdRadioBtn.TabIndex = 0;
            this.StdRadioBtn.TabStop = true;
            this.StdRadioBtn.Text = "Standard";
            this.StdRadioBtn.UseVisualStyleBackColor = true;
            this.StdRadioBtn.CheckedChanged += new System.EventHandler(this.StdRadioBtn_CheckedChanged);
            // 
            // ExpressRadioBtn
            // 
            this.ExpressRadioBtn.AutoSize = true;
            this.ExpressRadioBtn.Location = new System.Drawing.Point(8, 42);
            this.ExpressRadioBtn.Name = "ExpressRadioBtn";
            this.ExpressRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.ExpressRadioBtn.TabIndex = 1;
            this.ExpressRadioBtn.TabStop = true;
            this.ExpressRadioBtn.Text = "Express";
            this.ExpressRadioBtn.UseVisualStyleBackColor = true;
            this.ExpressRadioBtn.CheckedChanged += new System.EventHandler(this.ExpressRadioBtn_CheckedChanged);
            // 
            // SameRadioBtn
            // 
            this.SameRadioBtn.AutoSize = true;
            this.SameRadioBtn.Location = new System.Drawing.Point(8, 65);
            this.SameRadioBtn.Name = "SameRadioBtn";
            this.SameRadioBtn.Size = new System.Drawing.Size(74, 17);
            this.SameRadioBtn.TabIndex = 2;
            this.SameRadioBtn.TabStop = true;
            this.SameRadioBtn.Text = "Same Day";
            this.SameRadioBtn.UseVisualStyleBackColor = true;
            this.SameRadioBtn.CheckedChanged += new System.EventHandler(this.SameRadioBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StdRadioBtn);
            this.groupBox1.Controls.Add(this.ExpressRadioBtn);
            this.groupBox1.Controls.Add(this.SameRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 186);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Shipping Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton StdRadioBtn;
        private System.Windows.Forms.RadioButton ExpressRadioBtn;
        private System.Windows.Forms.RadioButton SameRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

