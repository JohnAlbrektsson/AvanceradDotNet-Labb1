using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1
{
    internal class LådaCollection : ICollection<Låda>
    {
        private List<Låda> _innerCol;

        public LådaCollection() { _innerCol = new List<Låda>(); }

        public Låda this[int index]
        {
            get { return _innerCol[index]; }
            set { _innerCol[index] = value; }
        }
        public int Count {get { return _innerCol.Count; } }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Låda item)
        {
            
            if(!Contains(item))
            {
                _innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("Endast unika lådor kan läggas till");
            }
        }

        public void Clear()
        {
            _innerCol.Clear();
        }

        public bool Contains(Låda item)
        {
            foreach(Låda låda in _innerCol)
            {
                if(new LådaSameDimensions().Equals(låda, item))
                {
                    return true;
                }
                if(new LådaSameVol().Equals(låda, item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Contains(Låda item, EqualityComparer<Låda> comparer)
        {
            foreach(Låda låda in _innerCol)
            {
                if(comparer.Equals(låda, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if(array == null)
            {
                throw new ArgumentException("The array can not be null");
            }
            if(arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Array index can not be negative");
            }
            if(Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The array has fewer elements than the collection");
            }
            for (int i = 0; i < _innerCol.Count; i++)
            {
                array[i + arrayIndex] = _innerCol[i];
            }
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnum(this);
        }

        public bool Remove(Låda item)
        {
            for (int i = 0; i < _innerCol.Count; i++)
            {
                Låda tempLåda = _innerCol[i];
                if(new LådaSameDimensions().Equals(tempLåda, item))
                {
                    _innerCol.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
