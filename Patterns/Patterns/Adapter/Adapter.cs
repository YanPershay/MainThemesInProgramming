using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Adapter
{
    public class Adaptee : ICommon
    {
        private readonly SpecificClass _specific;

        public Adaptee(SpecificClass specific)
        {
            _specific = specific;
        }

        public string Method() => $"This is {_specific.SpecificMethod()}";
    }
}
