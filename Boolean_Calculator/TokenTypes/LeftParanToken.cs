﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Calculator.TokenTypes
{
    public class LeftParanToken : IToken
    {
        public string stringValue { get { return "("; } }
    }
}
