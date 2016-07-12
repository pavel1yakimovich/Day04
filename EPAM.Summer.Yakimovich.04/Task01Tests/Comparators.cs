using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01Tests
{
    class SumAscending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Sum() > rhs.Sum() ? 1 : lhs.Sum() == rhs.Sum() ? 0 : -1;
        }
    }

    class SumDscending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Sum() < rhs.Sum() ? 1 : lhs.Sum() == rhs.Sum() ? 0 : -1;
        }
    }

    class MaxElementAscending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Max() > rhs.Max() ? 1 : lhs.Max() == rhs.Max() ? 0 : -1;
        }
    }

    class MaxElementDescending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Max() < rhs.Max() ? 1 : lhs.Max() == rhs.Max() ? 0 : -1;
        }
    }

    class MinElementAscending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Min() > rhs.Min() ? 1 : lhs.Min() == rhs.Min() ? 0 : -1;
        }
    }

    class MinElementDescending : IComparer<int[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            return lhs.Min() < rhs.Min() ? 1 : lhs.Min() == rhs.Min() ? 0 : -1;
        }
    }
}
