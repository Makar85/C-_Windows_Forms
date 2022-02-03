using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            CalcEngine.GetData1(textBox1.Text);
            this.btnOk1.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            CalcEngine.GetData2(textBox1.Text);
            this.btnOk2.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            CalcEngine.GetData3(textBox1.Text);
            this.btnOk3.BackColor = System.Drawing.SystemColors.ControlDark;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcOperation2(CalcEngine.Operator2.Ur2);   // Новая операция
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcEngine.ShowResult();            
        }
    }
}
