using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snippet.Demo.PartialClass
{
    public partial class PartClass : IDisposable
    {
        public string OneFunction()
        {
            return TestPrivate("oneFunction");
        }

        private string TestPrivate(string content) {
            return content;
        }

        public void Dispose()
        {
        }
    }
}
