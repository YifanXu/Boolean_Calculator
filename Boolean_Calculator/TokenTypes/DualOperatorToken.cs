using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.TokenTypes
{
    public class DualOperatorToken : IToken
    {
        public readonly DualOperatorEnum operation;

        public string stringValue { get { return operation.ToString(); } }

        public DualOperatorToken(DualOperatorEnum operation)
        {
            this.operation = operation;
        }
    }
}
