using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.Expressions
{
    public abstract class ExpressionNode
    {
        public static Dictionary<char, bool> VariableValues;

        public virtual ExpressionNode result { get { throw new NotImplementedException(); } }
    }
}
