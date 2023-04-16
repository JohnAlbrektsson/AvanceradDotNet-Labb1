using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1
{
    internal class LådaEnum : IEnumerator<Låda>
    {
        private LådaCollection _lådor;
        private Låda _currLåda;

        public LådaEnum(LådaCollection lådor)
        {
            _lådor = lådor;
            _currLåda = default(Låda);
        }
        int currIdx = -1;

        public Låda Current { get { return _currLåda; } }


        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if(++currIdx >= _lådor.Count)
            {
                return false;
            }
            else
            {
                _currLåda = _lådor[currIdx];
            }
            return true;
        }

        public void Reset()
        {
            currIdx = -1;
        }
    }
}
