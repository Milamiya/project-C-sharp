using System;
using System.Collections.Generic;
using System.Text;

namespace CDateExeption
{
    public class CDateExe : ApplicationException
    {
        public CDateExe() : base() { }
        public CDateExe(string Str) : base(Str) { }
    }
}
