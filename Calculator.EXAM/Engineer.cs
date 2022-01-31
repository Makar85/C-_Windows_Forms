using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calculator;


namespace SimpleCalculator
{
    public partial class Engineer : Form
    {
        public Engineer()
        {
            InitializeComponent();
            VersionInfo.Text = CalcEngine.GetVersion();
            OutputDisplay.Text = "0";
        }

		protected void KeyPlus_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
		}

		protected void KeyMinus_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
		}

		private void btnPow_Click(object sender, EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.ePow);
		}

		private void KeySqrt_Click(object sender, EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eSqrt);
		}

		private void KeyInv_Click(object sender, EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eInv);
		}

		private void KeyGetSquare_Click(object sender, EventArgs e)
		{
			CalcEngine.CalcOperation(CalcEngine.Operator.eSquare);
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcDecimal();
		}

		protected void KeyDate_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click(object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			OutputDisplay.Text = "0";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
		}

		protected void KeyEight_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
		}

		protected void KeySeven_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
		}

		protected void KeySix_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
		}

		protected void KeyFive_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
		}

		protected void KeyFour_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
		}

		protected void KeyThree_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
		}

		protected void KeyTwo_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
		}

		protected void KeyOne_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
		}

		protected void KeyZero_Click(object sender, System.EventArgs e)
		{
			OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
		}

		//
		// End the program.
		//
		protected void KeyExit_Click(object sender, System.EventArgs e)
		{
			CalcUI newCalcUI = new CalcUI();
			newCalcUI.Visible = true;
			newCalcUI.Activate();
			this.Close();
		}

        private void инженерныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			Engineer newEngineer = new Engineer();
			newEngineer.ShowDialog();
			this.Close();

        }

        private void KeyPow_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip ePow = new ToolTip();
			ePow.SetToolTip(KeyPow, "Возведение в степень");
        }

        private void KeySqrt_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip eSqrt = new ToolTip();
			eSqrt.SetToolTip(KeySqrt, "Извлечение квадратного корня");
		}

        private void KeyInv_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip eInv = new ToolTip();
			eInv.SetToolTip(KeyInv, "Расчет обратного значения");
        }

        private void KeyGetSquare_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip eGetSquare = new ToolTip();
			eGetSquare.SetToolTip(KeyGetSquare, "Определение квадрата числа");
        }

        private void KeyDivide_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip eDivide = new ToolTip();
			eDivide.SetToolTip(KeyDivide, "Деление");
        }

        private void KeyMultiply_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip eMultiply = new ToolTip();
			eMultiply.SetToolTip(KeyMultiply, "Умножение");
        }

        private void KeyMinus_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip eMinus = new ToolTip();
			eMinus.SetToolTip(KeyMinus, "Вычитание");
        }

        private void KeyPlus_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip ePlus = new ToolTip();
			ePlus.SetToolTip(KeyPlus, "Сложение");
		}

        private void KeyClear_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip cleare = new ToolTip();
			cleare.SetToolTip(KeyClear, "Очистить");
		}

        private void KeyDate_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip date = new ToolTip();
			date.SetToolTip(KeyDate, "Показать дату");
		}

        private void KeyExit_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip exit = new ToolTip();
			exit.SetToolTip(KeyExit, "Выход");
		}

        private void KeyEqual_MouseMove(object sender, MouseEventArgs e)
        {
			ToolTip equal = new ToolTip();
			equal.SetToolTip(KeyEqual, "Равно");
		}
    }
}
