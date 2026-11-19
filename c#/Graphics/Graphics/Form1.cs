using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPress(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter.Text = (int.Parse(Counter.Text)+1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter.Text = (int.Parse(Counter.Text) - 1).ToString();
        }

        private void ButtonsCounter(object sender, EventArgs e)
        {
            int currentCount = int.Parse(CountLabel2.Text);
            if (sender is Button)
            {
                Button bnt = (Button)sender;
                if(bnt.Name == "plus")
                {
                    CountLabel2.Text = (currentCount + 1).ToString();
                }
                else if(bnt.Name == "minus")
                {
                    CountLabel2.Text =  (currentCount + 1).ToString(); 
                }
                else if( bnt.Name == "multiply")
                {
                    CountLabel2.Text = (currentCount * 2).ToString();
                }
            }
        }

        private void Calc(object sender, EventArgs e)
        {
            double a = InputCheck(WidthInput.Text, WidthInput);
            double b = InputCheck(heightInput.Text,heightInput);
            if (a != -1 && b != -1)
            {
                errorLabel.Visible = false;
                Area.Text = (a * b).ToString();
                circumfrance.Text = (a * 2 + b * 2).ToString();
            }
        }

        private double InputCheck(string input, TextBox sender)
        {
            double ret = 0;
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            try
            {
                ret = double.Parse(input);
                if (ret < 0)
                {
                    throw new Exception("csakis pozitiv szam lehet");
                }
                return ret;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}: {sender.Name}");
                errorLabel.Visible = true;
                errorLabel.Text = ex.Message;
                return -1;
            }
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
