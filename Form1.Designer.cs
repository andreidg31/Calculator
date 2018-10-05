namespace Calculator
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
            this.display = new System.Windows.Forms.RichTextBox();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonNumpad9 = new System.Windows.Forms.Button();
            this.buttonNumpad8 = new System.Windows.Forms.Button();
            this.buttonNumpad7 = new System.Windows.Forms.Button();
            this.buttonNumpad6 = new System.Windows.Forms.Button();
            this.buttonNumpad5 = new System.Windows.Forms.Button();
            this.buttonNumpad4 = new System.Windows.Forms.Button();
            this.buttonChangeSign = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonNumpad0 = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonNumpad3 = new System.Windows.Forms.Button();
            this.buttonNumpad2 = new System.Windows.Forms.Button();
            this.buttonNumpad1 = new System.Windows.Forms.Button();
            this.scapegoat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Multiline = false;
            this.display.Name = "display";
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.display.Size = new System.Drawing.Size(410, 70);
            this.display.TabIndex = 0;
            this.display.Text = "";
            this.display.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonClearEntry.Location = new System.Drawing.Point(10, 80);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(90, 65);
            this.buttonClearEntry.TabIndex = 1;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonDivide.Location = new System.Drawing.Point(110, 80);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(90, 65);
            this.buttonDivide.TabIndex = 2;
            this.buttonDivide.Tag = "4";
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.signPress);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonMultiply.Location = new System.Drawing.Point(210, 80);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(90, 65);
            this.buttonMultiply.TabIndex = 3;
            this.buttonMultiply.Tag = "3";
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.signPress);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonSubstract.Location = new System.Drawing.Point(310, 80);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(90, 65);
            this.buttonSubstract.TabIndex = 4;
            this.buttonSubstract.Tag = "2";
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.signPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 32F);
            this.buttonAdd.Location = new System.Drawing.Point(308, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 140);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Tag = "1";
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.signPress);
            // 
            // buttonNumpad9
            // 
            this.buttonNumpad9.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad9.Location = new System.Drawing.Point(208, 155);
            this.buttonNumpad9.Name = "buttonNumpad9";
            this.buttonNumpad9.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad9.TabIndex = 7;
            this.buttonNumpad9.Tag = "9";
            this.buttonNumpad9.Text = "9";
            this.buttonNumpad9.UseVisualStyleBackColor = true;
            this.buttonNumpad9.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad8
            // 
            this.buttonNumpad8.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad8.Location = new System.Drawing.Point(108, 155);
            this.buttonNumpad8.Name = "buttonNumpad8";
            this.buttonNumpad8.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad8.TabIndex = 6;
            this.buttonNumpad8.Tag = "8";
            this.buttonNumpad8.Text = "8";
            this.buttonNumpad8.UseVisualStyleBackColor = true;
            this.buttonNumpad8.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad7
            // 
            this.buttonNumpad7.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad7.Location = new System.Drawing.Point(8, 155);
            this.buttonNumpad7.Name = "buttonNumpad7";
            this.buttonNumpad7.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad7.TabIndex = 5;
            this.buttonNumpad7.Tag = "7";
            this.buttonNumpad7.Text = "7";
            this.buttonNumpad7.UseVisualStyleBackColor = true;
            this.buttonNumpad7.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad6
            // 
            this.buttonNumpad6.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad6.Location = new System.Drawing.Point(210, 230);
            this.buttonNumpad6.Name = "buttonNumpad6";
            this.buttonNumpad6.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad6.TabIndex = 11;
            this.buttonNumpad6.Tag = "6";
            this.buttonNumpad6.Text = "6";
            this.buttonNumpad6.UseVisualStyleBackColor = true;
            this.buttonNumpad6.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad5
            // 
            this.buttonNumpad5.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad5.Location = new System.Drawing.Point(110, 230);
            this.buttonNumpad5.Name = "buttonNumpad5";
            this.buttonNumpad5.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad5.TabIndex = 10;
            this.buttonNumpad5.Tag = "5";
            this.buttonNumpad5.Text = "5";
            this.buttonNumpad5.UseVisualStyleBackColor = true;
            this.buttonNumpad5.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad4
            // 
            this.buttonNumpad4.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad4.Location = new System.Drawing.Point(10, 230);
            this.buttonNumpad4.Name = "buttonNumpad4";
            this.buttonNumpad4.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad4.TabIndex = 9;
            this.buttonNumpad4.Tag = "4";
            this.buttonNumpad4.Text = "4";
            this.buttonNumpad4.UseVisualStyleBackColor = true;
            this.buttonNumpad4.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonChangeSign
            // 
            this.buttonChangeSign.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonChangeSign.Location = new System.Drawing.Point(310, 380);
            this.buttonChangeSign.Name = "buttonChangeSign";
            this.buttonChangeSign.Size = new System.Drawing.Size(90, 65);
            this.buttonChangeSign.TabIndex = 16;
            this.buttonChangeSign.Tag = "";
            this.buttonChangeSign.Text = "+-";
            this.buttonChangeSign.UseVisualStyleBackColor = true;
            this.buttonChangeSign.Click += new System.EventHandler(this.buttonChangeSign_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(210, 380);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(90, 65);
            this.buttonDecimal.TabIndex = 15;
            this.buttonDecimal.Tag = "6";
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = true;
            // 
            // buttonNumpad0
            // 
            this.buttonNumpad0.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad0.Location = new System.Drawing.Point(110, 380);
            this.buttonNumpad0.Name = "buttonNumpad0";
            this.buttonNumpad0.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad0.TabIndex = 14;
            this.buttonNumpad0.Tag = "0";
            this.buttonNumpad0.Text = "0";
            this.buttonNumpad0.UseVisualStyleBackColor = true;
            this.buttonNumpad0.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Location = new System.Drawing.Point(10, 380);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(90, 65);
            this.buttonPercent.TabIndex = 13;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonEquals.Location = new System.Drawing.Point(310, 305);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(90, 65);
            this.buttonEquals.TabIndex = 20;
            this.buttonEquals.Tag = "0";
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.signPress);
            // 
            // buttonNumpad3
            // 
            this.buttonNumpad3.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad3.Location = new System.Drawing.Point(210, 305);
            this.buttonNumpad3.Name = "buttonNumpad3";
            this.buttonNumpad3.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad3.TabIndex = 19;
            this.buttonNumpad3.Tag = "3";
            this.buttonNumpad3.Text = "3";
            this.buttonNumpad3.UseVisualStyleBackColor = true;
            this.buttonNumpad3.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad2
            // 
            this.buttonNumpad2.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad2.Location = new System.Drawing.Point(110, 305);
            this.buttonNumpad2.Name = "buttonNumpad2";
            this.buttonNumpad2.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad2.TabIndex = 18;
            this.buttonNumpad2.Tag = "2";
            this.buttonNumpad2.Text = "2";
            this.buttonNumpad2.UseVisualStyleBackColor = true;
            this.buttonNumpad2.Click += new System.EventHandler(this.enterNumber);
            // 
            // buttonNumpad1
            // 
            this.buttonNumpad1.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonNumpad1.Location = new System.Drawing.Point(10, 305);
            this.buttonNumpad1.Name = "buttonNumpad1";
            this.buttonNumpad1.Size = new System.Drawing.Size(90, 65);
            this.buttonNumpad1.TabIndex = 17;
            this.buttonNumpad1.Tag = "1";
            this.buttonNumpad1.Text = "1";
            this.buttonNumpad1.UseVisualStyleBackColor = true;
            this.buttonNumpad1.Click += new System.EventHandler(this.enterNumber);
            // 
            // scapegoat
            // 
            this.scapegoat.AutoSize = true;
            this.scapegoat.Location = new System.Drawing.Point(5, 0);
            this.scapegoat.Name = "scapegoat";
            this.scapegoat.Size = new System.Drawing.Size(76, 17);
            this.scapegoat.TabIndex = 21;
            this.scapegoat.Text = "Scapegoat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scapegoat);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonNumpad3);
            this.Controls.Add(this.buttonNumpad2);
            this.Controls.Add(this.buttonNumpad1);
            this.Controls.Add(this.buttonChangeSign);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonNumpad0);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.buttonNumpad6);
            this.Controls.Add(this.buttonNumpad5);
            this.Controls.Add(this.buttonNumpad4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNumpad9);
            this.Controls.Add(this.buttonNumpad8);
            this.Controls.Add(this.buttonNumpad7);
            this.Controls.Add(this.buttonSubstract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonNumpad9;
        private System.Windows.Forms.Button buttonNumpad8;
        private System.Windows.Forms.Button buttonNumpad7;
        private System.Windows.Forms.Button buttonNumpad6;
        private System.Windows.Forms.Button buttonNumpad5;
        private System.Windows.Forms.Button buttonNumpad4;
        private System.Windows.Forms.Button buttonChangeSign;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonNumpad0;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonNumpad3;
        private System.Windows.Forms.Button buttonNumpad2;
        private System.Windows.Forms.Button buttonNumpad1;
        private System.Windows.Forms.Label scapegoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

