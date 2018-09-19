namespace Dimensions_Calculator
{
    partial class Form3
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
            this.btnClr = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxDollar1 = new System.Windows.Forms.CheckBox();
            this.cboxPound1 = new System.Windows.Forms.CheckBox();
            this.cboxEuro1 = new System.Windows.Forms.CheckBox();
            this.cboxRand1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxRand = new System.Windows.Forms.CheckBox();
            this.cboxDollar = new System.Windows.Forms.CheckBox();
            this.cboxPound = new System.Windows.Forms.CheckBox();
            this.cboxEuro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBck = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(292, 193);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(89, 23);
            this.btnClr.TabIndex = 19;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 163);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 23);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Amount Converted Is";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxDollar1);
            this.groupBox2.Controls.Add(this.cboxPound1);
            this.groupBox2.Controls.Add(this.cboxEuro1);
            this.groupBox2.Controls.Add(this.cboxRand1);
            this.groupBox2.Location = new System.Drawing.Point(250, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency Concerting to";
            // 
            // cboxDollar1
            // 
            this.cboxDollar1.AutoSize = true;
            this.cboxDollar1.Location = new System.Drawing.Point(7, 92);
            this.cboxDollar1.Name = "cboxDollar1";
            this.cboxDollar1.Size = new System.Drawing.Size(53, 17);
            this.cboxDollar1.TabIndex = 3;
            this.cboxDollar1.Text = "Dollar";
            this.cboxDollar1.UseVisualStyleBackColor = true;
            // 
            // cboxPound1
            // 
            this.cboxPound1.AutoSize = true;
            this.cboxPound1.Location = new System.Drawing.Point(7, 68);
            this.cboxPound1.Name = "cboxPound1";
            this.cboxPound1.Size = new System.Drawing.Size(57, 17);
            this.cboxPound1.TabIndex = 2;
            this.cboxPound1.Text = "Pound";
            this.cboxPound1.UseVisualStyleBackColor = true;
            // 
            // cboxEuro1
            // 
            this.cboxEuro1.AutoSize = true;
            this.cboxEuro1.Location = new System.Drawing.Point(7, 44);
            this.cboxEuro1.Name = "cboxEuro1";
            this.cboxEuro1.Size = new System.Drawing.Size(48, 17);
            this.cboxEuro1.TabIndex = 1;
            this.cboxEuro1.Text = "Euro";
            this.cboxEuro1.UseVisualStyleBackColor = true;
            // 
            // cboxRand1
            // 
            this.cboxRand1.AutoSize = true;
            this.cboxRand1.Location = new System.Drawing.Point(7, 20);
            this.cboxRand1.Name = "cboxRand1";
            this.cboxRand1.Size = new System.Drawing.Size(52, 17);
            this.cboxRand1.TabIndex = 0;
            this.cboxRand1.Text = "Rand";
            this.cboxRand1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxRand);
            this.groupBox1.Controls.Add(this.cboxDollar);
            this.groupBox1.Controls.Add(this.cboxPound);
            this.groupBox1.Controls.Add(this.cboxEuro);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 124);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Currency";
            // 
            // cboxRand
            // 
            this.cboxRand.AutoSize = true;
            this.cboxRand.Location = new System.Drawing.Point(10, 21);
            this.cboxRand.Name = "cboxRand";
            this.cboxRand.Size = new System.Drawing.Size(52, 17);
            this.cboxRand.TabIndex = 4;
            this.cboxRand.Text = "Rand";
            this.cboxRand.UseVisualStyleBackColor = true;
            // 
            // cboxDollar
            // 
            this.cboxDollar.AutoSize = true;
            this.cboxDollar.Location = new System.Drawing.Point(10, 92);
            this.cboxDollar.Name = "cboxDollar";
            this.cboxDollar.Size = new System.Drawing.Size(53, 17);
            this.cboxDollar.TabIndex = 3;
            this.cboxDollar.Text = "Dollar";
            this.cboxDollar.UseVisualStyleBackColor = true;
            // 
            // cboxPound
            // 
            this.cboxPound.AutoSize = true;
            this.cboxPound.Location = new System.Drawing.Point(10, 68);
            this.cboxPound.Name = "cboxPound";
            this.cboxPound.Size = new System.Drawing.Size(57, 17);
            this.cboxPound.TabIndex = 2;
            this.cboxPound.Text = "Pound";
            this.cboxPound.UseVisualStyleBackColor = true;
            // 
            // cboxEuro
            // 
            this.cboxEuro.AutoSize = true;
            this.cboxEuro.Location = new System.Drawing.Point(10, 44);
            this.cboxEuro.Name = "cboxEuro";
            this.cboxEuro.Size = new System.Drawing.Size(48, 17);
            this.cboxEuro.TabIndex = 1;
            this.cboxEuro.Text = "Euro";
            this.cboxEuro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please Enter Amount You Want To Convert";
            // 
            // btnBck
            // 
            this.btnBck.Location = new System.Drawing.Point(292, 222);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(89, 23);
            this.btnBck.TabIndex = 20;
            this.btnBck.Text = "Back";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxDollar1;
        private System.Windows.Forms.CheckBox cboxPound1;
        private System.Windows.Forms.CheckBox cboxEuro1;
        private System.Windows.Forms.CheckBox cboxRand1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxRand;
        private System.Windows.Forms.CheckBox cboxDollar;
        private System.Windows.Forms.CheckBox cboxPound;
        private System.Windows.Forms.CheckBox cboxEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBck;
    }
}