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
            AdaptDots();
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
            if ((LblDisplay.Text != "") && (LblDisplay.Text[0] == 'E' || LblDisplay.Text[0] == 'I'))
            {
                LblDisplay.Text = "";
            }
            LblDisplay.Text = calculadora.AddNumber(text);
            AdaptDots();
        }

        private void AddSign(string sign)
        {
            LblDisplay.Text = sign;
            calculadora.AddNumber(sign);
        }

        private void AddOperation(string text)
        {
            if (LblDisplay.Text == "" && LblAux.Text != ""
                && IsSign(LblAux.Text[LblAux.Text.Length - 1]))
            {
                if (!LblAux.Text.EndsWith(text))
                {
                    LblAux.Text.Remove(LblAux.Text.Length - 1);
                }
            }
            if (LblDisplay.Text == "" && text != "*" && text !="/")
            {
                //trocar o sign faz o aux ficar poluido. arrumar isso
                AddSign(text);
                return;
            }
            LblAux.Text = calculadora.AddOperation(text);
            LblDisplay.Text = "";
            /*if (LblDisplay.Text != "" && LblDisplay.Text[0] != 'E' && LblDisplay.Text[0] != 'I')
            {
                LblAux.Text += operation;
            }
            if (!calculadora.HasOperation)
            {
                LblAux.Text = ChangeOperation();
            }*/
        }

        private void DeleteChar()
        {
            if (LblDisplay.Text != "")
            {
                LblDisplay.Text = LblDisplay.Text.Remove(LblDisplay.Text.Length - 1);
                calculadora.DeleteChar();
            }
        }

        private void AdaptDots()
        {
            string number = LblDisplay.Text;
            if (number.Contains(',') || number.Contains('e')
                || number.Contains('E'))
            {
                return;
            }
            bool hasSignal = false;
            if (number[0] == '-' || number[0] == '+')
            {
                hasSignal = true;
                number = number.Replace('-', ' ').Replace('+', ' ').TrimStart();
            }
            while (number.Contains('.'))
            {
                int index = number.IndexOf('.');
                number = number.Remove(index, 1);
            }
            if(number.Length > 3)
            {
                int position = number.Length - 3;
                string aux;
                for (; position >= 1; position -= 3)
                {
                    aux = number.Substring(position);
                    number = number.Insert(position, ".")
                        .Remove(position + 1);
                    number = number + aux;
                }
            }
            if (hasSignal)
            {
                LblDisplay.Text = LblDisplay.Text[0] + number;
            }
            else
            {
                LblDisplay.Text = number;
            }
        }

        private bool IsSign(char position)
        {
            switch (position)
            {
                case '+':
                    return true;
                case '-':
                    return true;
                case '*':
                    return true;
                case '/':
                    return true;
                default:
                    return false;
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
