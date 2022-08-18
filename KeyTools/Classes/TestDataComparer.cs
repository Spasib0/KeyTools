using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace KeyTools.Classes
{
    internal class TestDataComparer : IEqualityComparer<TestData>
    {
        public bool Equals([AllowNull] TestData x, [AllowNull] TestData y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (x is null || y is null) return false;

            return x._id == y._id;
        }

        public int GetHashCode([DisallowNull] TestData data)
        {
            if (data is null) return 0;

            return data._id.GetHashCode();
        }
    }
}