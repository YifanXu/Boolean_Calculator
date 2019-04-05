using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boolean_Calculator.TokenTypes;

namespace Boolean_Calculator
{
    public class Program
    {
        private static Dictionary<char, DualOperatorToken> dualOperations = new Dictionary<char, DualOperatorToken>()
        {
            {'+', new DualOperatorToken(DualOperatorEnum.OR  )},
            {'*', new DualOperatorToken(DualOperatorEnum.AND )},
            {'.', new DualOperatorToken(DualOperatorEnum.NAND) },
            {'{', new DualOperatorToken(DualOperatorEnum.NOR )},
            {'@', new DualOperatorToken(DualOperatorEnum.XOR )},
        };

        private static Dictionary<char, SingleOperatorToken> singularOperations = new Dictionary<char, SingleOperatorToken>()
        {
            {'\'', new SingleOperatorToken(SingleOperatorEnum.INVERT) }
        };

        public static List<char> variables = new List<char>();

        static void Main(string[] args)
        {

        }

        public static IToken[] Parse(string s)
        {
            List<IToken> result = new List<IToken>();

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                switch(current)
                {
                    case ' ':
                        break;
                    case '(':
                        result.Add(new LeftParanToken());
                        break;
                    case ')':
                        result.Add(new RightParanToken());
                        break;
                    default:
                        //Sorry computer's C# version is actually so bad I have to do this. Forgive me father I have sinned.
                        DualOperatorToken dual;
                        SingleOperatorToken sing;
                        if (dualOperations.TryGetValue(current, out dual))
                        {
                            result.Add(dual);
                        }
                        else if(singularOperations.TryGetValue(current, out sing))
                        {
                            result.Add(sing);
                        }
                        else if(variables.Contains(current))
                        {
                            result.Add(new LiteratureToken(current));
                        }
                        else
                        {
                            throw new ArgumentException($"Character {current} is not a opeator, parantheses, or a variable specified.");
                        }
                        break;
                }
            }

            return result.ToArray();
        }

    }
}
