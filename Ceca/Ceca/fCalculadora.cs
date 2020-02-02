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
        public bool repeticao = false;
        double valor1;
        double valor2;
        int operacao;

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
            repeticao = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            tTela.Text = "";
            tela = "";
            dot = true;
            repeticao = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(tTela.Text);
            tela = "";
            operacao = 1;
            dot = true;
            repeticao = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(tTela.Text);
            tela = "";
            operacao = 2;
            dot = true;
            repeticao = false;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(tTela.Text);
            tela = "";
            operacao = 3;
            dot = true;
            repeticao = false;
        }

        private void buttonDevided_Click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(tTela.Text);
            tela = "";
            operacao = 4;
            dot = true;
            repeticao = false;
        }

        private void rest()
        {
            valor1 = Double.Parse(tTela.Text);
            tela = "";
            operacao = 4;
            dot = true;
            repeticao = false;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double resultado = 0;

            if(tTela.Text == "")
            {
                tTela.Text = "1";
            }

            if (repeticao)
            {
                valor1 = Double.Parse(tTela.Text);
            }
            else
            {
                valor2 = Double.Parse(tTela.Text);
                repeticao = true;
            }
            
            switch(operacao){
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    
                    resultado = valor1 / valor2;
                    break;
            }

            tTela.Text = resultado.ToString();
            tela = "";
            dot = true;

            
        }
        #endregion
    

    }
}
