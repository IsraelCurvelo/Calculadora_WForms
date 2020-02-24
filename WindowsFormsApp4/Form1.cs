using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Double valor = 0;
        String operacao = "";
        bool operacao1 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button_Click(object sender, EventArgs e)
        {
            if((resultado.Text == "0")||(operacao1))
                resultado.Clear();

                operacao1 = false;

                Button b = (Button)sender;
            resultado.Text = resultado.Text + b.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacao = b.Text;
            valor = Double.Parse(resultado.Text);
            operacao1 = true;
            equacao.Text = valor + " " + operacao;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            equacao.Text = "";
            switch (operacao)
            {
                
                case "+" :
                    resultado.Text = (valor + Double.Parse(resultado.Text)).ToString();
                    break;

                case "-" :
                    resultado.Text = (valor - Double.Parse(resultado.Text)).ToString();
                    break;
                case "*":
                    resultado.Text = (valor * Double.Parse(resultado.Text)).ToString();
                    break;

                case "/":
                    resultado.Text = (valor / Double.Parse(resultado.Text)).ToString();
                    break;

                default:
                    break;

            }
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            valor = 0;
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
