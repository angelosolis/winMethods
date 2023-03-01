using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsandParameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayResult();  
        }

        public int calculatePerimeter(int width, int length)
        {
            return (width + length) * 2;
        }
        public int calculateArea(int width, int length)
        {
            return width * length;
        }

        public void displayResult()
        {
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);

            lblPerimeter.Text = calculatePerimeter(width,length).ToString();
            lblArea.Text = calculateArea(width, length).ToString();

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
