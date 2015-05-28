using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetADT
{
    /// <summary>
    /// Generic set class.
    /// </summary>
    public class Set<T>
    {
        private List<T> set;

        public Set()
        {
            set = new List<T>();
        }

        /// <summary>
        /// Check if element in set.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsInSet(T value)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            return set.Exists(x => comparer.Compare(x, value) == 0);
        }

        /// <summary>
        /// Add unique element to set.
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(T value)
        {
            if (!IsInSet(value))
            {
                set.Add(value);
            }
        }

        /// <summary>
        /// Delete element from set.
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(T value)
        {
            if (IsInSet(value))
            {
                set.Remove(value);
            }
        }

        /// <summary>
        /// Union two sets.
        /// </summary>
        /// <param name="firstSet"></param>
        /// <param name="secondSet"></param>
        /// <returns></returns>
        public static Set<T> Union(Set<T> firstSet, Set<T> secondSet)
        {
            var resultSet = new Set<T>();
            foreach (T x in firstSet.set)
            {
                resultSet.AddElement(x);
            }
            foreach (T x in secondSet.set)
            {
                resultSet.AddElement(x);
            }
            return resultSet;
        }

        /// <summary>
        /// Intersections of two sets.
        /// </summary>
        /// <param name="firstSet"></param>
        /// <param name="secondSet"></param>
        /// <returns></returns>
        public static Set<T> Intersection(Set<T> firstSet, Set<T> secondSet)
        {
            var resultSet = new Set<T>();
            foreach (T x in firstSet.set)
            {
                if (secondSet.IsInSet(x))
                {
                    resultSet.AddElement(x);
                }
            }
            return resultSet;
        }
    }
}
