using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.Expressions
{
    public class DualExpressionNode : ExpressionNode
    {
        public static readonly Dictionary<DualOperatorEnum, Func<bool, bool, bool>> dualCalculations = new Dictionary<DualOperatorEnum, Func<bool, bool, bool>>()
        {
            {DualOperatorEnum.AND, (a,b) => (a&&b) },
            {DualOperatorEnum.OR, (a,b) => (a||b) },
            {DualOperatorEnum.NAND, (a,b) => !(a&&b) },
            {DualOperatorEnum.NOR, (a,b) => !(a||b) },
            {DualOperatorEnum.XOR, (a,b) => a^b }
        };
    }
}
