using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.TokenTypes
{
    public class RightParanToken : IToken
    {
        public string stringValue { get { return ")"; } }
    }
}
