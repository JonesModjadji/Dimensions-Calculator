namespace Dimensions_Calculator
{
    partial class Form5
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
            this.btnBck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStr
            // 
            this.btnStr.Location = new System.Drawing.Point(108, 10);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(75, 23);
            this.btnStr.TabIndex = 12;
            this.btnStr.Text = "Display";
            this.btnStr.UseVisualStyleBackColor = true;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // btnDsplay
            // 
            this.btnDsplay.Location = new System.Drawing.Point(9, 45);
            this.btnDsplay.Name = "btnDsplay";
            this.btnDsplay.Size = new System.Drawing.Size(75, 23);
            this.btnDsplay.TabIndex = 11;
            this.btnDsplay.Text = "Sort";
            this.btnDsplay.UseVisualStyleBackColor = true;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(9, 74);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 10;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(95, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(184, 216);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generate Numbers";
            // 
            // btnBck
            // 
            this.btnBck.Location = new System.Drawing.Point(9, 103);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(75, 23);
            this.btnBck.TabIndex = 7;
            this.btnBck.Text = "Back";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.btnDsplay);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBck);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.Button btnDsplay;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBck;
    }
}