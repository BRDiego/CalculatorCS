using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCS.Model
{
    class Logic
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }
        private string Field;
        private bool HasOperation { get; set; }
        private bool HasConma;



        public Logic()
        {
        }

        public void AddNumber(string number)
        {
                Field += number;
        }
        //FAZER FUNÇÃO QUE RECEBE STRING E PASSA PRO CALCULO E PRO DISPLAY

        public string AddOperation(string operation)
        {
            if (Field != null && Field != "")
            {
                Number1 = double.Parse(Field);
            }
                Operation = operation;
                Field = "";
            if (HasOperation)
            {
                return Operation;
            }
                HasOperation = true;
                return Operation;
        }

        public string Calculate()
        {
            if(Field == "")
            {
                return "Insira um número";
            }
            Number2 = double.Parse(Field);
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 == 0)
                    {
                        return "Impossível";
                    }
                    Result = Number1 / Number2;
                    break;
                default:
                    return "Escolha a operação";
            }
            Number1 = Result;
            Field = Result.ToString();
            Operation = "";
            HasOperation = false;
            return Result.ToString();
        }

        public void DeleteChar()
        {
            if (Field != "")
            {
                Field = Field.Remove(Field.Length - 1);
            }
        }

        public void Clear()
        {
            HasOperation = false;
            Field = "";
            Number1 = 0;
            Number2 = 0;
            Operation = "";
        }

        public string GetN1()
        {
            return Number1.ToString();
        }

        public string GetN2()
        {
            return Number2.ToString();
        }

        public string GetOp()
        {
            return Operation;
        }
    }
}
