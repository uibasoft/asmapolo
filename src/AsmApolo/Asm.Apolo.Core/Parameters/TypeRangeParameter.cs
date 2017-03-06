using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm.Apolo.Core.Parameters
{
    public class TypeRangeParameter<TElement>
    {
        public TypeRangeParameter()
        {

        }
        public TElement From { get; set; }
        public TElement To { get; set; }
    }
}
