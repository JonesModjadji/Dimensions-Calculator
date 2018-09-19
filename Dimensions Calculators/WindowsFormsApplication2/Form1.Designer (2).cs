namespace Dimensions_Calculator
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
            this.btnCompound = new System.Windows.Forms.Button();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btn40Array = new System.Windows.Forms.Button();
            this.btn20Array = new System.Windows.Forms.Button();
            this.btnMass = new System.Windows.Forms.Button();
            this.btnCrncy = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompound
            // 
            this.btnCompound.Location = new System.Drawing.Point(292, 70);
            this.btnCompound.Name = "btnCompound";
            this.btnCompound.Size = new System.Drawing.Size(131, 23);
            this.btnCompound.TabIndex = 13;
            this.btnCompound.Text = "Compound Interest";
            this.btnCompound.UseVisualStyleBackColor = true;
            this.btnCompound.Click += new System.EventHandler(this.btnCompound_Click);
            // 
            // btnSimple
            // 
            this.btnSimple.Location = new System.Drawing.Point(155, 70);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(131, 23);
            this.btnSimple.TabIndex = 12;
            this.btnSimple.Text = "Simple Interest";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btn40Array
            // 
            this.btn40Array.Location = new System.Drawing.Point(154, 41);
            this.btn40Array.Name = "btn40Array";
            this.btn40Array.Size = new System.Drawing.Size(132, 23);
            this.btn40Array.TabIndex = 11;
            this.btn40Array.Text = "40 Array";
            this.btn40Array.UseVisualStyleBackColor = true;
            this.btn40Array.Click += new System.EventHandler(this.btn40Array_Click);
            // 
            // btn20Array
            // 
            this.btn20Array.Location = new System.Drawing.Point(292, 41);
            this.btn20Array.Name = "btn20Array";
            this.btn20Array.Size = new System.Drawing.Size(132, 23);
            this.btn20Array.TabIndex = 10;
            this.btn20Array.Text = "20 Array";
            this.btn20Array.UseVisualStyleBackColor = true;
            this.btn20Array.Click += new System.EventHandler(this.btn20Array_Click);
            // 
            // btnMass
            // 
            this.btnMass.Location = new System.Drawing.Point(16, 99);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(132, 23);
            this.btnMass.TabIndex = 9;
            this.btnMass.Text = "Mass Converter";
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.Click += new System.EventHandler(this.btnMass_Click);
            // 
            // btnCrncy
            // 
            this.btnCrncy.Location = new System.Drawing.Point(12, 70);
            this.btnCrncy.Name = "btnCrncy";
            this.btnCrncy.Size = new System.Drawing.Size(132, 23);
            this.btnCrncy.TabIndex = 8;
            this.btnCrncy.Text = "Currency Converter";
            this.btnCrncy.UseVisualStyleBackColor = true;
            this.btnCrncy.Click += new System.EventHandler(this.btnCrncy_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 41);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(132, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Scientific Calculator";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please Click On The Calculator You Want To Use";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(192, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompound);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.btn40Array);
            this.Controls.Add(this.btn20Array);
            this.Controls.Add(this.btnMass);
            this.Controls.Add(this.btnCrncy);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompound;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btn40Array;
        private System.Windows.Forms.Button btn20Array;
        private System.Windows.Forms.Button btnMass;
        private System.Windows.Forms.Button btnCrncy;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}

