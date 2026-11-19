namespace Buttons
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
            this.show = new System.Windows.Forms.Button();
            this.none = new System.Windows.Forms.Button();
            this.vNev = new System.Windows.Forms.Label();
            this.keresztNev = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.GetYear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nevPart = new System.Windows.Forms.TextBox();
            this.osztalyPart = new System.Windows.Forms.TextBox();
            this.atlagPart = new System.Windows.Forms.TextBox();
            this.onePart = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(187, 142);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(198, 60);
            this.show.TabIndex = 0;
            this.show.Text = "vnev";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.ShowName);
            // 
            // none
            // 
            this.none.Enabled = false;
            this.none.Location = new System.Drawing.Point(410, 142);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(189, 60);
            this.none.TabIndex = 1;
            this.none.Text = "kereszt";
            this.none.UseVisualStyleBackColor = true;
            this.none.Click += new System.EventHandler(this.ShowName);
            // 
            // vNev
            // 
            this.vNev.AutoSize = true;
            this.vNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.vNev.Location = new System.Drawing.Point(311, 86);
            this.vNev.Name = "vNev";
            this.vNev.Size = new System.Drawing.Size(44, 24);
            this.vNev.TabIndex = 2;
            this.vNev.Text = "Nev";
            this.vNev.Visible = false;
            // 
            // keresztNev
            // 
            this.keresztNev.Location = new System.Drawing.Point(391, 91);
            this.keresztNev.Name = "keresztNev";
            this.keresztNev.ReadOnly = true;
            this.keresztNev.Size = new System.Drawing.Size(100, 20);
            this.keresztNev.TabIndex = 3;
            this.keresztNev.Visible = false;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.yearLabel.Location = new System.Drawing.Point(366, 221);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(75, 24);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Mai ev: ";
            this.yearLabel.Visible = false;
            // 
            // GetYear
            // 
            this.GetYear.Location = new System.Drawing.Point(95, 360);
            this.GetYear.Name = "GetYear";
            this.GetYear.Size = new System.Drawing.Size(96, 50);
            this.GetYear.TabIndex = 5;
            this.GetYear.Text = "add ide az evet";
            this.GetYear.UseVisualStyleBackColor = true;
            this.GetYear.Click += new System.EventHandler(this.ShowData);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "add ide az evet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowData);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "add ide az evet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nevPart
            // 
            this.nevPart.Location = new System.Drawing.Point(197, 322);
            this.nevPart.Name = "nevPart";
            this.nevPart.ReadOnly = true;
            this.nevPart.Size = new System.Drawing.Size(100, 20);
            this.nevPart.TabIndex = 8;
            this.nevPart.Visible = false;
            // 
            // osztalyPart
            // 
            this.osztalyPart.Location = new System.Drawing.Point(303, 322);
            this.osztalyPart.Name = "osztalyPart";
            this.osztalyPart.ReadOnly = true;
            this.osztalyPart.Size = new System.Drawing.Size(100, 20);
            this.osztalyPart.TabIndex = 9;
            this.osztalyPart.Visible = false;
            // 
            // atlagPart
            // 
            this.atlagPart.Location = new System.Drawing.Point(409, 322);
            this.atlagPart.Name = "atlagPart";
            this.atlagPart.ReadOnly = true;
            this.atlagPart.Size = new System.Drawing.Size(100, 20);
            this.atlagPart.TabIndex = 10;
            this.atlagPart.Visible = false;
            // 
            // onePart
            // 
            this.onePart.Location = new System.Drawing.Point(197, 376);
            this.onePart.Name = "onePart";
            this.onePart.ReadOnly = true;
            this.onePart.Size = new System.Drawing.Size(100, 20);
            this.onePart.TabIndex = 11;
            this.onePart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.onePart);
            this.Controls.Add(this.atlagPart);
            this.Controls.Add(this.osztalyPart);
            this.Controls.Add(this.nevPart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetYear);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.keresztNev);
            this.Controls.Add(this.vNev);
            this.Controls.Add(this.none);
            this.Controls.Add(this.show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button none;
        private System.Windows.Forms.Label vNev;
        private System.Windows.Forms.TextBox keresztNev;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nevPart;
        private System.Windows.Forms.TextBox osztalyPart;
        private System.Windows.Forms.TextBox atlagPart;
        private System.Windows.Forms.TextBox onePart;
        private System.Windows.Forms.Button GetYear;
        private System.Windows.Forms.Button button1;
    }
}

