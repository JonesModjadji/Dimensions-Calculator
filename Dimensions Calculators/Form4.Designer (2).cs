namespace Dimensions_Calculator
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxLitres1 = new System.Windows.Forms.CheckBox();
            this.cboxStone1 = new System.Windows.Forms.CheckBox();
            this.cboxPound1 = new System.Windows.Forms.CheckBox();
            this.cboxKilo1 = new System.Windows.Forms.CheckBox();
            this.btnClr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxLitres = new System.Windows.Forms.CheckBox();
            this.cboxStone = new System.Windows.Forms.CheckBox();
            this.cboxPound = new System.Windows.Forms.CheckBox();
            this.cboxKilo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxLitres1);
            this.groupBox1.Controls.Add(this.cboxStone1);
            this.groupBox1.Controls.Add(this.cboxPound1);
            this.groupBox1.Controls.Add(this.cboxKilo1);
            this.groupBox1.Location = new System.Drawing.Point(444, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 142);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Your Converting Value Into";
            // 
            // cboxLitres1
            // 
            this.cboxLitres1.AutoSize = true;
            this.cboxLitres1.Location = new System.Drawing.Point(7, 101);
            this.cboxLitres1.Name = "cboxLitres1";
            this.cboxLitres1.Size = new System.Drawing.Size(51, 17);
            this.cboxLitres1.TabIndex = 3;
            this.cboxLitres1.Text = "Litres";
            this.cboxLitres1.UseVisualStyleBackColor = true;
            // 
            // cboxStone1
            // 
            this.cboxStone1.AutoSize = true;
            this.cboxStone1.Location = new System.Drawing.Point(7, 77);
            this.cboxStone1.Name = "cboxStone1";
            this.cboxStone1.Size = new System.Drawing.Size(54, 17);
            this.cboxStone1.TabIndex = 2;
            this.cboxStone1.Text = "Stone";
            this.cboxStone1.UseVisualStyleBackColor = true;
            // 
            // cboxPound1
            // 
            this.cboxPound1.AutoSize = true;
            this.cboxPound1.Location = new System.Drawing.Point(7, 53);
            this.cboxPound1.Name = "cboxPound1";
            this.cboxPound1.Size = new System.Drawing.Size(57, 17);
            this.cboxPound1.TabIndex = 1;
            this.cboxPound1.Text = "Pound";
            this.cboxPound1.UseVisualStyleBackColor = true;
            // 
            // cboxKilo1
            // 
            this.cboxKilo1.AutoSize = true;
            this.cboxKilo1.Location = new System.Drawing.Point(7, 29);
            this.cboxKilo1.Name = "cboxKilo1";
            this.cboxKilo1.Size = new System.Drawing.Size(66, 17);
            this.cboxKilo1.TabIndex = 0;
            this.cboxKilo1.Text = "Kilogram";
            this.cboxKilo1.UseVisualStyleBackColor = true;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(550, 235);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 23);
            this.btnClr.TabIndex = 17;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Converted Weight";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 15;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(469, 235);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxLitres);
            this.groupBox2.Controls.Add(this.cboxStone);
            this.groupBox2.Controls.Add(this.cboxPound);
            this.groupBox2.Controls.Add(this.cboxKilo);
            this.groupBox2.Location = new System.Drawing.Point(19, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 142);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit You Want To Convert Value Into";
            // 
            // cboxLitres
            // 
            this.cboxLitres.AutoSize = true;
            this.cboxLitres.Location = new System.Drawing.Point(7, 101);
            this.cboxLitres.Name = "cboxLitres";
            this.cboxLitres.Size = new System.Drawing.Size(51, 17);
            this.cboxLitres.TabIndex = 3;
            this.cboxLitres.Text = "Litres";
            this.cboxLitres.UseVisualStyleBackColor = true;
            // 
            // cboxStone
            // 
            this.cboxStone.AutoSize = true;
            this.cboxStone.Location = new System.Drawing.Point(7, 77);
            this.cboxStone.Name = "cboxStone";
            this.cboxStone.Size = new System.Drawing.Size(54, 17);
            this.cboxStone.TabIndex = 2;
            this.cboxStone.Text = "Stone";
            this.cboxStone.UseVisualStyleBackColor = true;
            // 
            // cboxPound
            // 
            this.cboxPound.AutoSize = true;
            this.cboxPound.Location = new System.Drawing.Point(7, 53);
            this.cboxPound.Name = "cboxPound";
            this.cboxPound.Size = new System.Drawing.Size(57, 17);
            this.cboxPound.TabIndex = 1;
            this.cboxPound.Text = "Pound";
            this.cboxPound.UseVisualStyleBackColor = true;
            // 
            // cboxKilo
            // 
            this.cboxKilo.AutoSize = true;
            this.cboxKilo.Location = new System.Drawing.Point(7, 29);
            this.cboxKilo.Name = "cboxKilo";
            this.cboxKilo.Size = new System.Drawing.Size(66, 17);
            this.cboxKilo.TabIndex = 0;
            this.cboxKilo.Text = "Kilogram";
            this.cboxKilo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insert Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 11;
            // 
            // btnBck
            // 
            this.btnBck.Location = new System.Drawing.Point(631, 235);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(75, 23);
            this.btnBck.TabIndex = 10;
            this.btnBck.Text = "Back";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBck);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxLitres1;
        private System.Windows.Forms.CheckBox cboxStone1;
        private System.Windows.Forms.CheckBox cboxPound1;
        private System.Windows.Forms.CheckBox cboxKilo1;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxLitres;
        private System.Windows.Forms.CheckBox cboxStone;
        private System.Windows.Forms.CheckBox cboxPound;
        private System.Windows.Forms.CheckBox cboxKilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBck;
    }
}