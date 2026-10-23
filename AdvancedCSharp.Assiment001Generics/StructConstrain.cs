using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp.Assiment001Generics
{
    internal class StructConstrain<T>where T : struct
    {
        T value;
        public StructConstrain(T value) { this.value = value; }
    }
}
