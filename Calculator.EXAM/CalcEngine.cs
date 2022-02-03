using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace SimpleCalculator
{
    class CalcEngine
    {
		//
		// Operation Constants.
		//
		public enum Operator : int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			ePow = 5,
		
		}

		public enum Operator1 : int
		{
			eUnknown = 0,
			eSqrt = 1,
			eInv = 2,
			eSquare = 3,
			eFact =4,
			eCubeRt = 5,
		    Ur2 = 6
		}

		public enum Operator2 : int
		{
			Ur2 = 0
		}


		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 3.0.1.1
		private static string versionInfo = "Calculator v3.0.1.1";

		//
		// Module-level Variables.
		//

		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static Operator1 calcOperation1;
		private static Operator2 calcOperation2;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
		private static bool operationType1;  // тип операции, где нужно ввести два числа  
		private static bool operationType2;  // добавляю тип операции, где нужно ввести одно число 
		private static bool operationType3;

		private static double firstData;  // Ur2 1е число
		private static double secondData; // Ur2 2е число
		private static double thirdData; // Ur2 3е число
		private static int dd;
		private static double x1;
		private static double x2;
		//
		// Class Constructor.
		//



		public CalcEngine()
		{
			decimalAdded = false;
			secondNumberAdded = false;
			operationType1 = false; 
			operationType2 = false;
			operationType3 = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber(string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

		//
		// Called when an operator is selected (+, -, *, /, ^)
		//

		public static void CalcOperation(Operator calcOper)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
                firstNumber = Convert.ToDouble(stringAnswer,NumberFormatInfo.InvariantInfo);
				calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
				operationType1 = true;
			}
			
		}

		//
		// Called when an operator is selected (KeySqrt, KeyInv, KeyGetSquare)
		//

		public static void CalcOperation1(Operator1 calcOper1)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
				firstNumber = Convert.ToDouble(stringAnswer, NumberFormatInfo.InvariantInfo);
				calcOperation1 = calcOper1;
				decimalAdded = false;
				operationType2 = true;
			}

		}

		//--------------------------------- BEGIN Ur2--------------------------------------//

		public static void CalcOperation2(Operator2 calcOper2)
		{

			if (stringAnswer != "" && !secondNumberAdded)
			{
				calcOperation2 = calcOper2;
				decimalAdded = false;
				operationType3 = true;
			}

		}



		public static string GetData1(string Data)
		{
			if (stringAnswer != "")
			firstData = Convert.ToDouble(Data, NumberFormatInfo.InvariantInfo);
			return (Data);
		}

		public static string GetData2(string Data)
		{
			if (stringAnswer != "")
				secondData = Convert.ToDouble(Data, NumberFormatInfo.InvariantInfo);
			return (Data);
		}

		public static string GetData3(string Data)
		{
			if (stringAnswer != "")
				thirdData = Convert.ToDouble(Data, NumberFormatInfo.InvariantInfo);
			return (Data);
		}

		public static int Gg(double a, double b, double c, out double x1, out double x2)
		{
					
			double d = Deskr(a, b, c);

			if (d > 0)
			{
				x1 = (-b + Math.Sqrt(d)) / (2 * a);
				x2 = (-b - Math.Sqrt(d)) / (2 * a);
				return 1;
			}

			else
			{
				x1 = (-b + Math.Abs(d)) / (2 * a);
				x2 = x1;
				return 0;
			}



		}


		public static double Deskr(double a, double b, double c)
		{
			double d = b * b - 4 * a * c;
			return d;

		}

		//--------------------------------- END Ur2--------------------------------------//


		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}

			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}



		//
		// Called when = is pressed.
		//

		public static string CalcEqual()
		{
			bool validEquation = false;

			if (stringAnswer != "" && operationType1)
			{
				secondNumber = System.Convert.ToDouble(stringAnswer, NumberFormatInfo.InvariantInfo);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;
					case Operator.ePow:
						numericAnswer = Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;


					default:
						validEquation = false;
						break;
				}


				if (validEquation)
					stringAnswer = System.Convert.ToString(numericAnswer);
			}
			else if (stringAnswer != "" && operationType2)
			{
				switch (calcOperation1)
				{
					case Operator1.eSqrt:
						numericAnswer = Math.Sqrt(firstNumber);
						validEquation = true;
						break;
					case Operator1.eInv:
						numericAnswer = 1 / firstNumber;
						validEquation = true;
						break;
					case Operator1.eSquare:
						numericAnswer = firstNumber * firstNumber;
						validEquation = true;
						break;
					case Operator1.eFact:
						numericAnswer = fact(firstNumber);
						double fact(double num)
						{
							numericAnswer = 1;
							double i;
							for (i = 1; i <= num; i++)

								numericAnswer *= i;
							return numericAnswer;

						}
						validEquation = true;
						break;

					case Operator1.eCubeRt:
						numericAnswer = Math.Pow(firstNumber, 1.0 / 3);
						validEquation = true;
						break;

					

					default:
						validEquation = false;
						break;

				}
				if (validEquation)
					stringAnswer = System.Convert.ToString(numericAnswer);
			}

										
			

			return (stringAnswer);
		}

		//
		// Called when Dialog button2 is pressed.
		//

		public static void ShowResult()				
		{
			bool validEquation = false;
			if (operationType3)
			{
				switch (calcOperation2)
				{
					case Operator2.Ur2:

						int dd;
						double x1;
						double x2;
						double a = firstData;
						double b = secondData;
						double c = thirdData;

						if (Deskr(a, b, c) >= 0)
						{
							dd = Gg(a, b, c, out x1, out x2);
							validEquation = true;
						}

						else
						{
							dd = -1;
							validEquation = false;
						}

						break;

				}


				if (validEquation)
					stringAnswer = dd + "\n x1= " + x1 + "\n x2 = " + x2;
				if (!validEquation)
					stringAnswer = dd + " \n Корней нет";

			}

									
			CalcUI newCalc = new CalcUI();
			newCalc.ShowResult1(stringAnswer);

		}


		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;
			operationType1 = false;
			operationType2 = false;
			operationType3 = false;
		}
	}
}

