using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int count = 0;
        }

        private void ShowName(object sender, EventArgs e)
        {

            if(sender is Button)
            {
                Button btn = sender as Button;
                if(btn.Name == "show")
                {
                    vNev.Visible = true;
                    vNev.Text = "Almasy";
                    none.Enabled = true;
                    
                }
                if(btn.Name == "none")
                {
                    keresztNev.Visible = true;
                    keresztNev.Text = "Peter";
                }
            }
        }

        private void getCurrentYear(object sender, EventArgs e)
        {
            yearLabel.Visible = true;
            yearLabel.Text = DateTime.Now.Year.ToString();
        }

        private void ShowData(object sender, EventArgs e)
        {
           
        }
    }
}
