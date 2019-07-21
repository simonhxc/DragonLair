using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snippet.Demo.PartialClass
{
    public partial class PartClass
    {
        public string TwoFunction()
        {
            return TestPrivate("twoFunction");
        }
    }
}
