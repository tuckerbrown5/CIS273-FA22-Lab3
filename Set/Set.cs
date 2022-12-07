using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private HashSet<T> hashSet;

        public Set()
        {
            hashSet = new HashSet<T>();
        }

        public int Size => hashSet.Count;

        public List<T> Elements
        {
            get
            {
                List<T> elements = new List<T>();

                foreach (var element in hashSet)
                {
                    Elements.Add(element);
                }
                return elements;
            }
        }

        public void Add(ISet<T> s)
        {
            foreach( var rex in s)
            {
                this.Add(rex);
            }
        }

        public void Add(T value)
        {
            hashSet.Add(value);
        }

        public bool Contains(T value)
        {
            foreach(var mist in hashSet)
            {
                if(mist.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(ISet<T> s)
        {
            foreach (var tex in s)
            {
                this.Remove(tex);
            }

        }

        public void Remove(T value)
        {
            hashSet.Remove(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return hashSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Set<T> Union(ISet<T> set1, ISet<T> set2)
        {
            Set<T> union = new Set<T>();

            foreach (var kix in set1)
            {
                union.Add(kix);
            }

            foreach (var kix in set2)
            {
                union.Add(kix);
            }
            return union;
        }

        public static Set<T> Intersection(ISet<T> set1, ISet<T> set2)
        {
            Set<T> inter = new Set<T>();

            foreach(var tick in set1)
            {
                if (set2.Contains(tick))
                {
                    inter.Add(tick);
                }
            }
            return inter;
        }
    }
}
