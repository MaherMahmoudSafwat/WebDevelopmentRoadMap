using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Expression
{
    class ExpressionParser
    {
        private const string MathSymbols = "+*/%^";
        public static MathExpression Parse(string input)
        {
            input = input.Trim();
            var expression = new MathExpression();
            string token = "";
            bool LeftSideInitialized = false ;
            for(int i = 0;i<input.Length;i++)
            {
                var CurrentChar = input[i];
                if(char.IsDigit(CurrentChar))
                {
                    token += CurrentChar;
                    if(i==input.Length-1 && LeftSideInitialized)
                    {
                        expression.RightSideOperand = double.Parse(token);
                        break;
                    }
                }
                else if(MathSymbols.Contains(CurrentChar))
                {
                    if (!LeftSideInitialized)
                    {
                        expression.LeftSideOperand = double.Parse(token);
                        LeftSideInitialized = true; 
                    }
                    expression.Operation = ParseMathOperation(CurrentChar.ToString());
                    token = "";
                }
                else if(CurrentChar == '-' && i > 0)
                {
                    if (expression.Operation == MathOperation.None)
                    {
                        expression.Operation = MathOperation.Subtraction;
                        expression.LeftSideOperand = double.Parse(token);
                        LeftSideInitialized = true;
                        token = "";
                    }
                    else
                        token += CurrentChar;
                }
                else if(char.IsLetter(CurrentChar))
                {
                    token += CurrentChar;
                    LeftSideInitialized = true;
                }
                else if (CurrentChar == ' ')
                {
                    if (!LeftSideInitialized)
                    {
                        expression.LeftSideOperand = double.Parse(token);
                        LeftSideInitialized = true;
                        token = "";
                    }
                    else if (expression.Operation == MathOperation.None)
                    {
                        expression.Operation = ParseMathOperation(token);
                        token = "";
                    }
                }
            }
            return expression;
        }
        public static MathOperation ParseMathOperation(string Operation)
        {
            switch(Operation.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                case "mod":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}
