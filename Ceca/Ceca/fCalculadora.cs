using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceca
{
    public partial class fCalculadora : Form
    {
        public string tela = "";
        public bool dot = true;
        public bool repetition = false;
        double value1, value2, result;
        int operation;

        public fCalculadora()
        {
            InitializeComponent();
        }

        

        //BOTOES NUMERICOS
        #region Botoes numericos
        private void button1_Click(object sender, EventArgs e)
        {
            tela += "1";
            tTela.Text = tela;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tela += "2";
            tTela.Text = tela;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tela += "3";
            tTela.Text = tela;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tela += "4";
            tTela.Text = tela;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tela += "5";
            tTela.Text = tela;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tela += "6";
            tTela.Text = tela;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tela += "7";
            tTela.Text = tela;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tela += "8";
            tTela.Text = tela;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tela += "9";
            tTela.Text = tela;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string teste = tTela.Text;
            if(teste != "0")
            {
                tela += "0";
                tTela.Text = tela;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            string teste = tTela.Text;
            if (teste != "" && dot)
            {
                tela += ".";
                tTela.Text = tela;
                dot = false;
            }
        }
        #endregion

        //OPERACOES
        #region Operacoes
        private void buttonEraser_Click(object sender, EventArgs e)
        {
            tela = tela.Remove(tela.Length - 1);
            tTela.Text = tela;
            repetition = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            tTela.Text = "";
            tela = "";
            dot = true;
            repetition = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            value1 = Double.Parse(tTela.Text);
            tela = "";
            operation = 1;
            dot = true;
            repetition = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            value1 = Double.Parse(tTela.Text);
            tela = "";
            operation = 2;
            dot = true;
            repetition = false;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            value1 = Double.Parse(tTela.Text);
            tela = "";
            operation = 3;
            dot = true;
            repetition = false;
        }

        private void buttonDevided_Click(object sender, EventArgs e)
        {
            value1 = Double.Parse(tTela.Text);
            tela = "";
            operation = 4;
            dot = true;
            repetition = false;
        }

        private void rest()
        {
            value1 = Double.Parse(tTela.Text);
            tela = "";
            operation = 5;
            dot = true;
            repetition = false;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if(tTela.Text == "")
            {
                tTela.Text = "1";
            }

            if (repetition)
            {
                value1 = Double.Parse(tTela.Text);
            }
            else
            {
                value2 = Double.Parse(tTela.Text);
                repetition = true;
            }

            switch (operation)
            {
                case 1:
                    result = value1 + value2;
                    break;
                case 2:
                    result = value1 - value2;
                    break;
                case 3:
                    result = value1 * value2;
                    break;
                case 4:
                    result = value1 / value2;
                    break;
                case 5:
                    result = value1 % value2;
                    break;
            }

            tTela.Text = result.ToString();
            tela = "";
            dot = true;

            
        }
        #endregion
    

    }
}
