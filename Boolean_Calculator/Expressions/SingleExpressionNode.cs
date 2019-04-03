using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.Expressions
{
    public class SingleExpressionNode
    {
        public static readonly Dictionary<SingleOperatorEnum, Func<bool, bool>> singleCalculations = new Dictionary<SingleOperatorEnum, Func<bool, bool>>()
        {
            {SingleOperatorEnum.INVERT, (a) => !a }
        };
    }
}
