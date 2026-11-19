using System;

namespace Graphics
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
            this.myButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.CountLabel2 = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.TextBox();
            this.circumfrance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elso cucc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // myButton
            // 
            this.myButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myButton.Location = new System.Drawing.Point(221, 66);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(227, 71);
            this.myButton.TabIndex = 1;
            this.myButton.Text = "Press me >w<";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.ButtonPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(454, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "u pressed it!!";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(50, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Increase >w<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(283, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "u pressed it this much: ";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.Counter.Location = new System.Drawing.Point(485, 164);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(21, 22);
            this.Counter.TabIndex = 5;
            this.Counter.Text = "0";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(512, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 71);
            this.button2.TabIndex = 6;
            this.button2.Text = "Decrease >w<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(80, 216);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(47, 45);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.ButtonsCounter);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.Location = new System.Drawing.Point(133, 216);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(45, 45);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.ButtonsCounter);
            // 
            // CountLabel2
            // 
            this.CountLabel2.AutoSize = true;
            this.CountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold);
            this.CountLabel2.Location = new System.Drawing.Point(182, 217);
            this.CountLabel2.Name = "CountLabel2";
            this.CountLabel2.Size = new System.Drawing.Size(33, 35);
            this.CountLabel2.TabIndex = 9;
            this.CountLabel2.Text = "0";
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiply.Location = new System.Drawing.Point(215, 216);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(45, 45);
            this.multiply.TabIndex = 10;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.ButtonsCounter);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.widthLabel.Location = new System.Drawing.Point(90, 289);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(100, 25);
            this.widthLabel.TabIndex = 11;
            this.widthLabel.Text = "szelesseg";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.heightLabel.Location = new System.Drawing.Point(83, 314);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(107, 25);
            this.heightLabel.TabIndex = 12;
            this.heightLabel.Text = "hosszusag";
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(196, 295);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 20);
            this.WidthInput.TabIndex = 13;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(196, 320);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(100, 20);
            this.heightInput.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(302, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 45);
            this.button3.TabIndex = 15;
            this.button3.Text = "Count >w<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Calc);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(563, 300);
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Size = new System.Drawing.Size(94, 20);
            this.Area.TabIndex = 16;
            // 
            // circumfrance
            // 
            this.circumfrance.Location = new System.Drawing.Point(563, 325);
            this.circumfrance.Name = "circumfrance";
            this.circumfrance.ReadOnly = true;
            this.circumfrance.Size = new System.Drawing.Size(94, 20);
            this.circumfrance.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(484, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Terulet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(484, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kerulet";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(228, 364);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(65, 25);
            this.errorLabel.TabIndex = 20;
            this.errorLabel.Text = "Error: ";
            this.errorLabel.Visible = false;
            this.errorLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 419);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.circumfrance);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.CountLabel2);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Little Gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Label CountLabel2;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.TextBox circumfrance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLabel;
    }
}

