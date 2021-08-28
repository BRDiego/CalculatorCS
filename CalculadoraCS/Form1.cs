using CalculadoraCS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Logic calculadora = new Logic();

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            LblDisplay.Text = calculadora.Calculate();
            if (LblDisplay.Text[0] != 'E' && LblDisplay.Text[0] != 'I')
            {
                LblAux.Text = LblDisplay.Text;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            AddNumber(Btn0.Text);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            AddNumber(Btn1.Text);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            AddNumber(Btn2.Text);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            AddNumber(Btn3.Text);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            AddNumber(Btn4.Text);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            AddNumber(Btn5.Text);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            AddNumber(Btn6.Text);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            AddNumber(Btn7.Text);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            AddNumber(Btn8.Text);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            AddNumber(Btn9.Text);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            AddOperation(BtnPlus.Text);
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            AddOperation(BtnMinus.Text);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            AddOperation(BtnMultiply.Text);
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            AddOperation(BtnDivide.Text);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteChar();
        }

        private void BtnConma_Click(object sender, EventArgs e)
        {
            if (!(LblDisplay.Text.Contains(",")))
            {
                AddNumber(BtnConma.Text);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            calculadora.Clear();
            LblDisplay.Text = "";
            LblAux.Text = "";
        }

        private void AddNumber(string text)
        {
            calculadora.AddNumber(text);
            if ((LblDisplay.Text != "") && (LblDisplay.Text[0] == 'E' || LblDisplay.Text[0] == 'I'))
            {
                LblDisplay.Text = "";
            }
            LblDisplay.Text += text;
        }

        private void AddSign(string sign)
        {
            if(sign == "+" || sign == "-")
            {
                LblDisplay.Text = sign;
                calculadora.AddNumber(sign);
            }
        }

        private void AddOperation(string text)
        {
            if (LblDisplay.Text == "")
            {
                AddSign(text);
                return;
            }
                string operation = calculadora.AddOperation(text);
            if (LblDisplay.Text != "" && LblDisplay.Text[0] != 'E' && LblDisplay.Text[0] != 'I')
            {
                LblAux.Text += operation;
            }
            if (LblAux.Text != "" && LblAux.Text.Length > 0)
            {
                LblAux.Text = ChangeOperation(LblAux.Text, operation);
            }
            LblDisplay.Text = "";
        }

        private string ChangeOperation(string Field, string newOperation)
        {
            int index = Field.Length - 1;
            switch (Field[index])
            {
                case '+':
                    Field = Field.Remove(index);
                    Field += newOperation;
                    break;
                case '-':
                    Field = Field.Remove(index);
                    Field += newOperation;
                    break;
                case '*':
                    Field = Field.Remove(index);
                    Field += newOperation;
                    break;
                case '/':
                    Field = Field.Remove(index);
                    Field += newOperation;
                    break;
            }
            return Field;
        }

        private void DeleteChar()
        {
            if (LblDisplay.Text != "")
            {
                LblDisplay.Text = LblDisplay.Text.Remove(LblDisplay.Text.Length - 1);
                calculadora.DeleteChar();
            }
        }

        private void ShowN1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calculadora.GetN1());
        }

        private void ShowN2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calculadora.GetN2());
        }

        private void ShowOp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(calculadora.GetOp());
        }
    }
}
