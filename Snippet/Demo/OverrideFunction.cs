using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snippet.Demo
{
    public class BaseClass
    {

        public virtual string Virtual()
        {
            return "baseVirture";
        }

        public string Normal()
        {
            return "baseNormal";
        }
    }

    public class ChildFunction : BaseClass, IDisposable
    {
        public override string Virtual()
        {
            return "overrideVirtual";
        }

        public new string Normal() {
            return "newNormal";
        }

        public void Dispose()
        {
        }
    }
}
