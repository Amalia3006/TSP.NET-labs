using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratoareTSPNET
{
    public partial class cal : Form
    {

        private string calcul = String.Empty;

        public cal()
        {
            InitializeComponent();
            calcul = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
        private void button0_Click(object sender, EventArgs e)
        {
            //calcul.Append("0");
            calcul += "0";
            textChanged(calcul);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //calcul.Append("1");
            calcul += "1";
            textChanged(calcul);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //calcul.Append("2");
            calcul += "2";
            textChanged(calcul);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //calcul.Append("3");
            calcul += "3";
            textChanged(calcul);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //calcul.Append("4");
            calcul += "4";
            textChanged(calcul);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //calcul.Append("5");
            calcul += "5";
            textChanged(calcul);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //calcul.Append("6");
            calcul += "6";
            textChanged(calcul);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //calcul.Append("7");
            calcul += "7";
            textChanged(calcul);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //calcul.Append("8");
            calcul += "8";
            textChanged(calcul);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //calcul.Append("9");
            calcul += "9";
            textChanged(calcul);
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {

            //calcul.Append(".");
            calcul += ".";
            textChanged(calcul);
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            //calcul.Append("=");
            calcul += "=";
            textChanged(calcul);
        }
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            calcul = String.Empty;
            textChanged(calcul);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //calcul.Append("+");
            calcul += "+";
            textChanged(calcul);
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            //calcul.Append("-");
            calcul += "-";
            textChanged(calcul);
        }
        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            //calcul.Append("/");
            calcul += "/";
            textChanged(calcul);
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //calcul.Append("*");
            calcul += "*";
            textChanged(calcul);
        }

        private void textChanged(string calcul)
        {
            Result.Text = calcul;
           
            Console.WriteLine(calcul);
        }

       
    }
}
