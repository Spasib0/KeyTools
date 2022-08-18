using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace KeyTools.Classes
{
    internal class FactDataComparer : IEqualityComparer<Fact>
    {
        public bool Equals([AllowNull] Fact x, [AllowNull] Fact y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (x is null || y is null) return false;

            return x._id == y._id;
        }

        public int GetHashCode([DisallowNull] Fact data)
        {
            if (data is null) return 0;

            return data._id.GetHashCode();
        }
    }
}