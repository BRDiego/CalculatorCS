
namespace CalculadoraCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBoxCalculadora = new System.Windows.Forms.GroupBox();
            this.ShowN2 = new System.Windows.Forms.Button();
            this.ShowN1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAux = new System.Windows.Forms.Label();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnConma = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.ShowOp = new System.Windows.Forms.Button();
            this.GBoxCalculadora.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxCalculadora
            // 
            this.GBoxCalculadora.BackColor = System.Drawing.SystemColors.Control;
            this.GBoxCalculadora.Controls.Add(this.ShowOp);
            this.GBoxCalculadora.Controls.Add(this.ShowN2);
            this.GBoxCalculadora.Controls.Add(this.ShowN1);
            this.GBoxCalculadora.Controls.Add(this.panel1);
            this.GBoxCalculadora.Controls.Add(this.BtnEnter);
            this.GBoxCalculadora.Controls.Add(this.BtnPlus);
            this.GBoxCalculadora.Controls.Add(this.BtnMinus);
            this.GBoxCalculadora.Controls.Add(this.BtnMultiply);
            this.GBoxCalculadora.Controls.Add(this.BtnDot);
            this.GBoxCalculadora.Controls.Add(this.Btn3);
            this.GBoxCalculadora.Controls.Add(this.Btn6);
            this.GBoxCalculadora.Controls.Add(this.Btn9);
            this.GBoxCalculadora.Controls.Add(this.BtnDivide);
            this.GBoxCalculadora.Controls.Add(this.BtnConma);
            this.GBoxCalculadora.Controls.Add(this.Btn0);
            this.GBoxCalculadora.Controls.Add(this.Btn2);
            this.GBoxCalculadora.Controls.Add(this.Btn1);
            this.GBoxCalculadora.Controls.Add(this.Btn5);
            this.GBoxCalculadora.Controls.Add(this.Btn4);
            this.GBoxCalculadora.Controls.Add(this.Btn8);
            this.GBoxCalculadora.Controls.Add(this.Btn7);
            this.GBoxCalculadora.Controls.Add(this.BtnDelete);
            this.GBoxCalculadora.Controls.Add(this.BtnClear);
            this.GBoxCalculadora.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GBoxCalculadora.Location = new System.Drawing.Point(87, 12);
            this.GBoxCalculadora.Name = "GBoxCalculadora";
            this.GBoxCalculadora.Size = new System.Drawing.Size(628, 510);
            this.GBoxCalculadora.TabIndex = 0;
            this.GBoxCalculadora.TabStop = false;
            this.GBoxCalculadora.Text = "Calculadora em C#";
            // 
            // ShowN2
            // 
            this.ShowN2.Location = new System.Drawing.Point(524, 94);
            this.ShowN2.Name = "ShowN2";
            this.ShowN2.Size = new System.Drawing.Size(75, 45);
            this.ShowN2.TabIndex = 4;
            this.ShowN2.Text = "N2";
            this.ShowN2.UseVisualStyleBackColor = true;
            this.ShowN2.Click += new System.EventHandler(this.ShowN2_Click);
            // 
            // ShowN1
            // 
            this.ShowN1.Location = new System.Drawing.Point(524, 43);
            this.ShowN1.Name = "ShowN1";
            this.ShowN1.Size = new System.Drawing.Size(75, 45);
            this.ShowN1.TabIndex = 3;
            this.ShowN1.Text = "N1";
            this.ShowN1.UseVisualStyleBackColor = true;
            this.ShowN1.Click += new System.EventHandler(this.ShowN1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblAux);
            this.panel1.Controls.Add(this.LblDisplay);
            this.panel1.Location = new System.Drawing.Point(122, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 66);
            this.panel1.TabIndex = 1;
            // 
            // LblAux
            // 
            this.LblAux.AutoSize = true;
            this.LblAux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAux.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAux.Location = new System.Drawing.Point(-1, -1);
            this.LblAux.Name = "LblAux";
            this.LblAux.Size = new System.Drawing.Size(2, 27);
            this.LblAux.TabIndex = 1;
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblDisplay.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDisplay.Location = new System.Drawing.Point(-1, 11);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(0, 54);
            this.LblDisplay.TabIndex = 0;
            this.LblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(406, 352);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(97, 134);
            this.BtnEnter.TabIndex = 2;
            this.BtnEnter.Text = "=";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(406, 287);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(97, 69);
            this.BtnPlus.TabIndex = 2;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(406, 220);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(97, 69);
            this.BtnMinus.TabIndex = 2;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(406, 153);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(97, 69);
            this.BtnMultiply.TabIndex = 2;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Location = new System.Drawing.Point(311, 417);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(97, 69);
            this.BtnDot.TabIndex = 2;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(311, 352);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(97, 69);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(311, 287);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(97, 69);
            this.Btn6.TabIndex = 2;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(311, 220);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(97, 69);
            this.Btn9.TabIndex = 2;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(311, 153);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(97, 69);
            this.BtnDivide.TabIndex = 2;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnConma
            // 
            this.BtnConma.Location = new System.Drawing.Point(217, 417);
            this.BtnConma.Name = "BtnConma";
            this.BtnConma.Size = new System.Drawing.Size(97, 69);
            this.BtnConma.TabIndex = 2;
            this.BtnConma.Text = ",";
            this.BtnConma.UseVisualStyleBackColor = true;
            this.BtnConma.Click += new System.EventHandler(this.BtnConma_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(122, 417);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(97, 69);
            this.Btn0.TabIndex = 2;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(217, 352);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(97, 69);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(122, 352);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(97, 69);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(217, 287);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(97, 69);
            this.Btn5.TabIndex = 2;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(122, 287);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(97, 69);
            this.Btn4.TabIndex = 2;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(217, 220);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(97, 69);
            this.Btn8.TabIndex = 2;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(122, 220);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(97, 69);
            this.Btn7.TabIndex = 2;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(217, 153);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 69);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Del";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(122, 153);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(97, 69);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // ShowOp
            // 
            this.ShowOp.Location = new System.Drawing.Point(524, 164);
            this.ShowOp.Name = "ShowOp";
            this.ShowOp.Size = new System.Drawing.Size(75, 47);
            this.ShowOp.TabIndex = 5;
            this.ShowOp.Text = "Op";
            this.ShowOp.UseVisualStyleBackColor = true;
            this.ShowOp.Click += new System.EventHandler(this.ShowOp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.GBoxCalculadora);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GBoxCalculadora.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxCalculadora;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnConma;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.Label LblAux;
        private System.Windows.Forms.Button ShowN2;
        private System.Windows.Forms.Button ShowN1;
        private System.Windows.Forms.Button ShowOp;
    }
}

