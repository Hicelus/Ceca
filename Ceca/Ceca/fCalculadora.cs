using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        #region Numbers
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
        #region Operations
        private void buttonEraser_Click(object sender, EventArgs e)
        {
            string a = "";

            if(tela != "")
            {
                a = tela.Substring(tela.Length - 1);
                tela = tela.Remove(tela.Length - 1);
                tTela.Text = tela;
                repetition = false;
            }
            if (a == ".")
            {
                dot = true;
            }
            
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fCalculadora_Load(object sender, EventArgs e)
        {
            lData.Text = DateTime.Now.ToLongDateString();
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

        //MEMÓRIA
        #region Memory
        private void bMemorize_Click(object sender, EventArgs e)
        {
            if (rbMemory1.Checked)
            {
                tMemory1.Text = tTela.Text;
            }
            else if (rbMemory2.Checked)
            {
                tMemory2.Text = tTela.Text;
            }
            else if (rbMemory3.Checked)
            {
                tMemory3.Text = tTela.Text;
            }
            else if (rbMemory4.Checked)
            {
                tMemory4.Text = tTela.Text;
            }
        }
                
        private void bRecovery_Click(object sender, EventArgs e)
        {
            if (rbMemory1.Checked)
            {
                tTela.Text = tMemory1.Text;
            }
            else if (rbMemory2.Checked)
            {
                tTela.Text = tMemory2.Text;
            }
            else if (rbMemory3.Checked)
            {
                tTela.Text = tMemory3.Text;
            }
            else if (rbMemory4.Checked)
            {
                tTela.Text = tMemory4.Text;
            }
        }

        

        private void bClean_Click(object sender, EventArgs e)
        {
            tMemory1.Text = "";
            tMemory2.Text = "";
            tMemory3.Text = "";
            tMemory4.Text = "";
        }
        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"file.dat", false, Encoding.Default);
            file.WriteLine(tTela.Text + ":" + tMemory1 + ":" + tMemory2 +":" + tMemory3 + ":" + tMemory4);
            file.Dispose();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("file.dat"))
            {
                StreamReader file = new StreamReader(@"file.dat", Encoding.Default);
                String memory = file.ReadLine();
                String[] division = memory.Split(':');
                tTela.Text = division[0];
                tMemory1.Text = division[2];
                tMemory2.Text = division[4];
                tMemory3.Text = division[6];
                tMemory4.Text = division[8];
                file.Dispose();
            }
            else
            {
                MessageBox.Show("Sem dados salvos");
            }
        }

    }
}