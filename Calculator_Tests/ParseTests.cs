using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boolean_Calculator;
using Boolean_Calculator.TokenTypes;

namespace Calculator_Tests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void ParseNullString ()
        {
            Assert.IsNull(Program.Parse(""));
        }

        [TestMethod]
        public void ParseSpaces ()
        {
            Assert.IsNull(Program.Parse("    "));
        }

        [TestMethod]
        public void ParseSingleVariable ()
        {
            
        }

        private static bool EvaluateArrayContent (IToken[] a, IToken[] b)
        {
            if (a == null && b == null) return true;
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i].GetType() != b[i].GetType() || a[i].ToString() != b[i].ToString()) return false;
            }
            return true;
        }
    }
}
