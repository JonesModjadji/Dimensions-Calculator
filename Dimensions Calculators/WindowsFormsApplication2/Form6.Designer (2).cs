namespace Dimensions_Calculator
{
    partial class Form6
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
            this.btnStr = new System.Windows.Forms.Button();
            this.btnDsplay = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStr
            // 
            this.btnStr.Location = new System.Drawing.Point(9, 32);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(75, 23);
            this.btnStr.TabIndex = 19;
            this.btnStr.Text = "Store";
            this.btnStr.UseVisualStyleBackColor = true;
            // 
            // btnDsplay
            // 
            this.btnDsplay.Location = new System.Drawing.Point(9, 61);
            this.btnDsplay.Name = "btnDsplay";
            this.btnDsplay.Size = new System.Drawing.Size(75, 23);
            this.btnDsplay.TabIndex = 18;
            this.btnDsplay.Text = "Display";
            this.btnDsplay.UseVisualStyleBackColor = true;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(9, 90);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 17;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(95, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 216);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Insert 20 Values";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.btnDsplay);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.Button btnDsplay;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}