using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.TokenTypes
{
    public class LiteratureToken : IToken
    {
        public readonly char variable;

        public string stringValue { get { return variable.ToString(); } }

        public LiteratureToken(char variable)
        {
            this.variable = variable;
        }
    }
}
