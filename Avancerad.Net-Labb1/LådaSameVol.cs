using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1
{
    internal class LådaSameVol : EqualityComparer<Låda>
    {
        public override bool Equals(Låda? x, Låda? y)
        {
            if(x.längd * x.höjd * x.bredd == y.längd * y.höjd * y.bredd)
            {
                return true;
            }
            else { return false; }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            return obj.längd ^ obj.höjd ^ obj.bredd;
        }
    }
}
